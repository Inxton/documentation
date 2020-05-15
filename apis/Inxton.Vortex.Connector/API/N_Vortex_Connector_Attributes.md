# Vortex.Connector.Attributes Namespace
 _**\[This is preliminary documentation and is subject to change.\]**_

\[Missing <summary> documentation for "N:Vortex.Connector.Attributes"\]


## Classes
&nbsp;<table><tr><th></th><th>Class</th><th>Description</th></tr><tr><td>![Public class](media/pubclass.gif "Public class")</td><td><a href="T_Vortex_Connector_Attributes_AssemblyPlcCounterPart.md">AssemblyPlcCounterPart</a></td><td>
Provides meta information about Plc controller types that is linked to respective connector.
&nbsp;<table><tr><th>![Note](media/AlertNote.png) Note</th></tr><tr><td>This attribute is not applicable in framework consumers code. It serves a purpose of providing information about the library metadata.</td></tr></table></td></tr><tr><td>![Public class](media/pubclass.gif "Public class")![Code example](media/CodeExample.png "Code example")</td><td><a href="T_Vortex_Connector_Attributes_CompilerOmitsAttribute.md">CompilerOmitsAttribute</a></td><td>
Prevents vortex builder to create a member for specific group of output type (Shadow, Plain, Onliner).
&nbsp;<table><tr><th>![Note](media/AlertNote.png) Note</th></tr><tr><td>This attribute must be declared in the PLC code to be effective during build process.</td></tr></table>

## Examples
This example demonstrates how to prevent the vortex builder to compile specific property into specific output group. 
```
// This will not compile to 'omitsInPlainString' member into respective 'Plain' type.
{attribute clr [CompilerOmits(CompilerOmissionGroups.BuilderPlainer))]} 
ommitsInPlainString : STRING(50) := 'THIS IS OMMITED IN PLAINER';     
// This will not compile to 'ommitsInPlainAndShadowerInterfaceString' member into respective 'Plain' type and Shadow interface.
{attribute clr [CompilerOmits(CompilerOmissionGroups.BuilderPlainer, CompilerOmissionGroups.BuilderShadowerInterface))]} 
ommitsInPlainAndShadowerInterfaceString : STRING(50) := 'THIS IS OMMITED IN PLAINER';
```</td></tr><tr><td>![Public class](media/pubclass.gif "Public class")![Code example](media/CodeExample.png "Code example")</td><td><a href="T_Vortex_Connector_Attributes_ReadOnlyAttribute.md">ReadOnlyAttribute</a></td><td>
Attribute allows to prevent writing to the members of Vortex connector. 
<a href="T_Vortex_Connector_Attributes_ReadOnlyAttribute.md">ReadOnlyAttribute</a> can be declared for member of a FB, GVL or STRUCT.
&nbsp;<table><tr><th>![Note](media/AlertNote.png) Note</th></tr><tr><td>This attribute is typically defined in the declaration section of PLC block and then trans-piled by Vortex.Builder.</td></tr></table>&nbsp;
&nbsp;<table><tr><th>![Caution](media/AlertCaution.png) Caution</th></tr><tr><td>Use of <a href="T_Vortex_Connector_Attributes_ReadOnlyAttribute.md">ReadOnlyAttribute</a> does not prevent the PLC program to write to the variable that declares this attribute.</td></tr></table>

## Examples
This example demonstrates declaration of <a href="T_Vortex_Connector_Attributes_ReadOnlyAttribute.md">ReadOnlyAttribute</a> on a member of a FB. 
```
FUNCTION_BLOCK fbSomeReadOnlyMembers 
VAR
    {attribute clr [ReadOnly()]]}
    _nonWrittableItem : BOOL;       // Member is readonly for .net application.
    {attribute clr [ReadOnly()]]}
    _nonWrittableFunctionBlock : fbNonWrittable; // Member and its members are readonly for the .net application.
END_VAR
```</td></tr><tr><td>![Public class](media/pubclass.gif "Public class")</td><td><a href="T_Vortex_Connector_Attributes_TypeMetaDescriptorAttribute.md">TypeMetaDescriptorAttribute</a></td><td>
Provides meta information about Plc controller type for the library compilation process.
&nbsp;<table><tr><th>![Note](media/AlertNote.png) Note</th></tr><tr><td>This attribute is not applicable in framework consumers code. It serves a purpose of providing information about the library metadata.</td></tr></table></td></tr></table>

## Enumerations
&nbsp;<table><tr><th></th><th>Enumeration</th><th>Description</th></tr><tr><td>![Public enumeration](media/pubenumeration.gif "Public enumeration")</td><td><a href="T_Vortex_Connector_Attributes_CompilerOmissionGroups.md">CompilerOmissionGroups</a></td><td>
Builder omission groups enumerator. Enumerates builder output groups suitable for the omission.</td></tr></table>&nbsp;
