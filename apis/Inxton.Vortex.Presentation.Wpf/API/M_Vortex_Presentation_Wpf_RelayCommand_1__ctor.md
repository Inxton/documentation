# RelayCommand(*T*) Constructor (Action(*T*), Func(*T*, Boolean), Object, String)
 

Creates new instance of <a href="T_Vortex_Presentation_Wpf_RelayCommand.md">RelayCommand</a>.

**Namespace:**&nbsp;<a href="N_Vortex_Presentation_Wpf.md">Vortex.Presentation.Wpf</a><br />**Assembly:**&nbsp;Vortex.Presentation.Wpf (in Vortex.Presentation.Wpf.dll) Version: 1.3.21+Branch.tags/v1.3.21.Sha.d2d012c69d12da922e6e4a18ad43e5435cbba0f0

## Syntax

**C#**<br />
``` C#
public RelayCommand(
	Action<T> executeMethod,
	Func<T, bool> canExecuteMethod = null,
	Object callerObject = null,
	string commandName = ""
)
```


#### Parameters
&nbsp;<dl><dt>executeMethod</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.action-1" target="_blank">System.Action</a>(<a href="T_Vortex_Presentation_Wpf_RelayCommand_1.md">*T*</a>)<br />Method to be executed with this command.</dd><dt>canExecuteMethod (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.func-2" target="_blank">System.Func</a>(<a href="T_Vortex_Presentation_Wpf_RelayCommand_1.md">*T*</a>, <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_blank">Boolean</a>)<br />Can execute method determined whether this command can be executed.</dd><dt>callerObject (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">System.Object</a><br />Object that invoked this command.</dd><dt>commandName (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_blank">System.String</a><br />Optional command description of the command to enrich the logged data.</dd></dl>

## See Also


#### Reference
<a href="T_Vortex_Presentation_Wpf_RelayCommand_1.md">RelayCommand(T) Class</a><br /><a href="Overload_Vortex_Presentation_Wpf_RelayCommand_1__ctor.md">RelayCommand(T) Overload</a><br /><a href="N_Vortex_Presentation_Wpf.md">Vortex.Presentation.Wpf Namespace</a><br />