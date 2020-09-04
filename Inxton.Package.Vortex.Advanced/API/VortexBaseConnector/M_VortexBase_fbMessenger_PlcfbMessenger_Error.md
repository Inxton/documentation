# fbMessenger.PlcfbMessenger.Error Method 
 

Adds message of 'error' category to the message queue.
&nbsp;<table><tr><th>![Note](media/AlertNote.png) Note</th></tr><tr><td>This is PLC method. This method is invokable only from the PLC code.</td></tr></table>&nbsp;
**Namespace:**&nbsp;<a href="N_VortexBase.md">VortexBase</a><br />**Assembly:**&nbsp;VortexBaseConnector (in VortexBaseConnector.dll) Version: 0.101.0-dotnetcore.38+Branch.feature/dotnetcore.Sha.9184ded7250ef900bfdd1d83b2841836087bcfce

## Syntax

**C#**<br />
``` C#
public void Error(
	Object Message
)
```


#### Parameters
&nbsp;<dl><dt>Message</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">System.Object</a><br />
Plc type : STRING [VAR_INPUT]; Twin type : OnlinerString


Arbitrary message string.</dd></dl>

#### Return Value
Type: <br />Plc type VOID; Twin type: <a href="https://docs.microsoft.com/dotnet/api/system.void" target="_blank">Void</a>

## See Also


#### Reference
<a href="T_VortexBase_fbMessenger_PlcfbMessenger.md">fbMessenger.PlcfbMessenger Class</a><br /><a href="N_VortexBase.md">VortexBase Namespace</a><br />