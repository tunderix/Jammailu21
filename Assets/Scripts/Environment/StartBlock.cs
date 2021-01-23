using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace TerraFirma.ConnectedEnvironment
{
    public class StartBlock : MonoBehaviour, ITerraBlock
    {
        [SerializeField] private Connector inConnector;

        public List<IConnector> Outs => _outConnectors;

        [SerializeField] private Connector connectorOut;

        private List<IConnector> _outConnectors;

        private void Awake()
        {
            _outConnectors = new List<IConnector>();
        }

        private void Start()
        {
            _outConnectors.Add(connectorOut.GetComponent<Connector>());
        }


        public IConnector In => inConnector;

        public IConnector Out => _outConnectors.First();

        public GameObject GO => this.gameObject;

        public ConnectorType InType => ConnectorType.Empty;

        public Vector3 Position => this.transform.position;

        public void SetPositionBasedOn(IConnector connector)
        {
            throw new System.NotImplementedException();
        }
    }
}
