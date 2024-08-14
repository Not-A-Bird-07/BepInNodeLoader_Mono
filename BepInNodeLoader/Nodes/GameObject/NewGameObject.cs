using BepInNodeLoader.Core;
using BepInNodeLoader.CustomAttributes;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

namespace BepInNodeLoader.Nodes.GameObject;
public class NewGameObject : Node
{
    [XmlIgnore]
    public UnityEngine.PrimitiveType Primitivetype { get; set; }
    public System.Numerics.Vector3 Pos { get; set; }
    public System.Numerics.Vector3 Rot { get; set; }
    public System.Numerics.Vector3 Scl { get; set; }

    [XmlIgnore]
    [IsArgOut]
    public UnityEngine.GameObject Instantiated { get; set; }

    public override void Execute()
    {
        List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
        UnityEngine.PrimitiveType Primitivetype = (UnityEngine.PrimitiveType)args[0];
        System.Numerics.Vector3 pos = (System.Numerics.Vector3)args[1];
        System.Numerics.Vector3 rot = (System.Numerics.Vector3)args[2];
        System.Numerics.Vector3 scl = (System.Numerics.Vector3)args[3];

        UnityEngine.GameObject go = UnityEngine.GameObject.CreatePrimitive(Primitivetype);
        go.transform.position = new UnityEngine.Vector3(pos.X, pos.Y, pos.Z);
        go.transform.rotation = Quaternion.Euler(new UnityEngine.Vector3(rot.X, rot.Y, rot.Z));
        go.transform.localScale = new UnityEngine.Vector3(scl.X, scl.Y, scl.Z);

        Instantiated = go;
    }
}
