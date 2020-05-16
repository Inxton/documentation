# SymbolLoadingMode Enumeration
 

Enumerates way the symbols will be loaded from the PLC.

**Namespace:**&nbsp;<a href="N_Vortex_Adapters_Connector_Tc3_Adapter.md">Vortex.Adapters.Connector.Tc3.Adapter</a><br />**Assembly:**&nbsp;Vortex.Adapters.Connector.Tc3 (in Vortex.Adapters.Connector.Tc3.dll) Version: 1.0.0+Branch.master.Sha.24c869c7af4ddc9e28426985d5ac87eee1422bb2

## Syntax

**C#**<br />
``` C#
public enum SymbolLoadingMode
```


## Members
&nbsp;<table><tr><th></th><th>Member name</th><th>Value</th><th>Description</th></tr><tr><td /><td target="F:Vortex.Adapters.Connector.Tc3.Adapter.SymbolLoadingMode.AfterConnectorConstruction">**AfterConnectorConstruction**</td><td>0</td><td>The symbols are loaded and linked when the connector is created.
&nbsp;<table><tr><th>![Note](media/AlertNote.png) Note</th></tr><tr><td>This mode considerably slows down the start of the application. All symbols are loaded and linked regardless the usage by the application.</td></tr></table></td></tr><tr><td /><td target="F:Vortex.Adapters.Connector.Tc3.Adapter.SymbolLoadingMode.PreLoadSymbolsLinkOnTheFly">**PreLoadSymbolsLinkOnTheFly**</td><td>1</td><td>The symbols are loaded but not linked. Linking is deferred at the first symbol use during the life time of the application.
&nbsp;<table><tr><th>![Note](media/AlertNote.png) Note</th></tr><tr><td>This mode slows down the start up of the application. All symbols are loaded regardless the usage by the application.</td></tr></table></td></tr><tr><td /><td target="F:Vortex.Adapters.Connector.Tc3.Adapter.SymbolLoadingMode.LoadAndLinkOnTheFly">**LoadAndLinkOnTheFly**</td><td>2</td><td>The symbols are loaded and linked when first time required by the application.
&nbsp;<table><tr><th>![Note](media/AlertNote.png) Note</th></tr><tr><td>This is the fastest way of starting up the application. The symbol loading and linking are performed in a lazily during the application life time.</td></tr></table></td></tr></table>

## See Also


#### Reference
<a href="N_Vortex_Adapters_Connector_Tc3_Adapter.md">Vortex.Adapters.Connector.Tc3.Adapter Namespace</a><br />