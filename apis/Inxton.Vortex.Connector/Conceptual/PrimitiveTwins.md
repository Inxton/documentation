# Primitive Twins

Each elementary/primitive/base type is represented by a twin wrapper object that are summarily called **Onliners**. Onliners allow for direct access to the PLC variable via __Cyclic__ (variable is read or written cyclically in specific time periods) or __Synchron__ (the variable is read or written synchronously). There is also an off line value holder exposed via __Shadow__ member (allows for manipulation and batch read and write of entire structures).

| PLC Type      | Twin Wrapper Onliner type |
|---------------|:-------------:|
| BOOL          |  [OnlinerBool Class](../API/T_Vortex_Connector_ValueTypes_OnlinerBool.md) |  
| BYTE          |  [OnlinerByte Class](../API/T_Vortex_Connector_ValueTypes_OnlinerByte.md) |  
| WORD          |  [OnlinerWord Class](../API/T_Vortex_Connector_ValueTypes_OnlinerWord.md)|
| DWORD         |  [OnlinerDWord Class](../API/T_Vortex_Connector_ValueTypes_OnlinerDWord.md)|
| LWORD         |  [OnlinerLWord Class](../API/T_Vortex_Connector_ValueTypes_OnlinerLWord.md) |
| SINT          |  [OnlinerSInt Class](../API/T_Vortex_Connector_ValueTypes_OnlinerSInt.md) |
| INT          |  [OnlinerInt Class](../API/T_Vortex_Connector_ValueTypes_OnlinerInt.md) |
| DINT          |  [OnlinerDInt Class](../API/T_Vortex_Connector_ValueTypes_OnlinerDInt.md) |
| LINT          | [OnlinerLInt Class](../API/T_Vortex_Connector_ValueTypes_OnlinerLInt.md) |
| USINT          |  [OnlinerUSInt Class](../API/T_Vortex_Connector_ValueTypes_OnlinerUSInt.md) |
| UINT          |  [OnlinerUInt Class](../API/T_Vortex_Connector_ValueTypes_OnlinerUInt.md) |
| UDINT          | [OnlinerUDInt Class](../API/T_Vortex_Connector_ValueTypes_OnlinerUDInt.md) |
| ULINT          |  [OnlinerULInt Class](../API/T_Vortex_Connector_ValueTypes_OnlinerULInt.md) |
| REAL          |  [OnlinerReal Class](../API/T_Vortex_Connector_ValueTypes_OnlinerReal.md) |
| LREAL          |  [OnlinerLReal Class](../API/T_Vortex_Connector_ValueTypes_OnlinerLReal.md) |
| TIME          | [OnlinerTime Class](../API/T_Vortex_Connector_ValueTypes_OnlinerTime.md) |
| LTIME          |  [OnlinerLTime Class](../API/T_Vortex_Connector_ValueTypes_OnlinerLTime.md) |
| DATE          |  [OnlinerDate Class](../API/T_Vortex_Connector_ValueTypes_OnlinerDate.md) |
| TIME_OF_DAY / TOD    |       [OnlinerTimeOfDay Class](../API/T_Vortex_Connector_ValueTypes_OnlinerTimeOfDay.md) |
| DATE_AND_TIME / DT         | [OnlinerDateTime Class](../API/T_Vortex_Connector_ValueTypes_OnlinerDateTime.md) |
| STRING          |  [OnlinerString Class](../API/T_Vortex_Connector_ValueTypes_OnlinerString.md) |
| WSTRING          | [OnlinerWString Class](../API/T_Vortex_Connector_ValueTypes_OnlinerWString.md) |

![primitive twins](../../assets/TwinObject.png)

## Cyclic access

**Cyclic access** allows for fast, low performance cost, two way access to the PLC variables. Cyclic values are being read and written in an optimized periodic loop. The controller twin object contains entire PLC program, it does not discriminate between the variables and object that are used by the consumer and those that are not. However the Inxton Cyclic values are accessed via communication interface only after they are accessed for the first time by the consumer program. Once a Primitive Twin is accessed via its Cyclic property it is queued for the cyclic reading.

Primitive Twins implement notification change when the cyclic property changes (INotifyPropertyChanged). This feature is particularly useful for visualization scenarios in presentation frameworks that support data binding with change notification (WPF, in limited ways WinForm).

Cyclic access may result in degraded performance when the cyclic loop contains too many cyclically accessed primitive twins. This is however true for very large programs, it those scenarios a combination of cyclic and batched access should be used.

Primitive twin is accessed via its *Cyclic* property

~~~ C#
// Cyclic Read
/*
Notice that the property Cyclic will return type's default value when called for the first time.
*/
Console.WriteLine($"{PlcController.MAIN.Counter.Symbol} : {PlcController.MAIN.Counter.Cyclic}");

// Cyclic Write
/*
Notice that the value of the Cyclic will be written to the PLC at the next iteration of the r/w cycle.
*/
PlcController.MAIN.RunCounter.Cyclic = true;
~~~


### Synchronous access

**Synchronous access** is two way access to the PLC variable, that is enacted in synchronous way. Variable is accessed via *Synchron* property of the Primitive Twin class. In contrast to the cyclical access the Synchron accesses the variable (either reads or writes) and only then returns the control to the caller. In other words the *Synchron* property allows for immediate access to the PLC variable.

~~~ C#
// Synchronous Read
/*
Notice that the property Synchron in contrast to Cyclic will return the value from the PLC immediately.
*/
Console.WriteLine($"{PlcController.MAIN.Counter.Symbol} : {PlcController.MAIN.Counter.Synchron}");

// Synchronous Write
/*
Notice that the value of the Synchron in contrast to Cyclic will be written to the PLC immediately.
*/
PlcController.MAIN.RunCounter.Synchron = true;
~~~

> NOTE: The Synchronous access is expensive to use in scenarios when more variables are required to be read or written in the same moment as it performs item by item access without any optimization. When you want to mitigate this effect use batched access instead.

### Batched access

**Batched access** allows you to read or write a group of variables in a single shot. Strictly speaking batched reading and writing are the operations that are performed with TwinObjects while Primitive Twins hold the values that are read or written.There are several ways to access the data in a batched way. Easiest and the most straight forward way is to use methods *Read()* or *Write()* which are extension methods for *IVortexObject* aka Twin Object. All variables that are contained in the represented structure are read or written when *Read()* or *Write()* methods are used respectively.

During the batched read operation the values are stored in *LastValue* property of corresponding Primitive Twin.

During batched write operation the values written to controller are those that were stored in the *Cyclic* property of corresponding Primitive Twin.

~~~ C#
// in this namespace are extension methods for batched operations.
using Vortex.Connector;

public class BatchedAccess
{
    public void ReadBatched()
    {
        // Reads whole structure settings
        PlcController.MAIN.Settings.Read();

        // Write values to the console
        Console.WriteLine($"{PlcController.MAIN.Settings.PosX.Symbol}:{PlcController.MAIN.Settings.PosX.LastValue});

        Console.WriteLine($"{PlcController.MAIN.Settings.PosY.Symbol}:{PlcController.MAIN.Settings.PosY.LastValue});

        Console.WriteLine($"{PlcController.MAIN.Settings.PosZ.Symbol}:{PlcController.MAIN.Settings.PosZ.LastValue});
    }


    public void WriteBatched()
    {
        PlcController.MAIN.Settings.PosX.Cyclic = 100.0f;
        PlcController.MAIN.Settings.PosY.Cyclic = 120.0f;
        PlcController.MAIN.Settings.PosZ.Cyclic = 130.0f;

        // Writes all value of the settings structure.
        PlcController.MAIN.Settings.Write();
    }
}
~~~

## Other useful properties of Primitive Twins

Let's have a sample program
```BASIC
PROGRAM MAIN
VAR
    {attribute addProperty Name "<#App#>" }
    _app : fbApp;
END_VAR
---
FUNCTION_BLOCK fbApp
VAR
    {attribute addProperty Name "<#Settings#>" }
    settings : stSettings;
END_VAR
---
TYPE stSettings :
    STRUCT
        {attribute addProperty Name "<#Lights off#>" }
        TurnLightsOff :BOOL;
    END_STRUCT
END_TYPE

```

### Symbol

Symbol is readonly property that is symbolic representation of the variable in the PLC program, which corresponds to instance path of the variable.

Symbol for `TurnLightsOff` is `MAIN._app.settings.TurnLightsOff` 

### AttributeName

AttributeName is default [added property](../../Inxton.vortex.compiler.console/Conceptual/AddedProperties.md) of all objects in Inxton.Vortex.Framework. They are used to represent the name of the variable or object in user friendly way. These attribute can be later used to label the variables consistently in the UI.

AttributeName for `TurnLightsOff` is `Lights off` . Text inside tags `<#` and `#>` is marked as LocalizedString. They are optional.

### AttributeUnits

AttributeUnit is default [added property](../../Inxton.vortex.compiler.console/Conceptual/AddedProperties.md) of all PrimitiveTwins in Inxton.Vortex.Framework. They are used to represent the unit of the variable.

~~~
{attribute addProperty Units "mm"}
_length : REAL;
~~~

~~~ C#
// Writes unit of the '_lenght' variable to the console.
System.Console.WriteLine(MainPlc.MAIN._length.AttributeUnits);
~~~

### AttributeMinimum

AttributeMinimum is default [added property](../../Inxton.vortex.compiler.console/Conceptual/AddedProperties.md) of all PrimitiveTwins in Inxton.Vortex.Framework. They are used to get or set the minimal value for the variable. By default this attribute contains the minimal value of given type.

~~~
{attribute addProperty Minimum 10.8f}
_length : REAL;
~~~

~~~ C#
// Writes min value of '_length' variable to the console.
System.Console.WriteLine(MainPlc.MAIN._length.AttributeMinimum);
~~~


### AttributeMaximum

AttributeMaximum is default [added property](../../Inxton.vortex.compiler.console/Conceptual/AddedProperties.md) of all PrimitiveTwins in Inxton.Vortex.Framework. They are used to get or set the maximal value for the variable. By default this attribute contains the maximal value of given type.

~~~
{attribute addProperty Maximum 1528.8f}
_length : REAL;
~~~

~~~ C#
// Writes max. value of '_length' variable to the console.
System.Console.WriteLine(MainPlc.MAIN._length.AttributeMaximum);
~~~

### AttributeMinimum and AttributeMaximum at run time

When the application tries to write to the variable it first validates that the value to be written corresponds to limit given by AttributeMinimum and AttributeMaximum. If the value to be written does not fall withing the range this value is not written to the PLC and writing operation is silently ignored.

### AttributeToolTip

AttributeToolTip allows you to describe the variable or an object. These can be then used to give short hints for the user in the application. This attribute can be localized.

~~~
{attribute addProperty ToolTip "Value indicates the length of product."}
_length : REAL;
~~~

~~~ C#
// Writes max. value of '_length' variable to the console.
System.Console.WriteLine(MainPlc.MAIN._length.AttributeToolTip);
~~~

### HumanReadable

HumanReadable property is concatenation of AttributeName in the hierarchy of the twin, where single AttributeName(s) are separated by '.'. Human readable can be used to represent the path to the object in user friendly manner.

HumanReadable from `TurnLightsOff` is `App.Settings.Lights off`
