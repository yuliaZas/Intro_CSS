using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{

    public class SingleMission : IMission
    {
        private Excercise_1.func function;

        private string mission;

        public event EventHandler<double> OnCalculate;

        public SingleMission(Excercise_1.func func, string v)
        {
            this.function = func;
            this.mission = v;
        }

        public string Name { get; private set; }

        public string Type
        {
            get
            {
                return "Single";
            }
        }

        public double Calculate(double value)
        {
            double retVal = this.function(value);
            this.OnCalculate?.Invoke(this,retVal);
            return retVal;   
        }

    }
}
