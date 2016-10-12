using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cellular_Automaton
{
    public partial class RuleList : Form
    {
        ListViewEx listView = new ListViewEx();
        public RuleList()
        {
            InitializeComponent();
            MakeListView(listView);
            PopulateGrid();
        }

        private void PopulateGrid()
        {
            listView.Items.Clear();

            int no=0;
            foreach (var rule in GUI.mainVisualization.ruleList)
            {
                ListViewItem item = new ListViewItem(rule.ID.ToString());

                item.SubItems.Add(rule.priority.ToString());

                item.SubItems.Add(rule.finalState.ToString());


                 if (rule.gridRule == null)
                 {
                     TextBox equationRule = new TextBox();
                     equationRule.Width = 200;
                     string concat;
                     if (rule.equationRule.opeartorDead == "")
                         concat = ("Alive  " + rule.equationRule.opeartorAlive + "  " + rule.equationRule.numberOfAlive);
                     else if (rule.equationRule.opeartorAlive == "")
                         concat = ("Dead " + rule.equationRule.opeartorDead + "  " + rule.equationRule.numberOfDead);
                     else
                         concat = ("Alive  " + rule.equationRule.opeartorAlive + "  " + rule.equationRule.numberOfAlive + "\nDead " + rule.equationRule.opeartorDead + "  " + rule.equationRule.numberOfDead);
                     equationRule.Text = concat;
                     equationRule.Multiline = true;
                     equationRule.Enabled = false;
                     item.SubItems.Add(concat);
                     item.SubItems.Add("X");
                     listView.Items.Add(item);
                 }
                 else
                 {
                     item.SubItems.Add("");
                     item.SubItems.Add(rule.gridRule.neigboursState.ToString());
                     listView.Items.Add(item);

                     TableLayoutPanel grid = new TableLayoutPanel();
                     grid.RowCount = 5;
                     grid.ColumnCount = 5;
                     grid.Width = 100;
                     grid.Height = 100;

                     for (int y = 0; y < 5; y++)
                     {
                         grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F / 5));

                         for (int x = 0; x < 5; x++)
                         {
                             grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F / 5));
                         }
                     }
                      
                     Button[] btnArray = new Button[25];
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
                             btnArray[n].Name = (n + 1).ToString();
                             btnArray[n].Dock = System.Windows.Forms.DockStyle.Fill;
                             btnArray[n].Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right))); btnArray[n].Margin = new System.Windows.Forms.Padding(0);
                             btnArray[n].UseVisualStyleBackColor = false;
                             if (n == 12)
                                 btnArray[n].BackColor = Color.Black;
                             if (rule.gridRule.ruleGrid[j,i] == true)
                                 btnArray[n].BackColor = Color.Red;
                             grid.Controls.Add(btnArray[n], j, i);
                             n++;
                         }
                     }
                     listView.AddEmbeddedControl(grid, 3, no, DockStyle.Fill);
                 }
                Button delete = new Button();
                delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                delete.Name = (no).ToString();
                delete.Text = "X";
                delete.BackColor = SystemColors.Control;
                delete.MouseDown += new MouseEventHandler(DeleteClickButton);
                listView.AddEmbeddedControl(delete, 5, no, DockStyle.Fill);

                no++;
            }
        }

        public void DeleteClickButton(Object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            GUI.mainVisualization.DeleteRule(Int32.Parse(btn.Name));
            PopulateGrid();
        }

        private void SetHeight(ListView listView, int height)
        {
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, height);
            listView.SmallImageList = imgList;
        }

        private void MakeListView(ListViewEx listView)
        {

            listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            ID,
            Priority,
            FinalState,
            Rule,
            ConditionState,
            ActionButtons});
            listView.Dock = System.Windows.Forms.DockStyle.Fill;
            listView.Location = new System.Drawing.Point(0, 0);
            listView.Name = "listViewRuleList";
            listView.Size = new System.Drawing.Size(489, 734);
            listView.TabIndex = 0;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = System.Windows.Forms.View.Details;
            listView.GridLines = true;
            SetHeight(listView, 150);
            this.Controls.Add(listView);
        }
    }
}
