# OnlinerBaseType(*T*).Edit Property 
 

Gets the cyclicly read value. Setter set the value that will be written in the next cycle. The value is validated prior to performing write operation. The value must fall between <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_InstanceMinValue.md">InstanceMinValue</a> and <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_InstanceMaxValue.md">InstanceMaxValue</a>, any value outside permissible range will not be written and original value will remain unaltered. Editing of the value invokes EditValue(UTP, UTP) which allows for value change logging via <a href="P_Vortex_Connector_ValueTypes_OnlinerBaseType_1_EditValueChange.md">EditValueChange</a> delegate.

**Namespace:**&nbsp;<a href="N_Vortex_Connector_ValueTypes.md">Vortex.Connector.ValueTypes</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 1.0.0+Branch.master.Sha.24c869c7af4ddc9e28426985d5ac87eee1422bb2

## Syntax

**C#**<br />
``` C#
public T Edit { get; set; }
```


#### Property Value
Type: <a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">*T*</a>

## See Also


#### Reference
<a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType_1.md">OnlinerBaseType(T) Class</a><br /><a href="N_Vortex_Connector_ValueTypes.md">Vortex.Connector.ValueTypes Namespace</a><br />