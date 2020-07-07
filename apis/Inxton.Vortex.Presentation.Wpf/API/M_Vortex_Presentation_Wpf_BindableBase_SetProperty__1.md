# BindableBase.SetProperty(*T*) Method 
 

Sets the property and raises <a href="http://msdn2.microsoft.com/en-us/library/ms133023" target="_blank">PropertyChanged</a> event.

**Namespace:**&nbsp;<a href="N_Vortex_Presentation_Wpf.md">Vortex.Presentation.Wpf</a><br />**Assembly:**&nbsp;Vortex.Presentation.Wpf (in Vortex.Presentation.Wpf.dll) Version: 1.1.2+Branch.master.Sha.e10390af75ec466990c3a0e7b7d3595bd05fe7b8

## Syntax

**C#**<br />
``` C#
protected virtual void SetProperty<T>(
	ref T member,
	T val,
	string propertyName = null
)

```


#### Parameters
&nbsp;<dl><dt>member</dt><dd>Type: *T*<br />Member</dd><dt>val</dt><dd>Type: *T*<br />New value</dd><dt>propertyName (Optional)</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />Property name</dd></dl>

#### Type Parameters
&nbsp;<dl><dt>T</dt><dd>Property type.</dd></dl>

## See Also


#### Reference
<a href="T_Vortex_Presentation_Wpf_BindableBase.md">BindableBase Class</a><br /><a href="N_Vortex_Presentation_Wpf.md">Vortex.Presentation.Wpf Namespace</a><br />