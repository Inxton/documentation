# IVortexObjectExtensions.RetrieveValueTags Method 
 

Retrieves all value tags of given object.

**Namespace:**&nbsp;<a href="N_Vortex_Connector.md">Vortex.Connector</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 1.3.9+Branch.tags/v1.3.9.Sha.76b254c0c0b18db4a0754abdd4dde08f4adae41f

## Syntax

**C#**<br />
``` C#
public static IEnumerable<IValueTag> RetrieveValueTags(
	this IVortexObject onlineObject,
	List<IValueTag> valueTags = null
)
```


#### Parameters
&nbsp;<dl><dt>onlineObject</dt><dd>Type: <a href="T_Vortex_Connector_IVortexObject.md">Vortex.Connector.IVortexObject</a><br />Object from which the value tags are to be retrieved.</dd><dt>valueTags (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.list-1" target="_blank">System.Collections.Generic.List</a>(<a href="T_Vortex_Connector_IValueTag.md">IValueTag</a>)<br />Existing value tags.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank">IEnumerable</a>(<a href="T_Vortex_Connector_IValueTag.md">IValueTag</a>)<br />Value tags of given object.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Vortex_Connector_IVortexObject.md">IVortexObject</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods">Extension Methods (C# Programming Guide)</a>.

## Examples
This example demonstrates how to get all value tags of the MAIN PRG object. 
```
var mainProgramTags = Connector.MAIN.RetrieveValueTags();
```


## See Also


#### Reference
<a href="T_Vortex_Connector_IVortexObjectExtensions.md">IVortexObjectExtensions Class</a><br /><a href="N_Vortex_Connector.md">Vortex.Connector Namespace</a><br />