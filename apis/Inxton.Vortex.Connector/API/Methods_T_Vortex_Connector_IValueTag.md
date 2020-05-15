# IValueTag Methods
 _**\[This is preliminary documentation and is subject to change.\]**_

The <a href="T_Vortex_Connector_IValueTag.md">IValueTag</a> type exposes the following members.


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_IVortexElement_GetParent.md">GetParent</a></td><td>
Gets the parent object of this instance. Parent object is the object that created this instance.
 (Inherited from <a href="T_Vortex_Connector_IVortexElement.md">IVortexElement</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_IVortexElement_GetSymbolTail.md">GetSymbolTail</a></td><td>
Get symbol tail of this instance.
 (Inherited from <a href="T_Vortex_Connector_IVortexElement.md">IVortexElement</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_IValueTag_MakeReadOnly.md">MakeReadOnly</a></td><td>
Makes this tag readonly for the current application.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_IValueTag_Subscribe.md">Subscribe</a></td><td>
Subscribes this tag for cyclical reading and invokes <a href="T_Vortex_Connector_ValueTypes_ValueChangedEventHandlerDelegate.md">ValueChangedEventHandlerDelegate</a> when the value changes.
&nbsp;<table><tr><th>![Note](media/AlertNote.png) Note</th></tr><tr><td>Tag will be set for cyclical reading.</td></tr></table></td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_IValueTag_UnSubscribe.md">UnSubscribe</a></td><td>
Un-subscribes this tag from handling the value change.
&nbsp;<table><tr><th>![Note](media/AlertNote.png) Note</th></tr><tr><td>The cyclical reading of this tag will not be cancelled.</td></tr></table></td></tr></table>&nbsp;
<a href="#ivaluetag-methods">Back to Top</a>

## See Also


#### Reference
<a href="T_Vortex_Connector_IValueTag.md">IValueTag Interface</a><br /><a href="N_Vortex_Connector.md">Vortex.Connector Namespace</a><br />