# IValueTag.UnSubscribe Method 
 

Un-subscribes this tag from handling the value change.
&nbsp;<table><tr><th>![Note](media/AlertNote.png) Note</th></tr><tr><td>The cyclical reading of this tag will not be cancelled.</td></tr></table>&nbsp;
**Namespace:**&nbsp;<a href="N_Vortex_Connector.md">Vortex.Connector</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 1.3.12+Branch.tags-v1.3.12.Sha.00bdfb8be9e078a68c552d3a1d81a8775d48ab55

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