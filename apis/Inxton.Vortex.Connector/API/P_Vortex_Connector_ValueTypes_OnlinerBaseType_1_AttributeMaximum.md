# OnlinerBaseType(*T*).AttributeMaximum Property 
 _**\[This is preliminary documentation and is subject to change.\]**_

Gets or sets max. value allowed for this tag. If the value is not set the max. value will be the maximum allowed for this type.
&nbsp;<table><tr><th>![Note](media/AlertNote.png) Note</th></tr><tr><td>The value is typically set by attribute in the PLC code</td></tr></table>

## Examples
This example demonstrates how to set value boundaries for a numerical value. <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_AttributeMinimum.md">AttributeMinimum</a> and AttributeMaximum. Notice that the name of the 'added property' is prefixed with 'Attribute' when trans-piled into .net class. 
```
{attribute addProperty Minimum 10}
{attribute addProperty Maximum 50}
_integerVar : INT;
```


**Namespace:**&nbsp;<a href="N_Vortex_Connector_ValueTypes.md">Vortex.Connector.ValueTypes</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 0.101.0-alpha.5+Branch.develop.Sha.964441db673232ae7ce236ab6ff4c304c79df7be

## Syntax

**C#**<br />
``` C#
public T AttributeMaximum { get; set; }
```


#### Property Value
Type: <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">*T*</a>

## See Also


#### Reference
<a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T) Class</a><br /><a href="N_Vortex_Connector_ValueTypes.md">Vortex.Connector.ValueTypes Namespace</a><br />