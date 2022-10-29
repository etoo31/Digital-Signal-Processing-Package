using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSPAlgorithms.DataStructures;

namespace DSPAlgorithms.Algorithms
{
    public class Adder : Algorithm
    {
        public List<Signal> InputSignals { get; set; }
        public Signal OutputSignal { get; set; }

        public override void Run()
        {
            Signal sig = InputSignals[0];
            for(int i = 1; i < InputSignals.Count(); i++)
            {
                List<float> temp = new List<float>();
                for (int j = 0; j < sig.Samples.Count();j++)
                {
                    temp.Add(sig.Samples[j] + InputSignals[i].Samples[j]);
                    sig.Samples[j] = sig.Samples[j] + InputSignals[i].Samples[j];
                }
                
            }
            OutputSignal = new Signal(sig.Samples, false);
            //throw new NotImplementedException();
        }
    }
}