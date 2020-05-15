# ValueChangedEventHandlerDelegate Delegate
 _**\[This is preliminary documentation and is subject to change.\]**_

Provides delegate for notification of tags value change.

**Namespace:**&nbsp;<a href="N_Vortex_Connector_ValueTypes.md">Vortex.Connector.ValueTypes</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 0.101.0-alpha.5+Branch.develop.Sha.964441db673232ae7ce236ab6ff4c304c79df7be

## Syntax

**C#**<br />
``` C#
public delegate void ValueChangedEventHandlerDelegate(
	IValueTag sender,
	ValueChangedEventArgs args
)
```


#### Parameters
&nbsp;<dl><dt>sender</dt><dd>Type: <a href="T_Vortex_Connector_IValueTag.md">Vortex.Connector.IValueTag</a><br />Value tag where the change occurred.</dd><dt>args</dt><dd>Type: <a href="T_Vortex_Connector_ValueTypes_ValueChangedEventArgs.md">Vortex.Connector.ValueTypes.ValueChangedEventArgs</a><br />Value change arguments.</dd></dl>

## See Also


#### Reference
<a href="N_Vortex_Connector_ValueTypes.md">Vortex.Connector.ValueTypes Namespace</a><br />