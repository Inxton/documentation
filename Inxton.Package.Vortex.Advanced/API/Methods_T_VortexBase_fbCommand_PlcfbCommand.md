# PlcfbCommand Methods
 

The <a href="T_VortexBase_fbCommand_PlcfbCommand.md">fbCommand.PlcfbCommand</a> type exposes the following members.


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_VortexBase_fbCommand_PlcfbCommand_Complete.md">Complete</a></td><td>
Completes the execution of the command.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.object.equals#System_Object_Equals_System_Object_" target="_blank">Equals</a></td><td>
Determines whether the specified object is equal to the current object.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.object.finalize#System_Object_Finalize" target="_blank">Finalize</a></td><td>
Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.object.gethashcode#System_Object_GetHashCode" target="_blank">GetHashCode</a></td><td>
Serves as the default hash function.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.object.gettype#System_Object_GetType" target="_blank">GetType</a></td><td>
Gets the <a href="https://docs.microsoft.com/dotnet/api/system.type" target="_blank">Type</a> of the current instance.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_VortexBase_fbCommand_PlcfbCommand_Invoke.md">Invoke</a></td><td>
Invokes execution of the command from the plc.</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.object.memberwiseclone#System_Object_MemberwiseClone" target="_blank">MemberwiseClone</a></td><td>
Creates a shallow copy of the current <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_VortexBase_fbCommand_PlcfbCommand_Monitor.md">Monitor</a></td><td>
Monitors invocation of the command. Command is invoked on rising edge of the '_Invoke' variable or by calling Invoke method. Command execution stops when <a href="M_VortexBase_fbCommand_PlcfbCommand_Complete.md">Complete()</a> method is called. Typically the command is invoked by the HMI/SCADA side by setting 'Invoke' variable to 'true'.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_VortexBase_fbCommand_PlcfbCommand_MonitorWithTimeOut.md">MonitorWithTimeOut</a></td><td>
Monitors invocation of the command with 'timed out' option. When the command execution exceeds the pre-set time info message is reported to the messaging system. Command is invoked on rising edge of the '_Invoke' variable or by calling Invoke method. Command execution stops when <a href="M_VortexBase_fbCommand_PlcfbCommand_Complete.md">Complete()</a> method is called. Typically the command is invoked by the HMI/SCADA side by setting 'Invoke' variable to 'true'.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_VortexBase_fbCommand_PlcfbCommand_Reset.md">Reset</a></td><td>
Resets the command. Internal states is set to initial state.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.object.tostring#System_Object_ToString" target="_blank">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.)</td></tr></table>&nbsp;
<a href="#plcfbcommand-methods">Back to Top</a>

## See Also


#### Reference
<a href="T_VortexBase_fbCommand_PlcfbCommand.md">fbCommand.PlcfbCommand Class</a><br /><a href="N_VortexBase.md">VortexBase Namespace</a><br />