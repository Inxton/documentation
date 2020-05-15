# IValueTag Interface
 _**\[This is preliminary documentation and is subject to change.\]**_

Provides basic contract for plc tag.

**Namespace:**&nbsp;<a href="N_Vortex_Connector.md">Vortex.Connector</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 0.101.0-alpha.5+Branch.develop.Sha.964441db673232ae7ce236ab6ff4c304c79df7be

## Syntax

**C#**<br />
``` C#
public interface IValueTag : ITwinPrimitive, 
	IVortexElement
```

The IValueTag type exposes the following members.


## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_IVortexElement_AttributeName.md">AttributeName</a></td><td>
Gets Name of this instance.
 (Inherited from <a href="T_Vortex_Connector_IVortexElement.md">IVortexElement</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_IValueTag_EditValueChange.md">EditValueChange</a></td><td>
Delegate invoked when the 'Edit' value changes.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_IVortexElement_HumanReadable.md">HumanReadable</a></td><td>
Provides a string combined from <a href="P_Vortex_Connector_IVortexElement_AttributeName.md">AttributeName</a> of ancestors (<a href="M_Vortex_Connector_IVortexElement_GetParent.md">GetParent()</a>) of this instance and the tail of this instance.
 (Inherited from <a href="T_Vortex_Connector_IVortexElement.md">IVortexElement</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_IValueTag_ShadowValueChange.md">ShadowValueChange</a></td><td>
Delegate invoked when the 'Shadow' value changes.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_IVortexElement_Symbol.md">Symbol</a></td><td>
Get symbol of this instance.
 (Inherited from <a href="T_Vortex_Connector_IVortexElement.md">IVortexElement</a>.)</td></tr></table>&nbsp;
<a href="#ivaluetag-interface">Back to Top</a>

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
<a href="#ivaluetag-interface">Back to Top</a>

## See Also


#### Reference
<a href="N_Vortex_Connector.md">Vortex.Connector Namespace</a><br />