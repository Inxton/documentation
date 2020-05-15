# RenderContentConverter Class
 _**\[This is preliminary documentation and is subject to change.\]**_

Value Converter provides rendering of [!:Twin] objects implementing IVortexObject or IValueTag.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">System.Object</a><br />&nbsp;&nbsp;<a href="https://docs.microsoft.com/dotnet/api/system.windows.markup.markupextension" target="_blank">System.Windows.Markup.MarkupExtension</a><br />&nbsp;&nbsp;&nbsp;&nbsp;Vortex.Presentation.Wpf.RenderContentConverter<br />
**Namespace:**&nbsp;<a href="N_Vortex_Presentation_Wpf.md">Vortex.Presentation.Wpf</a><br />**Assembly:**&nbsp;Vortex.Presentation.Wpf (in Vortex.Presentation.Wpf.dll) Version: 0.112.0-alpha.12+Branch.develop.Sha.df20d7449a44daab5691c666370b08ce38564334

## Syntax

**C#**<br />
``` C#
public class RenderContentConverter : MarkupExtension, 
	IValueConverter
```

The RenderContentConverter type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Presentation_Wpf_RenderContentConverter__ctor.md">RenderContentConverter</a></td><td>
Initializes a new instance of the RenderContentConverter class</td></tr></table>&nbsp;
<a href="#rendercontentconverter-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Presentation_Wpf_RenderContentConverter_MaxCountInDesignMode.md">MaxCountInDesignMode</a></td><td>
Gets or sets maximum number of object rendered in Design mode.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Presentation_Wpf_RenderContentConverter_ParentContainer.md">ParentContainer</a></td><td>
Gets or sets the parent container for the content rendered by this converter.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Presentation_Wpf_RenderContentConverter_PreferCustomized.md">PreferCustomized</a></td><td /></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Presentation_Wpf_RenderContentConverter_PresentationType.md">PresentationType</a></td><td>
Gets or sets presentation type of the content rendered by this converter.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Presentation_Wpf_RenderContentConverter_ReportingLevel.md">ReportingLevel</a></td><td>
Gets or sets reporting level of possible messages or errors that might be produced by the rendering process.</td></tr></table>&nbsp;
<a href="#rendercontentconverter-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Presentation_Wpf_RenderContentConverter_Convert.md">Convert</a></td><td>
Converts an object that derives form IVortexObject or IValueTag into UI representation following 'PresentationType' pipeline.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Presentation_Wpf_RenderContentConverter_ConvertBack.md">ConvertBack</a></td><td>
Not implemented for RenderContentConverter</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.object.equals#System_Object_Equals_System_Object_" target="_blank">Equals</a></td><td>
Determines whether the specified object is equal to the current object.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.object.finalize#System_Object_Finalize" target="_blank">Finalize</a></td><td>
Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.object.gethashcode#System_Object_GetHashCode" target="_blank">GetHashCode</a></td><td>
Serves as the default hash function.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.object.gettype#System_Object_GetType" target="_blank">GetType</a></td><td>
Gets the <a href="https://docs.microsoft.com/dotnet/api/system.type" target="_blank">Type</a> of the current instance.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.object.memberwiseclone#System_Object_MemberwiseClone" target="_blank">MemberwiseClone</a></td><td>
Creates a shallow copy of the current <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Presentation_Wpf_RenderContentConverter_ProvideValue.md">ProvideValue</a></td><td>
Provides instance of this RenderContentConverter
 (Overrides <a href="https://docs.microsoft.com/dotnet/api/system.windows.markup.markupextension.providevalue#System_Windows_Markup_MarkupExtension_ProvideValue_System_IServiceProvider_" target="_blank">MarkupExtension.ProvideValue(IServiceProvider)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.object.tostring#System_Object_ToString" target="_blank">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.)</td></tr></table>&nbsp;
<a href="#rendercontentconverter-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Vortex_Presentation_Wpf.md">Vortex.Presentation.Wpf Namespace</a><br />