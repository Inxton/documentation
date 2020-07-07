# IVortexObjectExtensions.Read Method 
 

Reads all value tags of instance <a href="T_Vortex_Connector_IVortexOnlineObject.md">IVortexOnlineObject</a>.

**Namespace:**&nbsp;<a href="N_Vortex_Connector.md">Vortex.Connector</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 1.1.0+Branch.master.Sha.6964545d53528bb038364111fd08af947d49d02f

## Syntax

**C#**<br />
``` C#
public static void Read(
	this IVortexObject structure
)
```


#### Parameters
&nbsp;<dl><dt>structure</dt><dd>Type: <a href="T_Vortex_Connector_IVortexObject.md">Vortex.Connector.IVortexObject</a><br /></dd></dl>

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Vortex_Connector_IVortexObject.md">IVortexObject</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="http://msdn.microsoft.com/en-us/library/bb384936.aspx">Extension Methods (Visual Basic)</a> or <a href="http://msdn.microsoft.com/en-us/library/bb383977.aspx">Extension Methods (C# Programming Guide)</a>.

## Examples

```
// Reads all value tags of the MAIN PRG. The value is stored in property 'Cyclic' and 'LastValue' of the respective value tag.
Connector.MAIN.Read();
```


## See Also


#### Reference
<a href="T_Vortex_Connector_IVortexObjectExtensions.md">IVortexObjectExtensions Class</a><br /><a href="N_Vortex_Connector.md">Vortex.Connector Namespace</a><br />