# DummyConnectorFactory.CreateREAL Method 
 _**\[This is preliminary documentation and is subject to change.\]**_

Creates <a href="http://msdn2.microsoft.com/en-us/library/3www918f" target="_blank">Single</a> dummy tag of PLC value type REAL

**Namespace:**&nbsp;<a href="N_Vortex_Connector.md">Vortex.Connector</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 0.101.0-alpha.5+Branch.develop.Sha.964441db673232ae7ce236ab6ff4c304c79df7be

## Syntax

**C#**<br />
``` C#
public override OnlinerReal CreateREAL(
	IVortexObject parent,
	string readableTail,
	string symbolTail
)
```


#### Parameters
&nbsp;<dl><dt>parent</dt><dd>Type: <a href="T_Vortex_Connector_IVortexObject.md">Vortex.Connector.IVortexObject</a><br />Parent object of <a href="T_Vortex_Connector_IVortexObject.md">IVortexObject</a> type.</dd><dt>readableTail</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Human readable tail of this value tag.</dd><dt>symbolTail</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Symbol tail of this value tag.</dd></dl>

#### Return Value
Type: <a href="T_Vortex_Connector_ValueTypes_OnlinerReal.md">OnlinerReal</a><br />New instance of <a href="T_Vortex_Connector_ValueTypes_OnlinerReal.md">OnlinerReal</a>

## See Also


#### Reference
<a href="T_Vortex_Connector_DummyConnectorFactory.md">DummyConnectorFactory Class</a><br /><a href="N_Vortex_Connector.md">Vortex.Connector Namespace</a><br />