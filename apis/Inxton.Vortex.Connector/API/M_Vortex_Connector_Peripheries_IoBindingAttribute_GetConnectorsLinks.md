# IoBindingAttribute.GetConnectorsLinks Method 
 

Gets links of a connector object.

**Namespace:**&nbsp;<a href="N_Vortex_Connector_Peripheries.md">Vortex.Connector.Peripheries</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 1.0.0+Branch.master.Sha.24c869c7af4ddc9e28426985d5ac87eee1422bb2

## Syntax

**C#**<br />
``` C#
public static IEnumerable<BindLink> GetConnectorsLinks(
	Object obj,
	BindLink previousLink = null,
	IList<BindLink> links = null
)
```


#### Parameters
&nbsp;<dl><dt>obj</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">System.Object</a><br />Connector object.</dd><dt>previousLink (Optional)</dt><dd>Type: <a href="T_Vortex_Connector_Peripheries_BindLink.md">Vortex.Connector.Peripheries.BindLink</a><br />Previous link that should be added to linking path.</dd><dt>links (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ilist-1" target="_blank">System.Collections.Generic.IList</a>(<a href="T_Vortex_Connector_Peripheries_BindLink.md">BindLink</a>)<br />Pre-existing links</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank">IEnumerable</a>(<a href="T_Vortex_Connector_Peripheries_BindLink.md">BindLink</a>)<br />List of links

## See Also


#### Reference
<a href="T_Vortex_Connector_Peripheries_IoBindingAttribute.md">IoBindingAttribute Class</a><br /><a href="N_Vortex_Connector_Peripheries.md">Vortex.Connector.Peripheries Namespace</a><br />