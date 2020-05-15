# IVortexObjectExtensions.ReadStructure Method 
 _**\[This is preliminary documentation and is subject to change.\]**_

Reads all value tags of instance <a href="T_Vortex_Connector_IVortexOnlineObject.md">IVortexOnlineObject</a>.

**Namespace:**&nbsp;<a href="N_Vortex_Connector.md">Vortex.Connector</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 0.101.0-alpha.5+Branch.develop.Sha.964441db673232ae7ce236ab6ff4c304c79df7be

## Syntax

**C#**<br />
``` C#
public static void ReadStructure(
	this IVortexOnlineObject structure
)
```


#### Parameters
&nbsp;<dl><dt>structure</dt><dd>Type: <a href="T_Vortex_Connector_IVortexOnlineObject.md">Vortex.Connector.IVortexOnlineObject</a><br /></dd></dl>

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Vortex_Connector_IVortexOnlineObject.md">IVortexOnlineObject</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="http://msdn.microsoft.com/en-us/library/bb384936.aspx">Extension Methods (Visual Basic)</a> or <a href="http://msdn.microsoft.com/en-us/library/bb383977.aspx">Extension Methods (C# Programming Guide)</a>.

## Examples

```
// Reads all value tags of the MAIN PRG. The value is stored in property 'Cyclic' and 'LastValue' of the respective value tag.
Connector.MAIN.ReadStructure();
```


## See Also


#### Reference
<a href="T_Vortex_Connector_IVortexObjectExtensions.md">IVortexObjectExtensions Class</a><br /><a href="N_Vortex_Connector.md">Vortex.Connector Namespace</a><br />