using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    /* This class stores one of the stored functions in the FunctionsContainer class.
     * You must call the function to start the task Calculate which exists in the class. */
    public class SingleMission : IMission
    {
        private Excercise_1.func function;
        private string mission;

        public event EventHandler<double> OnCalculate;

        //CTOR
        public SingleMission(Excercise_1.func func, string v)
        {
            this.function = func;
            this.mission = v;
        }

        //Getter and Setter.
        public string Name { get; private set; }

        //Return the type of the mission.
        public string Type
        {
            get
            {
                return "Single";
            }
        }

        /*Returnd the calculated value of the func. */
        public double Calculate(double value)
        {
            double retVal = this.function(value);
            this.OnCalculate?.Invoke(this,retVal);
            return retVal;   
        }

    }
}
