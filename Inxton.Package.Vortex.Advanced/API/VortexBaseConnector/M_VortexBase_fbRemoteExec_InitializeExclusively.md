# fbRemoteExec.InitializeExclusively Method (Action)
 

Initializes this <a href="T_VortexBase_fbRemoteExec.md">fbRemoteExec</a> exclusively for this DefferedAction. Any following attempt to initialize this <a href="T_VortexBase_fbRemoteExec.md">fbRemoteExec</a> will throw an exception.

**Namespace:**&nbsp;<a href="N_VortexBase.md">VortexBase</a><br />**Assembly:**&nbsp;VortexBaseConnector (in VortexBaseConnector.dll) Version: 0.101.0-dotnetcore.38+Branch.feature/dotnetcore.Sha.9184ded7250ef900bfdd1d83b2841836087bcfce

## Syntax

**C#**<br />
``` C#
public void InitializeExclusively(
	Action deferredAction
)
```


#### Parameters
&nbsp;<dl><dt>deferredAction</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.action" target="_blank">System.Action</a><br />Action to be executed on this <a href="T_VortexBase_fbRemoteExec.md">fbRemoteExec</a> call.</dd></dl>

## See Also


#### Reference
<a href="T_VortexBase_fbRemoteExec.md">fbRemoteExec Class</a><br /><a href="Overload_VortexBase_fbRemoteExec_InitializeExclusively.md">InitializeExclusively Overload</a><br /><a href="N_VortexBase.md">VortexBase Namespace</a><br />