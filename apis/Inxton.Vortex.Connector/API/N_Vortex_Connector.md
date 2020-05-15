# Vortex.Connector Namespace
 _**\[This is preliminary documentation and is subject to change.\]**_


Vortex.Connector namespace groups building block of Vortex Connector that mediates the connectivity to the PLC for vortex framework application. It also provides multiple functions to manage the transfer of data between .net application and PLC system.



## Classes
&nbsp;<table><tr><th></th><th>Class</th><th>Description</th></tr><tr><td>![Public class](media/pubclass.gif "Public class")</td><td><a href="T_Vortex_Connector_ConnectorAdapter.md">ConnectorAdapter</a></td><td>
Provides basic abstractions for vortex connectors.</td></tr><tr><td>![Public class](media/pubclass.gif "Public class")</td><td><a href="T_Vortex_Connector_DummyConnector.md">DummyConnector</a></td><td>
Provides a connector without real target system connections.</td></tr><tr><td>![Public class](media/pubclass.gif "Public class")</td><td><a href="T_Vortex_Connector_DummyConnectorFactory.md">DummyConnectorFactory</a></td><td>
Dummy connector factory class. Serves as offline connector with no connection to a controller.</td></tr><tr><td>![Public class](media/pubclass.gif "Public class")</td><td><a href="T_Vortex_Connector_EnumeratorDiscriminatorAttribute.md">EnumeratorDiscriminatorAttribute</a></td><td>
Attribute provides information about the member being treated as enum.</td></tr><tr><td>![Public class](media/pubclass.gif "Public class")</td><td><a href="T_Vortex_Connector_IConnector.md">IConnector</a></td><td>

Abstract base class provides implementation contract for the PLC connector and basic common underlying logic.</td></tr><tr><td>![Public class](media/pubclass.gif "Public class")</td><td><a href="T_Vortex_Connector_IConnectorFactory.md">IConnectorFactory</a></td><td>
Provides abstraction for creation of <a href="T_Vortex_Connector_IConnector.md">IConnector</a> and value types (tags) for vortex connector.</td></tr><tr><td>![Public class](media/pubclass.gif "Public class")</td><td><a href="T_Vortex_Connector_IgnoreReflectionAttribute.md">IgnoreReflectionAttribute</a></td><td>
Indicates that the member should not be reflected within the vortex framework.</td></tr><tr><td>![Public class](media/pubclass.gif "Public class")</td><td><a href="T_Vortex_Connector_InvalidLicenseConnector.md">InvalidLicenseConnector</a></td><td>
Fall-back connector when invalid license provided</td></tr><tr><td>![Public class](media/pubclass.gif "Public class")</td><td><a href="T_Vortex_Connector_InvalidLicenseConnectorAdapter.md">InvalidLicenseConnectorAdapter</a></td><td>
Provides connector for application with invalid license.</td></tr><tr><td>![Public class](media/pubclass.gif "Public class")</td><td><a href="T_Vortex_Connector_InvalidLicenseConnectorFactory.md">InvalidLicenseConnectorFactory</a></td><td>
Fall-back connector when invalid license provided</td></tr><tr><td>![Public class](media/pubclass.gif "Public class")</td><td><a href="T_Vortex_Connector_IVortexObjectExtensions.md">IVortexObjectExtensions</a></td><td>
Extensions methods for <a href="T_Vortex_Connector_IVortexObject.md">IVortexObject</a>.</td></tr><tr><td>![Public class](media/pubclass.gif "Public class")</td><td><a href="T_Vortex_Connector_RootVortexerObject.md">RootVortexerObject</a></td><td> **Obsolete. **
Object to represent the root VortexObject. Instance of this class is typically used as root for the connector object.</td></tr><tr><td>![Public class](media/pubclass.gif "Public class")</td><td><a href="T_Vortex_Connector_StringInterpolator.md">StringInterpolator</a></td><td>
Provides extension methods for PLC's string interpolation.</td></tr></table>

## Interfaces
&nbsp;<table><tr><th></th><th>Interface</th><th>Description</th></tr><tr><td>![Public interface](media/pubinterface.gif "Public interface")</td><td><a href="T_Vortex_Connector_IPlain.md">IPlain</a></td><td>
Basic abstraction for 'Plain' types.
&nbsp;<table><tr><th>![Note](media/AlertNote.png) Note</th></tr><tr><td>Implementation used in building process. Not to be declared by framework consumers.</td></tr></table></td></tr><tr><td>![Public interface](media/pubinterface.gif "Public interface")</td><td><a href="T_Vortex_Connector_ITwinController.md">ITwinController</a></td><td>
Represents twin object for PLC controller.</td></tr><tr><td>![Public interface](media/pubinterface.gif "Public interface")</td><td><a href="T_Vortex_Connector_ITwinObject.md">ITwinObject</a></td><td>
Represents twin object for complex PLC types.</td></tr><tr><td>![Public interface](media/pubinterface.gif "Public interface")</td><td><a href="T_Vortex_Connector_ITwinPrimitive.md">ITwinPrimitive</a></td><td>
Represents twin object for base PLC types.</td></tr><tr><td>![Public interface](media/pubinterface.gif "Public interface")</td><td><a href="T_Vortex_Connector_IValueTag.md">IValueTag</a></td><td>
Provides basic contract for plc tag.</td></tr><tr><td>![Public interface](media/pubinterface.gif "Public interface")</td><td><a href="T_Vortex_Connector_IValueTagInfo.md">IValueTagInfo</a></td><td>
Provides interface for information about value types symbols.</td></tr><tr><td>![Public interface](media/pubinterface.gif "Public interface")</td><td><a href="T_Vortex_Connector_IVortexElement.md">IVortexElement</a></td><td>
Basic contract for any type that is product of building process.</td></tr><tr><td>![Public interface](media/pubinterface.gif "Public interface")</td><td><a href="T_Vortex_Connector_IVortexObject.md">IVortexObject</a></td><td>
Basic contract for any complex object that is product of build process.</td></tr><tr><td>![Public interface](media/pubinterface.gif "Public interface")</td><td><a href="T_Vortex_Connector_IVortexOnlineObject.md">IVortexOnlineObject</a></td><td>
Basic abstraction for 'IOnline' types.
&nbsp;<table><tr><th>![Note](media/AlertNote.png) Note</th></tr><tr><td>Implementation used in building process. Not to be declared by framework consumers.</td></tr></table></td></tr><tr><td>![Public interface](media/pubinterface.gif "Public interface")</td><td><a href="T_Vortex_Connector_IVortexShadowObject.md">IVortexShadowObject</a></td><td>
Basic abstraction for 'IShadow' types.
&nbsp;<table><tr><th>![Note](media/AlertNote.png) Note</th></tr><tr><td>Implementation used in building process. Not to be declared by framework consumers.</td></tr></table></td></tr></table>

## Enumerations
&nbsp;<table><tr><th></th><th>Enumeration</th><th>Description</th></tr><tr><td>![Public enumeration](media/pubenumeration.gif "Public enumeration")</td><td><a href="T_Vortex_Connector_CommStateEnum.md">CommStateEnum</a></td><td>
Enumeration of possible states of target system.</td></tr><tr><td>![Public enumeration](media/pubenumeration.gif "Public enumeration")</td><td><a href="T_Vortex_Connector_DataExchangeStatusEnum.md">DataExchangeStatusEnum</a></td><td>
Enumerates possible states of communication with target system.</td></tr><tr><td>![Public enumeration](media/pubenumeration.gif "Public enumeration")</td><td><a href="T_Vortex_Connector_TypeComplexityEnum.md">TypeComplexityEnum</a></td><td>
Enumerates types of objects depending on complexity.</td></tr></table>&nbsp;
