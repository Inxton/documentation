# RenderContentConverter Class
 

Value Converter provides rendering of [!:Twin] objects implementing IVortexObject or IValueTag.


## Inheritance Hierarchy
<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;<a href="http://msdn2.microsoft.com/en-us/library/ms618227" target="_blank">System.Windows.Markup.MarkupExtension</a><br />&nbsp;&nbsp;&nbsp;&nbsp;Vortex.Presentation.Wpf.RenderContentConverter<br />
**Namespace:**&nbsp;<a href="N_Vortex_Presentation_Wpf.md">Vortex.Presentation.Wpf</a><br />**Assembly:**&nbsp;Vortex.Presentation.Wpf (in Vortex.Presentation.Wpf.dll) Version: 1.1.2+Branch.master.Sha.e10390af75ec466990c3a0e7b7d3595bd05fe7b8

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
Not implemented for RenderContentConverter</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/bsc2ak47" target="_blank">Equals</a></td><td>
Determines whether the specified object is equal to the current object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/4k87zsw7" target="_blank">Finalize</a></td><td>
Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/zdee4b3y" target="_blank">GetHashCode</a></td><td>
Serves as the default hash function.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/dfwy45w9" target="_blank">GetType</a></td><td>
Gets the <a href="http://msdn2.microsoft.com/en-us/library/42892f65" target="_blank">Type</a> of the current instance.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/57ctke0a" target="_blank">MemberwiseClone</a></td><td>
Creates a shallow copy of the current <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Presentation_Wpf_RenderContentConverter_ProvideValue.md">ProvideValue</a></td><td>
Provides instance of this RenderContentConverter
 (Overrides <a href="http://msdn2.microsoft.com/en-us/library/ms590291" target="_blank">MarkupExtension.ProvideValue(IServiceProvider)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/7bxwbwt2" target="_blank">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr></table>&nbsp;
<a href="#rendercontentconverter-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Vortex_Presentation_Wpf.md">Vortex.Presentation.Wpf Namespace</a><br />