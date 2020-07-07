# DummyConnectorFactory.CreateDATE_TIME Method 
 

Creates <a href="http://msdn2.microsoft.com/en-us/library/03ybds8y" target="_blank">DateTime</a> dummy tag of PLC value type DATE_TIME (DT)

**Namespace:**&nbsp;<a href="N_Vortex_Connector.md">Vortex.Connector</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 1.1.0+Branch.master.Sha.6964545d53528bb038364111fd08af947d49d02f

## Syntax

**C#**<br />
``` C#
public override OnlinerDateTime CreateDATE_TIME(
	IVortexObject parent,
	string readableTail,
	string symbolTail
)
```


#### Parameters
&nbsp;<dl><dt>parent</dt><dd>Type: <a href="T_Vortex_Connector_IVortexObject.md">Vortex.Connector.IVortexObject</a><br />Parent object of <a href="T_Vortex_Connector_IVortexObject.md">IVortexObject</a> type.</dd><dt>readableTail</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Human readable tail of this value tag.</dd><dt>symbolTail</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Symbol tail of this value tag.</dd></dl>

#### Return Value
Type: <a href="T_Vortex_Connector_ValueTypes_OnlinerDateTime.md">OnlinerDateTime</a><br />New instance of <a href="T_Vortex_Connector_ValueTypes_OnlinerDateTime.md">OnlinerDateTime</a>

## See Also


#### Reference
<a href="T_Vortex_Connector_DummyConnectorFactory.md">DummyConnectorFactory Class</a><br /><a href="N_Vortex_Connector.md">Vortex.Connector Namespace</a><br />