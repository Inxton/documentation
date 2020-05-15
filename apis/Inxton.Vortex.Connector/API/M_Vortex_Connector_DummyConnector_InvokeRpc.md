# DummyConnector.InvokeRpc Method 
 _**\[This is preliminary documentation and is subject to change.\]**_

This method does not have effect on <a href="T_Vortex_Connector_DummyConnector.md">DummyConnector</a>

**Namespace:**&nbsp;<a href="N_Vortex_Connector.md">Vortex.Connector</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 0.101.0-alpha.5+Branch.develop.Sha.964441db673232ae7ce236ab6ff4c304c79df7be

## Syntax

**C#**<br />
``` C#
public override Object InvokeRpc(
	string symbolPath,
	string methodName,
	Object[] params
)
```


#### Parameters
&nbsp;<dl><dt>symbolPath</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Symbol path of the block whit remotely invokable method</dd><dt>methodName</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Method name. NOTE: Method must have attribute 'TcRpcEnable' declared.}</dd><dt>params</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a>[]<br />Method's parameters. NOTE: Only value type parameters are accepted.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a><br />Result of the remotely called method. NOTE:Only value types are allowed as return values.

## See Also


#### Reference
<a href="T_Vortex_Connector_DummyConnector.md">DummyConnector Class</a><br /><a href="N_Vortex_Connector.md">Vortex.Connector Namespace</a><br />