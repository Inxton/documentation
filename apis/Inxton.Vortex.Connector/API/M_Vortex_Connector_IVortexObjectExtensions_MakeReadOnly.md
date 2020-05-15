# IVortexObjectExtensions.MakeReadOnly Method 
 _**\[This is preliminary documentation and is subject to change.\]**_

Makes <a href="T_Vortex_Connector_IVortexObject.md">IVortexObject</a> readonly for this application.

**Namespace:**&nbsp;<a href="N_Vortex_Connector.md">Vortex.Connector</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 0.101.0-alpha.5+Branch.develop.Sha.964441db673232ae7ce236ab6ff4c304c79df7be

## Syntax

**C#**<br />
``` C#
public static void MakeReadOnly(
	this IVortexObject structure
)
```


#### Parameters
&nbsp;<dl><dt>structure</dt><dd>Type: <a href="T_Vortex_Connector_IVortexObject.md">Vortex.Connector.IVortexObject</a><br />Object to be rendered readonly</dd></dl>

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Vortex_Connector_IVortexObject.md">IVortexObject</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="http://msdn.microsoft.com/en-us/library/bb384936.aspx">Extension Methods (Visual Basic)</a> or <a href="http://msdn.microsoft.com/en-us/library/bb383977.aspx">Extension Methods (C# Programming Guide)</a>.

## Examples

```
// Rendres whole structure value tag readonly
ReadonlyStructure.MakeReadOnly();
// Renders element [0,0] of the array readonly.
roArray[0, 0].MakeReadOnly();
```


## See Also


#### Reference
<a href="T_Vortex_Connector_IVortexObjectExtensions.md">IVortexObjectExtensions Class</a><br /><a href="N_Vortex_Connector.md">Vortex.Connector Namespace</a><br />