# fbCommand ClassfbCommand is partially extended.

Provides a coordination mechanism for arbitrary logic execution that can be invoked from HMI. Use of the command can be journaled by the journaling system when implemented.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">System.Object</a><br />&nbsp;&nbsp;<a href="T_VortexBase_fbVortexer.md">VortexBase.fbVortexer</a><br />&nbsp;&nbsp;&nbsp;&nbsp;VortexBase.fbCommand<br />
**Namespace:**&nbsp;<a href="N_VortexBase.md">VortexBase</a><br />**Assembly:**&nbsp;VortexBaseConnector (in VortexBaseConnector.dll) Version: 0.101.0-dotnetcore.38+Branch.feature/dotnetcore.Sha.9184ded7250ef900bfdd1d83b2841836087bcfce

## Syntax

**C#**<br />
``` C#
public class fbCommand : fbVortexer, ICommand, 
	IVortexObject, ITwinObject, IVortexElement, IVortexOnlineObject, IVortexShadowObject
```

The fbCommand type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_VortexBase_fbCommand__ctor.md">fbCommand()</a></td><td>
Initializes a new instance of the fbCommand class</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_VortexBase_fbCommand__ctor_1.md">fbCommand(IVortexObject, String, String)</a></td><td>
Initializes a new instance of the fbCommand class</td></tr></table>&nbsp;
<a href="#fbcommand-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_VortexBase_fbCommand__Complete.md">_Complete</a></td><td>
When set to command will be completed.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_VortexBase_fbCommand__Disabled.md">_Disabled</a></td><td>
When set to true command can not be triggered.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_VortexBase_fbCommand__Invoke.md">_Invoke</a></td><td>
When set to true method 'Monitor' and 'MonitorWithTimeOut' will return true;</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_VortexBase_fbVortexer__messenger.md">_messenger</a></td><td>
Provides messager for this instance.
 (Inherited from <a href="T_VortexBase_fbVortexer.md">fbVortexer</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_VortexBase_fbVortexer_Analyzer.md">Analyzer</a></td><td> (Inherited from <a href="T_VortexBase_fbVortexer.md">fbVortexer</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_VortexBase_fbVortexer_App.md">App</a></td><td>
Gets the application this with this object belongs.
 (Inherited from <a href="T_VortexBase_fbVortexer.md">fbVortexer</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_VortexBase_fbVortexer_AttributeName.md">AttributeName</a></td><td> (Inherited from <a href="T_VortexBase_fbVortexer.md">fbVortexer</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_VortexBase_fbVortexer_AttributeToolTip.md">AttributeToolTip</a></td><td> (Inherited from <a href="T_VortexBase_fbVortexer.md">fbVortexer</a>.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td><a href="P_VortexBase_fbVortexer_Connector.md">Connector</a></td><td> (Inherited from <a href="T_VortexBase_fbVortexer.md">fbVortexer</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_VortexBase_fbVortexer_HumanReadable.md">HumanReadable</a></td><td> (Inherited from <a href="T_VortexBase_fbVortexer.md">fbVortexer</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_VortexBase_fbVortexer_Identity.md">Identity</a></td><td>
Unique identity of this instance.
 (Inherited from <a href="T_VortexBase_fbVortexer.md">fbVortexer</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_VortexBase_fbVortexer_Mime.md">Mime</a></td><td>
Gets most important message holder of this <a href="T_VortexBase_fbVortexer.md">fbVortexer</a>.
 (Inherited from <a href="T_VortexBase_fbVortexer.md">fbVortexer</a>.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td><a href="P_VortexBase_fbVortexer_Parent.md">Parent</a></td><td> (Inherited from <a href="T_VortexBase_fbVortexer.md">fbVortexer</a>.)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_VortexBase_fbCommand_ResetCommand.md">ResetCommand</a></td><td>
Aborts the execution of the this fbCommand.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_VortexBase_fbVortexer_Symbol.md">Symbol</a></td><td> (Inherited from <a href="T_VortexBase_fbVortexer.md">fbVortexer</a>.)</td></tr><tr><td>![Protected property](media/protproperty.gif "Protected property")</td><td><a href="P_VortexBase_fbVortexer_SymbolTail.md">SymbolTail</a></td><td> (Inherited from <a href="T_VortexBase_fbVortexer.md">fbVortexer</a>.)</td></tr></table>&nbsp;
<a href="#fbcommand-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_VortexBase_fbVortexer_AddChild.md">AddChild</a></td><td> (Inherited from <a href="T_VortexBase_fbVortexer.md">fbVortexer</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_VortexBase_fbVortexer_AddValueTag.md">AddValueTag</a></td><td> (Inherited from <a href="T_VortexBase_fbVortexer.md">fbVortexer</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_VortexBase_fbCommand_CanExecute.md">CanExecute</a></td><td> **Obsolete. **
Returns always true. If necessary to prevent the execution this command use <a href="F_VortexBase_fbCommand_PreCommandExecution.md">PreCommandExecution</a> delegate.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_VortexBase_fbCommand_CopyPlainToShadow.md">CopyPlainToShadow(PlainfbCommand)</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_VortexBase_fbVortexer_CopyPlainToShadow.md">CopyPlainToShadow(PlainfbVortexer)</a></td><td> (Inherited from <a href="T_VortexBase_fbVortexer.md">fbVortexer</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_VortexBase_fbCommand_CreatePlainerType.md">CreatePlainerType()</a></td><td /></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_VortexBase_fbCommand_CreatePlainerType_1.md">CreatePlainerType(PlainfbCommand)</a></td><td /></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_VortexBase_fbVortexer_CreatePlainerType_1.md">CreatePlainerType(PlainfbVortexer)</a></td><td> (Inherited from <a href="T_VortexBase_fbVortexer.md">fbVortexer</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.object.equals#System_Object_Equals_System_Object_" target="_blank">Equals</a></td><td>
Determines whether the specified object is equal to the current object.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_VortexBase_fbCommand_Execute.md">Execute</a></td><td>
Executes the fbCommand. When <a href="F_VortexBase_fbCommand_PreCommandExecution.md">PreCommandExecution</a> is not assigned or returns 'true'. fbCommand monitored in the controller will start execution of the associated logic.</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.object.finalize#System_Object_Finalize" target="_blank">Finalize</a></td><td>
Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_VortexBase_fbCommand_FlushOnlineToPlain.md">FlushOnlineToPlain(PlainfbCommand)</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_VortexBase_fbVortexer_FlushOnlineToPlain.md">FlushOnlineToPlain(PlainfbVortexer)</a></td><td> (Inherited from <a href="T_VortexBase_fbVortexer.md">fbVortexer</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_VortexBase_fbCommand_FlushOnlineToShadow.md">FlushOnlineToShadow</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_VortexBase_fbCommand_FlushPlainToOnline.md">FlushPlainToOnline(PlainfbCommand)</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_VortexBase_fbVortexer_FlushPlainToOnline.md">FlushPlainToOnline(PlainfbVortexer)</a></td><td> (Inherited from <a href="T_VortexBase_fbVortexer.md">fbVortexer</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_VortexBase_fbCommand_FlushShadowToOnline.md">FlushShadowToOnline</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_VortexBase_fbVortexer_GetChildren.md">GetChildren</a></td><td> (Inherited from <a href="T_VortexBase_fbVortexer.md">fbVortexer</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_VortexBase_fbVortexer_GetConnector.md">GetConnector</a></td><td> (Inherited from <a href="T_VortexBase_fbVortexer.md">fbVortexer</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.object.gethashcode#System_Object_GetHashCode" target="_blank">GetHashCode</a></td><td>
Serves as the default hash function.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_VortexBase_fbVortexer_GetParent.md">GetParent</a></td><td> (Inherited from <a href="T_VortexBase_fbVortexer.md">fbVortexer</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_VortexBase_fbVortexer_GetSymbolTail.md">GetSymbolTail</a></td><td> (Inherited from <a href="T_VortexBase_fbVortexer.md">fbVortexer</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.object.gettype#System_Object_GetType" target="_blank">GetType</a></td><td>
Gets the <a href="https://docs.microsoft.com/dotnet/api/system.type" target="_blank">Type</a> of the current instance.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_VortexBase_fbVortexer_GetValueTags.md">GetValueTags</a></td><td> (Inherited from <a href="T_VortexBase_fbVortexer.md">fbVortexer</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_VortexBase_fbCommand_LazyOnlineToShadow.md">LazyOnlineToShadow</a></td><td /></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_VortexBase_fbCommand_LazyShadowToOnline.md">LazyShadowToOnline</a></td><td /></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.object.memberwiseclone#System_Object_MemberwiseClone" target="_blank">MemberwiseClone</a></td><td>
Creates a shallow copy of the current <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="https://docs.microsoft.com/dotnet/api/system.object.tostring#System_Object_ToString" target="_blank">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_blank">Object</a>.)</td></tr></table>&nbsp;
<a href="#fbcommand-class">Back to Top</a>

## Events
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td><a href="E_VortexBase_fbCommand_CanExecuteChanged.md">CanExecuteChanged</a></td><td> **Obsolete. **
Present to meet the interface contract it has no effect on function of this class.</td></tr></table>&nbsp;
<a href="#fbcommand-class">Back to Top</a>

## Fields
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Protected field](media/protfield.gif "Protected field")</td><td><a href="F_VortexBase_fbVortexer__humanReadable.md">_humanReadable</a></td><td> (Inherited from <a href="T_VortexBase_fbVortexer.md">fbVortexer</a>.)</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")</td><td><a href="F_VortexBase_fbCommand_PreCommandExecution.md">PreCommandExecution</a></td><td>
Allows or prevents the execution of the command based on return from the delegate. If delegate is not assigned the execution will be allowed by default. When the delegate is assigned it must return 'true' to be executed. <a href="F_VortexBase_fbCommand_PreCommandExecution.md">PreCommandExecution</a> can execute arbitrary logic such as dialogue window, information for the user about the execution of the command, etc.</td></tr></table>&nbsp;
<a href="#fbcommand-class">Back to Top</a>

## Extension Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_VortexBase_Extensions_IVortexObjectExtensions_GetParentOfType__1.md">GetParentOfType(T)</a></td><td>
Searches recursively the parents of this IVortexObject until encounters object of given type. When the root object IConnector is hit climbing up the hierarchy the method returns pre-existing parent.
 (Defined by <a href="T_VortexBase_Extensions_IVortexObjectExtensions.md">IVortexObjectExtensions</a>.)</td></tr></table>&nbsp;
<a href="#fbcommand-class">Back to Top</a>

## See Also


#### Reference
<a href="N_VortexBase.md">VortexBase Namespace</a><br /><a href="T_VortexBase_fbCommand_PlcfbCommand.md">VortexBase.fbCommand.PlcfbCommand</a><br />