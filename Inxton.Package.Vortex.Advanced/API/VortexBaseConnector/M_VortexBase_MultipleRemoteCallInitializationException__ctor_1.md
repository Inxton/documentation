# MultipleRemoteCallInitializationException Constructor (SerializationInfo, StreamingContext)
 

Initializes a new instance of the <a href="T_VortexBase_MultipleRemoteCallInitializationException.md">MultipleRemoteCallInitializationException</a> class with serialized data.

**Namespace:**&nbsp;<a href="N_VortexBase.md">VortexBase</a><br />**Assembly:**&nbsp;VortexBaseConnector (in VortexBaseConnector.dll) Version: 0.101.0-dotnetcore.38+Branch.feature/dotnetcore.Sha.9184ded7250ef900bfdd1d83b2841836087bcfce

## Syntax

**C#**<br />
``` C#
protected MultipleRemoteCallInitializationException(
	SerializationInfo info,
	StreamingContext context
)
```


#### Parameters
&nbsp;<dl><dt>info</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.runtime.serialization.serializationinfo" target="_blank">System.Runtime.Serialization.SerializationInfo</a><br />The <a href="https://docs.microsoft.com/dotnet/api/system.runtime.serialization.serializationinfo" target="_blank">SerializationInfo</a> that holds the serialized object data about the exception being thrown.</dd><dt>context</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.runtime.serialization.streamingcontext" target="_blank">System.Runtime.Serialization.StreamingContext</a><br />The <a href="https://docs.microsoft.com/dotnet/api/system.runtime.serialization.streamingcontext" target="_blank">StreamingContext</a> that contains contextual information about the source or destination.</dd></dl>

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_blank">ArgumentNullException</a></td><td>The *info* parameter is null.</td></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.runtime.serialization.serializationexception" target="_blank">SerializationException</a></td><td>The class name is null or <a href="https://docs.microsoft.com/dotnet/api/system.exception.hresult#System_Exception_HResult" target="_blank">HResult</a> is zero (0).</td></tr></table>

## See Also


#### Reference
<a href="T_VortexBase_MultipleRemoteCallInitializationException.md">MultipleRemoteCallInitializationException Class</a><br /><a href="Overload_VortexBase_MultipleRemoteCallInitializationException__ctor.md">MultipleRemoteCallInitializationException Overload</a><br /><a href="N_VortexBase.md">VortexBase Namespace</a><br />