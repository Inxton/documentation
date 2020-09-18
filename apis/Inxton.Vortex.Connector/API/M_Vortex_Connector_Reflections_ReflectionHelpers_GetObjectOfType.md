# ReflectionHelpers.GetObjectOfType Method (Object, Type, List(Object))
 

Retrieves recursivelly list of objects of given type that are contained in reflected object.

**Namespace:**&nbsp;<a href="N_Vortex_Connector_Reflections.md">Vortex.Connector.Reflections</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 1.3.9+Branch.tags/v1.3.9.Sha.76b254c0c0b18db4a0754abdd4dde08f4adae41f

## Syntax

**C#**<br />
``` C#
public static IEnumerable<Object> GetObjectOfType(
	Object reflectedObject,
	Type requiredType,
	List<Object> listOfObjects = null
)
```


#### Parameters
&nbsp;<dl><dt>reflectedObject</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">System.Object</a><br />Object that will be searched for reuired type of objects.</dd><dt>requiredType</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.type" target="_blank">System.Type</a><br />Required type</dd><dt>listOfObjects (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.list-1" target="_blank">System.Collections.Generic.List</a>(<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>)<br />Pre-existing list of objects.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank">IEnumerable</a>(<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>)<br />List of object of given type.

## See Also


#### Reference
<a href="T_Vortex_Connector_Reflections_ReflectionHelpers.md">ReflectionHelpers Class</a><br /><a href="Overload_Vortex_Connector_Reflections_ReflectionHelpers_GetObjectOfType.md">GetObjectOfType Overload</a><br /><a href="N_Vortex_Connector_Reflections.md">Vortex.Connector.Reflections Namespace</a><br />