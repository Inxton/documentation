# Renderer.CreatePresentation Method 
 _**\[This is preliminary documentation and is subject to change.\]**_

Creates presentation of IVortexObject or IValueTag of given presentation type.

**Namespace:**&nbsp;<a href="N_Vortex_Presentation_Wpf.md">Vortex.Presentation.Wpf</a><br />**Assembly:**&nbsp;Vortex.Presentation.Wpf (in Vortex.Presentation.Wpf.dll) Version: 0.112.0-alpha.12+Branch.develop.Sha.df20d7449a44daab5691c666370b08ce38564334

## Syntax

**C#**<br />
``` C#
public Object CreatePresentation(
	Object presentationType,
	Object vortexObject,
	bool preferCustomized = false,
	ReportingLevel reportingLevel = ReportingLevel.None,
	int maxObjectsInDesignMode = 25,
	bool cacheVisuals = true
)
```


#### Parameters
&nbsp;<dl><dt>presentationType</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">System.Object</a><br />Presentation type</dd><dt>vortexObject</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">System.Object</a><br />Object to be represented.</dd><dt>preferCustomized (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_blank">System.Boolean</a><br />Instructs the renderer to prefer the use of layouting and other paramters from the customized control.</dd><dt>reportingLevel (Optional)</dt><dd>Type: <a href="T_Vortex_Presentation_Wpf_ReportingLevel.md">Vortex.Presentation.Wpf.ReportingLevel</a><br />Reporting level.</dd><dt>maxObjectsInDesignMode (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.int32" target="_blank">System.Int32</a><br />Max number of object to be displayed in design mode.</dd><dt>cacheVisuals (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_blank">System.Boolean</a><br />When true indicates that created visuals will be cached when first time created. This value is set to 'true' by default.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a><br />Visual representation of given presentation type for given object

## See Also


#### Reference
<a href="T_Vortex_Presentation_Wpf_Renderer.md">Renderer Class</a><br /><a href="N_Vortex_Presentation_Wpf.md">Vortex.Presentation.Wpf Namespace</a><br />