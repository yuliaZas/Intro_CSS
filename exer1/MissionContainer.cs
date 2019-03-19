using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Excercise_1
{

    public class FunctionsContainer
    {

        
        private Dictionary<string, Excercise_1.func> funcDictionary;

        public FunctionsContainer()
        {
            funcDictionary = new Dictionary<string, Excercise_1.func>();
        }
        public Excercise_1.func this[string name]
        {
            get
            {
                // return the value specified by index
                if (this.funcDictionary.ContainsKey(name))
                {
                    return funcDictionary[name];
                }
                else
                {
                    return val => val;
                }
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