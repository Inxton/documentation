# OnlinerValidationRule(*T*) Class
 _**\[This is preliminary documentation and is subject to change.\]**_

Generic class provides base for tags validation rules.


## Inheritance Hierarchy
<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;Vortex.Connector.ValueValidation.OnlinerValidationRule(T)<br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="#inheritance-hierarchy">More...</a>
**Namespace:**&nbsp;<a href="N_Vortex_Connector_ValueValidation.md">Vortex.Connector.ValueValidation</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 0.101.0-alpha.5+Branch.develop.Sha.964441db673232ae7ce236ab6ff4c304c79df7be

## Syntax

**C#**<br />
``` C#
public abstract class OnlinerValidationRule<T>

```


#### Type Parameters
&nbsp;<dl><dt>T</dt><dd /></dl>&nbsp;
The OnlinerValidationRule(T) type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_ValueValidation_OnlinerValidationRule_1__ctor.md">OnlinerValidationRule(T)</a></td><td>
Initializes a new instance of the <a href="T_Vortex_Connector_ValueValidation_ByteValueValidationRule.md">ByteValueValidationRule</a> class.</td></tr></table>&nbsp;
<a href="#onlinervalidationrule(*t*)-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueValidation_OnlinerValidationRule_1_Max.md">Max</a></td><td>
Gets the max. allowed value.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueValidation_OnlinerValidationRule_1_Min.md">Min</a></td><td>
Gets the min. allowed value.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_ValueValidation_OnlinerValidationRule_1_ValidationErrorTip.md">ValidationErrorTip</a></td><td>
Provides validation tip.</td></tr></table>&nbsp;
<a href="#onlinervalidationrule(*t*)-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/bsc2ak47" target="_blank">Equals</a></td><td>
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
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_ValueValidation_OnlinerValidationRule_1_Validate.md">Validate</a></td><td>
Validates value.</td></tr></table>&nbsp;
<a href="#onlinervalidationrule(*t*)-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Vortex_Connector_ValueValidation.md">Vortex.Connector.ValueValidation Namespace</a><br />

## Inheritance Hierarchy<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;Vortex.Connector.ValueValidation.OnlinerValidationRule(T)<br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Vortex_Connector_ValueValidation_BoolValueValidationRule.md">Vortex.Connector.ValueValidation.BoolValueValidationRule</a><br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Vortex_Connector_ValueValidation_ByteValueValidationRule.md">Vortex.Connector.ValueValidation.ByteValueValidationRule</a><br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Vortex_Connector_ValueValidation_DateTimeValueValidationRule.md">Vortex.Connector.ValueValidation.DateTimeValueValidationRule</a><br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Vortex_Connector_ValueValidation_DateValueValidationRule.md">Vortex.Connector.ValueValidation.DateValueValidationRule</a><br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Vortex_Connector_ValueValidation_DintValueValidationRule.md">Vortex.Connector.ValueValidation.DintValueValidationRule</a><br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Vortex_Connector_ValueValidation_DWordValueValidationRule.md">Vortex.Connector.ValueValidation.DWordValueValidationRule</a><br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Vortex_Connector_ValueValidation_IntValueValidationRule.md">Vortex.Connector.ValueValidation.IntValueValidationRule</a><br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Vortex_Connector_ValueValidation_LIntValueValidationRule.md">Vortex.Connector.ValueValidation.LIntValueValidationRule</a><br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Vortex_Connector_ValueValidation_LRealValueValidationRule.md">Vortex.Connector.ValueValidation.LRealValueValidationRule</a><br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Vortex_Connector_ValueValidation_LTimeValueValidationRule.md">Vortex.Connector.ValueValidation.LTimeValueValidationRule</a><br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Vortex_Connector_ValueValidation_LWordValueValidationRule.md">Vortex.Connector.ValueValidation.LWordValueValidationRule</a><br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Vortex_Connector_ValueValidation_RealValueValidationRule.md">Vortex.Connector.ValueValidation.RealValueValidationRule</a><br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Vortex_Connector_ValueValidation_SIntValueValidationRule.md">Vortex.Connector.ValueValidation.SIntValueValidationRule</a><br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Vortex_Connector_ValueValidation_StringValueValidationRule.md">Vortex.Connector.ValueValidation.StringValueValidationRule</a><br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Vortex_Connector_ValueValidation_TimeOfDayValueValidationRule.md">Vortex.Connector.ValueValidation.TimeOfDayValueValidationRule</a><br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Vortex_Connector_ValueValidation_TimeValueValidationRule.md">Vortex.Connector.ValueValidation.TimeValueValidationRule</a><br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Vortex_Connector_ValueValidation_UDIntValueValidationRule.md">Vortex.Connector.ValueValidation.UDIntValueValidationRule</a><br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Vortex_Connector_ValueValidation_UIntValueValidationRule.md">Vortex.Connector.ValueValidation.UIntValueValidationRule</a><br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Vortex_Connector_ValueValidation_ULIntValueValidationRule.md">Vortex.Connector.ValueValidation.ULIntValueValidationRule</a><br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Vortex_Connector_ValueValidation_USintValueValidationRule.md">Vortex.Connector.ValueValidation.USintValueValidationRule</a><br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Vortex_Connector_ValueValidation_WordValueValidationRule.md">Vortex.Connector.ValueValidation.WordValueValidationRule</a><br />&nbsp;&nbsp;&nbsp;&nbsp;<a href="T_Vortex_Connector_ValueValidation_WStringValueValidationRule.md">Vortex.Connector.ValueValidation.WStringValueValidationRule</a><br />