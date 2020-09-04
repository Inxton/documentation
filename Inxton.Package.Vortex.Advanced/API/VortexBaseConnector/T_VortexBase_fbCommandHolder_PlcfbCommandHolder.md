# fbCommandHolder.PlcfbCommandHolder Class
 

Command holder serves as coordination element that provides execution of an arbitrary code in PLC. The code will execute until the command holder is held; the _hold member is true. The execution can be invoked from the HMI.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">System.Object</a><br />&nbsp;&nbsp;<a href="T_VortexBase_fbVortexer_PlcfbVortexer.md">VortexBase.fbVortexer.PlcfbVortexer</a><br />&nbsp;&nbsp;&nbsp;&nbsp;VortexBase.fbCommandHolder.PlcfbCommandHolder<br />
**Namespace:**&nbsp;<a href="N_VortexBase.md">VortexBase</a><br />**Assembly:**&nbsp;VortexBaseConnector (in VortexBaseConnector.dll) Version: 0.101.0-dotnetcore.38+Branch.feature/dotnetcore.Sha.9184ded7250ef900bfdd1d83b2841836087bcfce

## Syntax

**C#**<br />
``` C#
protected abstract class PlcfbCommandHolder : fbVortexer.PlcfbVortexer
```

The fbCommandHolder.PlcfbCommandHolder type exposes the following members.


## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_VortexBase_fbCommandHolder_PlcfbCommandHolder_Disabled.md">Disabled</a></td><td>
When sets, command is disabled to change its state.</td></tr></table>&nbsp;
<a href="#fbcommandholder.plcfbcommandholder-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.object.equals#System_Object_Equals_System_Object_" target="_blank">Equals</a></td><td>
Determines whether the specified object is equal to the current object.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.object.finalize#System_Object_Finalize" target="_blank">Finalize</a></td><td>
Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.object.gethashcode#System_Object_GetHashCode" target="_blank">GetHashCode</a></td><td>
Serves as the default hash function.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.object.gettype#System_Object_GetType" target="_blank">GetType</a></td><td>
Gets the <a href="https://docs.microsoft.com/dotnet/api/system.type" target="_blank">Type</a> of the current instance.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_VortexBase_fbCommandHolder_PlcfbCommandHolder_Keep.md">Keep</a></td><td>
Invokes the execution of this <a href="T_VortexBase_fbCommandHolder.md">fbCommandHolder</a>s from the plc. The execution of the command is active until the command is 'unkept' by the <a href="M_VortexBase_fbCommandHolder_PlcfbCommandHolder_UnKeep.md">UnKeep()</a> or the HMI.</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.object.memberwiseclone#System_Object_MemberwiseClone" target="_blank">MemberwiseClone</a></td><td>
Creates a shallow copy of the current <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_VortexBase_fbCommandHolder_PlcfbCommandHolder_Monitor.md">Monitor</a></td><td>
Monitors invocation of the <a href="T_VortexBase_fbCommandHolder.md">fbCommandHolder</a>. Command holder is invoked while the <a href="P_VortexBase_fbCommandHolder__hold.md">_hold</a> variable is 'true'.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.object.tostring#System_Object_ToString" target="_blank">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_VortexBase_fbCommandHolder_PlcfbCommandHolder_UnKeep.md">UnKeep</a></td><td>
Cancels the execution of this <a href="T_VortexBase_fbCommandHolder.md">fbCommandHolder</a>s from the plc.</td></tr></table>&nbsp;
<a href="#fbcommandholder.plcfbcommandholder-class">Back to Top</a>

## See Also


#### Reference
<a href="N_VortexBase.md">VortexBase Namespace</a><br />