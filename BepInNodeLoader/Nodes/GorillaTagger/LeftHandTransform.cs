using BepInNodeLoader.Core;
using BepInNodeLoader.CustomAttributes;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BepInNodeLoader.Nodes.GorillaTagger;

public class LeftHandTransform : Node
{
    [XmlIgnore]
    [IsArgOut]
    public UnityEngine.Transform Transform { get; set; }

    public override void Execute()
    {
        Transform = TaggerHelper.Tagger.leftHandTransform;
    }
}


