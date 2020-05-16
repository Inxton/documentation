## Ignoring parts of source PLC code

In order to keep the compiler process safe and consistent the vortex.compiler uses a formal grammar description to parse and subsequently emit C# code. Most of the syntactical constructions are supported. However, due to lack of strict formalization and compliance on part of some PLC systems it could happen that an unforeseen syntax rule is used. Such syntactical construction is correct in the PLC environment yet unknown to the vortex.compiler's parser. In such cases the parsing process fails. To workaround this issue an ignore directives can be introduced to prevent the builder from parsing specific parts of code.

~~~ PASCAL
//~
    variable : ARRAY[0..*] OF INT := {1,3,8} // This part of code will be ignored.
//~
~~~