using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace YieldPractice
{
    internal class Car
    {
        public double ModelYear { get; set; }

        public string Maker { get; set; }
        //
        public override string ToString()
        {
            return ModelYear + " " + Maker;
        }
    }
}
