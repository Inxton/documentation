# OnlinerDateTime Properties
 _**\[This is preliminary documentation and is subject to change.\]**_

The <a href="T_Vortex_Connector_ValueTypes_OnlinerDateTime.md">OnlinerDateTime</a> type exposes the following members.


## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_AttributeFormatString.md">AttributeFormatString</a></td><td>
Gets or sets string format for the display of the value.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType.md">OnlinerBaseType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_AttributeMaximum.md">AttributeMaximum</a></td><td>
Gets or sets max. value allowed for this tag. If the value is not set the max. value will be the maximum allowed for this type.
&nbsp;<table><tr><th>![Note](media/AlertNote.png) Note</th></tr><tr><td>The value is typically set by attribute in the PLC code</td></tr></table>

## Examples
This example demonstrates how to set value boundaries for a numerical value. <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_AttributeMinimum.md">AttributeMinimum</a> and <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_AttributeMaximum.md">AttributeMaximum</a>. Notice that the name of the 'added property' is prefixed with 'Attribute' when trans-piled into .net class. 
```
{attribute addProperty Minimum 10}
{attribute addProperty Maximum 50}
_integerVar : INT;
```

 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Code example](media/CodeExample.png "Code example")</td><td><a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_AttributeMinimum.md">AttributeMinimum</a></td><td>
Gets or sets min. value allowed for this tag. If the value is not set the min. value will be the maximum allowed for this type.
&nbsp;<table><tr><th>![Note](media/AlertNote.png) Note</th></tr><tr><td>The value is typically set by attribute in the PLC code</td></tr></table>

## Examples
This example demonstrates how to set value boundaries for a numerical value. <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_AttributeMinimum.md">AttributeMinimum</a> and <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_AttributeMaximum.md">AttributeMaximum</a>. Notice that the name of the 'added property' is prefixed with 'Attribute' when trans-piled into .net class. 
```
{attribute addProperty Minimum 10}
{attribute addProperty Maximum 50}
_integerVar : INT;
```

 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_AttributeName.md">AttributeName</a></td><td>
Gets or sets the attribute name.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_AttributeToolTip.md">AttributeToolTip</a></td><td>
Gets or sets tool tip message for this tag.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_AttributeUnits.md">AttributeUnits</a></td><td>
Gets or sets the attribute units.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_Cyclic.md">Cyclic</a></td><td>
Gets the value that was read in the last cycle or sets the value to be written in the next cycle.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_CyclicReading.md">CyclicReading</a></td><td>
Gets or sets a value indicating whether cyclic reading of this tag is active.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td><a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_cyclicToWrite.md">cyclicToWrite</a></td><td>
Gets the value that will be written in the next cycle.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_Edit.md">Edit</a></td><td>
Gets the cyclicly read value. Setter set the value that will be written in the next cycle. The value is validated prior to performing write operation. The value must fall between <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_InstanceMinValue.md">InstanceMinValue</a> and <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_InstanceMaxValue.md">InstanceMaxValue</a>, any value outside permissible range will not be written and original value will remain unaltered. Editing of the value invokes EditValue(UTP, UTP) which allows for value change logging via <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_EditValueChange.md">EditValueChange</a> delegate.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_EditValueChange.md">EditValueChange</a></td><td>
Gets or sets delegate that executes when <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_Edit.md">Edit</a> property is changed.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_HasBeenWritten.md">HasBeenWritten</a></td><td>
Gets or sets a value indicating whether has been written in the last cycle.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_HumanReadable.md">HumanReadable</a></td><td>
Provides a string combined from <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_AttributeName.md">AttributeName</a> of ancestors (<a href="M_Vortex_Connector_ValueTypes_OnlinerBaseType_1_GetParent.md">GetParent()</a>) of this instance and the tail of this instance.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_OnlinerDateTime_InstanceMaxValue.md">InstanceMaxValue</a></td><td>
Gets the max value for this instance.
 (Overrides <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_InstanceMaxValue.md">OnlinerBaseType(T).InstanceMaxValue</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_OnlinerDateTime_InstanceMinValue.md">InstanceMinValue</a></td><td>
Gets the min value for this instance.
 (Overrides <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_InstanceMinValue.md">OnlinerBaseType(T).InstanceMinValue</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_IsToBeRead.md">IsToBeRead</a></td><td>
Gets a value indicating whether is to be read in the next cycle.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_IsToBeWritten.md">IsToBeWritten</a></td><td>
Gets a value indicating whether is to be written.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_LastValue.md">LastValue</a></td><td>
Gets the last value retrieved from cyclical or batched reading. Without requesting cyclical read operation on this onliner.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td><a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_Parent.md">Parent</a></td><td>
Gets the parent object of this instance. Parent object is the object that created this instance.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_Raw.md">Raw</a></td><td>
Gets the raw value read from the controller. The value is not affected by <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_Translator.md">Translator</a> or <a href="T_Vortex_Connector_StringInterpolator.md">StringInterpolator</a>.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_ReadFromPlcIsRequested.md">ReadFromPlcIsRequested</a></td><td>
Gets or sets a value indicating whether read from plc is requested.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_ReadWriteAccess.md">ReadWriteAccess</a></td><td>
Gets the read write access mode for this tag.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType.md">OnlinerBaseType</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_SetLastValue.md">SetLastValue</a></td><td> **Obsolete. **
Sets <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_LastValue.md">LastValue</a> property value. This property should be used only for testing purposes.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_Shadow.md">Shadow</a></td><td>
Gets or sets shadow placeholder for the value of this instance. <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_Shadow.md">Shadow</a> is off line placeholder that does not affect the PLC controller's value of this tag. Shadow values can be written to PLC controller via 'FlushShadowToOnline' method of a respective structure. Online values can be written to its Shadow representation via 'FlushOnlineToShadow' method of the respective structure. The value must fall between <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_InstanceMinValue.md">InstanceMinValue</a> and <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_InstanceMaxValue.md">InstanceMaxValue</a>, any value outside permissible range will not be set and original value will remain unaltered. Change of the shadow value can be observed via <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_ShadowValueChange.md">ShadowValueChange</a> delegate.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_ShadowValueChange.md">ShadowValueChange</a></td><td>
Gets or sets delegate that executed when <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_Shadow.md">Shadow</a> property is changed.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_Symbol.md">Symbol</a></td><td>
Gets the symbol of this on line variable.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td><a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_SymbolTail.md">SymbolTail</a></td><td>
Gets or sets the tail of the symbol of this tag.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_Synchron.md">Synchron</a></td><td>
Gets or sets the online value synchronously.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_Translator.md">Translator</a></td><td>
Provides translator for the localization for this tag.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_Validator.md">Validator</a></td><td>
Gets the validation rule for this type. Validation occurs only when property <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_Edit.md">Edit</a> is changed.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_VariableInfo.md">VariableInfo</a></td><td>
Gets information about this tag's online variable info.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_WriteToPlcIsRequested.md">WriteToPlcIsRequested</a></td><td>
Gets or sets a value indicating whether this variable should be written to the controller in the next cycle.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr></table>&nbsp;
<a href="#onlinerdatetime-properties">Back to Top</a>

## See Also


#### Reference
<a href="T_Vortex_Connector_ValueTypes_OnlinerDateTime.md">OnlinerDateTime Class</a><br /><a href="N_Vortex_Connector_ValueTypes.md">Vortex.Connector.ValueTypes Namespace</a><br />