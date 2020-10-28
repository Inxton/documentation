# IoBindingAttribute.RetrieveLinks Method 
 

Returns dictionary of links for given object.

**Namespace:**&nbsp;<a href="N_Vortex_Connector_Peripheries.md">Vortex.Connector.Peripheries</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 1.3.12+Branch.tags-v1.3.12.Sha.00bdfb8be9e078a68c552d3a1d81a8775d48ab55

## Syntax

**C#**<br />
``` C#
public static IDictionary<string, PeripheryLink> RetrieveLinks(
	Object obj,
	IDictionary<string, PeripheryLink> links = null
)
```


#### Parameters
&nbsp;<dl><dt>obj</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">System.Object</a><br />Object from which the links are to be retrieved.</dd><dt>links (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.idictionary-2" target="_blank">System.Collections.Generic.IDictionary</a>(<a href="https://docs.microsoft.com/dotnet/api/system.string" target="_blank">String</a>, <a href="T_Vortex_Connector_Peripheries_PeripheryLink.md">PeripheryLink</a>)<br />Pre-existing links.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.idictionary-2" target="_blank">IDictionary</a>(<a href="https://docs.microsoft.com/dotnet/api/system.string" target="_blank">String</a>, <a href="T_Vortex_Connector_Peripheries_PeripheryLink.md">PeripheryLink</a>)<br />

## See Also


#### Reference
<a href="T_Vortex_Connector_Peripheries_IoBindingAttribute.md">IoBindingAttribute Class</a><br /><a href="N_Vortex_Connector_Peripheries.md">Vortex.Connector.Peripheries Namespace</a><br />