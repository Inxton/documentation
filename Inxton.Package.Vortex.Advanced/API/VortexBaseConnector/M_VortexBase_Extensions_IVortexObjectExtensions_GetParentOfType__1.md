# IVortexObjectExtensions.GetParentOfType(*T*) Method 
 

Searches recursively the parents of this IVortexObject until encounters object of given type. When the root object IConnector is hit climbing up the hierarchy the method returns pre-existing parent.

**Namespace:**&nbsp;<a href="N_VortexBase_Extensions.md">VortexBase.Extensions</a><br />**Assembly:**&nbsp;VortexBaseConnector (in VortexBaseConnector.dll) Version: 0.101.0-dotnetcore.38+Branch.feature/dotnetcore.Sha.9184ded7250ef900bfdd1d83b2841836087bcfce

## Syntax

**C#**<br />
``` C#
public static T GetParentOfType<T>(
	this IVortexObject obj,
	T parent = null
)
where T : class

```


#### Parameters
&nbsp;<dl><dt>obj</dt><dd>Type: IVortexObject<br />Searched object</dd><dt>parent (Optional)</dt><dd>Type: *T*<br />[optional] Pre-existing parent.</dd></dl>

#### Type Parameters
&nbsp;<dl><dt>T</dt><dd /></dl>

#### Return Value
Type: *T*<br />Parent object of given type.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type IVortexObject. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods">Extension Methods (C# Programming Guide)</a>.

## Remarks
Take into consideration possible performance degradation due to use of reflections in this method.

## See Also


#### Reference
<a href="T_VortexBase_Extensions_IVortexObjectExtensions.md">IVortexObjectExtensions Class</a><br /><a href="N_VortexBase_Extensions.md">VortexBase.Extensions Namespace</a><br />