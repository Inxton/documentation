# IConnectorFactory.CreateWSTRING Method (IVortexObject, String, String)
 

Creates <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_blank">String</a> tag of a value type WSTRING;

**Namespace:**&nbsp;<a href="N_Vortex_Connector.md">Vortex.Connector</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 1.0.0+Branch.master.Sha.24c869c7af4ddc9e28426985d5ac87eee1422bb2

## Syntax

**C#**<br />
``` C#
public abstract OnlinerWString CreateWSTRING(
	IVortexObject parent,
	string readableTail,
	string symbolTail
)
```


#### Parameters
&nbsp;<dl><dt>parent</dt><dd>Type: <a href="T_Vortex_Connector_IVortexObject.md">Vortex.Connector.IVortexObject</a><br />Parent object of <a href="T_Vortex_Connector_IVortexObject.md">IVortexObject</a> type.</dd><dt>readableTail</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_blank">System.String</a><br />Human readable tail of this value tag.</dd><dt>symbolTail</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_blank">System.String</a><br />Symbol tail of this value tag.</dd></dl>

#### Return Value
Type: <a href="T_Vortex_Connector_ValueTypes_OnlinerWString.md">OnlinerWString</a><br />New instance of <a href="T_Vortex_Connector_ValueTypes_OnlinerWString.md">OnlinerWString</a>

## See Also


#### Reference
<a href="T_Vortex_Connector_IConnectorFactory.md">IConnectorFactory Class</a><br /><a href="Overload_Vortex_Connector_IConnectorFactory_CreateWSTRING.md">CreateWSTRING Overload</a><br /><a href="N_Vortex_Connector.md">Vortex.Connector Namespace</a><br />