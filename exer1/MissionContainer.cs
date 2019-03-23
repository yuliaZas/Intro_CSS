using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Excercise_1
{
    /*This class contains an indexer, given a function name (string) returns the relevant action*/
    public class FunctionsContainer
    {
        
        private Dictionary<string, Excercise_1.func> funcDictionary;

        /*CTOR*/
        public FunctionsContainer()
        {
            funcDictionary = new Dictionary<string, Excercise_1.func>();
        }

        public Excercise_1.func this[string name]
        {
            // return the value specified by the func name
            get
            {
                //if the func in the dictionary
                if (this.funcDictionary.ContainsKey(name))
                {
                    return funcDictionary[name];
                }
                //else return the value itself
                else
                {
                    return val => val;
                }
            }
            // set the func name
            set
            {
                funcDictionary[name] = value;
            }
        }
        /*Return a list with all the fucns actions from the dictionary*/
        public List<string> getAllMissions()
        {
            List<string> nameList = new List<string>(this.funcDictionary.Keys);
            return nameList;
        }
    }
}