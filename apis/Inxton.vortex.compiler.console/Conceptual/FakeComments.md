# Fake commenting attributes

In some instances PLC program modification with changes in attributes that do not have effect on running PLC program (e.g. AddedProperties or clr attributes) can prevent [online change](https://infosys.beckhoff.com/english.php?content=../content/1033/tc3_plc_intro/36028799547005323.html&id=1818083454177464942) of the running program. Read more about TwinCat 3 [online change](https://infosys.beckhoff.com/english.php?content=../content/1033/tc3_plc_intro/36028799547005323.html&id=1818083454177464942);

To circumvent this inconvenience compiler comes with use of *faked comments*. These represent real comments for the PLC, but Inxton compiler will process those statements. *Faked comments* are single line comments. 

To provide **faked comment** simply prefix the attribute with **'//*'** as is shown at example below.

~~~ PASCAL
//* {attribute addProperty Name "This is the blocks name"}

(*Is the same as*)

{attribute addProperty Name "This is the blocks name"}

//* {attribute clr [RenderIgnore()]}
(*Is the same as*)
{attribute clr [ReadOnly()]}
~~~
