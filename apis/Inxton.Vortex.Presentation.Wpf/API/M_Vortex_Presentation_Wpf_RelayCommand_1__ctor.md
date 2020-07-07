# RelayCommand(*T*) Constructor (Action(*T*), Func(*T*, Boolean), Object, String)
 

Creates new instance of <a href="T_Vortex_Presentation_Wpf_RelayCommand.md">RelayCommand</a>.

**Namespace:**&nbsp;<a href="N_Vortex_Presentation_Wpf.md">Vortex.Presentation.Wpf</a><br />**Assembly:**&nbsp;Vortex.Presentation.Wpf (in Vortex.Presentation.Wpf.dll) Version: 1.1.2+Branch.master.Sha.e10390af75ec466990c3a0e7b7d3595bd05fe7b8

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
&nbsp;<dl><dt>executeMethod</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/018hxwa8" target="_blank">System.Action</a>(<a href="T_Vortex_Presentation_Wpf_RelayCommand_1.md">*T*</a>)<br />Method to be executed with this command.</dd><dt>canExecuteMethod (Optional)</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/bb549151" target="_blank">System.Func</a>(<a href="T_Vortex_Presentation_Wpf_RelayCommand_1.md">*T*</a>, <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">Boolean</a>)<br />Can execute method determined whether this command can be executed.</dd><dt>callerObject (Optional)</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />Object that invoked this command.</dd><dt>commandName (Optional)</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Optional command description of the command to enrich the logged data.</dd></dl>

## See Also


#### Reference
<a href="T_Vortex_Presentation_Wpf_RelayCommand_1.md">RelayCommand(T) Class</a><br /><a href="Overload_Vortex_Presentation_Wpf_RelayCommand_1__ctor.md">RelayCommand(T) Overload</a><br /><a href="N_Vortex_Presentation_Wpf.md">Vortex.Presentation.Wpf Namespace</a><br />