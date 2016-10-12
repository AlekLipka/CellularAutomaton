using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace Cellular_Automaton
{
    [Serializable]
    public class Grid
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int MaxWidth { get; set; }
        public int MaxHeight { get; set; }
        public Cell[,] cellList { get; set; }

        public void GenerateCells()
        {
            cellList = new Cell[Width,Height];
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Cell cell = new Cell();
                    cell.x = j;
                    cell.y = i;
                    cell.color = Color.White;
                    cell.state = State.Inactive;
                    cellList[j,i] = cell; 
                }
            }
        }

        public void ClearCells()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    cellList[j, i].color = Color.White;
                    cellList[j, i].state = State.Inactive;
                }
            }
        }
    }
}
