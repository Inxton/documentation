# IOnline(*T*) Interface
 _**\[This is preliminary documentation and is subject to change.\]**_

Implementation contract for base types tags to access online values from the PLC.

**Namespace:**&nbsp;<a href="N_Vortex_Connector_ValueTypes_Online.md">Vortex.Connector.ValueTypes.Online</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 0.101.0-alpha.5+Branch.develop.Sha.964441db673232ae7ce236ab6ff4c304c79df7be

## Syntax

**C#**<br />
``` C#
public interface IOnline<T>

```


#### Type Parameters
&nbsp;<dl><dt>T</dt><dd /></dl>&nbsp;
The IOnline(T) type exposes the following members.


## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_Online_IOnline_1_AttributeName.md">AttributeName</a></td><td>
Gets name of this tag.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_Online_IOnline_1_AttributeUnits.md">AttributeUnits</a></td><td>
Get units for this tag.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_Online_IOnline_1_Cyclic.md">Cyclic</a></td><td>
Gets or sets cyclically accessed value of this tag.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_Online_IOnline_1_CyclicReading.md">CyclicReading</a></td><td>
Gets or sets value indicating weather the value is read cyclically.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_Online_IOnline_1_Edit.md">Edit</a></td><td>
Get or set the value that will be written to the plc in the next cyclical R/W loop.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_Online_IOnline_1_Symbol.md">Symbol</a></td><td>
Get symbol of this tag.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_Online_IOnline_1_Synchron.md">Synchron</a></td><td>
Gets or sets the value synchronously.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_Online_IOnline_1_Value.md">Value</a></td><td>
Gets <a href="P_Vortex_Connector_ValueTypes_Online_IOnline_1_Cyclic.md">Cyclic</a> value in when accessing via IOnline interface.</td></tr></table>&nbsp;
<a href="#ionline(*t*)-interface">Back to Top</a>

## Events
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td><a href="E_Vortex_Connector_ValueTypes_Online_IOnline_1_ValueChanged.md">ValueChanged</a></td><td>
Raises when <a href="P_Vortex_Connector_ValueTypes_Online_IOnline_1_Cyclic.md">Cyclic</a> value changes. Provided that the value is set for cyclical reading.</td></tr></table>&nbsp;
<a href="#ionline(*t*)-interface">Back to Top</a>

## See Also


#### Reference
<a href="N_Vortex_Connector_ValueTypes_Online.md">Vortex.Connector.ValueTypes.Online Namespace</a><br />