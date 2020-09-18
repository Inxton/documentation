# Tc3ConnectorAdapter.Create Method (Int32, Boolean, SymbolLoadingMode, SymbolLoadMethod)
 

Creates an instance of <a href="T_Vortex_Adapters_Connector_Tc3_Adapter_Tc3ConnectorAdapter.md">Tc3ConnectorAdapter</a>.

**Namespace:**&nbsp;<a href="N_Vortex_Adapters_Connector_Tc3_Adapter.md">Vortex.Adapters.Connector.Tc3.Adapter</a><br />**Assembly:**&nbsp;Vortex.Adapters.Connector.Tc3 (in Vortex.Adapters.Connector.Tc3.dll) Version: 1.3.9+Branch.tags/v1.3.9.Sha.76b254c0c0b18db4a0754abdd4dde08f4adae41f

## Syntax

**C#**<br />
``` C#
public static ConnectorAdapter Create(
	int port,
	bool consoleOutput = false,
	SymbolLoadingMode symbolLoadingMode = SymbolLoadingMode.LoadAndLinkOnTheFly,
	SymbolLoadMethod symbolLoadingMethod = SymbolLoadMethod.SymbolInfoLoader
)
```


#### Parameters
&nbsp;<dl><dt>port</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.int32" target="_blank">System.Int32</a><br />Target system port</dd><dt>consoleOutput (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_blank">System.Boolean</a><br />When true outputs information to the console.</dd><dt>symbolLoadingMode (Optional)</dt><dd>Type: <a href="T_Vortex_Adapters_Connector_Tc3_Adapter_SymbolLoadingMode.md">Vortex.Adapters.Connector.Tc3.Adapter.SymbolLoadingMode</a><br />Determines <a href="T_Vortex_Adapters_Connector_Tc3_Adapter_SymbolLoadingMode.md">SymbolLoadingMode</a></dd><dt>symbolLoadingMethod (Optional)</dt><dd>Type: <a href="T_Vortex_Adapters_Connector_Tc3_Adapter_SymbolLoadMethod.md">Vortex.Adapters.Connector.Tc3.Adapter.SymbolLoadMethod</a><br />Determines <a href="T_Vortex_Adapters_Connector_Tc3_Adapter_SymbolLoadMethod.md">SymbolLoadMethod</a></dd></dl>

#### Return Value
Type: <a href="T_Vortex_Connector_ConnectorAdapter.md">ConnectorAdapter</a><br />TwinCat 3 connector adapter.

## See Also


#### Reference
<a href="T_Vortex_Adapters_Connector_Tc3_Adapter_Tc3ConnectorAdapter.md">Tc3ConnectorAdapter Class</a><br /><a href="Overload_Vortex_Adapters_Connector_Tc3_Adapter_Tc3ConnectorAdapter_Create.md">Create Overload</a><br /><a href="N_Vortex_Adapters_Connector_Tc3_Adapter.md">Vortex.Adapters.Connector.Tc3.Adapter Namespace</a><br />