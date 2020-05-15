# IVortexObject Interface
 _**\[This is preliminary documentation and is subject to change.\]**_

Basic contract for any complex object that is product of build process.

**Namespace:**&nbsp;<a href="N_Vortex_Connector.md">Vortex.Connector</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 0.101.0-alpha.5+Branch.develop.Sha.964441db673232ae7ce236ab6ff4c304c79df7be

## Syntax

**C#**<br />
``` C#
public interface IVortexObject : ITwinObject, 
	IVortexElement
```

The IVortexObject type exposes the following members.


## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_IVortexElement_AttributeName.md">AttributeName</a></td><td>
Gets Name of this instance.
 (Inherited from <a href="T_Vortex_Connector_IVortexElement.md">IVortexElement</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_IVortexElement_HumanReadable.md">HumanReadable</a></td><td>
Provides a string combined from <a href="P_Vortex_Connector_IVortexElement_AttributeName.md">AttributeName</a> of ancestors (<a href="M_Vortex_Connector_IVortexElement_GetParent.md">GetParent()</a>) of this instance and the tail of this instance.
 (Inherited from <a href="T_Vortex_Connector_IVortexElement.md">IVortexElement</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_IVortexElement_Symbol.md">Symbol</a></td><td>
Get symbol of this instance.
 (Inherited from <a href="T_Vortex_Connector_IVortexElement.md">IVortexElement</a>.)</td></tr></table>&nbsp;
<a href="#ivortexobject-interface">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_IVortexObject_AddChild.md">AddChild</a></td><td>
Adds child object to the list of children of this object. <a href="M_Vortex_Connector_IVortexObject_GetChildren.md">GetChildren()</a>
&nbsp;<table><tr><th>![Note](media/AlertNote.png) Note</th></tr><tr><td>This method is used by the objects built in building process. Not to be used by framework consumers.</td></tr></table></td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_IVortexObject_AddValueTag.md">AddValueTag</a></td><td>
Adds child value tag to the list of value tags of this object. <a href="M_Vortex_Connector_IVortexObject_GetValueTags.md">GetValueTags()</a>
&nbsp;<table><tr><th>![Note](media/AlertNote.png) Note</th></tr><tr><td>This method is used by the objects built in building process. Not to be used by framework consumers.</td></tr></table></td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_IVortexObject_GetChildren.md">GetChildren</a></td><td>
Gets all complex object that are created by this instance.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_IVortexObject_GetConnector.md">GetConnector</a></td><td>
Gets the instance of the <a href="T_Vortex_Connector_IConnector.md">IConnector</a> class to which this IVortexObject belongs.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_IVortexElement_GetParent.md">GetParent</a></td><td>
Gets the parent object of this instance. Parent object is the object that created this instance.
 (Inherited from <a href="T_Vortex_Connector_IVortexElement.md">IVortexElement</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_IVortexElement_GetSymbolTail.md">GetSymbolTail</a></td><td>
Get symbol tail of this instance.
 (Inherited from <a href="T_Vortex_Connector_IVortexElement.md">IVortexElement</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_IVortexObject_GetValueTags.md">GetValueTags</a></td><td>
Get all base type objects (tags) that are created by this instance.</td></tr></table>&nbsp;
<a href="#ivortexobject-interface">Back to Top</a>

## Extension Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_Vortex_Connector_IVortexObjectExtensions_MakeReadOnly.md">MakeReadOnly</a></td><td>
Makes IVortexObject readonly for this application.
 (Defined by <a href="T_Vortex_Connector_IVortexObjectExtensions.md">IVortexObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_Vortex_Connector_IVortexObjectExtensions_Read.md">Read</a></td><td>
Reads all value tags of instance <a href="T_Vortex_Connector_IVortexOnlineObject.md">IVortexOnlineObject</a>.
 (Defined by <a href="T_Vortex_Connector_IVortexObjectExtensions.md">IVortexObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_Vortex_Connector_IVortexObjectExtensions_RetrieveValueTags.md">RetrieveValueTags</a></td><td>
Retrieves all value tags of given object.
 (Defined by <a href="T_Vortex_Connector_IVortexObjectExtensions.md">IVortexObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_Vortex_Connector_IVortexObjectExtensions_SubscribeEditValueChange.md">SubscribeEditValueChange</a></td><td>
Subscribes a delegate to be invoked when any <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_Edit.md">Edit</a> value on given object changes its value.IVortexObject
 (Defined by <a href="T_Vortex_Connector_IVortexObjectExtensions.md">IVortexObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_Vortex_Connector_IVortexObjectExtensions_SubscribeShadowValueChange.md">SubscribeShadowValueChange</a></td><td>
Subscribes a delegate to be invoked when any <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_Shadow.md">Shadow</a> value on given object changes its value.IVortexObject
 (Defined by <a href="T_Vortex_Connector_IVortexObjectExtensions.md">IVortexObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Vortex_Connector_IVortexObjectExtensions_UnSubscribeEditValueChange.md">UnSubscribeEditValueChange</a></td><td>
Un-subscribes <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_Edit.md">Edit</a> value change delegate from the value tags of given object.
 (Defined by <a href="T_Vortex_Connector_IVortexObjectExtensions.md">IVortexObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Vortex_Connector_IVortexObjectExtensions_UnSubscribeShadowValueChange.md">UnSubscribeShadowValueChange</a></td><td>
Un-subscribes <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_Shadow.md">Shadow</a> value change delegate from the value tags of given object.
 (Defined by <a href="T_Vortex_Connector_IVortexObjectExtensions.md">IVortexObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_Vortex_Connector_IVortexObjectExtensions_Write.md">Write</a></td><td>
Writes all value tags of instance <a href="T_Vortex_Connector_IVortexOnlineObject.md">IVortexOnlineObject</a>
 (Defined by <a href="T_Vortex_Connector_IVortexObjectExtensions.md">IVortexObjectExtensions</a>.)</td></tr></table>&nbsp;
<a href="#ivortexobject-interface">Back to Top</a>

## See Also


#### Reference
<a href="N_Vortex_Connector.md">Vortex.Connector Namespace</a><br />