# fbCommandHolder.Execute Method 
 

Executes the <a href="T_VortexBase_fbCommand.md">fbCommand</a>. When <a href="F_VortexBase_fbCommandHolder_PreCommandExecution.md">PreCommandExecution</a> is not assigned or returns 'true'. <a href="T_VortexBase_fbCommand.md">fbCommand</a> monitored in the controller will start execution of the associated logic.

**Namespace:**&nbsp;<a href="N_VortexBase.md">VortexBase</a><br />**Assembly:**&nbsp;VortexBaseConnector (in VortexBaseConnector.dll) Version: 0.101.0-dotnetcore.38+Branch.feature/dotnetcore.Sha.9184ded7250ef900bfdd1d83b2841836087bcfce

## Syntax

**C#**<br />
``` C#
public void Execute(
	Object parameter
)
```


#### Parameters
&nbsp;<dl><dt>parameter</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">System.Object</a><br /></dd></dl>

#### Implements
<a href="https://docs.microsoft.com/dotnet/api/system.windows.input.icommand.execute#System_Windows_Input_ICommand_Execute_System_Object_" target="_blank">ICommand.Execute(Object)</a><br />

## See Also


#### Reference
<a href="T_VortexBase_fbCommandHolder.md">fbCommandHolder Class</a><br /><a href="N_VortexBase.md">VortexBase Namespace</a><br />