#### Added properties ####

Added property allow you to add a property to C# code using attribute declaration inside PLC code. Added properties are emitted into C# code via ***addProperty*** directive. The property will trans-pile with "Attribute" prefix (e.g. 'Name' => AttributeName). The type of the property is inferred from the assigned value. The addProperty can be set in the definition of PRG, FB, GVL, STRUCT. The value of the added property is assigned above the member declaration using the same syntax. Inxton allows you to assign multiple added properties to one member.

>NOTE: When there is a added property assigned but it does not exists in the member's definition the assignment will be ignored as the the property is not existing.

Added property declaration:

~~~ PASCAL
// Declares property 'AttributeName' assigning the default string value of "Some function block"
{attribute addProperty Name "<#Some function block#>"}
// Declares property 'AttributeCount' assigning default integer value of 1
{attribute addProperty Count 1}
FUNCTION_BLOCK SomeFunctionBlock
.
.
.

// Added property usage
FUNCTION_BLOCK SomeOtherFunctionBlock
VAR
    // Assigns to property 'AttributeName' value of "This is an instance of some function block"
    {attribute addProperty Name "<#Some function block#>"}
 
    // Assigns to property 'AttributeName' value of 'Important counter'
    {attribute addProperty Name "Important counter"}
    // Assigns to property 'AttributeCount' value of 123
    {attribute addProperty Count 123}
    instanceOfSomeFunctionBlock : SomeFunctionBlock
END_VAR
~~~

Possible use of added properties at WPF side:

~~~ C#
<label Content="{Binding instanceOfSomeFunctionBlock.AttributeName">
~~~

or at C# side:

~~~ C#
var myLocalCount = instanceOfSomeFunctionBlock.AttributeCount;
~~~

>NOTE: For demonstration purposes, mapping of DataContext is omited.
