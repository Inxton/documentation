# OnlinerBaseType.ValueChangeDelegate Delegate
 

Provides delegate for detection of a change of tag value.

**Namespace:**&nbsp;<a href="N_Vortex_Connector_ValueTypes.md">Vortex.Connector.ValueTypes</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 1.1.0+Branch.master.Sha.6964545d53528bb038364111fd08af947d49d02f

## Syntax

**C#**<br />
``` C#
public delegate void ValueChangeDelegate(
	IValueTag valueTag,
	Object original,
	Object newValue
)
```


#### Parameters
&nbsp;<dl><dt>valueTag</dt><dd>Type: <a href="T_Vortex_Connector_IValueTag.md">Vortex.Connector.IValueTag</a><br />Tag on which the value change occurred.</dd><dt>original</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />Original value.</dd><dt>newValue</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />Changed value.</dd></dl>

## See Also


#### Reference
<a href="N_Vortex_Connector_ValueTypes.md">Vortex.Connector.ValueTypes Namespace</a><br />