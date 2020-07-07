# OnlinerBaseType(*T*).Shadow Property 
 

Gets or sets shadow placeholder for the value of this instance. Shadow is off line placeholder that does not affect the PLC controller's value of this tag. Shadow values can be written to PLC controller via 'FlushShadowToOnline' method of a respective structure. Online values can be written to its Shadow representation via 'FlushOnlineToShadow' method of the respective structure. The value must fall between <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_InstanceMinValue.md">InstanceMinValue</a> and <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_InstanceMaxValue.md">InstanceMaxValue</a>, any value outside permissible range will not be set and original value will remain unaltered. Change of the shadow value can be observed via <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_ShadowValueChange.md">ShadowValueChange</a> delegate.

**Namespace:**&nbsp;<a href="N_Vortex_Connector_ValueTypes.md">Vortex.Connector.ValueTypes</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 1.1.0+Branch.master.Sha.6964545d53528bb038364111fd08af947d49d02f

## Syntax

**C#**<br />
``` C#
public T Shadow { get; set; }
```


#### Property Value
Type: <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">*T*</a>

## See Also


#### Reference
<a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T) Class</a><br /><a href="N_Vortex_Connector_ValueTypes.md">Vortex.Connector.ValueTypes Namespace</a><br />