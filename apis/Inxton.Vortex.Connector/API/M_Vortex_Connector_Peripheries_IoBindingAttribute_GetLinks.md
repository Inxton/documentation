# IoBindingAttribute.GetLinks Method 
 _**\[This is preliminary documentation and is subject to change.\]**_

Gets list of <a href="T_Vortex_Connector_Peripheries_BindLink.md">BindLink</a>s of a <a href="T_Vortex_Connector_IVortexElement.md">IVortexElement</a>

**Namespace:**&nbsp;<a href="N_Vortex_Connector_Peripheries.md">Vortex.Connector.Peripheries</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 0.101.0-alpha.5+Branch.develop.Sha.964441db673232ae7ce236ab6ff4c304c79df7be

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
&nbsp;<dl><dt>obj</dt><dd>Type: <a href="T_Vortex_Connector_IVortexElement.md">Vortex.Connector.IVortexElement</a><br />Object from which the links are to be retrieved.</dd><dt>previousLink (Optional)</dt><dd>Type: <a href="T_Vortex_Connector_Peripheries_BindLink.md">Vortex.Connector.Peripheries.BindLink</a><br />Previous link that should be added to linking path.</dd><dt>links (Optional)</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/5y536ey6" target="_blank">System.Collections.Generic.IList</a>(<a href="T_Vortex_Connector_Peripheries_BindLink.md">BindLink</a>)<br />Pre-existing links</dd><dt>task (Optional)</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Task to which the links are attached.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/9eekhta0" target="_blank">IEnumerable</a>(<a href="T_Vortex_Connector_Peripheries_BindLink.md">BindLink</a>)<br />\[Missing <returns> documentation for "M:Vortex.Connector.Peripheries.IoBindingAttribute.GetLinks(Vortex.Connector.IVortexElement,Vortex.Connector.Peripheries.BindLink,System.Collections.Generic.IList{Vortex.Connector.Peripheries.BindLink},System.String)"\]

## See Also


#### Reference
<a href="T_Vortex_Connector_Peripheries_IoBindingAttribute.md">IoBindingAttribute Class</a><br /><a href="N_Vortex_Connector_Peripheries.md">Vortex.Connector.Peripheries Namespace</a><br />