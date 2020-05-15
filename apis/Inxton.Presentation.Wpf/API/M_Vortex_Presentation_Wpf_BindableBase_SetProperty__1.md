# BindableBase.SetProperty(*T*) Method 
 _**\[This is preliminary documentation and is subject to change.\]**_

Sets the property and raises <a href="https://docs.microsoft.com/dotnet/api/system.componentmodel.inotifypropertychanged.propertychanged" target="_blank">PropertyChanged</a> event.

**Namespace:**&nbsp;<a href="N_Vortex_Presentation_Wpf.md">Vortex.Presentation.Wpf</a><br />**Assembly:**&nbsp;Vortex.Presentation.Wpf (in Vortex.Presentation.Wpf.dll) Version: 0.112.0-alpha.12+Branch.develop.Sha.df20d7449a44daab5691c666370b08ce38564334

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
&nbsp;<dl><dt>member</dt><dd>Type: *T*<br />Member</dd><dt>val</dt><dd>Type: *T*<br />New value</dd><dt>propertyName (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_blank">System.String</a><br />Property name</dd></dl>

#### Type Parameters
&nbsp;<dl><dt>T</dt><dd>Property type.</dd></dl>

## See Also


#### Reference
<a href="T_Vortex_Presentation_Wpf_BindableBase.md">BindableBase Class</a><br /><a href="N_Vortex_Presentation_Wpf.md">Vortex.Presentation.Wpf Namespace</a><br />