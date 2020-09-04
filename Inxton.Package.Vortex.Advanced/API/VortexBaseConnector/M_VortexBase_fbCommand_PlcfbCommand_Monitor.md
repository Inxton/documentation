# fbCommand.PlcfbCommand.Monitor Method 
 

Monitors invocation of the command. Command is invoked on rising edge of the '_Invoke' variable or by calling Invoke method. Command execution stops when <a href="M_VortexBase_fbCommand_PlcfbCommand_Complete.md">Complete()</a> method is called. Typically the command is invoked by the HMI/SCADA side by setting 'Invoke' variable to 'true'.
&nbsp;<table><tr><th>![Note](media/AlertNote.png) Note</th></tr><tr><td>This is PLC method. This method is invokable only from the PLC code.</td></tr></table>&nbsp;
**Namespace:**&nbsp;<a href="N_VortexBase.md">VortexBase</a><br />**Assembly:**&nbsp;VortexBaseConnector (in VortexBaseConnector.dll) Version: 0.101.0-dotnetcore.38+Branch.feature/dotnetcore.Sha.9184ded7250ef900bfdd1d83b2841836087bcfce

## Syntax

**C#**<br />
``` C#
public Object Monitor()
```


#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a><br />'TRUE' when the cammand was invoked and was not completed yet.

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a><br />Plc type BOOL; Twin type: OnlinerBool

## See Also


#### Reference
<a href="T_VortexBase_fbCommand_PlcfbCommand.md">fbCommand.PlcfbCommand Class</a><br /><a href="N_VortexBase.md">VortexBase Namespace</a><br />