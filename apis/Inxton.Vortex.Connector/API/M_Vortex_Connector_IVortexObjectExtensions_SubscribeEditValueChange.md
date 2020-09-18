# IVortexObjectExtensions.SubscribeEditValueChange Method 
 

Subscribes a delegate to be invoked when any <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_Edit.md">Edit</a> value on given object changes its value.<a href="T_Vortex_Connector_IVortexObject.md">IVortexObject</a>

**Namespace:**&nbsp;<a href="N_Vortex_Connector.md">Vortex.Connector</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 1.3.9+Branch.tags/v1.3.9.Sha.76b254c0c0b18db4a0754abdd4dde08f4adae41f

## Syntax

**C#**<br />
``` C#
public static void SubscribeEditValueChange(
	this IVortexObject obj,
	OnlinerBaseType.ValueChangeDelegate valueChangeDelegate
)
```


#### Parameters
&nbsp;<dl><dt>obj</dt><dd>Type: <a href="T_Vortex_Connector_IVortexObject.md">Vortex.Connector.IVortexObject</a><br />Observed object.</dd><dt>valueChangeDelegate</dt><dd>Type: <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_ValueChangeDelegate.md">Vortex.Connector.ValueTypes.OnlinerBaseType.ValueChangeDelegate</a><br />Delegate to be invoked on Edit value change.</dd></dl>

#### Return Value
Type: <br />

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Vortex_Connector_IVortexObject.md">IVortexObject</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods">Extension Methods (C# Programming Guide)</a>.

## Examples

```
class EditValueChangeObserver
{
    public EditValueChangeObserver()
    {
        Connector.MAIN.SubscribeEditValueChange(DetectEditValueChange);                 
    }

    private void DetectEditValueChange(IValueTag valueTag, dynamic original, dynamic newValue)
    {
        Console.WriteLine($"Value '{valueTag.Symbol}' has changed form {original} to {newValue}.")
    }

}
```


## See Also


#### Reference
<a href="T_Vortex_Connector_IVortexObjectExtensions.md">IVortexObjectExtensions Class</a><br /><a href="N_Vortex_Connector.md">Vortex.Connector Namespace</a><br />