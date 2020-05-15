# RelayCommand Constructor (Action(Object), Func(Object, Boolean), IVortexObject, String)
 _**\[This is preliminary documentation and is subject to change.\]**_

Creates new instance of <a href="T_Vortex_Presentation_Wpf_RelayCommand.md">RelayCommand</a>.

**Namespace:**&nbsp;<a href="N_Vortex_Presentation_Wpf.md">Vortex.Presentation.Wpf</a><br />**Assembly:**&nbsp;Vortex.Presentation.Wpf (in Vortex.Presentation.Wpf.dll) Version: 0.112.0-alpha.12+Branch.develop.Sha.df20d7449a44daab5691c666370b08ce38564334

## Syntax

**C#**<br />
``` C#
public RelayCommand(
	Action<Object> executeMethod,
	Func<Object, bool> canExecuteMethod = null,
	IVortexObject callerObject = null,
	string commandName = ""
)
```


#### Parameters
&nbsp;<dl><dt>executeMethod</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.action-1" target="_blank">System.Action</a>(<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>)<br />Method to be executed with this command.</dd><dt>canExecuteMethod (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.func-2" target="_blank">System.Func</a>(<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>, <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_blank">Boolean</a>)<br />Can execute method determined whether this command can be executed.</dd><dt>callerObject (Optional)</dt><dd>Type: IVortexObject<br />Object that invoked this command.</dd><dt>commandName (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_blank">System.String</a><br />Optional command description of the command to enrich the logged data.</dd></dl>

## See Also


#### Reference
<a href="T_Vortex_Presentation_Wpf_RelayCommand.md">RelayCommand Class</a><br /><a href="Overload_Vortex_Presentation_Wpf_RelayCommand__ctor.md">RelayCommand Overload</a><br /><a href="N_Vortex_Presentation_Wpf.md">Vortex.Presentation.Wpf Namespace</a><br />