# RenderContentConverter.Convert Method 
 

Converts an object that derives form IVortexObject or IValueTag into UI representation following 'PresentationType' pipeline.

**Namespace:**&nbsp;<a href="N_Vortex_Presentation_Wpf.md">Vortex.Presentation.Wpf</a><br />**Assembly:**&nbsp;Vortex.Presentation.Wpf (in Vortex.Presentation.Wpf.dll) Version: 1.1.2+Branch.master.Sha.e10390af75ec466990c3a0e7b7d3595bd05fe7b8

## Syntax

**C#**<br />
``` C#
public virtual Object Convert(
	Object value,
	Type targetType,
	Object parameter,
	CultureInfo culture
)
```


#### Parameters
&nbsp;<dl><dt>value</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />object IVortexObject or IValueTag</dd><dt>targetType</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/42892f65" target="_blank">System.Type</a><br />Target type</dd><dt>parameter</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />Presentation type</dd><dt>culture</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/kx54z3k7" target="_blank">System.Globalization.CultureInfo</a><br />Culture</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a><br /><a href="http://msdn2.microsoft.com/en-us/library/ms602714" target="_blank">FrameworkElement</a>

#### Implements
<a href="http://msdn2.microsoft.com/en-us/library/ms590771" target="_blank">IValueConverter.Convert(Object, Type, Object, CultureInfo)</a><br />

## See Also


#### Reference
<a href="T_Vortex_Presentation_Wpf_RenderContentConverter.md">RenderContentConverter Class</a><br /><a href="N_Vortex_Presentation_Wpf.md">Vortex.Presentation.Wpf Namespace</a><br />