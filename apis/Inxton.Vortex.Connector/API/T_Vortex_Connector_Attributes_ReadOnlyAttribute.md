# ReadOnlyAttribute Class
 _**\[This is preliminary documentation and is subject to change.\]**_

Attribute allows to prevent writing to the members of Vortex connector. 
ReadOnlyAttribute can be declared for member of a FB, GVL or STRUCT.
&nbsp;<table><tr><th>![Note](media/AlertNote.png) Note</th></tr><tr><td>This attribute is typically defined in the declaration section of PLC block and then trans-piled by Vortex.Builder.</td></tr></table>&nbsp;
&nbsp;<table><tr><th>![Caution](media/AlertCaution.png) Caution</th></tr><tr><td>Use of ReadOnlyAttribute does not prevent the PLC program to write to the variable that declares this attribute.</td></tr></table>

## Examples
This example demonstrates declaration of ReadOnlyAttribute on a member of a FB. 
```
FUNCTION_BLOCK fbSomeReadOnlyMembers 
VAR
    {attribute clr [ReadOnly()]]}
    _nonWrittableItem : BOOL;       // Member is readonly for .net application.
    {attribute clr [ReadOnly()]]}
    _nonWrittableFunctionBlock : fbNonWrittable; // Member and its members are readonly for the .net application.
END_VAR
```



## Inheritance Hierarchy
<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;<a href="http://msdn2.microsoft.com/en-us/library/e8kc3626" target="_blank">System.Attribute</a><br />&nbsp;&nbsp;&nbsp;&nbsp;Vortex.Connector.Attributes.ReadOnlyAttribute<br />
**Namespace:**&nbsp;<a href="N_Vortex_Connector_Attributes.md">Vortex.Connector.Attributes</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 0.101.0-alpha.5+Branch.develop.Sha.964441db673232ae7ce236ab6ff4c304c79df7be

## Syntax

**C#**<br />
``` C#
[AttributeUsageAttribute(AttributeTargets.Property)]
public class ReadOnlyAttribute : Attribute
```

The ReadOnlyAttribute type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_Attributes_ReadOnlyAttribute__ctor.md">ReadOnlyAttribute</a></td><td>
Creates new instance of ReadOnlyAttribute</td></tr></table>&nbsp;
<a href="#readonlyattribute-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="http://msdn2.microsoft.com/en-us/library/sa1bf03e" target="_blank">TypeId</a></td><td>
When implemented in a derived class, gets a unique identifier for this <a href="http://msdn2.microsoft.com/en-us/library/e8kc3626" target="_blank">Attribute</a>.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e8kc3626" target="_blank">Attribute</a>.)</td></tr></table>&nbsp;
<a href="#readonlyattribute-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/09ds241w" target="_blank">Equals</a></td><td>
Returns a value that indicates whether this instance is equal to a specified object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e8kc3626" target="_blank">Attribute</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/4k87zsw7" target="_blank">Finalize</a></td><td>
Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/365e1bxs" target="_blank">GetHashCode</a></td><td>
Returns the hash code for this instance.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e8kc3626" target="_blank">Attribute</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/dfwy45w9" target="_blank">GetType</a></td><td>
Gets the <a href="http://msdn2.microsoft.com/en-us/library/42892f65" target="_blank">Type</a> of the current instance.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/tbkb5x6t" target="_blank">IsDefaultAttribute</a></td><td>
When overridden in a derived class, indicates whether the value of this instance is the default value for the derived class.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e8kc3626" target="_blank">Attribute</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/wy7chz44" target="_blank">Match</a></td><td>
When overridden in a derived class, returns a value that indicates whether this instance equals a specified object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e8kc3626" target="_blank">Attribute</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/57ctke0a" target="_blank">MemberwiseClone</a></td><td>
Creates a shallow copy of the current <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="http://msdn2.microsoft.com/en-us/library/7bxwbwt2" target="_blank">ToString</a></td><td>
Returns a string that represents the current object.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">Object</a>.)</td></tr></table>&nbsp;
<a href="#readonlyattribute-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Vortex_Connector_Attributes.md">Vortex.Connector.Attributes Namespace</a><br />