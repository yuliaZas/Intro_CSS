using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        private string missionName;
        private List<Excercise_1.func> funcList;

        public event EventHandler<double> OnCalculate;

        public ComposedMission(string v)
        {
            this.missionName = v;
            this.funcList = new List<Excercise_1.func>();
        }

        public string Name { get; private set; }

        public string Type
        {
            get
            {
                return "Composed";
            }
        }

        public double Calculate(double value)
        {
            double val=value;
            foreach (var f in funcList)
            {
                val = f(val);
            }
            
            this.OnCalculate?.Invoke(this, val);
            return val;
        }

        public ComposedMission Add(Excercise_1.func func)
        {
            this.funcList.Add(func);
            return this;
        }
    
    }
}
