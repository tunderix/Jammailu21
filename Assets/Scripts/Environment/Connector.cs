using UnityEngine;

namespace TerraFirma.ConnectedEnvironment
{
    public class Connector : MonoBehaviour, IConnector
    {
        [SerializeField] ConnectorType connectorType;
        public ConnectorType ConnectType { get => connectorType; }

        public Vector3 Position => this.transform.position;
    }
}
