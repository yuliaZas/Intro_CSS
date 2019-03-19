using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{

    public class FunctionsContainer
    {
        //ממפה בין STRING לפונקציות
        public delegate double func(double value);
        private Dictionary<string, func> funcDictionary;

        public FunctionsContainer()
        {

        }

        public List<string> getAllMissions()
        {
            return this.nameList;
        }
    }
}
