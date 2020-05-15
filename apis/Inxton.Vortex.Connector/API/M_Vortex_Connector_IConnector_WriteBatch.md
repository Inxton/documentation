# IConnector.WriteBatch Method 
 _**\[This is preliminary documentation and is subject to change.\]**_

Writes batch of value items to the plc.

**Namespace:**&nbsp;<a href="N_Vortex_Connector.md">Vortex.Connector</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 0.101.0-alpha.5+Branch.develop.Sha.964441db673232ae7ce236ab6ff4c304c79df7be

## Syntax

**C#**<br />
``` C#
public abstract void WriteBatch(
	IEnumerable<IValueTag> valueTags
)
```


#### Parameters
&nbsp;<dl><dt>valueTags</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/9eekhta0" target="_blank">System.Collections.Generic.IEnumerable</a>(<a href="T_Vortex_Connector_IValueTag.md">IValueTag</a>)<br />Value items to be written.</dd></dl>

## See Also


#### Reference
<a href="T_Vortex_Connector_IConnector.md">IConnector Class</a><br /><a href="N_Vortex_Connector.md">Vortex.Connector Namespace</a><br />