# Attributes

## Standard PLC attribute pragmas

Pragma instructions affect the properties of one or more variables regarding the compilation or precompilation process. Please find out more about TwinCAT 3 attribute [pragmas](https://infosys.beckhoff.com/english.php?content=../content/1033/tc3_plc_intro/171136788369635211.html&id=9069166866486725303) or some more information about [pragrmas in general](https://en.wikipedia.org/wiki/Directive_(programming)).

Some of the standard PLC attribute pragmas have influence as well to the Inxton compiler. However, Inxton elevates pragmas to another level by extending pragmas to provide you faster UI development or extending [Twins](Twins.md) by properties that suit your needs.

### Attribute hide

#### Effects of 'hide' attribute

Whenever attribute *hide* is used on a member in the PLC program, such member will not be included in the TwinObject where it is defined.

~~~ PASCAL
{attribute 'hide'}
SomeVar : BOOL;
~~~

### Attribute 'hide_all_locals'

#### Effects of 'hide_all_locals' attribute

Whenever attribute *hide_all_locals* is used on a block in the PLC program, such block will not be included in the compile process and it will be marked as unknown. The compiler will issue a warning when such type is used in other parts of the program.

~~~ PASCAL
{attribute 'hide_all_locals'}
FUNCTION_BLOCK SomeFunctionBlockWithHiddenMembers
~~~

## Extended Attributes

Inxton.Vortex.Framework defines several **Extended Attributes** to enhance description and functional abilities. Extended Attributes have following syntax:

{**attribute** *compile_directive* \[AttributeType(optional_parameters)\]}

* Extended attributes are always closed in curly brackets.
* Attribute definition starts with the 'attribute' keyword.
* 'compile_directive' is an arbitrary sequence of characters directing the compiler that given attribute should be compiled for a given configuration. Default directives are 'clr' and 'wpf'. (directives are settable in _Vortex/vortex_config.json file).
* Attribute type is any type that derives from 'System.Attribute' class.
* Arguments of the attribute can only be .net Value types and System.String type.

### ReadOnlyAttribute

*ReadOnlyAttribute* makes the member and all inner members read-only. **There is no explicit warning about an attempt to write read-only members. The write access is silently ignored**.

~~~ PASCAL

{attribute clr [ReadOnly()]}
AnyVariable : BOOL; (* This variable is readonly *)
{attribute clr [ReadOnly()]}
AnyStructure : stSomeStructure; (* Entire structure is Read only *)
~~~

><b style="color:red">ATTENTION</b>:
<span style="color:red"> Use of ReadOnly attribute does not prevent from writing to variables from the PLC. ReadOnly prevents writing from the PC application only.
</span>

### CompilerOmitsAttribute

~~~ PASCAL
{attribute clr [CompilerOmits(params omitted)]}
~~~

*CompilerOmitsAttribute* makes it possible to prevent a member to be emitted into a specific type of object. When parameters are used consumer can specify for which type of emitted objects member should not be compiled.

| Parameter                 | Description                                                       |
|---------------------------|:----------------------------------------------------------------- |
| BuilderOnliner            | will prevent compiler to compile the member in the Onliner classes|
| BuilderOnlinerInterface   | will prevent compiler to compile the member in the Onliner interfaces|
| BuilderShadowerInterface  | will prevent compiler to compile the member in the Shadow interfaces|
| BuilderPlainer            | will prevent compiler to compile the member in Plainer classed|

~~~ PASCAL
// Member will not appear in Plainer classes
{attribute clr [CompilerOmits("BuilderPlainer")]}
_identity : ULINT;

// Member will not appear Plainer and Onliner classes
{attribute clr [CompilerOmits("BuilderPlainer", "BuilderOnliner")]}
_identity2 : ULINT;
~~~

#### MemberByIdentityAttribute

This is an advanced attribute used for the specific feature of the framework in more advanced scenarios.

MemberByIdentityAttribute allows a property to return a member with a given identity.

Only types that inherit from `fbVortexer` or `stVortexer` (part of VortexBase PLC library) are eligible to be passed by identity all other members will return actual objects without identity search. Objects passed as identities **are required to be defined in GVLs**.

This approach is useful when there is a need to access objects passed as input parameters of a FB but the actual need is to access the member not its copy. This approach can be used with VAR and VAR_IN_OUT.

NOTE: Parameters passed as VAR_OUTPUT are not affected by MemberByIdentityAttribute as they keep a local copy of its own identity.

USAGE

~~~ PASCAL
{attribute clr [MemberByIdentity()]}
AnyVariable : VortexBase.iBOOL;
~~~
