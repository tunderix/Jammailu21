using System.Collections.Generic;
using UnityEngine;

namespace TerraFirma.ConnectedEnvironment
{
    public class StartBlock : MonoBehaviour, ITerraBlock
    {
        [SerializeField] private EmptyConnector emptyConnector;
        [SerializeField] private GameObject connectorOut;

        private List<IConnector> _outConnectors;

        private void Awake()
        {
            _outConnectors = new List<IConnector>();
            _outConnectors.Add(connectorOut.GetComponent<Connector>());
        }


        public IConnector In => emptyConnector;

        public List<IConnector> Outs => _outConnectors;

        public GameObject GO => this.gameObject;

        public ConnectorType InType => throw new System.NotImplementedException();

        public void SetPositionBasedOn(IConnector connector)
        {
            throw new System.NotImplementedException();
        }
    }
}
