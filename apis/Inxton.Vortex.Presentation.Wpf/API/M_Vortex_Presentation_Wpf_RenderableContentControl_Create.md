# RenderableContentControl.Create Method 
 

Create representation of an object according the PresentationType

**Namespace:**&nbsp;<a href="N_Vortex_Presentation_Wpf.md">Vortex.Presentation.Wpf</a><br />**Assembly:**&nbsp;Vortex.Presentation.Wpf (in Vortex.Presentation.Wpf.dll) Version: 1.3.21+Branch.tags/v1.3.21.Sha.d2d012c69d12da922e6e4a18ad43e5435cbba0f0

## Syntax

**C#**<br />
``` C#
public static RenderableContentControl Create(
	IVortexObject obj,
	string presentationType
)
```


#### Parameters
&nbsp;<dl><dt>obj</dt><dd>Type: IVortexObject<br />IVortexObject to be rendered.</dd><dt>presentationType</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_blank">System.String</a><br />Presentation type (e.g. 'Display', 'Control')</dd></dl>

#### Return Value
Type: <a href="T_Vortex_Presentation_Wpf_RenderableContentControl.md">RenderableContentControl</a><br />Rendered presentation of given object.

## Examples

**XAML**<br />
``` XAML
<UserControl x:Class="PresentationWpfExamples.CB.RenderableContentControlExample.AutoRenderingViewCodeBehind"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
             xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
             xmlns:local="clr-namespace:PresentationWpfExamples.CB.RenderableContentControlExample"
             xmlns:app="clr-namespace:PresentationWpfExamples"
             mc:Ignorable="d" 
             d:DesignHeight="450" d:DesignWidth="800"
             DataContext="{x:Static app:App.Plc}">
    <UniformGrid>
        <GroupBox Header="Control-CanChange-Values" x:Name="CounterControl"></GroupBox>
        <GroupBox Header="Display-CannotChange-Values" x:Name="CounterDisplay"></GroupBox>
    </UniformGrid>
</UserControl>
```

**C#**<br />
``` C#
using System;
using System.Linq;
using System.Windows.Controls;
namespace PresentationWpfExamples.CB.RenderableContentControlExample
{
    using Vortex.Presentation.Wpf;

    /// <summary>
    /// Interaction logic for AutoRenderingViewCodeBehind.xaml
    /// </summary>
    public partial class AutoRenderingViewCodeBehind : UserControl
    {
        public AutoRenderingViewCodeBehind()
        {
            InitializeComponent();

            #region CodeBehindRenderingDisplay
            // Renders representation of MAIN._counter object from the PLC in read-only mode.
            this.CounterDisplay.Content = Renderer.Get.CreatePresentation("Display", App.Plc.MAIN._counter);
            #endregion

            #region CodeBehindRenderingControl
            // Renders representation of MAIN._counter object from the PLC in read/write mode.
            this.CounterControl.Content = Renderer.Get.CreatePresentation("Control", App.Plc.MAIN._counter);
            #endregion
        }
    }
}
```


## See Also


#### Reference
<a href="T_Vortex_Presentation_Wpf_RenderableContentControl.md">RenderableContentControl Class</a><br /><a href="N_Vortex_Presentation_Wpf.md">Vortex.Presentation.Wpf Namespace</a><br /><a href="T_Vortex_Presentation_Wpf_RenderableViewModel.md">Vortex.Presentation.Wpf.RenderableViewModel</a><br /><a href="T_Vortex_Presentation_Wpf_RenderContentConverter.md">Vortex.Presentation.Wpf.RenderContentConverter</a><br /><a href="T_Vortex_Presentation_Wpf_Renderer.md">Vortex.Presentation.Wpf.Renderer</a><br />