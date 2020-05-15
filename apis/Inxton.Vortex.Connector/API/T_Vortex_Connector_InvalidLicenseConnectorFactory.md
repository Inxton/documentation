# InvalidLicenseConnectorFactory Class
 _**\[This is preliminary documentation and is subject to change.\]**_

Fall-back connector when invalid license provided


## Inheritance Hierarchy
<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;<a href="T_Vortex_Connector_IConnectorFactory.md">Vortex.Connector.IConnectorFactory</a><br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Vortex_Connector_DummyConnectorFactory.md">Vortex.Connector.DummyConnectorFactory</a><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Vortex.Connector.InvalidLicenseConnectorFactory<br />
**Namespace:**&nbsp;<a href="N_Vortex_Connector.md">Vortex.Connector</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 0.101.0-alpha.5+Branch.develop.Sha.964441db673232ae7ce236ab6ff4c304c79df7be

## Syntax

**C#**<br />
``` C#
public class InvalidLicenseConnectorFactory : DummyConnectorFactory
```

The InvalidLicenseConnectorFactory type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_InvalidLicenseConnectorFactory__ctor.md">InvalidLicenseConnectorFactory</a></td><td>
Initializes a new instance of the InvalidLicenseConnectorFactory class</td></tr></table>&nbsp;
<a href="#invalidlicenseconnectorfactory-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_DummyConnectorFactory_CreateBOOL.md">CreateBOOL</a></td><td>
Creates <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">Boolean</a> dummy tag of PLC value type BOOL
 (Inherited from <a href="T_Vortex_Connector_DummyConnectorFactory.md">DummyConnectorFactory</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_DummyConnectorFactory_CreateBYTE.md">CreateBYTE</a></td><td>
Creates <a href="http://msdn2.microsoft.com/en-us/library/yyb1w04y" target="_blank">Byte</a> dummy tag of PLC value type BYTE
 (Inherited from <a href="T_Vortex_Connector_DummyConnectorFactory.md">DummyConnectorFactory</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_InvalidLicenseConnectorFactory_CreateConnector.md">CreateConnector</a></td><td>
Creates connector.
 (Overrides <a href="M_Vortex_Connector_DummyConnectorFactory_CreateConnector.md">DummyConnectorFactory.CreateConnector(Object[])</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_DummyConnectorFactory_CreateDATE.md">CreateDATE</a></td><td>
Creates <a href="http://msdn2.microsoft.com/en-us/library/03ybds8y" target="_blank">DateTime</a> dummy tag of PLC value type DATE
 (Inherited from <a href="T_Vortex_Connector_DummyConnectorFactory.md">DummyConnectorFactory</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_DummyConnectorFactory_CreateDATE_TIME.md">CreateDATE_TIME</a></td><td>
Creates <a href="http://msdn2.microsoft.com/en-us/library/03ybds8y" target="_blank">DateTime</a> dummy tag of PLC value type DATE_TIME (DT)
 (Inherited from <a href="T_Vortex_Connector_DummyConnectorFactory.md">DummyConnectorFactory</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_DummyConnectorFactory_CreateDINT.md">CreateDINT</a></td><td>
Creates <a href="http://msdn2.microsoft.com/en-us/library/td2s409d" target="_blank">Int32</a> dummy tag of PLC value type DINT
 (Inherited from <a href="T_Vortex_Connector_DummyConnectorFactory.md">DummyConnectorFactory</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_DummyConnectorFactory_CreateDWORD.md">CreateDWORD</a></td><td>
Creates <a href="http://msdn2.microsoft.com/en-us/library/ctys3981" target="_blank">UInt32</a> dummy tag of PLC value type DWORD
 (Inherited from <a href="T_Vortex_Connector_DummyConnectorFactory.md">DummyConnectorFactory</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_DummyConnectorFactory_CreateINT.md">CreateINT</a></td><td>
Creates <a href="http://msdn2.microsoft.com/en-us/library/e07e6fds" target="_blank">Int16</a> dummy tag of PLC value type INT
 (Inherited from <a href="T_Vortex_Connector_DummyConnectorFactory.md">DummyConnectorFactory</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_DummyConnectorFactory_CreateLINT.md">CreateLINT</a></td><td>
Creates <a href="http://msdn2.microsoft.com/en-us/library/6yy583ek" target="_blank">Int64</a> dummy tag of PLC value type LINT
 (Inherited from <a href="T_Vortex_Connector_DummyConnectorFactory.md">DummyConnectorFactory</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_DummyConnectorFactory_CreateLREAL.md">CreateLREAL</a></td><td>
Creates <a href="http://msdn2.microsoft.com/en-us/library/643eft0t" target="_blank">Double</a> dummy tag of PLC value type LREAL
 (Inherited from <a href="T_Vortex_Connector_DummyConnectorFactory.md">DummyConnectorFactory</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_DummyConnectorFactory_CreateLTIME.md">CreateLTIME</a></td><td>
Creates <a href="http://msdn2.microsoft.com/en-us/library/269ew577" target="_blank">TimeSpan</a> dummy tag of PLC value type LTIME
 (Inherited from <a href="T_Vortex_Connector_DummyConnectorFactory.md">DummyConnectorFactory</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_DummyConnectorFactory_CreateLWORD.md">CreateLWORD</a></td><td>
Creates <a href="http://msdn2.microsoft.com/en-us/library/06cf7918" target="_blank">UInt64</a> dummy tag of PLC value type LWORD
 (Inherited from <a href="T_Vortex_Connector_DummyConnectorFactory.md">DummyConnectorFactory</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_DummyConnectorFactory_CreateREAL.md">CreateREAL</a></td><td>
Creates <a href="http://msdn2.microsoft.com/en-us/library/3www918f" target="_blank">Single</a> dummy tag of PLC value type REAL
 (Inherited from <a href="T_Vortex_Connector_DummyConnectorFactory.md">DummyConnectorFactory</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_DummyConnectorFactory_CreateSINT.md">CreateSINT</a></td><td>
Creates <a href="http://msdn2.microsoft.com/en-us/library/f71b253d" target="_blank">SByte</a> dummy tag of PLC value type SINT
 (Inherited from <a href="T_Vortex_Connector_DummyConnectorFactory.md">DummyConnectorFactory</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_DummyConnectorFactory_CreateSTRING.md">CreateSTRING</a></td><td>
Creates <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a> dummy tag of PLC value type STRING
 (Inherited from <a href="T_Vortex_Connector_DummyConnectorFactory.md">DummyConnectorFactory</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_DummyConnectorFactory_CreateTIME.md">CreateTIME</a></td><td>
Creates <a href="http://msdn2.microsoft.com/en-us/library/269ew577" target="_blank">TimeSpan</a> dummy tag of PLC value type TIME
 (Inherited from <a href="T_Vortex_Connector_DummyConnectorFactory.md">DummyConnectorFactory</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_DummyConnectorFactory_CreateTIME_OF_DAY.md">CreateTIME_OF_DAY</a></td><td>
Creates <a href="http://msdn2.microsoft.com/en-us/library/269ew577" target="_blank">TimeSpan</a> dummy tag of PLC value type TIME_OF_DAY (TOD)
 (Inherited from <a href="T_Vortex_Connector_DummyConnectorFactory.md">DummyConnectorFactory</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_DummyConnectorFactory_CreateUDINT.md">CreateUDINT</a></td><td>
Creates <a href="http://msdn2.microsoft.com/en-us/library/ctys3981" target="_blank">UInt32</a> dummy tag of PLC value type UDINT
 (Inherited from <a href="T_Vortex_Connector_DummyConnectorFactory.md">DummyConnectorFactory</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_DummyConnectorFactory_CreateUINT.md">CreateUINT</a></td><td>
Creates <a href="http://msdn2.microsoft.com/en-us/library/s6eyk10z" target="_blank">UInt16</a> dummy tag of PLC value type UINT
 (Inherited from <a href="T_Vortex_Connector_DummyConnectorFactory.md">DummyConnectorFactory</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_DummyConnectorFactory_CreateULINT.md">CreateULINT</a></td><td>
Creates <a href="http://msdn2.microsoft.com/en-us/library/06cf7918" target="_blank">UInt64</a> dummy tag of PLC value type ULINT
 (Inherited from <a href="T_Vortex_Connector_DummyConnectorFactory.md">DummyConnectorFactory</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_DummyConnectorFactory_CreateUSINT.md">CreateUSINT</a></td><td>
Creates <a href="http://msdn2.microsoft.com/en-us/library/yyb1w04y" target="_blank">Byte</a> dummy tag of PLC value type USINT
 (Inherited from <a href="T_Vortex_Connector_DummyConnectorFactory.md">DummyConnectorFactory</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_DummyConnectorFactory_CreateWORD.md">CreateWORD</a></td><td>
Creates <a href="http://msdn2.microsoft.com/en-us/library/s6eyk10z" target="_blank">UInt16</a> dummy tag of PLC value type WORD
 (Inherited from <a href="T_Vortex_Connector_DummyConnectorFactory.md">DummyConnectorFactory</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_DummyConnectorFactory_CreateWSTRING.md">CreateWSTRING</a></td><td>
Creates <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a> dummy tag of PLC value type WSTRING
 (Inherited from <a href="T_Vortex_Connector_DummyConnectorFactory.md">DummyConnectorFactory</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/bsc2ak47" target="_blank">Equals</a></td><td>
Determines whether the specified object is equal to the current object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/4k87zsw7" target="_blank">Finalize</a></td><td>
Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/zdee4b3y" target="_blank">GetHashCode</a></td><td>
Serves as the default hash function.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/dfwy45w9" target="_blank">GetType</a></td><td>
Gets the <a href="http://msdn2.microsoft.com/en-us/library/42892f65" target="_blank">Type</a> of the current instance.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/57ctke0a" target="_blank">MemberwiseClone</a></td><td>
Creates a shallow copy of the current <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/7bxwbwt2" target="_blank">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr></table>&nbsp;
<a href="#invalidlicenseconnectorfactory-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Vortex_Connector.md">Vortex.Connector Namespace</a><br />