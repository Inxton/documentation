# ReflectionHelpers.GetObjectOfTypeAndDerived Method 
 _**\[This is preliminary documentation and is subject to change.\]**_

Retrieves recursivelly list of objects that are of required type or derive from the required type and are contained in reflected object.

**Namespace:**&nbsp;<a href="N_Vortex_Connector_Reflections.md">Vortex.Connector.Reflections</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 0.101.0-alpha.5+Branch.develop.Sha.964441db673232ae7ce236ab6ff4c304c79df7be

## Syntax

**C#**<br />
``` C#
public static IEnumerable<Object> GetObjectOfTypeAndDerived(
	Object reflectedObject,
	Type requiredType,
	List<Object> listOfObjects = null
)
```


#### Parameters
&nbsp;<dl><dt>reflectedObject</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />Object that will be searched for required type of objects.</dd><dt>requiredType</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/42892f65" target="_blank">System.Type</a><br />Reuired type.</dd><dt>listOfObjects (Optional)</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/6sh2ey19" target="_blank">System.Collections.Generic.List</a>(<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>)<br />Pre-existing list of objects.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/9eekhta0" target="_blank">IEnumerable</a>(<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>)<br />List of object of given type.

## See Also


#### Reference
<a href="T_Vortex_Connector_Reflections_ReflectionHelpers.md">ReflectionHelpers Class</a><br /><a href="N_Vortex_Connector_Reflections.md">Vortex.Connector.Reflections Namespace</a><br />