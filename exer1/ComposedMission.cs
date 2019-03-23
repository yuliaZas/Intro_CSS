using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    /* This class stores a concatenation of functions among the functions
     * which are stored in the FunctionsContainer class.
     * To start the task, call the Calculate function.
     */
    public class ComposedMission : IMission
    {
        private string missionName;
        private List<Excercise_1.func> funcList;

        public event EventHandler<double> OnCalculate;
        /*CTOR*/
        public ComposedMission(string v)
        {
            this.missionName = v;
            this.funcList = new List<Excercise_1.func>();
        }
        
        //Getter and Setter.
        public string Name { get; private set; }

        //Return the type of the mission.
        public string Type
        {
            get
            {
                return "Composed";
            }
        }

        /*Returnd the calculated value of the funcs from the whole fun list*/
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

        /*Return this class with the updated list of funcs*/
        public ComposedMission Add(Excercise_1.func func)
        {
            this.funcList.Add(func);
            return this;
        }
    
    }
}
