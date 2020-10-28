# IoBindingAttribute.GetLinks Method 
 

Gets list of <a href="T_Vortex_Connector_Peripheries_BindLink.md">BindLink</a>s of a <a href="T_Vortex_Connector_IVortexElement.md">IVortexElement</a>

**Namespace:**&nbsp;<a href="N_Vortex_Connector_Peripheries.md">Vortex.Connector.Peripheries</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 1.3.12+Branch.tags-v1.3.12.Sha.00bdfb8be9e078a68c552d3a1d81a8775d48ab55

## Syntax

**C#**<br />
``` C#
public static IEnumerable<BindLink> GetLinks(
	IVortexElement obj,
	BindLink previousLink = null,
	IList<BindLink> links = null,
	string task = null
)
```


#### Parameters
&nbsp;<dl><dt>obj</dt><dd>Type: <a href="T_Vortex_Connector_IVortexElement.md">Vortex.Connector.IVortexElement</a><br />Object from which the links are to be retrieved.</dd><dt>previousLink (Optional)</dt><dd>Type: <a href="T_Vortex_Connector_Peripheries_BindLink.md">Vortex.Connector.Peripheries.BindLink</a><br />Previous link that should be added to linking path.</dd><dt>links (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ilist-1" target="_blank">System.Collections.Generic.IList</a>(<a href="T_Vortex_Connector_Peripheries_BindLink.md">BindLink</a>)<br />Pre-existing links</dd><dt>task (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_blank">System.String</a><br />Task to which the links are attached.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank">IEnumerable</a>(<a href="T_Vortex_Connector_Peripheries_BindLink.md">BindLink</a>)<br />

## See Also


#### Reference
<a href="T_Vortex_Connector_Peripheries_IoBindingAttribute.md">IoBindingAttribute Class</a><br /><a href="N_Vortex_Connector_Peripheries.md">Vortex.Connector.Peripheries Namespace</a><br />