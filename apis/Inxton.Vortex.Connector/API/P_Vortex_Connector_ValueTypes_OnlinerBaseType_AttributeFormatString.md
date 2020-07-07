# OnlinerBaseType.AttributeFormatString Property 
 

Gets or sets string format for the display of the value.

**Namespace:**&nbsp;<a href="N_Vortex_Connector_ValueTypes.md">Vortex.Connector.ValueTypes</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 1.1.0+Branch.master.Sha.6964545d53528bb038364111fd08af947d49d02f

## Syntax

**C#**<br />
``` C#
public string AttributeFormatString { get; set; }
```


#### Property Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">String</a>

## Remarks
If you would like to transform the value using String.Format use <b>FormatString</b> attribute in your PLC code. Notice the usage of <b>[[</b> and <b>]]</b>. During runtime "[[" will be replaced with "{" and "[[" will be replaced with "}" so you can use <a href="https://docs.microsoft.com/en-us/dotnet/api/system.string.format?view=netframework-4.8">String.Format</a> class as you wish. The string transformation will occur only on <b>Vortex.Presentation.Controls.Wpf.OnlineControl.OnlineControlTextBox</b>.

## Examples

```
{attribute addProperty Name "REAL"}
{attribute addProperty FormatString "[[0:F2]]"}
REAL_val : REAL;
```


## See Also


#### Reference
<a href="T_Vortex_Connector_ValueTypes_OnlinerBaseType.md">OnlinerBaseType Class</a><br /><a href="N_Vortex_Connector_ValueTypes.md">Vortex.Connector.ValueTypes Namespace</a><br />