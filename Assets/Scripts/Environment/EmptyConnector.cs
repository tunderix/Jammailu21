using UnityEngine;

namespace TerraFirma.ConnectedEnvironment
{
    public class EmptyConnector : MonoBehaviour, IConnector
    {
        public ConnectorType ConnectType { get => ConnectorType.Empty; }

        public Vector3 Position => Vector3.zero;
    }
}
