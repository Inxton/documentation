# stMessageQueue.FilterMessages Method 
 

Returns filtered messages.

**Namespace:**&nbsp;<a href="N_VortexBase.md">VortexBase</a><br />**Assembly:**&nbsp;VortexBaseConnector (in VortexBaseConnector.dll) Version: 0.101.0-dotnetcore.38+Branch.feature/dotnetcore.Sha.9184ded7250ef900bfdd1d83b2841836087bcfce

## Syntax

**C#**<br />
``` C#
public Task<IEnumerable<PlainstMessage>> FilterMessages(
	Func<PlainstMessage, bool> filter
)
```


#### Parameters
&nbsp;<dl><dt>filter</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.func-2" target="_blank">System.Func</a>(PlainstMessage, <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_blank">Boolean</a>)<br />Custom filter</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.threading.tasks.task-1" target="_blank">Task</a>(<a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank">IEnumerable</a>(PlainstMessage))<br />\[Missing <returns> documentation for "M:VortexBase.stMessageQueue.FilterMessages(System.Func{VortexBase.PlainstMessage,System.Boolean})"\]

## See Also


#### Reference
<a href="T_VortexBase_stMessageQueue.md">stMessageQueue Class</a><br /><a href="N_VortexBase.md">VortexBase Namespace</a><br />