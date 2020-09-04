# fbCommand.PreCommandExecution Field
 

Allows or prevents the execution of the command based on return from the delegate. If delegate is not assigned the execution will be allowed by default. When the delegate is assigned it must return 'true' to be executed. PreCommandExecution can execute arbitrary logic such as dialogue window, information for the user about the execution of the command, etc.

**Namespace:**&nbsp;<a href="N_VortexBase.md">VortexBase</a><br />**Assembly:**&nbsp;VortexBaseConnector (in VortexBaseConnector.dll) Version: 0.101.0-dotnetcore.38+Branch.feature/dotnetcore.Sha.9184ded7250ef900bfdd1d83b2841836087bcfce

## Syntax

**C#**<br />
``` C#
public fbCommand.PreCommandExecutionDelegate PreCommandExecution
```


#### Field Value
Type: <a href="T_VortexBase_fbCommand_PreCommandExecutionDelegate.md">fbCommand.PreCommandExecutionDelegate</a>

## See Also


#### Reference
<a href="T_VortexBase_fbCommand.md">fbCommand Class</a><br /><a href="N_VortexBase.md">VortexBase Namespace</a><br />