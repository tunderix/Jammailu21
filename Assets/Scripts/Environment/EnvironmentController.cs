using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace TerraFirma.ConnectedEnvironment
{
    public class EnvironmentController : MonoBehaviour
    {
        public List<GameObject> registeredPossibleBlockPrefabs;

        private ITerraBlock startBlock;

        private void Awake()
        {
        }

        private void Start()
        {

            StartBlock startBlock = (StartBlock)GameObject.Find("Terrain").GetComponent<StartBlock>();

            //Exceptional Handling for first blocks

            GenerateBlock(startBlock.Out);
        }

        public void GenerateBlock(IConnector outConnector)
        {
            ITerraBlock matchingTerraBlockFromPrefabs = TerraBlockWith(outConnector.ConnectType);
            GameObject.Instantiate(matchingTerraBlockFromPrefabs.GO);
            matchingTerraBlockFromPrefabs.SetPositionBasedOn(outConnector);
        }

        public IConnector RandomConnector(List<IConnector> connectors)
        {
            return connectors[Random.Range(0, connectors.Count - 1)];
        }

        public ITerraBlock TerraBlockWith(ConnectorType type)
        {
            ITerraBlock chosenBlock = null;
            foreach (GameObject go in registeredPossibleBlockPrefabs)
            {
                ITerraBlock block = (ITerraBlock)go.GetComponent<PathBlock>();
                if (block == null) continue;
                if (block.In.ConnectType == type)
                {
                    chosenBlock = block;
                }
            }
            registeredPossibleBlockPrefabs.Remove(chosenBlock.GO);

            return chosenBlock;
        }
    }
}
