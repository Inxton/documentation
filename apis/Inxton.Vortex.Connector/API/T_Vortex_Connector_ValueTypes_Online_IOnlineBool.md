# IOnlineBool Interface
 _**\[This is preliminary documentation and is subject to change.\]**_

Defines contract to access online value of <a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">Boolean</a>; BOOL type of the PLC.

**Namespace:**&nbsp;<a href="N_Vortex_Connector_ValueTypes_Online.md">Vortex.Connector.ValueTypes.Online</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 0.101.0-alpha.5+Branch.develop.Sha.964441db673232ae7ce236ab6ff4c304c79df7be

## Syntax

**C#**<br />
``` C#
public interface IOnlineBool : IOnline<bool>
```

The IOnlineBool type exposes the following members.


## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_Online_IOnline_1_AttributeName.md">AttributeName</a></td><td>
Gets name of this tag.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_Online_IOnline_1.md">IOnline(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_Online_IOnline_1_AttributeUnits.md">AttributeUnits</a></td><td>
Get units for this tag.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_Online_IOnline_1.md">IOnline(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_Online_IOnline_1_Cyclic.md">Cyclic</a></td><td>
Gets or sets cyclically accessed value of this tag.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_Online_IOnline_1.md">IOnline(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_Online_IOnline_1_CyclicReading.md">CyclicReading</a></td><td>
Gets or sets value indicating weather the value is read cyclically.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_Online_IOnline_1.md">IOnline(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_Online_IOnline_1_Edit.md">Edit</a></td><td>
Get or set the value that will be written to the plc in the next cyclical R/W loop.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_Online_IOnline_1.md">IOnline(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_Online_IOnline_1_Symbol.md">Symbol</a></td><td>
Get symbol of this tag.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_Online_IOnline_1.md">IOnline(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_Online_IOnline_1_Synchron.md">Synchron</a></td><td>
Gets or sets the value synchronously.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_Online_IOnline_1.md">IOnline(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_Online_IOnline_1_Value.md">Value</a></td><td>
Gets <a href="P_Vortex_Connector_ValueTypes_Online_IOnline_1_Cyclic.md">Cyclic</a> value in when accessing via IOnline interface.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_Online_IOnline_1.md">IOnline(T)</a>.)</td></tr></table>&nbsp;
<a href="#ionlinebool-interface">Back to Top</a>

## Events
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td><a href="E_Vortex_Connector_ValueTypes_Online_IOnline_1_ValueChanged.md">ValueChanged</a></td><td>
Raises when <a href="P_Vortex_Connector_ValueTypes_Online_IOnline_1_Cyclic.md">Cyclic</a> value changes. Provided that the value is set for cyclical reading.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_Online_IOnline_1.md">IOnline(T)</a>.)</td></tr></table>&nbsp;
<a href="#ionlinebool-interface">Back to Top</a>

## See Also


#### Reference
<a href="N_Vortex_Connector_ValueTypes_Online.md">Vortex.Connector.ValueTypes.Online Namespace</a><br />