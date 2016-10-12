using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cellular_Automaton
{
    [Serializable]
    public class Rule
    {
        public int ID { get; set; }
        public int priority { get; set; }
        public EquationRule equationRule{ get; set; }
        public GridRule gridRule { get; set; }
        public State finalState { get; set; }
    }

    [Serializable]
    public class EquationRule
    {
        public int numberOfAlive { get; set; }
        public int numberOfDead { get; set; }
        public string opeartorAlive { get; set; }
        public string opeartorDead { get; set; }
    }

    [Serializable]
    public class GridRule
    {
        public bool[,] ruleGrid { get; set; }
        public State neigboursState { get; set; }
    }
}
