# IVortexObjectExtensions.WriteStructure Method 
 

Writes all value tags of instance <a href="T_Vortex_Connector_IVortexOnlineObject.md">IVortexOnlineObject</a>

**Namespace:**&nbsp;<a href="N_Vortex_Connector.md">Vortex.Connector</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 1.3.12+Branch.tags-v1.3.12.Sha.00bdfb8be9e078a68c552d3a1d81a8775d48ab55

## Syntax

**C#**<br />
``` C#
public static void WriteStructure(
	this IVortexOnlineObject structure
)
```


#### Parameters
&nbsp;<dl><dt>structure</dt><dd>Type: <a href="T_Vortex_Connector_IVortexOnlineObject.md">Vortex.Connector.IVortexOnlineObject</a><br /></dd></dl>

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Vortex_Connector_IVortexOnlineObject.md">IVortexOnlineObject</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods">Extension Methods (C# Programming Guide)</a>.

## Examples

```
// Writes all modified values of the MAIN PRG.
Connector.Online.MAIN.GrowingLayoutStructure.WriteStructure()
```


## See Also


#### Reference
<a href="T_Vortex_Connector_IVortexObjectExtensions.md">IVortexObjectExtensions Class</a><br /><a href="N_Vortex_Connector.md">Vortex.Connector Namespace</a><br />