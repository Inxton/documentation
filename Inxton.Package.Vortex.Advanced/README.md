![Inxton logo](/common/assets/logo.png)

# Inxton.Package.Vortex.Advanced

*Inxton.Package.Vortex.Advanced* extends [Inxton.Package.Vortex.Essentials](/Inxton.Package.Vortex.Essentials/README.md) with libraries for **PLC to .NET RPC, User Management, Diagnostics and Security.** .

[What is Remote Procedure Call (RPC)](https://searchapparchitecture.techtarget.com/definition/Remote-Procedure-Call-RPC)

This project is part of Inxton.Vortex.Framework. 


## What's inside *Inxton.Package.Vortex.Advanced* package

- **[Inxton.Vortex.Base](/apis/Inxton.Vortex.Base.Wpf/API/README.md)** - Base for PLC App, Components, Diagnostics, Messaging, Commands and Security
- **[Inxton.Vortex.Base.Wpf](/apis/Inxton.Vortex.Base.Wpf/README.md)** - Visual components for components mentioned above
- **[Inxton.Vortex.Security](/apis/Inxton.Vortex.Security/README.md)** - User management, roles - enable/disable parts of your app for specific users.
- **[Inxton.Vortex.Security.Wpf](/apis/Inxton.Vortex.Security.Wpf/README.md)**- Visual components for components mentioned above

# Getting started

## Check the prerequisites

Make sure you have everything you need to start using examples in this repository [here](https://github.com/Inxton/documentation/blob/master/PREREQUISITES.MD).

If you are not familiar with INXTON, make sure you understand the basics [Inxton.Package.Vortex.Core](https://github.com/Inxton/Examples-Inxton.Package.Vortex.Core/).

## Setup PLC
Create a function block which will extend from `VortexBase.fbVortexApp`. This will be the root of the application.
```
FUNCTION_BLOCK fbApp EXTENDS VortexBase.fbVortexApp 
```
It has to override method `Main`. This method is the cyclic root of the code.
`METHOD PROTECTED Main`

In your `PROGRAM` create an instance of the function block and run it with the AMS ID of your PLC.
```PASCAL
PROGRAM MAIN
VAR
	App :fbApp;
END_VAR
---
App.Run('851');
```

## Required NuGet packages

Make sure you install the following NuGet packages.

For TwinConnector project:

https://www.nuget.org/packages/Inxton.Package.Vortex.Advanced/
~~~ bash
Install-Package Inxton.Package.Vortex.Advanced
~~~

For your WPF application:

https://www.nuget.org/packages/Inxton.Package.Vortex.Advanced.Wpf/
~~~ bash
Install-Package Inxton.Package.Vortex.Advanced.Wpf
~~~

## Installing the license

Get your free developer license [here](/common/LicenseInstallation.md).

## How to invoke C# code from PLC

In your PLC project create an instance of `fbRemoteExec`
```pascal
FUNCTION_BLOCK fbApp EXTENDS VortexBase.fbVortexApp 
VAR
	CSharp : VortexBase.fbRemoteExec;
	Counter : INT;
END_VAR 
-------
Counter := Counter +1;
IF Counter > 100 THEN
  CSharp.Invoke();
END_IF
```
Run the Inxton builder.
In your C# Code
```csharp
private static fbApp MAIN;

static void Main(string[] args)
{
    Entry.Plc.Connector.BuildAndStart();
    MAIN = Entry.Plc.MAIN.App;
    MAIN.CSharp.Initialize(MethodToExecuteWhenInvokeIsCalledInPlc);
    Console.ReadKey();
}

private static bool MethodToExecuteWhenInvokeIsCalledInPlc()
{
    Console.WriteLine("Invoked from PLC");
    MAIN.Counter.Cyclic = 0;
    return true;
}
}
```
### Results

![inxton breakpoint plc project](Assets/invoked_from_plc.gif)

#### Breakpoint work too!
![inxton breakpoint plc project](Assets/breakpoint.gif)


## How to use diagnostics tools
** TODO **
## How to create a component
** TODO **
## How to protect your app from unauthorized user
** TODO **
## How to add user and roles
** TODO **

## New project template

When you are already familiar with the framework you can [clone](https://github.com/Inxton/template.advanced.git) or [download](https://github.com/Inxton/template.advanced/archive/master.zip) the [template.advanced](https://github.com/Inxton/template.advanced) project.

## What to do next?

Checkout documentation  [Inxton.Package.Vortex.Core](/Inxton.Package.Vortex.Advanced/README.md).

Install the extension from [Visual Studio Marketplace](https://marketplace.visualstudio.com/items?itemName=Inxton.InxtonVortexBuilderExtensionPre).

# Need help?

🧪 Create an issue [here](https://github.com/Inxton/Feedback/issues/new/choose)

📫 We use mail too team@inxton.com 

🐤 Contact us on Twitter [@Inxton](https://twitter.com/inxtonteam)

📽 Check out our [YouTube](https://www.youtube.com/channel/UCB3EcnWyLSsV5gqSt8PRDXA/featured)

🌐 For more info check out our website [INXTON.com](https://www.inxton.com/)


# Contributing

We are more than happy to hear your feedback, ideas!
Just submit it [here](https://github.com/Inxton/Feedback/issues/new/choose)  

---
Developed with ♥ at [MTS](https://www.mts.sk/en) - putting the heart into manufacturing.
