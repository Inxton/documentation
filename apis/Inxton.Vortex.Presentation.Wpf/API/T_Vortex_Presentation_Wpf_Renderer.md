# Renderer ClassRenderer renders representation for object that derive IVortexObject or IValueTag


## Inheritance Hierarchy
<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;Vortex.Presentation.Wpf.Renderer<br />
**Namespace:**&nbsp;<a href="N_Vortex_Presentation_Wpf.md">Vortex.Presentation.Wpf</a><br />**Assembly:**&nbsp;Vortex.Presentation.Wpf (in Vortex.Presentation.Wpf.dll) Version: 1.1.2+Branch.master.Sha.e10390af75ec466990c3a0e7b7d3595bd05fe7b8

## Syntax

**C#**<br />
``` C#
public class Renderer
```

The Renderer type exposes the following members.


## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Static member](media/static.gif "Static member")</td><td><a href="P_Vortex_Presentation_Wpf_Renderer_Get.md">Get</a></td><td>
Gets singleton instance of Renderer</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Presentation_Wpf_Renderer_ReportingSeverity.md">ReportingSeverity</a></td><td>
Gets or sets <a href="T_Vortex_Presentation_Wpf_ReportingLevel.md">ReportingLevel</a> that displays messages and errors that might occur during the rendering process.</td></tr></table>&nbsp;
<a href="#renderer-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Presentation_Wpf_Renderer_AttachAllAppDomainAssemblies.md">AttachAllAppDomainAssemblies</a></td><td>
Loads all assemblies from the application domain of currently running application.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Presentation_Wpf_Renderer_AttachAllReferencedAssemblies.md">AttachAllReferencedAssemblies</a></td><td>
Loads all assemblies from current application directory that have defined <a href="T_Vortex_Presentation_Wpf_RenderableAssemblyAttribute.md">RenderableAssemblyAttribute</a>. These assemblies are then search for corresponding Views and ViewModel.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Presentation_Wpf_Renderer_AttachAssemblyToLookUpList.md">AttachAssemblyToLookUpList</a></td><td>
Attaches the assembly with given assembly name to the list of assemblies that are being searched for Views and ViewModels.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Presentation_Wpf_Renderer_CreatePresentation.md">CreatePresentation</a></td><td>
Creates presentation of IVortexObject or IValueTag of given presentation type.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/bsc2ak47" target="_blank">Equals</a></td><td>
Determines whether the specified object is equal to the current object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/4k87zsw7" target="_blank">Finalize</a></td><td>
Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Presentation_Wpf_Renderer_GetEnumeratorDiscriminatorAttribute.md">GetEnumeratorDiscriminatorAttribute</a></td><td>
Returns Enumerator description attribute for given member.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/zdee4b3y" target="_blank">GetHashCode</a></td><td>
Serves as the default hash function.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Presentation_Wpf_Renderer_GetPropertyViaSymbol.md">GetPropertyViaSymbol</a></td><td>
Locates property of IVortexObject via its symbol.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Presentation_Wpf_Renderer_GetReferencedAssemblies.md">GetReferencedAssemblies</a></td><td>
Returns lookup assemblies.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/dfwy45w9" target="_blank">GetType</a></td><td>
Gets the <a href="http://msdn2.microsoft.com/en-us/library/42892f65" target="_blank">Type</a> of the current instance.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Presentation_Wpf_Renderer_GetView.md">GetView</a></td><td>
Gets the view of given presentation type for given object type.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Presentation_Wpf_Renderer_GetViewModel.md">GetViewModel</a></td><td>
Gets the view model for given object type and given presentation type.</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/57ctke0a" target="_blank">MemberwiseClone</a></td><td>
Creates a shallow copy of the current <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/7bxwbwt2" target="_blank">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr></table>&nbsp;
<a href="#renderer-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Vortex_Presentation_Wpf.md">Vortex.Presentation.Wpf Namespace</a><br />

#### Other Resources
[f89438a0-b071-411f-9c91-3061a8156633]<br />