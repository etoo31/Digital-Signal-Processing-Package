using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSPAlgorithms.DataStructures;

namespace DSPAlgorithms.Algorithms
{
    public class Normalizer : Algorithm
    {
        public Signal InputSignal { get; set; }
        public float InputMinRange { get; set; }
        public float InputMaxRange { get; set; }
        public Signal OutputNormalizedSignal { get; set; }

        public override void Run()
        {
            List<float> temp = new List<float>();
            for (int i = 0; i < InputSignal.Samples.Count(); i++)
            {
                //s_norm = (s - s_min) / (s_max - s_min)
                float mini = InputSignal.Samples.Min();
                float maxi = InputSignal.Samples.Max();
                float val = InputSignal.Samples[i];
                float normalNormalize = (val - mini) / (maxi - mini);
                //t = s_norm * (t_max - t_min) + t_min
                temp.Add(normalNormalize * (InputMaxRange - InputMinRange) + InputMinRange); 
            }
            OutputNormalizedSignal = new Signal(temp, false);
        }
    }
}
