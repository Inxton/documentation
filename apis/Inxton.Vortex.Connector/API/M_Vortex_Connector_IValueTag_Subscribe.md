# IValueTag.Subscribe Method 
 _**\[This is preliminary documentation and is subject to change.\]**_

Subscribes this tag for cyclical reading and invokes <a href="T_Vortex_Connector_ValueTypes_ValueChangedEventHandlerDelegate.md">ValueChangedEventHandlerDelegate</a> when the value changes.
&nbsp;<table><tr><th>![Note](media/AlertNote.png) Note</th></tr><tr><td>Tag will be set for cyclical reading.</td></tr></table>&nbsp;
**Namespace:**&nbsp;<a href="N_Vortex_Connector.md">Vortex.Connector</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 0.101.0-alpha.5+Branch.develop.Sha.964441db673232ae7ce236ab6ff4c304c79df7be

## Syntax

**C#**<br />
``` C#
void Subscribe(
	ValueChangedEventHandlerDelegate handler
)
```


#### Parameters
&nbsp;<dl><dt>handler</dt><dd>Type: <a href="T_Vortex_Connector_ValueTypes_ValueChangedEventHandlerDelegate.md">Vortex.Connector.ValueTypes.ValueChangedEventHandlerDelegate</a><br />Handles the value change event.</dd></dl>

## See Also


#### Reference
<a href="T_Vortex_Connector_IValueTag.md">IValueTag Interface</a><br /><a href="N_Vortex_Connector.md">Vortex.Connector Namespace</a><br />