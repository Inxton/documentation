#define LOCAL
using Vortex.Adapters.Connector.Tc3.Adapter;

namespace Plc
{
    public static class Entry
    {
#if LOCAL
        const string AmsId = null; // your ams id or set to 'null' if local
        const int Port = 851;
#else
        private const string AmsId = "172.20.10.102.1.1"; // set your target ams id
        private const int Port = 851;
#endif
        public static PlcTwinController Plc { get; } = new PlcTwinController(Tc3ConnectorAdapter.Create(AmsId, Port));

    }
}