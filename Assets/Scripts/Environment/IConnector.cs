using UnityEngine;

namespace TerraFirma.ConnectedEnvironment
{
    public interface IConnector
    {
        public ConnectorType ConnectType { get; }
        public Vector3 Position { get; }
    }
}
