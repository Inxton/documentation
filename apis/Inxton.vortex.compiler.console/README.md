# Inxton.vortex.compiler.console

Inxton.vortex.compiler.console(compiler) is a Command line interface (CLI) implementation of Inxton.Vortex.Compiler that trans-piles TwinCat 3 PLC's program data into C# classes making the PLC's data accessible to .net environment in a structured way.

## Compiler

### Compiler's output project **ConnectorProject**

Connector project is a C# library project that contains the mirror (twin) representation of the PLC.

Compiler outputs C# source code which is located in the solution folder '_Vortex/out/[PlcProjectName]/src/singles/'. The content of this folder is then linked to the project in your solution that follows this naming convention: **[PlcProjectName]Connector**. For example if your PLC project is named 'MyPlc' then the connector project must be named 'MyPlcConnector'.

### Type of emitted objects

Compiled entities are called [*Twins*](Conceptual/Twins.md). There are three main groups of twin entities:

* [**Twin Controller**](Conceptual/TwinController.md) represents mirror of PLC controller and it is the root entry point for all twin objects. The name of TwinController class is '[PlcProjectName]TwinController'.

* [**Twin Object**](Conceptual/TwinObjects.md) represent a twin of a complex PLC type (STRUCT, FB, PRG, GVL, ENUM, UNION). The representation type of TwinObject is simply BlockName.

* [**Twin Primitive**](../Inxton.Vortex.Connector/Conceptual/PrimitiveTwins.md) represents twin of a base/elementary PLC type (BOOL, BYTE, WORD, DWORD, INT, TIME, ..., DATE, DATE_TIME, ..., STRING, WSTRING etc) [more].


## Getting more from the compiler

* [Attributes](Conceptual/Attributes.md) to enhance the capabilities twin objects.
* [Added Properties](Conceptual/AddedProperties.md) to add properties to C# classes directly from PLC code.

## Troubleshooting compiler

* [Ignoring unknown syntax constructions](Conceptual/IgnoringPartsOfCode.md)
* [Fake attribute commenting](Conceptual/FakeComments.md)



## Getting started

The best way to get started with the compiler is to use examples form [Inxton.Package.Vortex.Core](../Inxton.Package.Vortex.Core/README.MD).

### Pre-requisites check [here](../PREREQUISITES.MD) please

### First project

1. Open Visual Studio
1. Create new **TwinCAT Project** (name it e.g. XAE)
1. Create new **TwinCAT PLC project** in TwinCAT project under **PLC** branch (name it e.g MainPlc)
1. Create new C# library project (.net framework 4.8) and name it {PlcProjectName}Connector (e.g. MainPlcConnector).
1. Add NuGet package Inxton.Vortex.Core to newly created C# library project. (this package contains the compiler and supporting libraries) [nuget](https://www.nuget.org/packages/Inxton.Packages.Vortex.Core).

   ~~~ PowerShell
       PM> Install-Package Inxton.Packages.Vortex.Core
   ~~~

The solution is ready at this point.

Now there are two options to run the compiler:

#### Visual Studio Extension
Inxton provides Visual Studio extension so builder is every time just one click away.
You can download Visual Studio Extension directly from [Visual Studio marketplace](https://marketplace.visualstudio.com/items?itemName=Inxton.InxtonVortexBuilderExtensionPre).

##### To install extension follow easy step by step video turorial below. 
[![Video instruction here](https://img.youtube.com/vi/seL77D0eykI/0.jpg)](https://www.youtube.com/watch?v=seL77D0eykI&feature=youtu.be "Run builder.")

Or follow few easy installation steps [here](../ExtensionInstalation.md).


#### Command line interface (CLI)

CLI can be used as an alternative. Run the compiler from the '_Vortex' folder in the solution folder. The '_Vortex' folder will be created when the *Inxton.Package.Vortex.Core* is installed.
Follwing lines of code have to be executed either in Windows command line or Powershell.

**Command line:**
~~~ CMD
C:> CD C:\[YourSolutionFolder]\_Vortex\
C:\[YourSolutionFolder]\_Vortex> builder\vortex.compiler.console.exe
~~~

**Powershel:**
~~~ PowerShell
PS C:\[YourSolutionFolder]\_Vortex>
PS C:\[YourSolutionFolder]\_Vortex> .\builder\vortex.compiler.console.exe
~~~


><strong style="color:orange">NOTE</strong>: <span style="color:orange">
Compiler collects strings from the PLC program that can be later localized. 
This feature is available and will be documented soon. 
At this point localization file needs to be modified inside PlcConnector project at location Properties/Localizations.resx. 
Setting has to be performed only once in newly created project.
Please keep in mind that following is applicable only to .net framework project.</span>

<p><strong style="color:orange">Please follow these simple steps:</strong>
<ol style="color:orange">
<li>Open Localizations.resx within Visual Studio.</li>
<li>Set *'Access modifier'* in the upper part of the editor to *'internal'*.</li>
</ol></p>

<p style="color:orange">Resources for localization will be generated as a result.</p>

<strong style="color:orange">Or follow simple video guide:</strong>

[![Video instruction here](https://img.youtube.com/vi/K02ic222EE4/0.jpg)](https://www.youtube.com/watch?v=K02ic222EE4&feature=youtu.be "Video Title")

### How to access TwinController

You can reference Connector project in any .net framework v4.8 project. Here is an example how to create an instance of TwinController and how to access variable.

~~~ C#
// Creates an adapter for connecting to TwinCat 3 PLC with AMS ID '172.20.10.102.1.1' and port '851'
var adapter = Vortex.Adapters.Connector.Tc3.Adapter.Tc3ConnectorAdapter.Create("172.20.10.102.1.1", 851);

// Creates an instance of TwinController for 'Plc' project
var plc = new Plc.PlcTwinController();

// Starts operations with the TwinController.
plc.Connector.BuildAndStart();

// Accessing '_counter' variable from PRG 'MAIN'.
var counter = plc.MAIN._counter;

Console.WriteLine($"{counter.Symbol}: '{counter.Cyclic}'");
~~~
