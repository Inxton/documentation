# InvalidLicenseConnector Class
 _**\[This is preliminary documentation and is subject to change.\]**_

Fall-back connector when invalid license provided


## Inheritance Hierarchy
<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;<a href="T_Vortex_Connector_RootVortexerObject.md">Vortex.Connector.RootVortexerObject</a><br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Vortex_Connector_IConnector.md">Vortex.Connector.IConnector</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Vortex_Connector_DummyConnector.md">Vortex.Connector.DummyConnector</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Vortex.Connector.InvalidLicenseConnector<br />
**Namespace:**&nbsp;<a href="N_Vortex_Connector.md">Vortex.Connector</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 0.101.0-alpha.5+Branch.develop.Sha.964441db673232ae7ce236ab6ff4c304c79df7be

## Syntax

**C#**<br />
``` C#
public class InvalidLicenseConnector : DummyConnector
```

The InvalidLicenseConnector type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_InvalidLicenseConnector__ctor.md">InvalidLicenseConnector</a></td><td>
Initializes a new instance of the InvalidLicenseConnector class</td></tr></table>&nbsp;
<a href="#invalidlicenseconnector-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_RootVortexerObject_AttributeName.md">AttributeName</a></td><td>
Gets empty name for this root object.
 (Inherited from <a href="T_Vortex_Connector_RootVortexerObject.md">RootVortexerObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_IConnector_CommState.md">CommState</a></td><td>
Gets the communication state <a href="T_Vortex_Connector_CommStateEnum.md">CommStateEnum</a> of the connector.
 (Inherited from <a href="T_Vortex_Connector_IConnector.md">IConnector</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_IConnector_CyclicRwDuration.md">CyclicRwDuration</a></td><td>
Gets the last duration of Read/Write cycle in milliseconds.
 (Inherited from <a href="T_Vortex_Connector_IConnector.md">IConnector</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_IConnector_DataExchangeStatus.md">DataExchangeStatus</a></td><td>
Get data exchange status on this connector.
 (Inherited from <a href="T_Vortex_Connector_IConnector.md">IConnector</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_DummyConnector_ErrorCount.md">ErrorCount</a></td><td>
Gets or sets error counter of the adapter.
 (Inherited from <a href="T_Vortex_Connector_DummyConnector.md">DummyConnector</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_RootVortexerObject_HumanReadable.md">HumanReadable</a></td><td>
Gets empty human readable of this root object.
 (Inherited from <a href="T_Vortex_Connector_RootVortexerObject.md">RootVortexerObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_RootVortexerObject_Identity.md">Identity</a></td><td>
Get sn empty identity for this root object.
 (Inherited from <a href="T_Vortex_Connector_RootVortexerObject.md">RootVortexerObject</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_IConnector_IdentityProvider.md">IdentityProvider</a></td><td>
Gets object identity provider.
 (Inherited from <a href="T_Vortex_Connector_IConnector.md">IConnector</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_IConnector_LoadingSymbol.md">LoadingSymbol</a></td><td>
Gets currently loading symbol information from the remote system.
 (Inherited from <a href="T_Vortex_Connector_IConnector.md">IConnector</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_IConnector_Logger.md">Logger</a></td><td>
Provides logging capability for this connector.
 (Inherited from <a href="T_Vortex_Connector_IConnector.md">IConnector</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_IConnector_MonitorConnector.md">MonitorConnector</a></td><td>
Gets or sets value indicating whether the performance of the monitor should be active.
 (Inherited from <a href="T_Vortex_Connector_IConnector.md">IConnector</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_IConnector_Online.md">Online</a></td><td>
Gets adapter for onliners.
 (Inherited from <a href="T_Vortex_Connector_IConnector.md">IConnector</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_DummyConnector_OnlineTags.md">OnlineTags</a></td><td>
Gets online value items tags attached to this connector.
 (Inherited from <a href="T_Vortex_Connector_DummyConnector.md">DummyConnector</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_IConnector_ReadWriteCycleDelay.md">ReadWriteCycleDelay</a></td><td>
Gets or sets delay between Read/Write cycles.
 (Inherited from <a href="T_Vortex_Connector_IConnector.md">IConnector</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_IConnector_RwCycleCount.md">RwCycleCount</a></td><td>
Gets the number of Read Write cycles from the start of the connector.
 (Inherited from <a href="T_Vortex_Connector_IConnector.md">IConnector</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_IConnector_StartUpTime.md">StartUpTime</a></td><td>
Get the connector's startup timestamp.
 (Inherited from <a href="T_Vortex_Connector_IConnector.md">IConnector</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_RootVortexerObject_Symbol.md">Symbol</a></td><td>
Gets empty symbol for this root object.
 (Inherited from <a href="T_Vortex_Connector_RootVortexerObject.md">RootVortexerObject</a>.)</td></tr></table>&nbsp;
<a href="#invalidlicenseconnector-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_RootVortexerObject_AddChild.md">AddChild</a></td><td>
Adds child object to this root object.
 (Inherited from <a href="T_Vortex_Connector_RootVortexerObject.md">RootVortexerObject</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_RootVortexerObject_AddValueTag.md">AddValueTag</a></td><td>
Adds value tag to this root object.
 (Inherited from <a href="T_Vortex_Connector_RootVortexerObject.md">RootVortexerObject</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_DummyConnector_BuildAndStart.md">BuildAndStart</a></td><td>
This method does not have effect on <a href="T_Vortex_Connector_DummyConnector.md">DummyConnector</a>
 (Inherited from <a href="T_Vortex_Connector_DummyConnector.md">DummyConnector</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/bsc2ak47" target="_blank">Equals</a></td><td>
Determines whether the specified object is equal to the current object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/4k87zsw7" target="_blank">Finalize</a></td><td>
Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_RootVortexerObject_GetChildren.md">GetChildren</a></td><td>
Get list for this root object.
 (Inherited from <a href="T_Vortex_Connector_RootVortexerObject.md">RootVortexerObject</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_RootVortexerObject_GetConnector.md">GetConnector</a></td><td>
Get the instance of connector of this root object.
 (Inherited from <a href="T_Vortex_Connector_RootVortexerObject.md">RootVortexerObject</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/zdee4b3y" target="_blank">GetHashCode</a></td><td>
Serves as the default hash function.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_RootVortexerObject_GetParent.md">GetParent</a></td><td>
Gets this instance as parent object.
 (Inherited from <a href="T_Vortex_Connector_RootVortexerObject.md">RootVortexerObject</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_RootVortexerObject_GetSymbolTail.md">GetSymbolTail</a></td><td>
Get symbol tail of this object.
 (Inherited from <a href="T_Vortex_Connector_RootVortexerObject.md">RootVortexerObject</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/dfwy45w9" target="_blank">GetType</a></td><td>
Gets the <a href="http://msdn2.microsoft.com/en-us/library/42892f65" target="_blank">Type</a> of the current instance.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_RootVortexerObject_GetValueTags.md">GetValueTags</a></td><td>
Gets value tags of this root object.
 (Inherited from <a href="T_Vortex_Connector_RootVortexerObject.md">RootVortexerObject</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_DummyConnector_InvokeRpc.md">InvokeRpc</a></td><td>
This method does not have effect on <a href="T_Vortex_Connector_DummyConnector.md">DummyConnector</a>
 (Inherited from <a href="T_Vortex_Connector_DummyConnector.md">DummyConnector</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/57ctke0a" target="_blank">MemberwiseClone</a></td><td>
Creates a shallow copy of the current <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_DummyConnector_ReadBatch.md">ReadBatch</a></td><td>
Reads batch of value items from the plc.
 (Inherited from <a href="T_Vortex_Connector_DummyConnector.md">DummyConnector</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_DummyConnector_ReloadConnector.md">ReloadConnector</a></td><td>
This method does not have effect on dummy connector.
 (Inherited from <a href="T_Vortex_Connector_DummyConnector.md">DummyConnector</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/7bxwbwt2" target="_blank">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_DummyConnector_WriteBatch.md">WriteBatch</a></td><td>
Writes batch of value items to the plc.
 (Inherited from <a href="T_Vortex_Connector_DummyConnector.md">DummyConnector</a>.)</td></tr></table>&nbsp;
<a href="#invalidlicenseconnector-class">Back to Top</a>

## Events
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td><a href="E_Vortex_Connector_IConnector_PropertyChanged.md">PropertyChanged</a></td><td>
Implementation of <a href="http://msdn2.microsoft.com/en-us/library/ms133020" target="_blank">INotifyPropertyChanged</a>
 (Inherited from <a href="T_Vortex_Connector_IConnector.md">IConnector</a>.)</td></tr></table>&nbsp;
<a href="#invalidlicenseconnector-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Vortex_Connector.md">Vortex.Connector Namespace</a><br />