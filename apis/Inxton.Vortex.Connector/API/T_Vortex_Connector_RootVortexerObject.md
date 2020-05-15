# RootVortexerObject Class
 _**\[This is preliminary documentation and is subject to change.\]**_

**Note: This API is now obsolete.**

Object to represent the root VortexObject. Instance of this class is typically used as root for the connector object.


## Inheritance Hierarchy
<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;Vortex.Connector.RootVortexerObject<br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Vortex_Connector_IConnector.md">Vortex.Connector.IConnector</a><br />
**Namespace:**&nbsp;<a href="N_Vortex_Connector.md">Vortex.Connector</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 0.101.0-alpha.5+Branch.develop.Sha.964441db673232ae7ce236ab6ff4c304c79df7be

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("This class should not be directly instantiated by framework consumers.")]
public class RootVortexerObject : IVortexObject, 
	ITwinObject, IVortexElement
```

The RootVortexerObject type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_RootVortexerObject__ctor.md">RootVortexerObject</a></td><td>
Initializes a new instance of the RootVortexerObject class</td></tr></table>&nbsp;
<a href="#rootvortexerobject-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_RootVortexerObject_AttributeName.md">AttributeName</a></td><td>
Gets empty name for this root object.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_RootVortexerObject_HumanReadable.md">HumanReadable</a></td><td>
Gets empty human readable of this root object.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_RootVortexerObject_Identity.md">Identity</a></td><td>
Get sn empty identity for this root object.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_RootVortexerObject_Symbol.md">Symbol</a></td><td>
Gets empty symbol for this root object.</td></tr></table>&nbsp;
<a href="#rootvortexerobject-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_RootVortexerObject_AddChild.md">AddChild</a></td><td>
Adds child object to this root object.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_RootVortexerObject_AddValueTag.md">AddValueTag</a></td><td>
Adds value tag to this root object.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/bsc2ak47" target="_blank">Equals</a></td><td>
Determines whether the specified object is equal to the current object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/4k87zsw7" target="_blank">Finalize</a></td><td>
Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_RootVortexerObject_GetChildren.md">GetChildren</a></td><td>
Get list for this root object.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_RootVortexerObject_GetConnector.md">GetConnector</a></td><td>
Get the instance of connector of this root object.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/zdee4b3y" target="_blank">GetHashCode</a></td><td>
Serves as the default hash function.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_RootVortexerObject_GetParent.md">GetParent</a></td><td>
Gets this instance as parent object.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_RootVortexerObject_GetSymbolTail.md">GetSymbolTail</a></td><td>
Get symbol tail of this object.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/dfwy45w9" target="_blank">GetType</a></td><td>
Gets the <a href="http://msdn2.microsoft.com/en-us/library/42892f65" target="_blank">Type</a> of the current instance.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_RootVortexerObject_GetValueTags.md">GetValueTags</a></td><td>
Gets value tags of this root object.</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/57ctke0a" target="_blank">MemberwiseClone</a></td><td>
Creates a shallow copy of the current <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/7bxwbwt2" target="_blank">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr></table>&nbsp;
<a href="#rootvortexerobject-class">Back to Top</a>

## Extension Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_Vortex_Connector_IVortexObjectExtensions_MakeReadOnly.md">MakeReadOnly</a></td><td>
Makes <a href="T_Vortex_Connector_IVortexObject.md">IVortexObject</a> readonly for this application.
 (Defined by <a href="T_Vortex_Connector_IVortexObjectExtensions.md">IVortexObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_Vortex_Connector_IVortexObjectExtensions_Read.md">Read</a></td><td>
Reads all value tags of instance <a href="T_Vortex_Connector_IVortexOnlineObject.md">IVortexOnlineObject</a>.
 (Defined by <a href="T_Vortex_Connector_IVortexObjectExtensions.md">IVortexObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_Vortex_Connector_IVortexObjectExtensions_RetrieveValueTags.md">RetrieveValueTags</a></td><td>
Retrieves all value tags of given object.
 (Defined by <a href="T_Vortex_Connector_IVortexObjectExtensions.md">IVortexObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_Vortex_Connector_IVortexObjectExtensions_SubscribeEditValueChange.md">SubscribeEditValueChange</a></td><td>
Subscribes a delegate to be invoked when any <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_Edit.md">Edit</a> value on given object changes its value.<a href="T_Vortex_Connector_IVortexObject.md">IVortexObject</a>
 (Defined by <a href="T_Vortex_Connector_IVortexObjectExtensions.md">IVortexObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_Vortex_Connector_IVortexObjectExtensions_SubscribeShadowValueChange.md">SubscribeShadowValueChange</a></td><td>
Subscribes a delegate to be invoked when any <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_Shadow.md">Shadow</a> value on given object changes its value.<a href="T_Vortex_Connector_IVortexObject.md">IVortexObject</a>
 (Defined by <a href="T_Vortex_Connector_IVortexObjectExtensions.md">IVortexObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Vortex_Connector_IVortexObjectExtensions_UnSubscribeEditValueChange.md">UnSubscribeEditValueChange</a></td><td>
Un-subscribes <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_Edit.md">Edit</a> value change delegate from the value tags of given object.
 (Defined by <a href="T_Vortex_Connector_IVortexObjectExtensions.md">IVortexObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Vortex_Connector_IVortexObjectExtensions_UnSubscribeShadowValueChange.md">UnSubscribeShadowValueChange</a></td><td>
Un-subscribes <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_Shadow.md">Shadow</a> value change delegate from the value tags of given object.
 (Defined by <a href="T_Vortex_Connector_IVortexObjectExtensions.md">IVortexObjectExtensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_Vortex_Connector_IVortexObjectExtensions_Write.md">Write</a></td><td>
Writes all value tags of instance <a href="T_Vortex_Connector_IVortexOnlineObject.md">IVortexOnlineObject</a>
 (Defined by <a href="T_Vortex_Connector_IVortexObjectExtensions.md">IVortexObjectExtensions</a>.)</td></tr></table>&nbsp;
<a href="#rootvortexerobject-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Vortex_Connector.md">Vortex.Connector Namespace</a><br />