# Documentation blocks (implementation pending)

Types (FB, PRG, ENUMS, etc) and their members can be documented at PLC side and Ixnton helps you to transfer documentation content to the emitted code.

Transferable documentations comments must be enclosed with syntax as indicated in the following example. In addition to that the documentation content mus be placed between documentation tags. Content placed within the documentation tags will then be placed as documentation comments to the emitted code. 

>NOTE: There is no syntax checking and the content is transferred 'as is'.

Example code at PLC side:

~~~ PASCAL
(*~
<docu>
    any content
</docu>
~*)
FUNCTION_BLOCK fbDocumentedBlock
VAR
    (*~
        <docu>
            <summary>this is a member that is documented.</summary>
            <note> this is note to documented member</note>
        </docu>
    ~*)
    documentedMember : BOOL;
    
END_VAR

~~~

The example above will translate

~~~ C#
/// any content
public class fbDocumentedBlock
{
     /// <summary>this is a member that is documented.</summary>
     /// <note> this is note to documented member</note>  
    ...boolean documentedMember {get; set;}
}