# LazyRenderer.CreatePresentation Method 
 

Creates pre-rendered containers that are fully rendered when made visible.

**Namespace:**&nbsp;<a href="N_Vortex_Presentation_Wpf.md">Vortex.Presentation.Wpf</a><br />**Assembly:**&nbsp;Vortex.Presentation.Wpf (in Vortex.Presentation.Wpf.dll) Version: 1.1.2+Branch.master.Sha.e10390af75ec466990c3a0e7b7d3595bd05fe7b8

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
&nbsp;<dl><dt>presentationType</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />Presentation type</dd><dt>vortexObject</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />Object which should be visually represented.</dd><dt>rootContainer (Optional)</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/ms602714" target="_blank">System.Windows.FrameworkElement</a><br />Optionaly provides root container when the default option is not desirable.</dd><dt>preferCustomized (Optional)</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">System.Boolean</a><br />Instructs the renderer to prefer the use of layouting and other paramters from the customized control.</dd><dt>reportingLevel (Optional)</dt><dd>Type: <a href="T_Vortex_Presentation_Wpf_ReportingLevel.md">Vortex.Presentation.Wpf.ReportingLevel</a><br />Reporting level <a href="T_Vortex_Presentation_Wpf_ReportingLevel.md">ReportingLevel</a></dd><dt>maxObjectsInDesignMode (Optional)</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/td2s409d" target="_blank">System.Int32</a><br />Max object that should be rendered in design mode.</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a><br />

## See Also


#### Reference
<a href="T_Vortex_Presentation_Wpf_LazyRenderer.md">LazyRenderer Class</a><br /><a href="N_Vortex_Presentation_Wpf.md">Vortex.Presentation.Wpf Namespace</a><br />