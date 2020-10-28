# IConnectorFactory.CreateULINT Method (IVortexObject, String, String)
 

Creates <a href="https://docs.microsoft.com/dotnet/api/system.uint64" target="_blank">UInt64</a> tag of a value type ULINT;

**Namespace:**&nbsp;<a href="N_Vortex_Connector.md">Vortex.Connector</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 1.3.12+Branch.tags-v1.3.12.Sha.00bdfb8be9e078a68c552d3a1d81a8775d48ab55

## Syntax

**C#**<br />
``` C#
public abstract OnlinerULInt CreateULINT(
	IVortexObject parent,
	string readableTail,
	string symbolTail
)
```


#### Parameters
&nbsp;<dl><dt>parent</dt><dd>Type: <a href="T_Vortex_Connector_IVortexObject.md">Vortex.Connector.IVortexObject</a><br />Parent object of <a href="T_Vortex_Connector_IVortexObject.md">IVortexObject</a> type.</dd><dt>readableTail</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_blank">System.String</a><br />Human readable tail of this value tag.</dd><dt>symbolTail</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_blank">System.String</a><br />Symbol tail of this value tag.</dd></dl>

#### Return Value
Type: <a href="T_Vortex_Connector_ValueTypes_OnlinerULInt.md">OnlinerULInt</a><br />New instance of <a href="T_Vortex_Connector_ValueTypes_OnlinerULInt.md">OnlinerULInt</a>

## See Also


#### Reference
<a href="T_Vortex_Connector_IConnectorFactory.md">IConnectorFactory Class</a><br /><a href="Overload_Vortex_Connector_IConnectorFactory_CreateULINT.md">CreateULINT Overload</a><br /><a href="N_Vortex_Connector.md">Vortex.Connector Namespace</a><br />