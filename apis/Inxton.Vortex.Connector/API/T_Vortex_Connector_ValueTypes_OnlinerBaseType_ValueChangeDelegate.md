# OnlinerBaseType.ValueChangeDelegate Delegate
 

Provides delegate for detection of a change of tag value.

**Namespace:**&nbsp;<a href="N_Vortex_Connector_ValueTypes.md">Vortex.Connector.ValueTypes</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 1.3.12+Branch.tags-v1.3.12.Sha.00bdfb8be9e078a68c552d3a1d81a8775d48ab55

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
&nbsp;<dl><dt>valueTag</dt><dd>Type: <a href="T_Vortex_Connector_IValueTag.md">Vortex.Connector.IValueTag</a><br />Tag on which the value change occurred.</dd><dt>original</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">System.Object</a><br />Original value.</dd><dt>newValue</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">System.Object</a><br />Changed value.</dd></dl>

## See Also


#### Reference
<a href="N_Vortex_Connector_ValueTypes.md">Vortex.Connector.ValueTypes Namespace</a><br />