using System.Numerics;
using BepInNodeLoader.Core.CoreNodes.Variables.Set;
using BepInNodeLoader.CustomAttributes;

namespace BepInNodeLoader.Core.CoreNodes.Variables.Get
{
    [IsGetVariable]
    public class PrimitiveTypeGet : Node
    {
        [IsArgOut]
        public UnityEngine.PrimitiveType Value { get; set; }

        public override void Execute()
        {
            var setNode = (PrimitiveTypeSet)ModsData.GetNodeById(this.Id);
            Value = setNode.ValueOut;
        }
    }
}
