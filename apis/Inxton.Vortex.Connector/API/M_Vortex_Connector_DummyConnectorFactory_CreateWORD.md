# DummyConnectorFactory.CreateWORD Method 
 

Creates <a href="http://msdn2.microsoft.com/en-us/library/s6eyk10z" target="_blank">UInt16</a> dummy tag of PLC value type WORD

**Namespace:**&nbsp;<a href="N_Vortex_Connector.md">Vortex.Connector</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 1.1.0+Branch.master.Sha.6964545d53528bb038364111fd08af947d49d02f

## Syntax

**C#**<br />
``` C#
public override OnlinerWord CreateWORD(
	IVortexObject parent,
	string readableTail,
	string symbolTail
)
```


#### Parameters
&nbsp;<dl><dt>parent</dt><dd>Type: <a href="T_Vortex_Connector_IVortexObject.md">Vortex.Connector.IVortexObject</a><br />Parent object of <a href="T_Vortex_Connector_IVortexObject.md">IVortexObject</a> type.</dd><dt>readableTail</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Human readable tail of this value tag.</dd><dt>symbolTail</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Symbol tail of this value tag.</dd></dl>

#### Return Value
Type: <a href="T_Vortex_Connector_ValueTypes_OnlinerWord.md">OnlinerWord</a><br />New instance of <a href="T_Vortex_Connector_ValueTypes_OnlinerWord.md">OnlinerWord</a>

## See Also


#### Reference
<a href="T_Vortex_Connector_DummyConnectorFactory.md">DummyConnectorFactory Class</a><br /><a href="N_Vortex_Connector.md">Vortex.Connector Namespace</a><br />