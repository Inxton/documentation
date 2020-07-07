# IoBindingAttribute.GetParentLessLinks Method 
 

Returns list of <a href="T_Vortex_Connector_Peripheries_BindLink.md">BindLink</a>s without parent.

**Namespace:**&nbsp;<a href="N_Vortex_Connector_Peripheries.md">Vortex.Connector.Peripheries</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 1.1.0+Branch.master.Sha.6964545d53528bb038364111fd08af947d49d02f

## Syntax

**C#**<br />
``` C#
public static IEnumerable<BindLink> GetParentLessLinks(
	IEnumerable<BindLink> links,
	IList<BindLink> parentlessLinks = null
)
```


#### Parameters
&nbsp;<dl><dt>links</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/9eekhta0" target="_blank">System.Collections.Generic.IEnumerable</a>(<a href="T_Vortex_Connector_Peripheries_BindLink.md">BindLink</a>)<br /></dd><dt>parentlessLinks (Optional)</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/5y536ey6" target="_blank">System.Collections.Generic.IList</a>(<a href="T_Vortex_Connector_Peripheries_BindLink.md">BindLink</a>)<br /></dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/9eekhta0" target="_blank">IEnumerable</a>(<a href="T_Vortex_Connector_Peripheries_BindLink.md">BindLink</a>)<br />

## See Also


#### Reference
<a href="T_Vortex_Connector_Peripheries_IoBindingAttribute.md">IoBindingAttribute Class</a><br /><a href="N_Vortex_Connector_Peripheries.md">Vortex.Connector.Peripheries Namespace</a><br />