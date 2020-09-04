# fbCommandHolder.PlcfbCommandHolder.Keep Method 
 

Invokes the execution of this <a href="T_VortexBase_fbCommandHolder.md">fbCommandHolder</a>s from the plc. The execution of the command is active until the command is 'unkept' by the <a href="M_VortexBase_fbCommandHolder_PlcfbCommandHolder_UnKeep.md">UnKeep()</a> or the HMI.
&nbsp;<table><tr><th>![Note](media/AlertNote.png) Note</th></tr><tr><td>This is PLC method. This method is invokable only from the PLC code.</td></tr></table>&nbsp;
**Namespace:**&nbsp;<a href="N_VortexBase.md">VortexBase</a><br />**Assembly:**&nbsp;VortexBaseConnector (in VortexBaseConnector.dll) Version: 0.101.0-dotnetcore.38+Branch.feature/dotnetcore.Sha.9184ded7250ef900bfdd1d83b2841836087bcfce

## Syntax

**C#**<br />
``` C#
public Object Keep()
```


#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a><br />Plc type BOOL; Twin type: OnlinerBool

## See Also


#### Reference
<a href="T_VortexBase_fbCommandHolder_PlcfbCommandHolder.md">fbCommandHolder.PlcfbCommandHolder Class</a><br /><a href="N_VortexBase.md">VortexBase Namespace</a><br />