# OnlinerDInt Class
 _**\[This is preliminary documentation and is subject to change.\]**_

Class providing access to the DINT type online variable.


## Inheritance Hierarchy
<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;<a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType.md">Vortex.Connector.ValueTypes.OnlinerBaseType</a><br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">Vortex.Connector.ValueTypes.OnlinerBaseType</a>(<a href="http://msdn2.microsoft.com/en-us/library/td2s409d" target="_blank">Int32</a>)<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Vortex.Connector.ValueTypes.OnlinerDInt<br />
**Namespace:**&nbsp;<a href="N_Vortex_Connector_ValueTypes.md">Vortex.Connector.ValueTypes</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 0.101.0-alpha.5+Branch.develop.Sha.964441db673232ae7ce236ab6ff4c304c79df7be

## Syntax

**C#**<br />
``` C#
public class OnlinerDInt : OnlinerBaseType<int>, 
	IOnlineDInt, IOnline<int>, IShadowDInt, IShadow<int>
```

The OnlinerDInt type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_ValueTypes_OnlinerDInt__ctor.md">OnlinerDInt()</a></td><td>
Initializes a new instance of the OnlinerDInt class.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_ValueTypes_OnlinerDInt__ctor_1.md">OnlinerDInt(IVortexObject, String, String)</a></td><td>
Initializes a new instance of the OnlinerDInt class.</td></tr></table>&nbsp;
<a href="#onlinerdint-class">Back to Top</a>

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
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_OnlinerDInt_InstanceMaxValue.md">InstanceMaxValue</a></td><td>
Gets the max value for this instance.
 (Overrides <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_InstanceMaxValue.md">OnlinerBaseType(T).InstanceMaxValue</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueTypes_OnlinerDInt_InstanceMinValue.md">InstanceMinValue</a></td><td>
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
<a href="#onlinerdint-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/bsc2ak47" target="_blank">Equals</a></td><td>
Determines whether the specified object is equal to the current object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/4k87zsw7" target="_blank">Finalize</a></td><td>
Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_ValueTypes_OnlinerBaseType_1_GetDeclaringAssembly.md">GetDeclaringAssembly</a></td><td>
Gets the assembly that declares the instance of this tag.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/zdee4b3y" target="_blank">GetHashCode</a></td><td>
Serves as the default hash function.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_ValueTypes_OnlinerBaseType_1_GetLastAvailableValue.md">GetLastAvailableValue</a></td><td>
Gets tha most recent value either <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_LastValue.md">LastValue</a> or <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_Cyclic.md">Cyclic</a> if that is more recent.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_ValueTypes_OnlinerBaseType_1_GetParent.md">GetParent</a></td><td>
Gets the parent object of this instance. Parent object is the object that created this instance.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_ValueTypes_OnlinerBaseType_1_GetSymbolTail.md">GetSymbolTail</a></td><td>
Gets tail of the this tag symbol.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/dfwy45w9" target="_blank">GetType</a></td><td>
Gets the <a href="http://msdn2.microsoft.com/en-us/library/42892f65" target="_blank">Type</a> of the current instance.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_ValueTypes_OnlinerBaseType_1_GetValueChangeEventSubscribers.md">GetValueChangeEventSubscribers</a></td><td>
Gets delegates associated with ValueChangeEvent
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_ValueTypes_OnlinerBaseType_1_HasWriteAccess.md">HasWriteAccess</a></td><td>
Get true when this tag has write access.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_ValueTypes_OnlinerBaseType_MakeReadOnly.md">MakeReadOnly</a></td><td>
Makes this tag readonly for the current application.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType.md">OnlinerBaseType</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/57ctke0a" target="_blank">MemberwiseClone</a></td><td>
Creates a shallow copy of the current <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_Vortex_Connector_ValueTypes_OnlinerBaseType_1_NotifyPropertyChanged.md">NotifyPropertyChanged</a></td><td>
Implementation of <a href="http://msdn2.microsoft.com/en-us/library/ms133020" target="_blank">INotifyPropertyChanged</a>.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_Vortex_Connector_ValueTypes_OnlinerBaseType_1_OnValueChangeEvent.md">OnValueChangeEvent</a></td><td>
Notifies the change of <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_Cyclic.md">Cyclic</a>value.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_Vortex_Connector_ValueTypes_OnlinerBaseType_1_ReadFromItem.md">ReadFromItem</a></td><td>
NVI should be implemented in derived class. When implemented in derived class provide reading of the <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_Cyclic.md">Cyclic</a>value for this tag from a stream.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_ValueTypes_OnlinerBaseType_1_Subscribe.md">Subscribe</a></td><td>
Subscribes this tag for cyclical reading and invokes <a href="T_Vortex_Connector_ValueTypes_ValueChangedEventHandlerDelegate.md">ValueChangedEventHandlerDelegate</a> when the value changes.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/7bxwbwt2" target="_blank">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_ValueTypes_OnlinerBaseType_1_UnSubscribe.md">UnSubscribe</a></td><td>
Un-subscribes this tag from handling the value change. The cyclical reading of this tag will not be cancelled.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_Vortex_Connector_ValueTypes_OnlinerBaseType_1_UpdateRead.md">UpdateRead</a></td><td>
Updates cyclically read value and performs notifications.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_Vortex_Connector_ValueTypes_OnlinerBaseType_1_WriteItem.md">WriteItem</a></td><td>
NVI should be implemented in derived class. When implemented in derived class provide writing of the <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_Cyclic.md">Cyclic</a>value for this tag from a stream.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr></table>&nbsp;
<a href="#onlinerdint-class">Back to Top</a>

## Events
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td><a href="E_Vortex_Connector_ValueTypes_OnlinerBaseType_1_PropertyChanged.md">PropertyChanged</a></td><td>
Implementation of <a href="http://msdn2.microsoft.com/en-us/library/ms133020" target="_blank">INotifyPropertyChanged</a> interface.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td><a href="E_Vortex_Connector_ValueTypes_OnlinerBaseType_1_ShadowValueChangeEvent.md">ShadowValueChangeEvent</a></td><td><a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_Shadow.md">Shadow</a> value changed event.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td><a href="E_Vortex_Connector_ValueTypes_OnlinerBaseType_1_ValueChangeEvent.md">ValueChangeEvent</a></td><td>
Online <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_Cyclic.md">Cyclic</a> property changed event.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr></table>&nbsp;
<a href="#onlinerdint-class">Back to Top</a>

## Fields
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Vortex_Connector_ValueTypes_OnlinerDInt_MaxValue.md">MaxValue</a></td><td>
Gets the max value of OnlinerDInt.</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Vortex_Connector_ValueTypes_OnlinerDInt_MinValue.md">MinValue</a></td><td>
Gets the min value of OnlinerDInt.</td></tr><tr><td>![Protected field](media/protfield.gif "Protected field")</td><td><a href="F_Vortex_Connector_ValueTypes_OnlinerBaseType_1_validator.md">validator</a></td><td>
Holder field for validation rule.
 (Inherited from <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T)</a>.)</td></tr></table>&nbsp;
<a href="#onlinerdint-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Vortex_Connector_ValueTypes.md">Vortex.Connector.ValueTypes Namespace</a><br />