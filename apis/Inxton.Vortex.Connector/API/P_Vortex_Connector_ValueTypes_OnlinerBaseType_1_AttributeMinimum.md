# OnlinerBaseType(*T*).AttributeMinimum Property 
 

Gets or sets min. value allowed for this tag. If the value is not set the min. value will be the maximum allowed for this type.
&nbsp;<table><tr><th>![Note](media/AlertNote.png) Note</th></tr><tr><td>The value is typically set by attribute in the PLC code</td></tr></table>

## Examples
This example demonstrates how to set value boundaries for a numerical value. AttributeMinimum and <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_AttributeMaximum.md">AttributeMaximum</a>. Notice that the name of the 'added property' is prefixed with 'Attribute' when trans-piled into .net class. 
```
{attribute addProperty Minimum 10}
{attribute addProperty Maximum 50}
_integerVar : INT;
```


**Namespace:**&nbsp;<a href="N_Vortex_Connector_ValueTypes.md">Vortex.Connector.ValueTypes</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 1.3.9+Branch.tags/v1.3.9.Sha.76b254c0c0b18db4a0754abdd4dde08f4adae41f

## Syntax

**C#**<br />
``` C#
public T AttributeMinimum { get; set; }
```


#### Property Value
Type: <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">*T*</a>

## See Also


#### Reference
<a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T) Class</a><br /><a href="N_Vortex_Connector_ValueTypes.md">Vortex.Connector.ValueTypes Namespace</a><br />