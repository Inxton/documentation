# Twins

## What are *twins*

**Twins** are objects representing PLC program at different levels of hierarchy (Controller, Blocks, primitive/base types).

### [Twin Controller](TwinController.md)

The controller twin is the root object that represents the entry point into a twin representation of a PLC controller. You can think about it as a mirror of the PLC program. The name of such entry class is by convention **'[PlcName]ControllerTwin'**. [More about TwinController.](TwinController.md)

### [Twin object](TwinObjects.md)

Twin object is .net representation of a complex PLC data type (STRUCT, UNION, FB, GVL, PRG). Each of these data structures is represented by a separate class of which name is the same as the name of the respective structure.

Each twin object implements two types of interfaces  *IOnline* interface which exposes members with direct communication ability with the PLC system and IShadow interface with allows for an offline manipulation of object's data.

There is a separate class *Plainer* that is produced during the trans-piling process which is light (POCO like) representation of the same data structure, that can be is used in scenarios involving serialization. [More about Twin Objects](TwinObjects.md)

### [Primitive Twins](../../Inxton.Vortex.Connector/Conceptual/PrimitiveTwins.md)

Primitive twins are special types of objects that represent base types. Each base type has its representation in Inxton.Vortex.Framework. Primitive Twins allows for Read and Write operations of the respective values. They also offer different ways of accessing the values: Cyclic, Synchronous, Batched. [More about Primitive Twins.](../../Inxton.Vortex.Connector/Conceptual/PrimitiveTwins.md)

## Example

From a PLC structure
```
TYPE stSettings :
STRUCT
    {attribute addProperty Name "<#Lights off#>" }
    TurnLightsOff :BOOL;
    {attribute addProperty Name "<#Message for the user#>" }
    DefaultMessage:STRING;
END_STRUCT
END_TYPE
```
Inxton will generate following Twin object.
```C#
public partial class stSettings : Vortex.Connector.IVortexObject, IstSettings, IShadowstSettings, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
{
    public string Symbol
    {
        get;
        protected set;
    }

    public string HumanReadable
    {
        get
        {
            return TweetingPlcTwinController.Translator.Translate(_humanReadable).Interpolate(this);
        }

        protected set
        {
            _humanReadable = value;
        }
    }

    protected string _humanReadable;
    Vortex.Connector.ValueTypes.OnlinerBool _TurnLightsOff;
    public Vortex.Connector.ValueTypes.OnlinerBool TurnLightsOff
    {
        get
        {
            return _TurnLightsOff;
        }
    }

    Vortex.Connector.ValueTypes.Online.IOnlineBool IstSettings.TurnLightsOff
    {
        get
        {
            return TurnLightsOff;
        }
    }

    Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowstSettings.TurnLightsOff
    {
        get
        {
            return TurnLightsOff;
        }
    }

    Vortex.Connector.ValueTypes.OnlinerString _DefaultMessage;
    public Vortex.Connector.ValueTypes.OnlinerString DefaultMessage
    {
        get
        {
            return _DefaultMessage;
        }
    }

    Vortex.Connector.ValueTypes.Online.IOnlineString IstSettings.DefaultMessage
    {
        get
        {
            return DefaultMessage;
        }
    }

    Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowstSettings.DefaultMessage
    {
        get
        {
            return DefaultMessage;
        }
    }
    // etc...
```
In case you want to see the whole file it's here : [link to gist](http://bit.ly/2PLe3dE)
