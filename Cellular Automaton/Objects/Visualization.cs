using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Cellular_Automaton
{
    public class Visualization
    {
        public int Step { get; set; }
        public Grid grid { get; set; }
        public List<Rule> ruleList { get; set; }
        public Grid mainGrid { get; set; }
        public string mode { get; set; }

        public void GridVisualization()
        {
            try
            {
                grid = new Grid();
                grid.Width = mainGrid.Width + 4;
                grid.Height = mainGrid.Height + 4;
                grid.GenerateCells();
                for (int y = 0; y < mainGrid.Height; y++)
                    for (int x = 0; x < mainGrid.Width; x++)
                    {
                        grid.cellList[x + 2, y + 2].state = mainGrid.cellList[x, y].state;
                        grid.cellList[x + 2, y + 2].color = mainGrid.cellList[x, y].color;
                    }

                for (int y = 2; y < grid.Height - 2; y++)
                {
                    for (int x = 2; x < grid.Width - 2; x++)
                    {
                        grid.cellList[x, y].ApplyRule();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void AddRule(Rule rule)
        {
            ruleList.Add(rule);
        }

        public bool checkContradictions(Rule newRule)
        {
            #region Contradictions

            if (newRule.gridRule == null)
            {
                //Contradiction with Alive+Dead>24 (when (alive = | dead =) || (alive >= | dead =) || (alive = | dead >=))
                if ((newRule.equationRule.opeartorAlive == newRule.equationRule.opeartorDead ||
                     (newRule.equationRule.opeartorAlive == ">=" && newRule.equationRule.opeartorDead == "=") ||
                     newRule.equationRule.opeartorAlive == "=" && newRule.equationRule.opeartorDead == ">=") &&
                    newRule.equationRule.numberOfAlive + newRule.equationRule.numberOfDead > 24)
                {
                    Console.WriteLine("Entered rule with Dead+Alive>24");
                    return false;
                }

                //Contradiction with = and !=
                if (newRule.equationRule.opeartorAlive == "=" && newRule.equationRule.opeartorDead == "!=" &&
                    (newRule.equationRule.numberOfAlive == 24 - newRule.equationRule.numberOfDead ||
                     24 - newRule.equationRule.numberOfAlive == newRule.equationRule.numberOfDead))
                {
                    Console.WriteLine("Rule contradiction (Dead != n) and (Alive = 24-n)");
                    return false;
                }

                //Contradiction with != and =
                if (newRule.equationRule.opeartorAlive == "!=" && newRule.equationRule.opeartorDead == "=" &&
                    (newRule.equationRule.numberOfAlive == 24 - newRule.equationRule.numberOfDead ||
                     24 - newRule.equationRule.numberOfAlive == newRule.equationRule.numberOfDead))
                {
                    Console.WriteLine("Rule contradiction (Dead = n) and (Alive != 24-n)");
                    return false;
                }

                //Contradiction with >= and <=
                if (newRule.equationRule.opeartorAlive == ">=" && newRule.equationRule.opeartorDead == "<=" &&
                    (newRule.equationRule.numberOfAlive == 25 - newRule.equationRule.numberOfDead ||
                     25 - newRule.equationRule.numberOfAlive == newRule.equationRule.numberOfDead))
                {
                    Console.WriteLine("Rule contradiction (Dead <= n) and (Alive >= 25-n)");
                    return false;
                }

                //Contradiction with <= and >=
                if (newRule.equationRule.opeartorAlive == "<=" && newRule.equationRule.opeartorDead == ">=" &&
                    (newRule.equationRule.numberOfAlive == 25 - newRule.equationRule.numberOfDead ||
                     25 - newRule.equationRule.numberOfAlive == newRule.equationRule.numberOfDead))
                {
                    Console.WriteLine("Rule contradiction (Dead >= n) and (Alive <= 25-n)");
                    return false;
                }

                //Contradiction with >= and =
                if (newRule.equationRule.opeartorAlive == ">=" && newRule.equationRule.opeartorDead == "=" &&
                    (newRule.equationRule.numberOfAlive == 25 - newRule.equationRule.numberOfDead ||
                     25 - newRule.equationRule.numberOfAlive == newRule.equationRule.numberOfDead))
                {
                    Console.WriteLine("Rule contradiction (Dead = n) and (Alive >= 25-n)");
                    return false;
                }
            }


            #endregion

            #region RulesInTheRuleListCheck
            bool toBeDisposed = false;

            foreach (var rule in ruleList)
            {
                if (newRule.gridRule == null)
                {
                    if (rule.gridRule == null)
                    {
                        //Same rules
                        if (rule.equationRule.opeartorDead == newRule.equationRule.opeartorDead &&
                            rule.equationRule.opeartorAlive == newRule.equationRule.opeartorAlive &&
                            rule.equationRule.numberOfAlive == newRule.equationRule.numberOfAlive &&
                            rule.equationRule.numberOfDead == newRule.equationRule.numberOfDead)
                        {
                            toBeDisposed = true;
                        }

                        //For dead
                        //Contradiction with = and !=
                        if (newRule.equationRule.opeartorDead == "=" && rule.equationRule.opeartorDead == "!=" &&
                            (rule.equationRule.numberOfDead == 24 - newRule.equationRule.numberOfDead ||
                             24 - rule.equationRule.numberOfDead == newRule.equationRule.numberOfDead))
                        {
                            toBeDisposed = true;
                        }
                        //Contradiction with != and =
                        if (newRule.equationRule.opeartorDead == "!=" && rule.equationRule.opeartorDead == "=" &&
                            (rule.equationRule.numberOfDead == 24 - newRule.equationRule.numberOfDead ||
                             24 - rule.equationRule.numberOfDead == newRule.equationRule.numberOfDead))
                        {
                            toBeDisposed = true;
                        }
                        //Contradiction with >= and =
                        if (newRule.equationRule.opeartorDead == ">=" && rule.equationRule.opeartorDead == "=" &&
                            (rule.equationRule.numberOfDead == 25 - newRule.equationRule.numberOfDead ||
                             25 - rule.equationRule.numberOfDead == newRule.equationRule.numberOfDead))
                        {
                            toBeDisposed = true;
                        }
                        //Contradiction with = and >=
                        if (newRule.equationRule.opeartorDead == "=" && rule.equationRule.opeartorDead == ">=" &&
                            (rule.equationRule.numberOfDead == 25 - newRule.equationRule.numberOfDead ||
                             25 - rule.equationRule.numberOfDead == newRule.equationRule.numberOfDead))
                        {
                            toBeDisposed = true;
                        }
                        //Contradiction with >= and <=
                        if (newRule.equationRule.opeartorDead == ">=" && rule.equationRule.opeartorDead == "<=" &&
                            (rule.equationRule.numberOfDead == 25 - newRule.equationRule.numberOfDead ||
                             25 - rule.equationRule.numberOfDead == newRule.equationRule.numberOfDead))
                        {
                            toBeDisposed = true;
                        }
                        //Contradiction with <= and >=
                        if (newRule.equationRule.opeartorDead == "<=" && rule.equationRule.opeartorDead == ">=" &&
                            (rule.equationRule.numberOfDead == 25 - newRule.equationRule.numberOfDead ||
                             25 - rule.equationRule.numberOfDead == newRule.equationRule.numberOfDead))
                        {
                            toBeDisposed = true;
                        }

                        //For alive
                        //Contradiction with = and !=
                        if (newRule.equationRule.opeartorAlive == "=" && rule.equationRule.opeartorAlive == "!=" &&
                            (rule.equationRule.numberOfAlive == 24 - newRule.equationRule.numberOfAlive ||
                             24 - rule.equationRule.numberOfAlive == newRule.equationRule.numberOfAlive))
                        {
                            toBeDisposed = true;
                        }
                        //Contradiction with != and =
                        if (newRule.equationRule.opeartorAlive == "!=" && rule.equationRule.opeartorAlive == "=" &&
                            (rule.equationRule.numberOfAlive == 24 - newRule.equationRule.numberOfAlive ||
                             24 - rule.equationRule.numberOfAlive == newRule.equationRule.numberOfAlive))
                        {
                            toBeDisposed = true;
                        }
                        //Contradiction with >= and =
                        if (newRule.equationRule.opeartorAlive == ">=" && rule.equationRule.opeartorAlive == "=" &&
                            (rule.equationRule.numberOfAlive == 25 - newRule.equationRule.numberOfAlive ||
                             25 - rule.equationRule.numberOfAlive == newRule.equationRule.numberOfAlive))
                        {
                            toBeDisposed = true;
                        }
                        //Contradiction with = and >=
                        if (newRule.equationRule.opeartorAlive == "=" && rule.equationRule.opeartorAlive == ">=" &&
                            (rule.equationRule.numberOfAlive == 25 - newRule.equationRule.numberOfAlive ||
                             25 - rule.equationRule.numberOfAlive == newRule.equationRule.numberOfAlive))
                        {
                            toBeDisposed = true;
                        }
                        //Contradiction with >= and <=
                        if (newRule.equationRule.opeartorAlive == ">=" && rule.equationRule.opeartorAlive == "<=" &&
                            (rule.equationRule.numberOfAlive == 25 - newRule.equationRule.numberOfAlive ||
                             25 - rule.equationRule.numberOfAlive == newRule.equationRule.numberOfAlive))
                        {
                            toBeDisposed = true;
                        }
                        //Contradiction with <= and >=
                        if (newRule.equationRule.opeartorAlive == "<=" && rule.equationRule.opeartorAlive == ">=" &&
                            (rule.equationRule.numberOfAlive == 25 - newRule.equationRule.numberOfAlive ||
                             25 - rule.equationRule.numberOfAlive == newRule.equationRule.numberOfAlive))
                        {
                            toBeDisposed = true;
                        }

                        //For mutual
                        //Contradiction with = and !=
                        if (newRule.equationRule.opeartorAlive == "=" && rule.equationRule.opeartorDead == "!=" &&
                            (newRule.equationRule.numberOfAlive == 24 - rule.equationRule.numberOfDead ||
                             24 - newRule.equationRule.numberOfAlive == rule.equationRule.numberOfDead))
                        {
                            toBeDisposed = true;
                        }
                        //Contradiction with != and =
                        if (newRule.equationRule.opeartorAlive == "!=" && rule.equationRule.opeartorDead == "=" &&
                            (newRule.equationRule.numberOfAlive == 24 - rule.equationRule.numberOfDead ||
                             24 - newRule.equationRule.numberOfAlive == rule.equationRule.numberOfDead))
                        {
                            toBeDisposed = true;
                        }
                        //Contradiction with >= and =
                        if (newRule.equationRule.opeartorAlive == ">=" && rule.equationRule.opeartorDead == "=" &&
                            (newRule.equationRule.numberOfAlive == 25 - rule.equationRule.numberOfDead ||
                             25 - newRule.equationRule.numberOfAlive == rule.equationRule.numberOfDead))
                        {
                            toBeDisposed = true;
                        }
                        //Contradiction with = and >=
                        if (newRule.equationRule.opeartorAlive == "=" && rule.equationRule.opeartorDead == ">=" &&
                            (newRule.equationRule.numberOfAlive == 25 - rule.equationRule.numberOfDead ||
                             25 - newRule.equationRule.numberOfAlive == rule.equationRule.numberOfDead))
                        {
                            toBeDisposed = true;
                        }
                        //Contradiction with >= and <=
                        if (newRule.equationRule.opeartorAlive == ">=" && rule.equationRule.opeartorDead == "<=" &&
                            (newRule.equationRule.numberOfAlive == 25 - rule.equationRule.numberOfDead ||
                             25 - newRule.equationRule.numberOfAlive == rule.equationRule.numberOfDead))
                        {
                            toBeDisposed = true;
                        }
                        //Contradiction with <= and >=
                        if (newRule.equationRule.opeartorAlive == "<=" && rule.equationRule.opeartorDead == ">=" &&
                            (newRule.equationRule.numberOfAlive == 25 - rule.equationRule.numberOfDead ||
                             25 - newRule.equationRule.numberOfAlive == rule.equationRule.numberOfDead))
                        {
                            toBeDisposed = true;
                        }
                    }

                }
                else
                {
                    if (rule.gridRule != null)
                    {
                        int count = 0;
                        //Same rule checking - the same grids
                        for (int y = 0; y < 5; y++)
                        {
                            for (int x = 0; x < 5; x++)
                            {
                                if (rule.gridRule.ruleGrid[x, y] == newRule.gridRule.ruleGrid[x, y])
                                {
                                    count ++;
                                }
                            }  
                        }
                        if (count == 25)
                        {
                            toBeDisposed = true;
                            goto aaa;
                        }
                        else
                        {
                            count = 0;
                        }
                        //Opposite grids with opposite states
                        if ((rule.gridRule.neigboursState == State.Alive &&
                             newRule.gridRule.neigboursState == State.Dead) ||
                            (rule.gridRule.neigboursState == State.Dead &&
                             newRule.gridRule.neigboursState == State.Alive))
                        {
                            for (int y = 0; y < 5; y++)
                            {
                                for (int x = 0; x < 5; x++)
                                {
                                    if (rule.gridRule.ruleGrid[x, y] != newRule.gridRule.ruleGrid[x, y])
                                    {
                                        count++;
                                    }
                                }
                            }
                            if (count == 24)
                            {
                                toBeDisposed = true;
                                goto aaa;
                            }
                            else
                            {
                                count = 0;
                            }
                        }
                    }
                }
            aaa:if (toBeDisposed)
                {
                    Console.WriteLine("Entered the same rule or there is contradiction with the existing one!");
                    if (newRule.priority > rule.priority)
                    {
                        Console.WriteLine("Swapping old rule with new rule: bigger priority");
                        DisposeRule(rule);
                        return true;
                    }
                    else
                        return false;
                }
            }
            #endregion
            return true;
        }

        public void DisposeRule(Rule rule)
        {
            ruleList.Remove(rule);
        }

        public void Clear()
        {
            Step = 1;
            mainGrid = null;
            grid = null;
            mode = null;
            if (ruleList != null)
                ruleList.Clear();
            ruleList = null;
        }

        public void DeleteRule(int position)
        {
            ruleList.RemoveAt(position);
        }

        public void SaveToFile(string filePath)
        {
            if (ruleList.Count != 0 || mainGrid != null)
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                int Width = 0;
                int Height = 0;
                if (mainGrid != null)
                {
                    Width = mainGrid.Width;
                    Height = mainGrid.Height;
                }
                writer.Write(Width);
                writer.WriteLine(" " + Height);
                for (int y = 0; y < Height; y++)
                {
                    for (int x = 0; x < Width; x++)
                    {
                        if(mainGrid.cellList[x,y].state == State.Dead)
                            writer.Write("0 ");
                        else if (mainGrid.cellList[x,y].state == State.Alive)
                            writer.Write("1 ");
                        else
                            writer.Write("2 ");
                    }
                    writer.WriteLine();
                }
                int count = 0;
                foreach (var rule in ruleList)
                {
                    if (rule.equationRule != null)
                    {
                        if (rule.equationRule.opeartorAlive != "" && rule.equationRule.opeartorDead != "")
                            count++;
                        if (rule.equationRule.opeartorDead == "!=")
                            count--;
                        if (rule.equationRule.opeartorAlive == "!=")
                            count--;
                        count++;
                    }
                    else
                    {
                        count++;
                    }
                }
                writer.WriteLine(count);
                foreach (var rule in ruleList)
                {
                    if (rule.gridRule == null)
                    {
                        if (rule.equationRule.opeartorAlive == "")
                        {
                            writer.WriteLine("1");
                            writer.WriteLine("3");
                            switch (rule.equationRule.opeartorDead)
                            {
                                case ">=":
                                    writer.Write("0 > " +  (rule.equationRule.numberOfDead - 1));
                                    break;
                                case "<=":
                                    writer.Write("0 < " + (rule.equationRule.numberOfDead + 1));
                                    break;
                                case "=":
                                    writer.Write("0 = " + (rule.equationRule.numberOfDead));
                                    break;
                            }
                            if (rule.finalState == State.Alive)
                                writer.WriteLine(" 1");
                            else
                            {
                                writer.WriteLine(" 0");
                            }
  
                        }
                        else if (rule.equationRule.opeartorDead == "")
                        {
                            writer.WriteLine("1");
                            writer.WriteLine("3");
                            switch (rule.equationRule.opeartorAlive)
                            {
                                case ">=":
                                    writer.Write("1 > " + (rule.equationRule.numberOfAlive - 1));
                                    break;
                                case "<=":
                                    writer.Write("1 < " + (rule.equationRule.numberOfAlive + 1));
                                    break;
                                case "=":
                                    writer.Write("1 = " + (rule.equationRule.numberOfAlive));
                                    break;
                            }
                            if (rule.finalState == State.Alive)
                                writer.WriteLine(" 1");
                            else
                            {
                                writer.WriteLine(" 0");
                            }
                        }
                        else
                        {
                            writer.WriteLine("1");
                            writer.WriteLine("3");
                            switch (rule.equationRule.opeartorAlive)
                            {
                                case ">=":
                                    writer.Write("1 > " + (rule.equationRule.numberOfAlive - 1));
                                    break;
                                case "<=":
                                    writer.Write("1 < " + (rule.equationRule.numberOfAlive + 1));
                                    break;
                                case "=":
                                    writer.Write("1 = " + (rule.equationRule.numberOfAlive));
                                    break;
                            }
                            if (rule.finalState == State.Alive)
                                writer.WriteLine(" 1");
                            else
                            {
                                writer.WriteLine(" 0");
                            }
                            writer.WriteLine("1");
                            writer.WriteLine("3");
                            switch (rule.equationRule.opeartorDead)
                            {
                                case ">=":
                                    writer.WriteLine("0 > " + (rule.equationRule.numberOfDead - 1));
                                    break;
                                case "<=":
                                    writer.WriteLine("0 < " + (rule.equationRule.numberOfDead + 1));
                                    break;
                                case "=":
                                    writer.WriteLine("0 = " + (rule.equationRule.numberOfDead));
                                    break;
                            }
                            if (rule.finalState == State.Alive)
                                writer.WriteLine(" 1");
                            else
                            {
                                writer.WriteLine(" 0");
                            }
                        }
                    }
                    else
                    {
                        writer.WriteLine("0");
                        if (rule.gridRule.neigboursState == State.Alive)
                            writer.WriteLine("1");
                        else
                            writer.WriteLine("0");

                        for (int y = 0; y < 5; y++)
                        {
                            for (int x = 0; x < 5; x++)
                            {
                                if (x == 2 && y == 2)
                                {
                                    if (rule.finalState == State.Alive)
                                        writer.Write("1 ");
                                    else
                                        writer.Write("0 ");
                                }   
                                else
                                {
                                    if (rule.gridRule.neigboursState == State.Dead)
                                    {
                                        if (rule.gridRule.ruleGrid[x, y])
                                            writer.Write("0 ");
                                        else
                                            writer.Write("1 ");
                                    }
                                    else if (rule.gridRule.neigboursState == State.Alive)
                                    {
                                        if (rule.gridRule.ruleGrid[x, y])
                                            writer.Write("1 ");
                                        else
                                            writer.Write("0 ");
                                    }
                                }
                            }
                            if(y!=5)
                            writer.WriteLine();
                        }
                    }
                }
            }
        }

        public int LoadFromFile(string filePath)
        {
            string source = File.ReadAllText(filePath);

            try
            {

                string aLine = null;
                string[] splittedLine = null;
                StringReader strReader = new StringReader(source);

                if (mainGrid == null)
                    mainGrid = new Grid();

                this.Step = 1;
                this.mode = "List";

                //Width and Height
                aLine = strReader.ReadLine();
                splittedLine = aLine.Split(' ');
                mainGrid.Width = Int32.Parse(splittedLine[0]);
                mainGrid.Height = Int32.Parse(splittedLine[1]);

                //mainGrid
                mainGrid.GenerateCells();
                for (int y = 0; y < mainGrid.Height; y++)
                {
                    aLine = strReader.ReadLine();
                    splittedLine = aLine.Split(' ');
                    for (int x = 0; x < mainGrid.Width; x++)
                    {
                        switch (splittedLine[x])
                        {
                            case "0":
                                mainGrid.cellList[x, y].state = State.Dead;
                                mainGrid.cellList[x, y].color = GUI.colorDead;
                                break;
                            case "1":
                                mainGrid.cellList[x, y].state = State.Alive;
                                mainGrid.cellList[x, y].color = GUI.colorAlive;
                                break;
                            case "2":
                                mainGrid.cellList[x, y].state = State.Inactive;
                                mainGrid.cellList[x, y].color = GUI.colorInactive;
                                break;
                        }
                    }
                }

                //Number of rules
                aLine = strReader.ReadLine();
                splittedLine = aLine.Split(' ');
                int rulesCount = Int32.Parse(splittedLine[0]);

                if (rulesCount > 0)
                    ruleList = new List<Rule>();

                //Rules
                for (int i = 0; i < rulesCount; i++)
                {
                    Rule rule = new Rule();
                    rule.ID = GUI.ruleID;
                    GUI.ruleID++;
                    rule.priority = 1;

                    //Type of rule 0-Grid, 1-Equation
                    aLine = strReader.ReadLine();
                    splittedLine = aLine.Split(' ');
                    int typeofRule = Int32.Parse(splittedLine[0]);

                    //Initial state of center cell
                    aLine = strReader.ReadLine();
                    splittedLine = aLine.Split(' ');
                    int inputStateofCenterCell = Int32.Parse(splittedLine[0]);

                    if (typeofRule == 0) //Grid rule
                    {
                        GridRule gridRule = new GridRule();

                        //NeigboursState
                        if (inputStateofCenterCell == 1)
                            gridRule.neigboursState = State.Alive;
                        else
                        {
                            gridRule.neigboursState = State.Dead;
                        }
                        gridRule.ruleGrid = new bool[5, 5];

                        for (int y = 0; y < 5; y++)
                        {
                            aLine = strReader.ReadLine();
                            splittedLine = aLine.Split(' ');
                            for (int x = 0; x < 5; x++)
                            {
                                if (Int32.Parse(splittedLine[x]) == 1)
                                    gridRule.ruleGrid[x, y] = true;
                                else
                                    gridRule.ruleGrid[x, y] = false;
                                if (x == 2 && y == 2)
                                {
                                    if (Int32.Parse(splittedLine[x]) == 1)
                                        rule.finalState = State.Alive;
                                    else
                                    {
                                        rule.finalState = State.Dead;
                                    }
                                    gridRule.ruleGrid[x, y] = false;
                                }
                            }
                        }
                        rule.gridRule = gridRule;
                    }
                    else //Equation rule
                    {
                        EquationRule equation = new EquationRule();
                        aLine = strReader.ReadLine();
                        splittedLine = aLine.Split(' ');
                        if (Int32.Parse(splittedLine[0]) == 1)
                        {
                            switch (splittedLine[1])
                            {
                                case ">":
                                    equation.opeartorAlive = ">=";
                                    equation.numberOfAlive = Int32.Parse(splittedLine[2]) + 1;
                                    break;
                                case "<":
                                    equation.opeartorAlive = "<=";
                                    equation.numberOfAlive = Int32.Parse(splittedLine[2]) - 1;
                                    break;
                                default:
                                    equation.opeartorAlive = splittedLine[1];
                                    equation.numberOfAlive = Int32.Parse(splittedLine[2]);
                                    break;
                            }
                            equation.opeartorDead = "";
                        }
                        else
                        {
                            switch (splittedLine[1])
                            {
                                case ">":
                                    equation.opeartorDead = ">=";
                                    equation.numberOfDead = Int32.Parse(splittedLine[2]) + 1;
                                    break;
                                case "<":
                                    equation.opeartorDead = "<=";
                                    equation.numberOfDead = Int32.Parse(splittedLine[2]) - 1;
                                    break;
                                default:
                                    equation.opeartorDead = splittedLine[1];
                                    equation.numberOfDead = Int32.Parse(splittedLine[2]);
                                    break;
                            }
                            equation.opeartorAlive = "";
                        }
                        if (Int32.Parse(splittedLine[3]) == 1)
                            rule.finalState = State.Alive;
                        else
                            rule.finalState = State.Dead;
                        rule.equationRule = equation;

                    }
                    ruleList.Add(rule);
                }
                return 0;
            }
            catch(Exception ex)
            {
                return -1;
            }
        }
        
    }
}
