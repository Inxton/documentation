# IConnectorFactory.CreateSTRING Method (IVortexObject, String, String)
 _**\[This is preliminary documentation and is subject to change.\]**_

Creates <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a> tag of a value type STRING;

**Namespace:**&nbsp;<a href="N_Vortex_Connector.md">Vortex.Connector</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 0.101.0-alpha.5+Branch.develop.Sha.964441db673232ae7ce236ab6ff4c304c79df7be

## Syntax

**C#**<br />
``` C#
public abstract OnlinerString CreateSTRING(
	IVortexObject parent,
	string readableTail,
	string symbolTail
)
```


#### Parameters
&nbsp;<dl><dt>parent</dt><dd>Type: <a href="T_Vortex_Connector_IVortexObject.md">Vortex.Connector.IVortexObject</a><br />Parent object of <a href="T_Vortex_Connector_IVortexObject.md">IVortexObject</a> type.</dd><dt>readableTail</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Human readable tail of this value tag.</dd><dt>symbolTail</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Symbol tail of this value tag.</dd></dl>

#### Return Value
Type: <a href="T_Vortex_Connector_ValueTypes_OnlinerString.md">OnlinerString</a><br />New instance of <a href="T_Vortex_Connector_ValueTypes_OnlinerString.md">OnlinerString</a>

## See Also


#### Reference
<a href="T_Vortex_Connector_IConnectorFactory.md">IConnectorFactory Class</a><br /><a href="Overload_Vortex_Connector_IConnectorFactory_CreateSTRING.md">CreateSTRING Overload</a><br /><a href="N_Vortex_Connector.md">Vortex.Connector Namespace</a><br />