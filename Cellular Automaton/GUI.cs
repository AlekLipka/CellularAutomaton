using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cellular_Automaton
{
    public partial class GUI : Form
    {
        Button[] btnArray = new Button[25];
        public static Visualization mainVisualization = new Visualization();
        public static Color colorDead = Color.DarkGreen;
        public static Color colorAlive = Color.YellowGreen;
        public static Color colorInactive = Color.White;
        public static bool pause = true;
        GridHistogram histogram = new GridHistogram();
        public static int ruleID = 0;
        private int time = 1000;
        public GUI()
        {
            InitializeComponent();
            typeof(TableLayoutPanel).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(tableLayoutPanelMainGrid, true, null);
            mainVisualization.ruleList = new List<Rule>();
            FillGrid();
        }

        #region RuleGrid
        /// <summary>
        /// Fills the rule grid with buttons
        /// </summary>
        private void FillGrid()
        {
            for (int i = 0; i < 25; i++)
            {
                btnArray[i] = new Button();
            }
            int n = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    btnArray[n].AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                    btnArray[n].Tag = n + 1; // Tag of button 
                    btnArray[n].TabIndex = n;
                    btnArray[n].Name = (n+1).ToString();
                    btnArray[n].Dock = System.Windows.Forms.DockStyle.Fill;
                    btnArray[n].Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)| System.Windows.Forms.AnchorStyles.Left)| System.Windows.Forms.AnchorStyles.Right))); btnArray[n].Margin = new System.Windows.Forms.Padding(0);
                    btnArray[n].UseVisualStyleBackColor = false;
                    btnArray[n].Text = btnArray[n].Tag.ToString();
                    if (n == 12)
                        btnArray[n].BackColor = Color.Black;

                    tableLayoutPanelAddRule.Controls.Add(btnArray[n], j, i);

                    // the Event of click Button 
                    if (n != 12)
                    {
                        btnArray[n].MouseDown += new MouseEventHandler(RuleGridClickButton);
                        btnArray[n].MouseEnter += new EventHandler(EnterB);
                        btnArray[n].MouseLeave += new EventHandler(LeaveB);
                    }
                    n++;
                }
            }
        }

        /// <summary>
        /// Hoover in over the rule grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterB(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.White)
                btn.BackColor = SystemColors.ActiveCaption;
        }
        /// <summary>
        /// Hoover out from the rule grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LeaveB(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == SystemColors.ActiveCaption)
                btn.BackColor = Color.White;
        }
        /// <summary>
        /// Button click in the rule grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void RuleGridClickButton(Object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Red)
                btn.BackColor = SystemColors.ActiveCaption;
            else if (btn.BackColor == SystemColors.ActiveCaption)
                btn.BackColor = Color.Red;
        }
        #endregion

        #region ActionPanelHandlers

        /// <summary>
        /// Grid creation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGridCreation_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel4.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        MessageBox.Show(("Unspecified value in " + textBox.Name), "ERROR" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            mainVisualization.mode = comboBoxRuleSchema.Text;
            mainVisualization.Step = Int32.Parse(textBoxStep.Text);

            Grid mainGrid = new Grid();

            mainGrid.Width = Int32.Parse(textBoxX.Text);
            mainGrid.Height = Int32.Parse(textBoxY.Text);
            mainGrid.GenerateCells();

            PopulateGrid(mainGrid);

            mainVisualization.mainGrid = mainGrid;

            pause = true;

            tableLayoutPanelMainGrid.Enabled = true;
            buttonNextStep.Enabled = true;
            buttonPreviousStep.Enabled = true;
            buttonPlay.Enabled = true;
            buttonPause.Enabled = true;
            buttonStop.Enabled = true;
        }

        private void PopulateGrid(Grid grid)
        {
            tableLayoutPanelMainGrid.Controls.Clear();
            tableLayoutPanelMainGrid.RowStyles.Clear();
            tableLayoutPanelMainGrid.ColumnStyles.Clear();
            tableLayoutPanelMainGrid.RowCount = grid.Height;
            tableLayoutPanelMainGrid.ColumnCount = grid.Width;

            Decimal d = Decimal.Divide((tableLayoutPanelMainGrid.Width-6), grid.Width);
            double  f = (float)d - Math.Truncate((float)d);
            double sum = 0;

            Decimal d2 = Decimal.Divide((tableLayoutPanelMainGrid.Height - 6), grid.Height);
            double f2 = (float)d - Math.Truncate((float)d);
            double sum2 = 0;
            
            Console.WriteLine(f);

            //sum = f * grid.Width;

            Console.WriteLine(sum);

            for (int y = 0; y < grid.Height; y++ )
            {
                sum += f;
                if (sum/1 == 1)
                {
                    tableLayoutPanelMainGrid.ColumnStyles.Add(
                        new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, ((int) d-1)));
                    sum -= 1;
                }
                else
                {
                    tableLayoutPanelMainGrid.ColumnStyles.Add(
                        new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, (int) d));
                }
                for (int x = 0; x < grid.Width; x++ )
                {
                    sum2 += f2;
                    if (sum2/1 == 1)
                    {
                        tableLayoutPanelMainGrid.RowStyles.Add(
                            new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute,
                                ((int) d2 - 1)));
                        sum2 -= 1;
                    }
                    else
                    {
                        tableLayoutPanelMainGrid.RowStyles.Add(
                            new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, (int) d2));
                    }
                }
            }
        }

        /// <summary>
        /// Textbox number input checker (checks if there are only digits entered in the textbox)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }
        /// <summary>
        ///  Textbox number from 1 to 24 input checker  (checks if there are only digits entered in the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeadAliveLeave(object sender, EventArgs e)
        {
            TextBox txb = (TextBox)sender;
            if (txb.Text != "")
            {
                if (Int32.Parse(txb.Text) > 24)
                    txb.Text = (24).ToString();
                if (Int32.Parse(txb.Text) == 0)
                    txb.Text = (1).ToString();
            }
        }

        private void comboBoxDead_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDead.Text == "")
                textBoxEquationDead.Text = "";
        }

        private void comboBoxAlive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAlive.Text == "")
                textBoxEquationAlive.Text = "";
        }
        

        /// <summary>
        /// Adds rule to the ruleList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonApply_Click(object sender, EventArgs e)
        {
            RadioButton checkedButton = panelRule.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            Rule rule = new Rule();

            if (textBoxPriority.Text == "")
            {
                MessageBox.Show("Unspecified priority", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            switch (checkedButton.Name)
            {
                case "radioButtonEquation":
                    if (comboBoxAlive.Text != "")
                    {
                        if (textBoxEquationAlive.Text == "")
                        {
                            MessageBox.Show("Unspecified number of alive cells", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    if (comboBoxDead.Text != "")
                    {
                        if (textBoxEquationDead.Text == "")
                        {
                            MessageBox.Show("Unspecified number of dead cells", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    EquationRule equationRule = new EquationRule();
                    if (textBoxEquationAlive.Text != "")
                        equationRule.numberOfAlive = Int32.Parse(textBoxEquationAlive.Text);
                    if (textBoxEquationDead.Text != "")
                        equationRule.numberOfDead = Int32.Parse(textBoxEquationDead.Text);

                    equationRule.opeartorAlive = comboBoxAlive.Text;
                    equationRule.opeartorDead = comboBoxDead.Text;

                    rule.equationRule = equationRule;
                    break;
                case "radioButtonGrid":
                    int no = 0;
                    foreach (var btn in btnArray)
                        if (btn.BackColor == Color.Red)
                            no++;
                    if (no == 0)
                    {
                        MessageBox.Show("Nothing is selected in the grid", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    GridRule gridRule = new GridRule();
                    bool[,] marked = new bool[5, 5];
                    int n = 0;
                    for (int y = 0; y < 5; y++)
                    {
                        for (int x = 0; x<5; x++){
                            if (btnArray[n].BackColor == Color.Red)
                                marked[x, y] = true;
                            else
                                marked[x, y] = false;
                            n++;
                        }
                    }
                    gridRule.ruleGrid = marked;
                    RadioButton checkedButtonGrid = panelGridRule.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                    if (checkedButtonGrid.Name == "radioButtonGridAlive")
                        gridRule.neigboursState = State.Alive;
                    else
                        gridRule.neigboursState = State.Dead;

                    rule.gridRule = gridRule;
                    break;
            }

            if (comboBoxCentralCellFinalState.Text == "Alive")
                rule.finalState = State.Alive;
            else
                rule.finalState = State.Dead;

            rule.priority = Int32.Parse(textBoxPriority.Text);

            rule.ID = ruleID;
            ruleID++;

            if (mainVisualization.ruleList == null)
                mainVisualization.ruleList = new List<Rule>();
            if (mainVisualization.checkContradictions(rule))
                mainVisualization.AddRule(rule);
            else
                ruleID--;

            textBoxEquationDead.Text = "";
            textBoxEquationAlive.Text = "";
            comboBoxDead.Text = "";
            comboBoxAlive.Text = "";
            foreach (var btn in btnArray)
            {
                if (btn.BackColor == Color.Red)
                    btn.BackColor = Color.White;
            }
        }

        private void buttonRandomize_Click(object sender, EventArgs e)
        {
            RadioButton checkedButton = panelRule.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            Random rand = new Random();
            switch (checkedButton.Name)
            {
                case "radioButtonEquation":
                    int randomDead = rand.Next(1, 25);
                    textBoxEquationDead.Text = randomDead.ToString();
                    textBoxEquationAlive.Text = rand.Next(1, 25 - randomDead).ToString();
                    int i = rand.Next(1, 5);
                    switch (i)
                    {
                        case 1:
                            comboBoxDead.Text = "=";
                            break;
                        case 2:
                            comboBoxDead.Text = "!=";
                            break;
                        case 3:
                            comboBoxDead.Text = ">=";
                            break;
                        case 4:
                            comboBoxDead.Text = "<=";
                            break;
                    }
                    i = rand.Next(1, 5);
                    switch (i)
                    {
                        case 1:
                            comboBoxAlive.Text = "=";
                            break;
                        case 2:
                            comboBoxAlive.Text = "!=";
                            break;
                        case 3:
                            comboBoxAlive.Text = ">=";
                            break;
                        case 4:
                            comboBoxAlive.Text = "<=";
                            break;
                    }
                    break;
                case "radioButtonGrid":
                    int m;
                    foreach (var btn in btnArray)
                    {
                        if (Int32.Parse(btn.Name) != 13)
                        {
                            m = rand.Next(2);
                            if (m == 0)
                                btn.BackColor = Color.White;
                            else
                                btn.BackColor = Color.Red;
                        }
                    }
                    m = rand.Next(2);
                    if (m == 0)
                        radioButtonGridAlive.Checked = true;
                    else
                        radioButtonGridDead.Checked = true;
                    break;
            }
        }

        /// <summary>
        /// Shows new form with all the rules listed in it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonruleList_Click(object sender, EventArgs e)
        {
            if (mainVisualization.ruleList == null)
                mainVisualization.ruleList = new List<Rule>();
            RuleList ruleListWindow = new RuleList();
            ruleListWindow.ShowDialog();

        }
        #endregion

        #region MainGrid
        private void tableLayoutPanelMainGrid_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (mainVisualization.mainGrid != null)
                if (mainVisualization.mainGrid.cellList != null)
                    using (var b = new SolidBrush(mainVisualization.mainGrid.cellList[e.Column, e.Row].color))
                        e.Graphics.FillRectangle(b, e.CellBounds);
        }

        private void tableLayoutPanelMainGrid_MouseClick(object sender, MouseEventArgs e)
        {
            int row = 0;
            int verticalOffset = 0;
            foreach (int h in tableLayoutPanelMainGrid.GetRowHeights())
            {
                int column = 0;
                int horizontalOffset = 0;
                foreach (int w in tableLayoutPanelMainGrid.GetColumnWidths())
                {
                    Rectangle rectangle = new Rectangle(horizontalOffset, verticalOffset, w, h);
                    if (rectangle.Contains(e.Location))
                    {
                        MouseEventArgs me = (MouseEventArgs)e;
                        if (me.Button == System.Windows.Forms.MouseButtons.Right)
                        {
                            mainVisualization.mainGrid.cellList[column, row].color = colorDead;
                            mainVisualization.mainGrid.cellList[column, row].state = State.Dead;
                        }
                        if (me.Button == System.Windows.Forms.MouseButtons.Left)
                        {
                            mainVisualization.mainGrid.cellList[column, row].color = colorAlive;
                            mainVisualization.mainGrid.cellList[column, row].state = State.Alive;
                        }
                        tableLayoutPanelMainGrid.Refresh();
                        return;
                    }
                    horizontalOffset += w;
                    column++;
                }
                verticalOffset += h;
                row++;
            }
        }

        private void tableLayoutPanelMainGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int row = 0;
            int verticalOffset = 0;
            foreach (int h in tableLayoutPanelMainGrid.GetRowHeights())
            {
                int column = 0;
                int horizontalOffset = 0;
                foreach (int w in tableLayoutPanelMainGrid.GetColumnWidths())
                {
                    Rectangle rectangle = new Rectangle(horizontalOffset, verticalOffset, w, h);
                    if (rectangle.Contains(e.Location))
                    {
                        MouseEventArgs me = (MouseEventArgs)e;
                        mainVisualization.mainGrid.cellList[column, row].color = colorInactive;
                        mainVisualization.mainGrid.cellList[column, row].state = State.Inactive;
                        tableLayoutPanelMainGrid.Refresh();
                        return;
                    }
                    horizontalOffset += w;
                    column++;
                }
                verticalOffset += h;
                row++;
            }
        }

        #endregion

        #region MainGridButtons
        private async void buttonPlay_Click(object sender, EventArgs e)
        {
            if (mainVisualization.ruleList.Count != 0)
                new Thread(() => GridCycle() ).Start();
        }

        private void GridCycle()
        {
            pause = false;
            int i = 1;
            if (histogram.histogram == null)
                histogram.histogram = new CustomStack<Grid>();
            while (!pause)
            {
                if (i % mainVisualization.Step == 0)
                    histogram.AddToHistogram(DeepCopy(GUI.mainVisualization.mainGrid));
                mainVisualization.GridVisualization();
                if (i%mainVisualization.Step == 0)
                {
                    this.Invoke((MethodInvoker) delegate
                    {
                        tableLayoutPanelMainGrid.Refresh();
                    });
                }
                if (time != 0)
                    Thread.Sleep(time);
                i++;
            }
        }

        private async void buttonPause_Click(object sender, EventArgs e)
        {
            pause = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            pause = true;
            mainVisualization.mainGrid.ClearCells();
            tableLayoutPanelMainGrid.Refresh();
        }

        private void buttonNextStep_Click(object sender, EventArgs e)
        {
            if (mainVisualization.ruleList != null)
            {
                if (mainVisualization.ruleList.Count != 0 && pause)
                {
                    if (histogram.histogram == null)
                        histogram.histogram = new CustomStack<Grid>();
                    histogram.AddToHistogram(DeepCopy(GUI.mainVisualization.mainGrid));
                    for (int i = 0; i < mainVisualization.Step; i++)
                    {
                        mainVisualization.GridVisualization();
                    }
                    tableLayoutPanelMainGrid.Refresh();
                }
            }
        }

        private void buttonPreviousStep_Click(object sender, EventArgs e)
        {
            if (pause)
            {
                if (histogram.histogram != null)
                {
                    if (histogram.histogram.GetCount() != 0)
                    {
                        mainVisualization.mainGrid.cellList = histogram.GetPreviousGeneration().cellList;
                        Console.WriteLine("Getting last grid from histogram");
                        tableLayoutPanelMainGrid.Refresh();
                    }
                }
            }
        }

        #endregion

        #region Menu
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cellular Automaton\ncreated by Aleksander Lipka\nVersion 1.0", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);                       
        }

        private void specifyMaxSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeMaxSizeWindow testDialog = new ChangeMaxSizeWindow();

            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                if (testDialog.textBox1.Text != "")
                    mainVisualization.mainGrid.MaxWidth = Int32.Parse(testDialog.textBox1.Text);
                if (testDialog.textBox2.Text != "")
                    mainVisualization.mainGrid.MaxHeight = Int32.Parse(testDialog.textBox2.Text);
                Console.WriteLine("Values has been changed");
            }
            testDialog.Dispose();
        }

        private void toPriorityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainVisualization.mode = "Priority";
        }

        private void toListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainVisualization.mode = "List";
        }

        private void toRandomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainVisualization.mode = "Random";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pause = true;
            mainVisualization.Clear();
            tableLayoutPanelMainGrid.Controls.Clear();
            tableLayoutPanelMainGrid.RowStyles.Clear();
            tableLayoutPanelMainGrid.ColumnStyles.Clear();
            tableLayoutPanelMainGrid.Enabled = false;
            tableLayoutPanelMainGrid.Refresh();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pause)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text File |*.txt";
                saveFileDialog.Title = "Save your Rule List";
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    Thread.Sleep(200);
                    if (mainVisualization.ruleList == null)
                        mainVisualization.ruleList = new List<Rule>();
                    mainVisualization.SaveToFile(saveFileDialog.FileName);
                }
            }
        }

        private void msToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            switch (item.Name)
            {
                case "xToolStripMenuItem":
                    time = 0;
                    break;
                case "msToolStripMenuItem":
                    time = 200;
                    break;
                case "msToolStripMenuItem1":
                    time = 500;
                    break;
                case "sToolStripMenuItem":
                    time = 1000;
                    break;
                case "sToolStripMenuItem1":
                    time = 2000;
                    break;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoYouWantToExit();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                int returnValue = mainVisualization.LoadFromFile(file);

                if (returnValue == 0)
                {
                    pause = true;
                    PopulateGrid(mainVisualization.mainGrid);
                    tableLayoutPanelMainGrid.Refresh();

                    tableLayoutPanelMainGrid.Enabled = true;
                    buttonNextStep.Enabled = true;
                    buttonPreviousStep.Enabled = true;
                    buttonPlay.Enabled = true;
                    buttonPause.Enabled = true;
                    buttonStop.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Couln't load the file!\nCheck if the file is in right format", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void aliveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            if (pause)
            {
                if (mainVisualization.mainGrid != null)
                {
                    for (int y = 0; y < mainVisualization.mainGrid.Height; y++)
                    {
                        for (int x = 0; x < mainVisualization.mainGrid.Width; x++)
                        {
                            switch (item.Name)
                            {
                                case "aliveToolStripMenuItem":
                                    mainVisualization.mainGrid.cellList[x, y].color = colorAlive;
                                    mainVisualization.mainGrid.cellList[x, y].state = State.Alive;
                                    break;
                                case "deadToolStripMenuItem":
                                    mainVisualization.mainGrid.cellList[x, y].color = colorDead;
                                    mainVisualization.mainGrid.cellList[x, y].state = State.Dead;
                                    break;
                            }
                        }
                    }
                }
                tableLayoutPanelMainGrid.Refresh();
            }
        }
        #endregion

        #region Other
        public static T DeepCopy<T>(T other)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(ms, other);
                ms.Position = 0;
                return (T)formatter.Deserialize(ms);
            }
        }

        private void GUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            DoYouWantToExit();
        }

        private void DoYouWantToExit()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                pause = true;
                Thread.Sleep(200);
                this.Dispose();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
        #endregion
    }
}
