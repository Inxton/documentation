# IValueTag.UnSubscribe Method 
 

Un-subscribes this tag from handling the value change.
&nbsp;<table><tr><th>![Note](media/AlertNote.png) Note</th></tr><tr><td>The cyclical reading of this tag will not be cancelled.</td></tr></table>&nbsp;
**Namespace:**&nbsp;<a href="N_Vortex_Connector.md">Vortex.Connector</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 1.3.9+Branch.tags/v1.3.9.Sha.76b254c0c0b18db4a0754abdd4dde08f4adae41f

## Syntax

**C#**<br />
``` C#
void UnSubscribe(
	ValueChangedEventHandlerDelegate handler
)
```


#### Parameters
&nbsp;<dl><dt>handler</dt><dd>Type: <a href="T_Vortex_Connector_ValueTypes_ValueChangedEventHandlerDelegate.md">Vortex.Connector.ValueTypes.ValueChangedEventHandlerDelegate</a><br /></dd></dl>

## See Also


#### Reference
<a href="T_Vortex_Connector_IValueTag.md">IValueTag Interface</a><br /><a href="N_Vortex_Connector.md">Vortex.Connector Namespace</a><br />