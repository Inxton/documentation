# ReflectionHelpers.GetObjectOfType Method (Object, ReflectionHelpers.IsRequiredTypeDelegate, List(Object))
 

Retrieves recursivelly list of objects that satisfy <a href="T_Vortex_Connector_Reflections_ReflectionHelpers_IsRequiredTypeDelegate.md">ReflectionHelpers.IsRequiredTypeDelegate</a> and are contained in reflected object.

**Namespace:**&nbsp;<a href="N_Vortex_Connector_Reflections.md">Vortex.Connector.Reflections</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 1.3.12+Branch.tags-v1.3.12.Sha.00bdfb8be9e078a68c552d3a1d81a8775d48ab55

## Syntax

**C#**<br />
``` C#
public static IEnumerable<Object> GetObjectOfType(
	Object reflectedObject,
	ReflectionHelpers.IsRequiredTypeDelegate isRequiredType,
	List<Object> listOfObjects = null
)
```


#### Parameters
&nbsp;<dl><dt>reflectedObject</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">System.Object</a><br />Object that will be searched for objects that match <a href="T_Vortex_Connector_Reflections_ReflectionHelpers_IsRequiredTypeDelegate.md">ReflectionHelpers.IsRequiredTypeDelegate</a>.</dd><dt>isRequiredType</dt><dd>Type: <a href="T_Vortex_Connector_Reflections_ReflectionHelpers_IsRequiredTypeDelegate.md">Vortex.Connector.Reflections.ReflectionHelpers.IsRequiredTypeDelegate</a><br />Delegate to evaluate whether the type matches the requirements.</dd><dt>listOfObjects (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.list-1" target="_blank">System.Collections.Generic.List</a>(<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>)<br />Pre-existing list of objects.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank">IEnumerable</a>(<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>)<br />List of object of given type.

## See Also


#### Reference
<a href="T_Vortex_Connector_Reflections_ReflectionHelpers.md">ReflectionHelpers Class</a><br /><a href="Overload_Vortex_Connector_Reflections_ReflectionHelpers_GetObjectOfType.md">GetObjectOfType Overload</a><br /><a href="N_Vortex_Connector_Reflections.md">Vortex.Connector.Reflections Namespace</a><br />