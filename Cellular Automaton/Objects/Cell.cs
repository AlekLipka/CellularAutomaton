using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cellular_Automaton
{
    [Serializable]
    public class Cell
    {
        public State state { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public Color color { get; set; }

        public void ApplyRule()
        {
            bool ruleAccepted = false;
            List<Rule> list = GUI.mainVisualization.ruleList;
            List<Rule> acceptedRules = new List<Rule>();
            switch (GUI.mainVisualization.mode)
            {
                case "Priority":
                    list = GUI.mainVisualization.ruleList.OrderBy(o => o.priority).ToList();
                    break;
                case "Random":
                    break;
                case "List":
                    list = GUI.mainVisualization.ruleList.OrderBy(o => o.ID).ToList();
                    break;
            }
            foreach (var rule in list)
            {

                if (rule.gridRule == null)
                {
                    int alive = 0;
                    int dead = 0;
                    for (int yy = -2; yy < 3; yy++)
                    {
                        for (int xx = -2; xx < 3; xx++)
                        {
                            if (GUI.mainVisualization.grid.cellList[x + xx, y + yy].state == State.Dead)
                                dead++;
                            if (GUI.mainVisualization.grid.cellList[x + xx, y + yy].state == State.Alive)
                                alive++;
                        }
                    }
                    bool ruleAcceptedA = false;
                    bool ruleAcceptedB = false;
                    switch (rule.equationRule.opeartorAlive)
                    {
                        case "=":
                            if (alive == rule.equationRule.numberOfAlive)
                                ruleAcceptedA = true;
                            break;
                        case ">=":
                            if (alive >= rule.equationRule.numberOfAlive)
                                ruleAcceptedA = true;
                            break;
                        case "<=":
                            if (alive <= rule.equationRule.numberOfAlive)
                                ruleAcceptedA = true;
                            break;
                        case "!=":
                            if (alive != rule.equationRule.numberOfAlive)
                                ruleAcceptedA = true;
                            break;
                        default:
                            ruleAcceptedA = true;
                            break;
                    }
                    switch (rule.equationRule.opeartorDead)
                    {
                        case "=":
                            if (dead == rule.equationRule.numberOfDead)
                                ruleAcceptedB = true;
                            break;
                        case ">=":
                            if (dead >= rule.equationRule.numberOfDead)
                                ruleAcceptedB = true;
                            break;
                        case "<=":
                            if (dead <= rule.equationRule.numberOfDead)
                                ruleAcceptedB = true;
                            break;
                        case "!=":
                            if (dead != rule.equationRule.numberOfDead)
                                ruleAcceptedB = true;
                            break;
                        default:
                            ruleAcceptedB = true;
                            break;
                    }
                    if (ruleAcceptedA && ruleAcceptedB)
                    {
                        ruleAccepted = true;
                    }
                }
                else
                {
                    ruleAccepted = false;
                    for (int yy = -2; yy < 3; yy++)
                    {
                        for (int xx = -2; xx < 3; xx++)
                        {
                            if (rule.gridRule.ruleGrid[xx + 2, yy + 2])
                                if (GUI.mainVisualization.grid.cellList[x + xx, y + yy].state !=
                                    rule.gridRule.neigboursState)
                                    goto lastStep;
                        }
                    }
                    ruleAccepted = true;
                }
       lastStep:if (ruleAccepted)
                {
                    if (GUI.mainVisualization.mode == "Priority" || GUI.mainVisualization.mode == "List")
                    {
                        if (rule.finalState != GUI.mainVisualization.grid.cellList[x, y].state)
                        {
                            GUI.mainVisualization.mainGrid.cellList[x - 2, y - 2].state = rule.finalState;
                            if (rule.finalState == State.Alive)
                                GUI.mainVisualization.mainGrid.cellList[x - 2, y - 2].color = GUI.colorAlive;
                            if (rule.finalState == State.Dead)
                                GUI.mainVisualization.mainGrid.cellList[x - 2, y - 2].color = GUI.colorDead;
                            return;
                        }
                    }
                    else
                    {
                        if (rule.finalState != GUI.mainVisualization.grid.cellList[x, y].state)
                        {
                            acceptedRules.Add(rule);
                        }
                    }
                }

            }
            if (GUI.mainVisualization.mode == "Random" && acceptedRules.Count != 0)
            {
                Random rand = new Random();
                int g = rand.Next(0, acceptedRules.Count);
                GUI.mainVisualization.mainGrid.cellList[x - 2, y - 2].state = acceptedRules.ElementAt(g).finalState;
                if (acceptedRules.ElementAt(g).finalState == State.Alive)
                    GUI.mainVisualization.mainGrid.cellList[x - 2, y - 2].color = GUI.colorAlive;
                if (acceptedRules.ElementAt(g).finalState == State.Dead)
                    GUI.mainVisualization.mainGrid.cellList[x - 2, y - 2].color = GUI.colorDead;
                return;
            }

        }
    }
}
