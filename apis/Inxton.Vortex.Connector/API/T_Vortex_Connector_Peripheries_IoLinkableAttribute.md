# IoLinkableAttribute Class
 _**\[This is preliminary documentation and is subject to change.\]**_

Attribute indicates that the member is linkable to the hardware and determines its direction.


## Inheritance Hierarchy
<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />&nbsp;&nbsp;<a href="http://msdn2.microsoft.com/en-us/library/e8kc3626" target="_blank">System.Attribute</a><br />&nbsp;&nbsp;&nbsp;&nbsp;Vortex.Connector.Peripheries.IoLinkableAttribute<br />
**Namespace:**&nbsp;<a href="N_Vortex_Connector_Peripheries.md">Vortex.Connector.Peripheries</a><br />**Assembly:**&nbsp;Vortex.Connector (in Vortex.Connector.dll) Version: 0.101.0-alpha.5+Branch.develop.Sha.964441db673232ae7ce236ab6ff4c304c79df7be

## Syntax

**C#**<br />
``` C#
[AttributeUsageAttribute(AttributeTargets.Property)]
public class IoLinkableAttribute : Attribute
```

The IoLinkableAttribute type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Vortex_Connector_Peripheries_IoLinkableAttribute__ctor.md">IoLinkableAttribute</a></td><td>
Creates new instance of IoLinkableAttribute.</td></tr></table>&nbsp;
<a href="#iolinkableattribute-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Vortex_Connector_Peripheries_IoLinkableAttribute_Direction.md">Direction</a></td><td>
Gets the direction of the member which declares this attribute.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="http://msdn2.microsoft.com/en-us/library/sa1bf03e" target="_blank">TypeId</a></td><td>
When implemented in a derived class, gets a unique identifier for this <a href="http://msdn2.microsoft.com/en-us/library/e8kc3626" target="_blank">Attribute</a>.
 (Inherited from <a href="http://msdn2.microsoft.com/en-us/library/e8kc3626" target="_blank">Attribute</a>.)</td></tr></table>&nbsp;
<a href="#iolinkableattribute-class">Back to Top</a>

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
<a href="#iolinkableattribute-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Vortex_Connector_Peripheries.md">Vortex.Connector.Peripheries Namespace</a><br />