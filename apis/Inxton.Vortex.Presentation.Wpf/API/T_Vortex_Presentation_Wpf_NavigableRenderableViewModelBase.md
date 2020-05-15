# NavigableRenderableViewModelBase Class
 _**\[This is preliminary documentation and is subject to change.\]**_

\[Missing <summary> documentation for "T:Vortex.Presentation.Wpf.NavigableRenderableViewModelBase"\]


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">System.Object</a><br />&nbsp;&nbsp;<a href="T_Vortex_Presentation_Wpf_BindableBase.md">Vortex.Presentation.Wpf.BindableBase</a><br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Vortex_Presentation_Wpf_RenderableViewModel.md">Vortex.Presentation.Wpf.RenderableViewModel</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Vortex.Presentation.Wpf.NavigableRenderableViewModelBase<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Vortex_Presentation_Wpf_MenuRenderableControlViewModel.md">Vortex.Presentation.Wpf.MenuRenderableControlViewModel</a><br />
**Namespace:**&nbsp;<a href="N_Vortex_Presentation_Wpf.md">Vortex.Presentation.Wpf</a><br />**Assembly:**&nbsp;Vortex.Presentation.Wpf (in Vortex.Presentation.Wpf.dll) Version: 0.112.0-alpha.12+Branch.develop.Sha.df20d7449a44daab5691c666370b08ce38564334

## Syntax

**C#**<br />
``` C#
public abstract class NavigableRenderableViewModelBase : RenderableViewModel, 
	INavigable
```

The NavigableRenderableViewModelBase type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Presentation_Wpf_NavigableRenderableViewModelBase__ctor.md">NavigableRenderableViewModelBase</a></td><td>
Initializes a new instance of the NavigableRenderableViewModelBase class</td></tr></table>&nbsp;
<a href="#navigablerenderableviewmodelbase-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Presentation_Wpf_NavigableRenderableViewModelBase_ContentPresentationMode.md">ContentPresentationMode</a></td><td /></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Presentation_Wpf_NavigableRenderableViewModelBase_CurrentView.md">CurrentView</a></td><td /></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Presentation_Wpf_NavigableRenderableViewModelBase_MenuVisibility.md">MenuVisibility</a></td><td /></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Presentation_Wpf_RenderableViewModel_Model.md">Model</a></td><td>
Gets or sets model object for this ViewModel type.
 (Inherited from <a href="T_Vortex_Presentation_Wpf_RenderableViewModel.md">RenderableViewModel</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Presentation_Wpf_NavigableRenderableViewModelBase_NavCommands.md">NavCommands</a></td><td /></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Presentation_Wpf_NavigableRenderableViewModelBase_Title.md">Title</a></td><td /></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Presentation_Wpf_NavigableRenderableViewModelBase_ToggleMenuCommand.md">ToggleMenuCommand</a></td><td /></tr></table>&nbsp;
<a href="#navigablerenderableviewmodelbase-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Presentation_Wpf_NavigableRenderableViewModelBase_AddCommand.md">AddCommand</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.object.equals#System_Object_Equals_System_Object_" target="_blank">Equals</a></td><td>
Determines whether the specified object is equal to the current object.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.object.finalize#System_Object_Finalize" target="_blank">Finalize</a></td><td>
Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.object.gethashcode#System_Object_GetHashCode" target="_blank">GetHashCode</a></td><td>
Serves as the default hash function.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.object.gettype#System_Object_GetType" target="_blank">GetType</a></td><td>
Gets the <a href="https://docs.microsoft.com/dotnet/api/system.type" target="_blank">Type</a> of the current instance.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.object.memberwiseclone#System_Object_MemberwiseClone" target="_blank">MemberwiseClone</a></td><td>
Creates a shallow copy of the current <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_Vortex_Presentation_Wpf_BindableBase_OnPropertyChanged.md">OnPropertyChanged</a></td><td>
Raises <a href="https://docs.microsoft.com/dotnet/api/system.componentmodel.inotifypropertychanged.propertychanged" target="_blank">PropertyChanged</a> event.
 (Inherited from <a href="T_Vortex_Presentation_Wpf_BindableBase.md">BindableBase</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Presentation_Wpf_NavigableRenderableViewModelBase_OpenCommand.md">OpenCommand</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Presentation_Wpf_NavigableRenderableViewModelBase_OpenDefault.md">OpenDefault</a></td><td /></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_Vortex_Presentation_Wpf_BindableBase_SetProperty__1.md">SetProperty(T)</a></td><td>
Sets the property and raises <a href="https://docs.microsoft.com/dotnet/api/system.componentmodel.inotifypropertychanged.propertychanged" target="_blank">PropertyChanged</a> event.
 (Inherited from <a href="T_Vortex_Presentation_Wpf_BindableBase.md">BindableBase</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_Vortex_Presentation_Wpf_NavigableRenderableViewModelBase_ToggleMenu.md">ToggleMenu</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.object.tostring#System_Object_ToString" target="_blank">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.)</td></tr></table>&nbsp;
<a href="#navigablerenderableviewmodelbase-class">Back to Top</a>

## Events
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td><a href="E_Vortex_Presentation_Wpf_BindableBase_PropertyChanged.md">PropertyChanged</a></td><td>
Implementation of <a href="https://docs.microsoft.com/dotnet/api/system.componentmodel.inotifypropertychanged.propertychanged" target="_blank">PropertyChanged</a>
 (Inherited from <a href="T_Vortex_Presentation_Wpf_BindableBase.md">BindableBase</a>.)</td></tr></table>&nbsp;
<a href="#navigablerenderableviewmodelbase-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Vortex_Presentation_Wpf.md">Vortex.Presentation.Wpf Namespace</a><br />