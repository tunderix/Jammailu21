using System.Collections.Generic;
using UnityEngine;

namespace TerraFirma.ConnectedEnvironment
{
    public interface ITerraBlock
    {
        public IConnector In { get; }
        public ConnectorType InType { get; }
        public List<IConnector> Outs { get; }
        public GameObject GO { get; }
        public void SetPositionBasedOn(IConnector connector);
    }
}
