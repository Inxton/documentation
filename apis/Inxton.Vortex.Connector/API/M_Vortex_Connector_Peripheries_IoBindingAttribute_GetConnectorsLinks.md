# IoBindingAttribute.GetConnectorsLinks Method 
 _**\[This is preliminary documentation and is subject to change.\]**_

Gets links of a connector object.

**Namespace:**&nbsp;<a href="N_Vortex_Connector_Peripheries.md">Vortex.Connector.Peripheries</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 0.101.0-alpha.5+Branch.develop.Sha.964441db673232ae7ce236ab6ff4c304c79df7be

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
&nbsp;<dl><dt>obj</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />Connector object.</dd><dt>previousLink (Optional)</dt><dd>Type: <a href="T_Vortex_Connector_Peripheries_BindLink.md">Vortex.Connector.Peripheries.BindLink</a><br />Previous link that should be added to linking path.</dd><dt>links (Optional)</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/5y536ey6" target="_blank">System.Collections.Generic.IList</a>(<a href="T_Vortex_Connector_Peripheries_BindLink.md">BindLink</a>)<br />Pre-existing links</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/9eekhta0" target="_blank">IEnumerable</a>(<a href="T_Vortex_Connector_Peripheries_BindLink.md">BindLink</a>)<br />List of links

## See Also


#### Reference
<a href="T_Vortex_Connector_Peripheries_IoBindingAttribute.md">IoBindingAttribute Class</a><br /><a href="N_Vortex_Connector_Peripheries.md">Vortex.Connector.Peripheries Namespace</a><br />