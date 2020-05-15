# IVortexObjectExtensions.SubscribeShadowValueChange Method 
 _**\[This is preliminary documentation and is subject to change.\]**_

Subscribes a delegate to be invoked when any <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_Shadow.md">Shadow</a> value on given object changes its value.<a href="T_Vortex_Connector_IVortexObject.md">IVortexObject</a>

**Namespace:**&nbsp;<a href="N_Vortex_Connector.md">Vortex.Connector</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 0.101.0-alpha.5+Branch.develop.Sha.964441db673232ae7ce236ab6ff4c304c79df7be

## Syntax

**C#**<br />
``` C#
public static void SubscribeShadowValueChange(
	this IVortexObject obj,
	OnlinerBaseType.ValueChangeDelegate valueChangeDelegate
)
```


#### Parameters
&nbsp;<dl><dt>obj</dt><dd>Type: <a href="T_Vortex_Connector_IVortexObject.md">Vortex.Connector.IVortexObject</a><br />Observed object.</dd><dt>valueChangeDelegate</dt><dd>Type: <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_ValueChangeDelegate.md">Vortex.Connector.ValueTypes.OnlinerBaseType.ValueChangeDelegate</a><br />Delegate to be invoked on shadow value change.</dd></dl>

#### Return Value
Type: <br />

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Vortex_Connector_IVortexObject.md">IVortexObject</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="http://msdn.microsoft.com/en-us/library/bb384936.aspx">Extension Methods (Visual Basic)</a> or <a href="http://msdn.microsoft.com/en-us/library/bb383977.aspx">Extension Methods (C# Programming Guide)</a>.

## Examples

```
class ShadowValueChangeObserver
{
    public ShadowValueChangeObserver()
    {
        Connector.MAIN.SubscribeShadowValueChange(DetectShadowValueChange);                 
    }

    private void DetectShadowValueChange(IValueTag valueTag, dynamic original, dynamic newValue)
    {
        Console.WriteLine($"Value '{valueTag.Symbol}' has changed form {original} to {newValue}.")
    }

}
```


## See Also


#### Reference
<a href="T_Vortex_Connector_IVortexObjectExtensions.md">IVortexObjectExtensions Class</a><br /><a href="N_Vortex_Connector.md">Vortex.Connector Namespace</a><br />