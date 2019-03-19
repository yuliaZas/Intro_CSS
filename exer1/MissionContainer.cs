using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{

    public class FunctionsContainer
    {
        public delegate double func(double value);
        private Dictionary<string, func> funcDictionary;

        public FunctionsContainer()
        {
            funcDictionary = new Dictionary<string, func>();
        }
        public func this[string name]
        {
            get
            {
                // return the value specified by index
                return funcDictionary[name];
            }
            set
            {
                // set the value specified by index
                funcDictionary[name] = value;
            }
        }
        public List<string> getAllMissions()
        {
            List<string> nameList = new List<string>(this.funcDictionary.Keys);
            return nameList;
        }
    }
}