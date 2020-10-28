# LazyRenderer.CreatePresentation Method 
 

Creates pre-rendered containers that are fully rendered when made visible.

**Namespace:**&nbsp;<a href="N_Vortex_Presentation_Wpf.md">Vortex.Presentation.Wpf</a><br />**Assembly:**&nbsp;Vortex.Presentation.Wpf (in Vortex.Presentation.Wpf.dll) Version: 1.3.21+Branch.tags/v1.3.21.Sha.d2d012c69d12da922e6e4a18ad43e5435cbba0f0

## Syntax

**C#**<br />
``` C#
public Object CreatePresentation(
	Object presentationType,
	Object vortexObject,
	FrameworkElement rootContainer = null,
	bool preferCustomized = false,
	ReportingLevel reportingLevel = ReportingLevel.None,
	int maxObjectsInDesignMode = 25
)
```


#### Parameters
&nbsp;<dl><dt>presentationType</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">System.Object</a><br />Presentation type</dd><dt>vortexObject</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">System.Object</a><br />Object which should be visually represented.</dd><dt>rootContainer (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.windows.frameworkelement" target="_blank">System.Windows.FrameworkElement</a><br />Optionaly provides root container when the default option is not desirable.</dd><dt>preferCustomized (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_blank">System.Boolean</a><br />Instructs the renderer to prefer the use of layouting and other paramters from the customized control.</dd><dt>reportingLevel (Optional)</dt><dd>Type: <a href="T_Vortex_Presentation_Wpf_ReportingLevel.md">Vortex.Presentation.Wpf.ReportingLevel</a><br />Reporting level <a href="T_Vortex_Presentation_Wpf_ReportingLevel.md">ReportingLevel</a></dd><dt>maxObjectsInDesignMode (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.int32" target="_blank">System.Int32</a><br />Max object that should be rendered in design mode.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a><br />

## See Also


#### Reference
<a href="T_Vortex_Presentation_Wpf_LazyRenderer.md">LazyRenderer Class</a><br /><a href="N_Vortex_Presentation_Wpf.md">Vortex.Presentation.Wpf Namespace</a><br />