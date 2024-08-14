using BepInNodeLoader.CustomAttributes;
using System.Collections.Generic;

namespace BepInNodeLoader.Core.CoreNodes.Variables.Set
{
    public class PrimitiveTypeSet : Node
    {
        public UnityEngine.PrimitiveType ValueIn { get; set; }

        [IsArgOut]
        public UnityEngine.PrimitiveType ValueOut { get; set; }

        public override void Execute()
        {
            List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
            ValueOut = (UnityEngine.PrimitiveType)args[0];
            ModsData.ReplaceIdNodePair(ModsData.IdNodePair, this.Id, this.Id, this);
        }
    }
}
