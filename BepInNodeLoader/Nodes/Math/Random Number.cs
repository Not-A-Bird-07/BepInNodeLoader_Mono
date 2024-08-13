using BepInNodeLoader.Core;
using BepInNodeLoader.CustomAttributes;
using System;
using System.Collections.Generic;

namespace BepInNodeLoader.Nodes.Math
{
    public class Random_Number_Float : Node
    {
        public float First { get; set; }
        public float Second { get; set; }

        [IsArgOut]
        public float Result { get; set; }

        public override void Execute()
        {
            List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
            Result = UnityEngine.Random.Range((float)args[0], (float)args[1]);
        }
    }

    public class Random_Number_Int : Node
    {
        public Int32 First { get; set; }
        public Int32 Second { get; set; }

        [IsArgOut]
        public Int32 Result { get; set; }

        public override void Execute()
        {
            List<object> args = ArgumentsRetriever.GetArgumentsOf(this);
            Result = UnityEngine.Random.Range((Int32)args[0], (Int32)args[1]);
        }
    }
}
