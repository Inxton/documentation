# IVortexObjectExtensions.RetrieveValueTags Method 
 _**\[This is preliminary documentation and is subject to change.\]**_

Retrieves all value tags of given object.

**Namespace:**&nbsp;<a href="N_Vortex_Connector.md">Vortex.Connector</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 0.101.0-alpha.5+Branch.develop.Sha.964441db673232ae7ce236ab6ff4c304c79df7be

## Syntax

**C#**<br />
``` C#
public static IEnumerable<IValueTag> RetrieveValueTags(
	this IVortexObject onlineObject,
	List<IValueTag> valueTags = null
)
```


#### Parameters
&nbsp;<dl><dt>onlineObject</dt><dd>Type: <a href="T_Vortex_Connector_IVortexObject.md">Vortex.Connector.IVortexObject</a><br />Object from which the value tags are to be retrieved.</dd><dt>valueTags (Optional)</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/6sh2ey19" target="_blank">System.Collections.Generic.List</a>(<a href="T_Vortex_Connector_IValueTag.md">IValueTag</a>)<br />Existing value tags.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/9eekhta0" target="_blank">IEnumerable</a>(<a href="T_Vortex_Connector_IValueTag.md">IValueTag</a>)<br />Value tags of given object.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Vortex_Connector_IVortexObject.md">IVortexObject</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="http://msdn.microsoft.com/en-us/library/bb384936.aspx">Extension Methods (Visual Basic)</a> or <a href="http://msdn.microsoft.com/en-us/library/bb383977.aspx">Extension Methods (C# Programming Guide)</a>.

## Examples
This example demonstrates how to get all value tags of the MAIN PRG object. 
```
var mainProgramTags = Connector.MAIN.RetrieveValueTags();
```


## See Also


#### Reference
<a href="T_Vortex_Connector_IVortexObjectExtensions.md">IVortexObjectExtensions Class</a><br /><a href="N_Vortex_Connector.md">Vortex.Connector Namespace</a><br />