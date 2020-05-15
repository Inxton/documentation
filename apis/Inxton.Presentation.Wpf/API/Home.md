# Automated UI rendering


Following documentation describes automated visualisation rendering process for WPF applications.




Visualization rendering mechanism provides automated way of representing objects that are product of compilation process of Vortex.Builder. Vortex.Builder tran-spiles data declarations and structures of the PLC program into objects accessible in .net environment, shuch objects are called 'Twin's.


Each complex Twin type object emitted by the Vortex.Builder implements 'IVortexObject' interface and each base (value) type (or tag) Twin implements 'IValueTag' interface. Base types will be referred to as 'Value Tags' . Object implementing one of these two interfaces can be rendered by the 'Renderer'.


Multiple object can be rendered in hierarchal structure replicating the structure of Twin object. Additional layout attribute can direct the rendering process. An object of rendering process will be calle `Twin Visual`.



## Principle of operation

The `Renderer` class provides core functionality for rendering `Twin object's Visual`s. `Renderer` takes as parameters Twin object and desired type of representation. Renderer runs accross the structure of the Twin object, looking for an existing 'View' for given type of Twin object and required presentation type. When a 'View' for a Twin object is located respective 'View' is added to the Visual tree and recursion stops for that object, but continues at the same recursion level if any other objects are present. When there are no Views located for an object the Renderer will run the recusion to the Value Tag and represent it from the piking up a respective represantion from the base control library.


**stCounter**<br />
``` pascal
{attribute wpf [Container(Layout.Stack)]}
TYPE stCounter :
  STRUCT
          {attribute addProperty Name "Allow counting"}
          {attribute addProperty ToolTip "Allows the counter to increment value."}
          _doCount : BOOL;
          {attribute addProperty Name "Counter"}
          {attribute addProperty ToolTip "Counter value."}
          _counterValue : INT;        
          {attribute addProperty Name "Reset Counter"}
          {attribute addProperty ToolTip "Resets counter to 0"}
          _resetCounterValue : BOOL;
  END_STRUCT
END_TYPE
```

**Creates base presentation**<br />
``` C#
// Renders representation of MAIN._counter object from the PLC in read-only mode.
this.CounterDisplay.Content = Renderer.Get.CreatePresentation("Display", App.Plc.MAIN._counter);
```
<br />**stCounter is represented like this when there is no 'View' defined for 'Display' presentation type.**<br /><img alt="Render Couter No Custom View" src="media/RenderCouterNoCustomView.PNG" /><br />
**Creates manual presentation**<br />
``` C#
this.stCounterManual.Content = Renderer.Get.CreatePresentation("Manual", Entry.PresentationPlc.MAIN._counter);
```
<br />**stCounter is represented like this when there is 'View' defined for 'Manual' presentation type.**<br /><img alt="Rendered As Manual" src="media/RenderedAsManual.PNG" /><br />

#### Assemblies and Views and ViewModels

Renderer searches for the respective View/VieModel in assemblies that are present in the application directory. Assemblies are located automatically providing that:
&nbsp;<ul><li>
assembly of the running application (automatically included).</li><li>
assembly declares `RenderableAssemblyAttribute`.</li></ul>&nbsp;
&nbsp;<table><tr><th>![Tip](media/AlertNote.png) Tip</th></tr><tr><td>
Assemblies that do not meet above listed requirements can be added manually by calling `
                Renderer.Get.AttachAssemblyToLookUpList("assemblyName");
              `</td></tr></table>&nbsp;
&nbsp;<table><tr><th>![Note](media/AlertNote.png) Note</th></tr><tr><td>
The application assembly i searched for Views and ViewModel before searching other assembly. Any definition of matching View or ViewModel in the application assembly will override possible Views or ViewModels in other assemblies.</td></tr></table>&nbsp;
&nbsp;<table><tr><th>![Important](media/AlertCaution.png) Important</th></tr><tr><td>
Assembly must be located in the directory of the running application.</td></tr></table>

## Creating and customizing renderable controls

Visualisation rendering is based on a variant of Locator Pattern. The visual represnetation of an Twin object will be called 'View'. Twin object that is to be represented will be called 'Model'. 'ViewModel' will be called an object that encapsulated 'Model' object and additional interaction logic between 'View' and 'Model'.


Each View has a 'DataContex' object that can be either'Model' object (direct bining to representation of Twin object) or a 'ViewModel' that encapsulated Mode of Twin object.
&nbsp;<table><tr><th>![Note](media/AlertNote.png) Note</th></tr><tr><td>
When the 'ViewModel'is not defined the the 'DataContext' of the View will be the 'Model' that is respective 'IVortexObject' or 'IValueTag'.</td></tr></table>

#### View and ViewModel location

View and ViewModel for given type of object are located accoring to naming convention where the name of the View and ViewModel starts with the name of the obect type suffixed with `View` for Views and `ViewModel` for ViewModels. The View and ViewModel must be placed in the same namespace in which the type is located. In addition to that `View` and `ViewModel` can be prefixed with 'Presentation type' signature that will determine the type of the UI presentation that shall be rendered.


Object `stCounter` will be represented in its presentation form 'Base' by the View named `stCounterView` with ViewModel `stCounterViewModel` when the rendering is created by calling the renderer `Renderer.Get.CreatePresentation("Base")`.


**stCounterView.xaml**<br />
``` XAML
<!--NOTICE! The namespace must be the same as the namespace where the stCounter is declared
            x:Class= x:Class="PlcPresentationExamples.stCounterView"            
-->
<UserControl x:Class="PlcPresentationExamples.stCounterView"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
             xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
             xmlns:local="clr-namespace:PlcPresentationExamples"
             mc:Ignorable="d" 
             d:DesignHeight="450" d:DesignWidth="800">
    <UserControl.DataContext>
        <local:stCounterViewModel></local:stCounterViewModel>
    </UserControl.DataContext>
    <Grid>
        <StackPanel>
            <GroupBox Header="Counter value">
                <TextBlock Text="{Binding Component._counterValue.Cyclic}"></TextBlock>
            </GroupBox>
            <UniformGrid Rows="0" Columns="2">
                <Button Command="{Binding StartCountingCommand}">Start</Button>
                <Button Command="{Binding StopCountingCommand}">Stop</Button>
            </UniformGrid>
        </StackPanel>
    </Grid>
</UserControl>
```

**stCounterView.xaml.cs**<br />
``` C#
namespace PlcPresentationExamples
{
    using System;
    using System.Linq;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for stCounterView.xaml
    /// </summary>
    public partial class stCounterView : UserControl
    {
        public stCounterView()
        {
            InitializeComponent();
        }
    }
}
```

**stCounterViewMode.cs**<br />
``` C#
namespace PlcPresentationExamples
{
    using System;
    using System.Windows;
    using Vortex.Presentation.Wpf;

    public class stCounterViewModel : RenderableViewModel
    {        
        private void InitializeCommands()
        {
            StartCountingCommand = new RelayCommand(a => this.StartCounting(), c => !Component._doCount.Cyclic);
            StopCountingCommand = new RelayCommand(a => this.StopCounting(), c => Component._doCount.Cyclic);         
        }

        public stCounter Component { get; private set; } = new stCounter();
        public override object Model
        {
            get { return Component; }
            set { Component = (stCounter)value; InitializeCommands(); }
        }

        public RelayCommand StartCountingCommand { get; private set; }
        public RelayCommand StopCountingCommand { get; private set; }

        private void StartCounting()
        {
            var answer = MessageBox.Show("Would you like to start counter?", "Counter start", MessageBoxButton.YesNo);

            if(answer == MessageBoxResult.Yes)
            {
                this.Component._doCount.Synchron = true;
            }
        }

        private void StopCounting()
        {
            var answer = MessageBox.Show("Would you like to stop counter?", "Counter stop", MessageBoxButton.YesNo);

            if (answer == MessageBoxResult.Yes)
            {
                this.Component._doCount.Synchron = false;
            }
        }        
    }
}
```

**Creates base presentation**<br />
``` C#
this.stCounterBase.Content = Renderer.Get.CreatePresentation("Base", Entry.PresentationPlc.MAIN._counter);
```
<br />**Renderer will create following Base UI rapresentation of stCounter**<br /><img alt="Rendered As Base" src="media/RenderedAsBase.PNG" /><br />
Object `fbCounter` will be represented in its presentation form 'Manual' by the View named `fbCounterView` with ViewModel `fbCounterViewModel` when the rendering is created by calling the renderer `Renderer.Get.CreatePresentation("Manual")`.


**stCounterManualView.xaml**<br />
``` XAML
<UserControl x:Class="PlcPresentationExamples.stCounterManualView"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
             xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
             xmlns:local="clr-namespace:PlcPresentationExamples"
             mc:Ignorable="d" 
             d:DesignHeight="450" d:DesignWidth="800">
    <UserControl.DataContext>
        <local:stCounterViewModel></local:stCounterViewModel>
    </UserControl.DataContext>
    <Grid>
        <StackPanel>
            <GroupBox Header="Counter value">
                <TextBox Text="{Binding Component._counterValue.Cyclic}"></TextBox>
            </GroupBox>
            <UniformGrid Rows="0" Columns="2">
                <Button Command="{Binding StartCountingCommand}">Start</Button>
                <Button Command="{Binding StopCountingCommand}">Stop</Button>
            </UniformGrid>
            <Button Command="{Binding ResetCounterCommand}">Reset counter</Button>
        </StackPanel>
    </Grid>
</UserControl>
```

**stCounterManualView.xaml.cs**<br />
``` C#
namespace PlcPresentationExamples
{
    using System;
    using System.Linq;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for stCounterManualView.xaml
    /// </summary>
    public partial class stCounterManualView : UserControl
    {
        public stCounterManualView()
        {
            InitializeComponent();
        }
    }
}
```

**stCounterManualViewMode.cs**<br />
``` C#
namespace PlcPresentationExamples
{
    using System;
    using System.Windows;
    using Vortex.Presentation.Wpf;

    public class stCounterManualViewModel : RenderableViewModel
    {        
        private void InitializeCommands()
        {
            StartCountingCommand = new RelayCommand(a => this.StartCounting(), c => !Component._doCount.Cyclic);
            StopCountingCommand = new RelayCommand(a => this.StopCounting(), c => Component._doCount.Cyclic);
            ResetCounterCommand = new RelayCommand(a => this.ResetCounter(), c => !Component._doCount.Cyclic);
        }

        public stCounter Component { get; private set; } = new stCounter();
        public override object Model
        {
            get { return Component; }
            set { Component = (stCounter)value; InitializeCommands(); }
        }

        public RelayCommand StartCountingCommand { get; private set; }
        public RelayCommand StopCountingCommand { get; private set; }
        public RelayCommand ResetCounterCommand { get; private set; }
        private void StartCounting()
        {
            var answer = MessageBox.Show("Would you like to start counter?", "Counter start", MessageBoxButton.YesNo);

            if(answer == MessageBoxResult.Yes)
            {
                this.Component._doCount.Synchron = true;
            }
        }

        private void StopCounting()
        {
            var answer = MessageBox.Show("Would you like to stop counter?", "Counter stop", MessageBoxButton.YesNo);

            if (answer == MessageBoxResult.Yes)
            {
                this.Component._doCount.Synchron = false;
            }
        }
        private void ResetCounter()
        {            
            var answer = MessageBox.Show("Would you like to reset counter?", "Counter reset", MessageBoxButton.YesNo);

            if (answer == MessageBoxResult.Yes)
            {
                this.Component._resetCounterValue.Synchron = true;
            }
        }
    }
}
```

**Creates manual presentation**<br />
``` C#
this.stCounterManual.Content = Renderer.Get.CreatePresentation("Manual", Entry.PresentationPlc.MAIN._counter);
```
<br />**Renderer will create following Manual UI rapresentation of stCounter**<br /><img alt="Rendered As Manual" src="media/RenderedAsManual.PNG" /><br />

#### Pipelining

In some instances it is desirable to render different types of presentation when there is no View or ViewModel defined for some type of presentation. In that case the rednerer is called with the parameter presentation type containing different types of presentation separated by '-'. `Renderer.Get.CreatePresentation("Diagnostics-Manual")`. In this case is if the 'Diagnostic' type View and ViewModel are not defined the View/ViewModel of 'Manual' type is rendered.


**Creates manual presentation**<br />
``` C#
this.stCounterDiagnosticsManual.Content = Renderer.Get.CreatePresentation("Diagnostics-Manual", Entry.PresentationPlc.MAIN._counter);
```
<br />**Renderer will create following Manual UI rapresentation of stCounter. Diagnostics does not exists.**<br /><img alt="Render As Diagnostics Manual" src="media/RenderAsDiagnosticsManual.PNG" /><br />
**Creates manual presentation**<br />
``` C#
this.stCounterDiagnosticsBase.Content = Renderer.Get.CreatePresentation("Diagnostics-Base", Entry.PresentationPlc.MAIN._counter);
```
<br />**Renderer will create following Base UI rapresentation of stCounter. 'Diagnostics' does not exists.**<br /><img alt="Render As Diagnostics Base" src="media/RenderAsDiagnosticsBase.PNG" /><br />

#### Consuming defined Views and ViewModel

**stCounterManualView.xaml**<br />
``` XAML
<UserControl x:Class="PresentationWpfExamples.CustomizePresentations.fbCounter.CounterCustomizedView"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
             xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
             xmlns:local="clr-namespace:PresentationWpfExamples.CustomizePresentations.fbCounter"
             mc:Ignorable="d" 
             d:DesignHeight="450" d:DesignWidth="800">
    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"></RowDefinition>
            <RowDefinition Height="Auto"></RowDefinition>
        </Grid.RowDefinitions>
        <UniformGrid Grid.Row="0">
            <GroupBox Header="Rendered as 'Base'" x:Name="stCounterBase"/>
            <GroupBox Header="Rendered as 'Manual' " x:Name="stCounterManual"/>
        </UniformGrid>
        <GroupBox Header="Rendering with pipelines" Grid.Row="1">
            <UniformGrid>
                <GroupBox Header="Pipeline 'Diagnostics-Manual' rendered as 'Manual' (no view for 'Diagnostics')" x:Name="stCounterDiagnosticsManual"/>
                <GroupBox Header="Pipeline 'Diagnostics-Base' rendered as 'Base' (no view for 'Diagnostics')" x:Name="stCounterDiagnosticsBase"/>
            </UniformGrid>
        </GroupBox>
    </Grid>
</UserControl>
```

**stCounterManualView.xaml.cs**<br />
``` C#
namespace PresentationWpfExamples.CustomizePresentations.fbCounter
{
    using System;
    using System.Linq;
    using System.Windows.Controls;
    using Vortex.Presentation.Wpf;
    using PlcPresentationExamplesConnector;

    /// <summary>
    /// Interaction logic for CounterCustomizedView.xaml
    /// </summary>
    public partial class CounterCustomizedView : UserControl
    {
        public CounterCustomizedView()
        {
            InitializeComponent();

            #region RendererWithBaseType
            this.stCounterBase.Content = Renderer.Get.CreatePresentation("Base", Entry.PresentationPlc.MAIN._counter);
            #endregion

            #region RenderedWithManualType
            this.stCounterManual.Content = Renderer.Get.CreatePresentation("Manual", Entry.PresentationPlc.MAIN._counter);
            #endregion

            #region RenderedWithPipelineDiagnosticsManual
            this.stCounterDiagnosticsManual.Content = Renderer.Get.CreatePresentation("Diagnostics-Manual", Entry.PresentationPlc.MAIN._counter);
            #endregion

            #region RenderedWithPipelineDiagnosticsBase
            this.stCounterDiagnosticsBase.Content = Renderer.Get.CreatePresentation("Diagnostics-Base", Entry.PresentationPlc.MAIN._counter);
            #endregion            
        }
    }
}
```
<br />**UI Presentation from example above**<br /><img alt="Renderer Consuming Example" src="media/RendererConsumingExample.PNG" /><br />

## Controlling layout

Resulting visual layout can be controlled by placing layout attributes to the PLC types and variable declarations. Let's consider following code. fbStations contains two members _st01 and _st02. Notice that fbStation has attribute [Container(Layout.Tabs)] defined which means that all subsequent members will be placed in 'TabItems' of 'TabControl' until declaration of next container is found.


```
{attribute wpf [Container(Layout.Tabs)]}
FUNCTION_BLOCK fbStations
VAR
    _st01 : fbStation01;
    _st02 : fbStation02;
END_VAR
```

'fbStation01' has [Container(Layout.Stack)] defined. A stack panel will be created and placed on separate 'TabItem' in the 'TabControl' with header stored in addedProperty 'Name' in this case 'ST 01'. All following members will be placed on this stack panel until new container is hit. Next container in this case is Wrap panel [Container(Layout.Wrap)] declared on '_step' member. All subsequent members (_step and _stepDescription) are placed in the Wrap panel until next container is hit. Next layout attribute is declared on _dataMember which is [Container(Layout.Wrap)] of which parent container of this Stack panel of 'fbStation01' structure.


```
{attribute wpf [Container(Layout.Stack)]}
{attribute wpf [Group(Layout.Scroll)]}
{attribute addProperty Name "ST 01"}
FUNCTION_BLOCK fbStation01
VAR    
    {attribute wpf [Container(Layout.Wrap)]}
    {attribute addProperty Name "Step Number"}
    {attribute clr [ReadOnly()]}
    _step : INT;
    {attribute addProperty Name "Step description"}
    {attribute clr [ReadOnly()]}
    _stepDescription : STRING;
    {attribute wpf [Container(Layout.Wrap)]}    
    {attribute addProperty Name "Data"}
    _data : stStation01_Data;
    {attribute addProperty Name "Components"}
    _components : stStation01_Components;
END_VAR
```

```
{attribute wpf [Container(Layout.Stack)]}
TYPE stStation01_Data :
STRUCT
    {attribute addProperty Name "X Min"}
    DimXMin : REAL;    
    {attribute clr [ReadOnly()]}
    {attribute addProperty Name "X Measured"}
    DimXMeasured : REAL;    
    {attribute addProperty Name "X Max"}
    DimXMax : REAL;
    {attribute addProperty Name "Result"}
    Result : STRING;
END_STRUCT
END_TYPE
```

```
{attribute wpf [Container(Layout.Stack)]}
TYPE stStation01_Components :
STRUCT
    {attribute addProperty Name "Sensor X"}
    SensorX : REAL;

    {attribute wpf [Container(Layout.Wrap)]}
    {attribute addProperty Name "Upper piston sensor"}
    PistonUpPosition AT %I* : BOOL;
    {attribute addProperty Name "Bottom piston sensor"}
    PistonDownPosition AT %I* : BOOL;

    {attribute wpf [Container(Layout.Wrap)]}
    {attribute addProperty Name "Move up piston singal"}
    MovePistonUp AT %Q* : BOOL;
    {attribute addProperty Name "Move down piston singal"}
    MovePistonDown AT %Q* : BOOL;
END_STRUCT
END_TYPE
```

**stCounterManualView.xaml.cs**<br />
``` C#
<UserControl x:Class="PresentationWpfExamples.fbStations.Generic.StationsGenerated"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
             xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
             xmlns:local="clr-namespace:PresentationWpfExamples.fbStations.Generic"
             xmlns:app="clr-namespace:PresentationWpfExamples"
             xmlns:v="http://vortex.mts/xaml"
             mc:Ignorable="d"
             DataContext="{x:Static app:App.Plc}"
             d:DesignHeight="450" d:DesignWidth="800">
    <Grid>
        <v:RenderableContentControl DataContext="{Binding MAIN._stations}" PresentationType="Control"></v:RenderableContentControl>    
    </Grid>
</UserControl>
```
<br />**UI Presentation from example above**<br /><img alt="ST 01 RENDERING EXAMPLE" src="media/ST01_RENDERING_EXAMPLE.PNG" /><br /><br />**UI Presentation from example above**<br /><img alt="rendering chart" src="media/rendering_chart.png" /><br />