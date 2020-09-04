# Analyzer.GetAndSortActiveMessages Method 
 

Retrieves Most Important Messages for given <a href="T_VortexBase_IVortexer.md">IVortexer</a> object and its child object.

**Namespace:**&nbsp;<a href="N_VortexBase_Diagnostics.md">VortexBase.Diagnostics</a><br />**Assembly:**&nbsp;VortexBaseConnector (in VortexBaseConnector.dll) Version: 0.101.0-dotnetcore.38+Branch.feature/dotnetcore.Sha.9184ded7250ef900bfdd1d83b2841836087bcfce

## Syntax

**C#**<br />
``` C#
public Task<IEnumerable<PlainstMessage>> GetAndSortActiveMessages()
```


#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.threading.tasks.task-1" target="_blank">Task</a>(<a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_blank">IEnumerable</a>(PlainstMessage))<br />Most Important Messages related to this and its child objects.

## See Also


#### Reference
<a href="T_VortexBase_Diagnostics_Analyzer.md">Analyzer Class</a><br /><a href="N_VortexBase_Diagnostics.md">VortexBase.Diagnostics Namespace</a><br />