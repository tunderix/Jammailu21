using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace TerraFirma.ConnectedEnvironment
{
    public class PathBlock : MonoBehaviour, ITerraBlock
    {
        [SerializeField] GameObject connectorIn;
        [SerializeField] GameObject connectorOut;
        private List<IConnector> _outConnectors;

        private void OnTriggerEnter(Collider other)
        {
            Revealer revealer = other.GetComponent<Revealer>();
            if (revealer != null)
            {
                GameObject.Find("Environment").GetComponent<EnvironmentController>().GenerateBlock(_outConnectors.First());
            }
        }

        private void Awake()
        {
            _outConnectors = new List<IConnector>();
            _outConnectors.Add(connectorOut.GetComponent<IConnector>());
        }

        public IConnector In => connectorIn.GetComponent<IConnector>();
        public List<IConnector> Outs => _outConnectors;

        public GameObject GO => this.gameObject;

        public ConnectorType InType => ConnectorType.A; // atm must match the In-Connector

        public Vector3 Position => this.transform.position;

        public void SetPositionBasedOn(IConnector connector)
        {
            Vector3 position = this.transform.position;
            Quaternion rotation = Quaternion.identity;
            rotation.y = 90f;
            Vector3 neededOffset = connector.Position - this.connectorIn.GetComponent<IConnector>().Position;
            position += neededOffset;
            this.transform.SetPositionAndRotation(position, rotation);
        }
    }
}
