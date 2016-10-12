namespace Cellular_Automaton
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.buttonApply = new System.Windows.Forms.Button();
            this.labelStep = new System.Windows.Forms.Label();
            this.labelRules = new System.Windows.Forms.Label();
            this.LabelSize = new System.Windows.Forms.Label();
            this.labelDead = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelAlive = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxStep = new System.Windows.Forms.TextBox();
            this.textBoxEquationDead = new System.Windows.Forms.TextBox();
            this.textBoxEquationAlive = new System.Windows.Forms.TextBox();
            this.buttonRandomize = new System.Windows.Forms.Button();
            this.tableLayoutPanelAddRule = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxDead = new System.Windows.Forms.ComboBox();
            this.comboBoxAlive = new System.Windows.Forms.ComboBox();
            this.buttonGridCreation = new System.Windows.Forms.Button();
            this.radioButtonGridAlive = new System.Windows.Forms.RadioButton();
            this.radioButtonGridDead = new System.Windows.Forms.RadioButton();
            this.panelGridRule = new System.Windows.Forms.Panel();
            this.IfSatisfied = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCentralCellFinalState = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonGrid = new System.Windows.Forms.RadioButton();
            this.radioButtonEquation = new System.Windows.Forms.RadioButton();
            this.panelRule = new System.Windows.Forms.Panel();
            this.textBoxPriority = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBoxRuleSchema = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxYMax = new System.Windows.Forms.TextBox();
            this.textBoxXMax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelGridCreator = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specifyMaxSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeContradictionSchemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toPriorityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toRandomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelMainGrid = new System.Windows.Forms.TableLayoutPanel();
            this.buttonruleList = new System.Windows.Forms.Button();
            this.buttonNextStep = new System.Windows.Forms.Button();
            this.buttonPreviousStep = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.makeTheGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aliveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelGridRule.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelRule.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(39, 369);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 38);
            this.buttonApply.TabIndex = 0;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // labelStep
            // 
            this.labelStep.AutoSize = true;
            this.labelStep.Location = new System.Drawing.Point(7, 29);
            this.labelStep.Name = "labelStep";
            this.labelStep.Size = new System.Drawing.Size(41, 17);
            this.labelStep.TabIndex = 1;
            this.labelStep.Text = "Step:";
            // 
            // labelRules
            // 
            this.labelRules.AutoSize = true;
            this.labelRules.Location = new System.Drawing.Point(15, 209);
            this.labelRules.Name = "labelRules";
            this.labelRules.Size = new System.Drawing.Size(48, 17);
            this.labelRules.TabIndex = 2;
            this.labelRules.Text = "Rules:";
            // 
            // LabelSize
            // 
            this.LabelSize.AutoSize = true;
            this.LabelSize.Location = new System.Drawing.Point(9, 3);
            this.LabelSize.Name = "LabelSize";
            this.LabelSize.Size = new System.Drawing.Size(39, 17);
            this.LabelSize.TabIndex = 3;
            this.LabelSize.Text = "Size:";
            // 
            // labelDead
            // 
            this.labelDead.AutoSize = true;
            this.labelDead.Location = new System.Drawing.Point(9, 12);
            this.labelDead.Name = "labelDead";
            this.labelDead.Size = new System.Drawing.Size(42, 17);
            this.labelDead.TabIndex = 4;
            this.labelDead.Text = "Dead";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(158, 3);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(31, 17);
            this.labelY.TabIndex = 5;
            this.labelY.Text = "y = ";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(58, 3);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(26, 17);
            this.labelX.TabIndex = 6;
            this.labelX.Text = "x =";
            // 
            // labelAlive
            // 
            this.labelAlive.AutoSize = true;
            this.labelAlive.Location = new System.Drawing.Point(17, 40);
            this.labelAlive.Name = "labelAlive";
            this.labelAlive.Size = new System.Drawing.Size(38, 17);
            this.labelAlive.TabIndex = 7;
            this.labelAlive.Text = "Alive";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(90, 3);
            this.textBoxX.MaxLength = 2;
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(46, 22);
            this.textBoxX.TabIndex = 1;
            this.textBoxX.Text = "10";
            this.textBoxX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumber_KeyPress);
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(190, 3);
            this.textBoxY.MaxLength = 2;
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(46, 22);
            this.textBoxY.TabIndex = 2;
            this.textBoxY.Text = "10";
            this.textBoxY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumber_KeyPress);
            // 
            // textBoxStep
            // 
            this.textBoxStep.Location = new System.Drawing.Point(50, 26);
            this.textBoxStep.MaxLength = 2;
            this.textBoxStep.Name = "textBoxStep";
            this.textBoxStep.Size = new System.Drawing.Size(100, 22);
            this.textBoxStep.TabIndex = 3;
            this.textBoxStep.Text = "1";
            this.textBoxStep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumber_KeyPress);
            // 
            // textBoxEquationDead
            // 
            this.textBoxEquationDead.Location = new System.Drawing.Point(109, 12);
            this.textBoxEquationDead.MaxLength = 2;
            this.textBoxEquationDead.Name = "textBoxEquationDead";
            this.textBoxEquationDead.Size = new System.Drawing.Size(100, 22);
            this.textBoxEquationDead.TabIndex = 12;
            this.textBoxEquationDead.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumber_KeyPress);
            this.textBoxEquationDead.Leave += new System.EventHandler(this.DeadAliveLeave);
            // 
            // textBoxEquationAlive
            // 
            this.textBoxEquationAlive.Location = new System.Drawing.Point(109, 37);
            this.textBoxEquationAlive.MaxLength = 2;
            this.textBoxEquationAlive.Name = "textBoxEquationAlive";
            this.textBoxEquationAlive.Size = new System.Drawing.Size(100, 22);
            this.textBoxEquationAlive.TabIndex = 13;
            this.textBoxEquationAlive.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumber_KeyPress);
            this.textBoxEquationAlive.Leave += new System.EventHandler(this.DeadAliveLeave);
            // 
            // buttonRandomize
            // 
            this.buttonRandomize.Location = new System.Drawing.Point(128, 369);
            this.buttonRandomize.Name = "buttonRandomize";
            this.buttonRandomize.Size = new System.Drawing.Size(109, 38);
            this.buttonRandomize.TabIndex = 15;
            this.buttonRandomize.Text = "Randomize";
            this.buttonRandomize.UseVisualStyleBackColor = true;
            this.buttonRandomize.Click += new System.EventHandler(this.buttonRandomize_Click);
            // 
            // tableLayoutPanelAddRule
            // 
            this.tableLayoutPanelAddRule.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelAddRule.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelAddRule.ColumnCount = 5;
            this.tableLayoutPanelAddRule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelAddRule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelAddRule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelAddRule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelAddRule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelAddRule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanelAddRule.Location = new System.Drawing.Point(14, 3);
            this.tableLayoutPanelAddRule.Name = "tableLayoutPanelAddRule";
            this.tableLayoutPanelAddRule.RowCount = 5;
            this.tableLayoutPanelAddRule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelAddRule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelAddRule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelAddRule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelAddRule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelAddRule.Size = new System.Drawing.Size(216, 136);
            this.tableLayoutPanelAddRule.TabIndex = 7;
            // 
            // comboBoxDead
            // 
            this.comboBoxDead.FormattingEnabled = true;
            this.comboBoxDead.Items.AddRange(new object[] {
            "",
            "=",
            ">=",
            "<=",
            "!="});
            this.comboBoxDead.Location = new System.Drawing.Point(60, 11);
            this.comboBoxDead.Name = "comboBoxDead";
            this.comboBoxDead.Size = new System.Drawing.Size(43, 24);
            this.comboBoxDead.TabIndex = 17;
            this.comboBoxDead.SelectedIndexChanged += new System.EventHandler(this.comboBoxDead_SelectedIndexChanged);
            // 
            // comboBoxAlive
            // 
            this.comboBoxAlive.FormattingEnabled = true;
            this.comboBoxAlive.Items.AddRange(new object[] {
            "",
            "=",
            ">=",
            "<=",
            "!="});
            this.comboBoxAlive.Location = new System.Drawing.Point(60, 37);
            this.comboBoxAlive.Name = "comboBoxAlive";
            this.comboBoxAlive.Size = new System.Drawing.Size(43, 24);
            this.comboBoxAlive.TabIndex = 18;
            this.comboBoxAlive.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlive_SelectedIndexChanged);
            // 
            // buttonGridCreation
            // 
            this.buttonGridCreation.Location = new System.Drawing.Point(0, 105);
            this.buttonGridCreation.Name = "buttonGridCreation";
            this.buttonGridCreation.Size = new System.Drawing.Size(272, 26);
            this.buttonGridCreation.TabIndex = 6;
            this.buttonGridCreation.Text = "Create grid";
            this.buttonGridCreation.UseVisualStyleBackColor = true;
            this.buttonGridCreation.Click += new System.EventHandler(this.buttonGridCreation_Click);
            // 
            // radioButtonGridAlive
            // 
            this.radioButtonGridAlive.AutoSize = true;
            this.radioButtonGridAlive.Checked = true;
            this.radioButtonGridAlive.Location = new System.Drawing.Point(46, 145);
            this.radioButtonGridAlive.Name = "radioButtonGridAlive";
            this.radioButtonGridAlive.Size = new System.Drawing.Size(59, 21);
            this.radioButtonGridAlive.TabIndex = 8;
            this.radioButtonGridAlive.TabStop = true;
            this.radioButtonGridAlive.Text = "Alive";
            this.radioButtonGridAlive.UseVisualStyleBackColor = true;
            // 
            // radioButtonGridDead
            // 
            this.radioButtonGridDead.AutoSize = true;
            this.radioButtonGridDead.Location = new System.Drawing.Point(138, 145);
            this.radioButtonGridDead.Name = "radioButtonGridDead";
            this.radioButtonGridDead.Size = new System.Drawing.Size(63, 21);
            this.radioButtonGridDead.TabIndex = 9;
            this.radioButtonGridDead.Text = "Dead";
            this.radioButtonGridDead.UseVisualStyleBackColor = true;
            // 
            // panelGridRule
            // 
            this.panelGridRule.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelGridRule.Controls.Add(this.radioButtonGridAlive);
            this.panelGridRule.Controls.Add(this.tableLayoutPanelAddRule);
            this.panelGridRule.Controls.Add(this.radioButtonGridDead);
            this.panelGridRule.Location = new System.Drawing.Point(25, 8);
            this.panelGridRule.Name = "panelGridRule";
            this.panelGridRule.Size = new System.Drawing.Size(242, 179);
            this.panelGridRule.TabIndex = 0;
            // 
            // IfSatisfied
            // 
            this.IfSatisfied.AutoSize = true;
            this.IfSatisfied.Location = new System.Drawing.Point(49, 310);
            this.IfSatisfied.Name = "IfSatisfied";
            this.IfSatisfied.Size = new System.Drawing.Size(172, 17);
            this.IfSatisfied.TabIndex = 22;
            this.IfSatisfied.Text = "If conditions are satisfied: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Make central cell ";
            // 
            // comboBoxCentralCellFinalState
            // 
            this.comboBoxCentralCellFinalState.FormattingEnabled = true;
            this.comboBoxCentralCellFinalState.Items.AddRange(new object[] {
            "Dead",
            "Alive"});
            this.comboBoxCentralCellFinalState.Location = new System.Drawing.Point(134, 330);
            this.comboBoxCentralCellFinalState.Name = "comboBoxCentralCellFinalState";
            this.comboBoxCentralCellFinalState.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCentralCellFinalState.TabIndex = 24;
            this.comboBoxCentralCellFinalState.Text = "Dead";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.comboBoxAlive);
            this.panel2.Controls.Add(this.textBoxEquationAlive);
            this.panel2.Controls.Add(this.textBoxEquationDead);
            this.panel2.Controls.Add(this.labelAlive);
            this.panel2.Controls.Add(this.labelDead);
            this.panel2.Controls.Add(this.comboBoxDead);
            this.panel2.Location = new System.Drawing.Point(25, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 79);
            this.panel2.TabIndex = 25;
            // 
            // radioButtonGrid
            // 
            this.radioButtonGrid.AutoSize = true;
            this.radioButtonGrid.Checked = true;
            this.radioButtonGrid.Location = new System.Drawing.Point(2, 61);
            this.radioButtonGrid.Name = "radioButtonGrid";
            this.radioButtonGrid.Size = new System.Drawing.Size(17, 16);
            this.radioButtonGrid.TabIndex = 26;
            this.radioButtonGrid.TabStop = true;
            this.radioButtonGrid.UseVisualStyleBackColor = true;
            // 
            // radioButtonEquation
            // 
            this.radioButtonEquation.AutoSize = true;
            this.radioButtonEquation.Location = new System.Drawing.Point(2, 221);
            this.radioButtonEquation.Name = "radioButtonEquation";
            this.radioButtonEquation.Size = new System.Drawing.Size(17, 16);
            this.radioButtonEquation.TabIndex = 27;
            this.radioButtonEquation.UseVisualStyleBackColor = true;
            // 
            // panelRule
            // 
            this.panelRule.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelRule.Controls.Add(this.textBoxPriority);
            this.panelRule.Controls.Add(this.label5);
            this.panelRule.Controls.Add(this.radioButtonEquation);
            this.panelRule.Controls.Add(this.radioButtonGrid);
            this.panelRule.Controls.Add(this.comboBoxCentralCellFinalState);
            this.panelRule.Controls.Add(this.label1);
            this.panelRule.Controls.Add(this.IfSatisfied);
            this.panelRule.Controls.Add(this.buttonRandomize);
            this.panelRule.Controls.Add(this.buttonApply);
            this.panelRule.Controls.Add(this.panelGridRule);
            this.panelRule.Controls.Add(this.panel2);
            this.panelRule.Location = new System.Drawing.Point(4, 229);
            this.panelRule.Name = "panelRule";
            this.panelRule.Size = new System.Drawing.Size(273, 420);
            this.panelRule.TabIndex = 28;
            // 
            // textBoxPriority
            // 
            this.textBoxPriority.Location = new System.Drawing.Point(128, 278);
            this.textBoxPriority.MaxLength = 2;
            this.textBoxPriority.Name = "textBoxPriority";
            this.textBoxPriority.Size = new System.Drawing.Size(48, 22);
            this.textBoxPriority.TabIndex = 29;
            this.textBoxPriority.Text = "1";
            this.textBoxPriority.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumber_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Priority: ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.comboBoxRuleSchema);
            this.panel4.Controls.Add(this.buttonGridCreation);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.textBoxYMax);
            this.panel4.Controls.Add(this.textBoxXMax);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.textBoxStep);
            this.panel4.Controls.Add(this.textBoxY);
            this.panel4.Controls.Add(this.textBoxX);
            this.panel4.Controls.Add(this.labelX);
            this.panel4.Controls.Add(this.labelY);
            this.panel4.Controls.Add(this.LabelSize);
            this.panel4.Controls.Add(this.labelStep);
            this.panel4.Location = new System.Drawing.Point(6, 54);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(271, 137);
            this.panel4.TabIndex = 29;
            // 
            // comboBoxRuleSchema
            // 
            this.comboBoxRuleSchema.FormattingEnabled = true;
            this.comboBoxRuleSchema.Items.AddRange(new object[] {
            "List",
            "Priority",
            "Random"});
            this.comboBoxRuleSchema.Location = new System.Drawing.Point(150, 79);
            this.comboBoxRuleSchema.Name = "comboBoxRuleSchema";
            this.comboBoxRuleSchema.Size = new System.Drawing.Size(121, 24);
            this.comboBoxRuleSchema.TabIndex = 20;
            this.comboBoxRuleSchema.Text = "List";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Choose rule schema: ";
            // 
            // textBoxYMax
            // 
            this.textBoxYMax.Location = new System.Drawing.Point(215, 51);
            this.textBoxYMax.MaxLength = 2;
            this.textBoxYMax.Name = "textBoxYMax";
            this.textBoxYMax.Size = new System.Drawing.Size(46, 22);
            this.textBoxYMax.TabIndex = 5;
            this.textBoxYMax.Text = "20";
            this.textBoxYMax.Visible = false;
            this.textBoxYMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumber_KeyPress);
            // 
            // textBoxXMax
            // 
            this.textBoxXMax.Location = new System.Drawing.Point(115, 51);
            this.textBoxXMax.MaxLength = 2;
            this.textBoxXMax.Name = "textBoxXMax";
            this.textBoxXMax.Size = new System.Drawing.Size(46, 22);
            this.textBoxXMax.TabIndex = 4;
            this.textBoxXMax.Text = "20";
            this.textBoxXMax.Visible = false;
            this.textBoxXMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckNumber_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "x =";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "y = ";
            this.label4.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Max size: ";
            this.label2.Visible = false;
            // 
            // labelGridCreator
            // 
            this.labelGridCreator.AutoSize = true;
            this.labelGridCreator.Location = new System.Drawing.Point(13, 34);
            this.labelGridCreator.Name = "labelGridCreator";
            this.labelGridCreator.Size = new System.Drawing.Size(90, 17);
            this.labelGridCreator.TabIndex = 36;
            this.labelGridCreator.Text = "Grid Creator:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1267, 28);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.specifyMaxSizeToolStripMenuItem,
            this.changeContradictionSchemaToolStripMenuItem,
            this.changeTimeToolStripMenuItem,
            this.makeTheGridToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // specifyMaxSizeToolStripMenuItem
            // 
            this.specifyMaxSizeToolStripMenuItem.Name = "specifyMaxSizeToolStripMenuItem";
            this.specifyMaxSizeToolStripMenuItem.Size = new System.Drawing.Size(278, 24);
            this.specifyMaxSizeToolStripMenuItem.Text = "Specify max size";
            this.specifyMaxSizeToolStripMenuItem.Visible = false;
            this.specifyMaxSizeToolStripMenuItem.Click += new System.EventHandler(this.specifyMaxSizeToolStripMenuItem_Click);
            // 
            // changeContradictionSchemaToolStripMenuItem
            // 
            this.changeContradictionSchemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toPriorityToolStripMenuItem,
            this.toListToolStripMenuItem,
            this.toRandomToolStripMenuItem});
            this.changeContradictionSchemaToolStripMenuItem.Name = "changeContradictionSchemaToolStripMenuItem";
            this.changeContradictionSchemaToolStripMenuItem.Size = new System.Drawing.Size(278, 24);
            this.changeContradictionSchemaToolStripMenuItem.Text = "Change Contradiction Schema";
            // 
            // toPriorityToolStripMenuItem
            // 
            this.toPriorityToolStripMenuItem.Name = "toPriorityToolStripMenuItem";
            this.toPriorityToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.toPriorityToolStripMenuItem.Text = "To Priority";
            this.toPriorityToolStripMenuItem.Click += new System.EventHandler(this.toPriorityToolStripMenuItem_Click);
            // 
            // toListToolStripMenuItem
            // 
            this.toListToolStripMenuItem.Name = "toListToolStripMenuItem";
            this.toListToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.toListToolStripMenuItem.Text = "To List";
            this.toListToolStripMenuItem.Click += new System.EventHandler(this.toListToolStripMenuItem_Click);
            // 
            // toRandomToolStripMenuItem
            // 
            this.toRandomToolStripMenuItem.Name = "toRandomToolStripMenuItem";
            this.toRandomToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.toRandomToolStripMenuItem.Text = "To Random";
            this.toRandomToolStripMenuItem.Click += new System.EventHandler(this.toRandomToolStripMenuItem_Click);
            // 
            // changeTimeToolStripMenuItem
            // 
            this.changeTimeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xToolStripMenuItem,
            this.msToolStripMenuItem,
            this.msToolStripMenuItem1,
            this.sToolStripMenuItem,
            this.sToolStripMenuItem1});
            this.changeTimeToolStripMenuItem.Name = "changeTimeToolStripMenuItem";
            this.changeTimeToolStripMenuItem.Size = new System.Drawing.Size(278, 24);
            this.changeTimeToolStripMenuItem.Text = "Change time";
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.xToolStripMenuItem.Text = "10x";
            this.xToolStripMenuItem.Click += new System.EventHandler(this.msToolStripMenuItem_Click);
            // 
            // msToolStripMenuItem
            // 
            this.msToolStripMenuItem.Name = "msToolStripMenuItem";
            this.msToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.msToolStripMenuItem.Text = "5x";
            this.msToolStripMenuItem.Click += new System.EventHandler(this.msToolStripMenuItem_Click);
            // 
            // msToolStripMenuItem1
            // 
            this.msToolStripMenuItem1.Name = "msToolStripMenuItem1";
            this.msToolStripMenuItem1.Size = new System.Drawing.Size(175, 24);
            this.msToolStripMenuItem1.Text = "2x";
            this.msToolStripMenuItem1.Click += new System.EventHandler(this.msToolStripMenuItem_Click);
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.sToolStripMenuItem.Text = "1x";
            this.sToolStripMenuItem.Click += new System.EventHandler(this.msToolStripMenuItem_Click);
            // 
            // sToolStripMenuItem1
            // 
            this.sToolStripMenuItem1.Name = "sToolStripMenuItem1";
            this.sToolStripMenuItem1.Size = new System.Drawing.Size(175, 24);
            this.sToolStripMenuItem1.Text = "0.5x";
            this.sToolStripMenuItem1.Click += new System.EventHandler(this.msToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // tableLayoutPanelMainGrid
            // 
            this.tableLayoutPanelMainGrid.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelMainGrid.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelMainGrid.ColumnCount = 1;
            this.tableLayoutPanelMainGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMainGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanelMainGrid.Enabled = false;
            this.tableLayoutPanelMainGrid.Location = new System.Drawing.Point(283, 24);
            this.tableLayoutPanelMainGrid.Name = "tableLayoutPanelMainGrid";
            this.tableLayoutPanelMainGrid.RowCount = 1;
            this.tableLayoutPanelMainGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMainGrid.Size = new System.Drawing.Size(976, 654);
            this.tableLayoutPanelMainGrid.TabIndex = 38;
            this.tableLayoutPanelMainGrid.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tableLayoutPanelMainGrid_CellPaint);
            this.tableLayoutPanelMainGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanelMainGrid_MouseClick);
            this.tableLayoutPanelMainGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanelMainGrid_MouseDoubleClick);
            // 
            // buttonruleList
            // 
            this.buttonruleList.Location = new System.Drawing.Point(76, 667);
            this.buttonruleList.Name = "buttonruleList";
            this.buttonruleList.Size = new System.Drawing.Size(118, 34);
            this.buttonruleList.TabIndex = 39;
            this.buttonruleList.Text = "Rule List";
            this.buttonruleList.UseVisualStyleBackColor = true;
            this.buttonruleList.Click += new System.EventHandler(this.buttonruleList_Click);
            // 
            // buttonNextStep
            // 
            this.buttonNextStep.Enabled = false;
            this.buttonNextStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNextStep.Image = global::Cellular_Automaton.Properties.Resources.Right_arrow_next_play_forward;
            this.buttonNextStep.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNextStep.Location = new System.Drawing.Point(1088, 684);
            this.buttonNextStep.Name = "buttonNextStep";
            this.buttonNextStep.Size = new System.Drawing.Size(171, 37);
            this.buttonNextStep.TabIndex = 35;
            this.buttonNextStep.Text = "Next Step";
            this.buttonNextStep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNextStep.UseVisualStyleBackColor = true;
            this.buttonNextStep.Click += new System.EventHandler(this.buttonNextStep_Click);
            // 
            // buttonPreviousStep
            // 
            this.buttonPreviousStep.Enabled = false;
            this.buttonPreviousStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPreviousStep.Image = global::Cellular_Automaton.Properties.Resources.Left_arrow_back_move_right;
            this.buttonPreviousStep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPreviousStep.Location = new System.Drawing.Point(283, 684);
            this.buttonPreviousStep.Name = "buttonPreviousStep";
            this.buttonPreviousStep.Size = new System.Drawing.Size(203, 37);
            this.buttonPreviousStep.TabIndex = 34;
            this.buttonPreviousStep.Text = "Previous Step";
            this.buttonPreviousStep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPreviousStep.UseVisualStyleBackColor = true;
            this.buttonPreviousStep.Click += new System.EventHandler(this.buttonPreviousStep_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Image = global::Cellular_Automaton.Properties.Resources._49_24;
            this.buttonStop.Location = new System.Drawing.Point(790, 684);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(37, 37);
            this.buttonStop.TabIndex = 33;
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Enabled = false;
            this.buttonPause.Image = global::Cellular_Automaton.Properties.Resources.pause_3_24;
            this.buttonPause.Location = new System.Drawing.Point(746, 684);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(38, 37);
            this.buttonPause.TabIndex = 32;
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Enabled = false;
            this.buttonPlay.Image = global::Cellular_Automaton.Properties.Resources.Play_next_music_movie_film;
            this.buttonPlay.Location = new System.Drawing.Point(704, 684);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(36, 37);
            this.buttonPlay.TabIndex = 31;
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // makeTheGridToolStripMenuItem
            // 
            this.makeTheGridToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aliveToolStripMenuItem,
            this.deadToolStripMenuItem});
            this.makeTheGridToolStripMenuItem.Name = "makeTheGridToolStripMenuItem";
            this.makeTheGridToolStripMenuItem.Size = new System.Drawing.Size(278, 24);
            this.makeTheGridToolStripMenuItem.Text = "Make the grid";
            // 
            // aliveToolStripMenuItem
            // 
            this.aliveToolStripMenuItem.Name = "aliveToolStripMenuItem";
            this.aliveToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.aliveToolStripMenuItem.Text = "Alive";
            this.aliveToolStripMenuItem.Click += new System.EventHandler(this.aliveToolStripMenuItem_Click);
            // 
            // deadToolStripMenuItem
            // 
            this.deadToolStripMenuItem.Name = "deadToolStripMenuItem";
            this.deadToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.deadToolStripMenuItem.Text = "Dead";
            this.deadToolStripMenuItem.Click += new System.EventHandler(this.aliveToolStripMenuItem_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 725);
            this.Controls.Add(this.buttonruleList);
            this.Controls.Add(this.tableLayoutPanelMainGrid);
            this.Controls.Add(this.labelGridCreator);
            this.Controls.Add(this.buttonNextStep);
            this.Controls.Add(this.buttonPreviousStep);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.labelRules);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelRule);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GUI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cellular Automaton";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUI_FormClosing);
            this.panelGridRule.ResumeLayout(false);
            this.panelGridRule.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelRule.ResumeLayout(false);
            this.panelRule.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Label labelStep;
        private System.Windows.Forms.Label labelRules;
        private System.Windows.Forms.Label LabelSize;
        private System.Windows.Forms.Label labelDead;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelAlive;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxStep;
        private System.Windows.Forms.TextBox textBoxEquationDead;
        private System.Windows.Forms.TextBox textBoxEquationAlive;
        private System.Windows.Forms.Button buttonRandomize;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAddRule;
        private System.Windows.Forms.ComboBox comboBoxDead;
        private System.Windows.Forms.ComboBox comboBoxAlive;
        private System.Windows.Forms.Button buttonGridCreation;
        private System.Windows.Forms.RadioButton radioButtonGridAlive;
        private System.Windows.Forms.RadioButton radioButtonGridDead;
        private System.Windows.Forms.Panel panelGridRule;
        private System.Windows.Forms.Label IfSatisfied;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCentralCellFinalState;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButtonGrid;
        private System.Windows.Forms.RadioButton radioButtonEquation;
        private System.Windows.Forms.Panel panelRule;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxPriority;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxRuleSchema;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxYMax;
        private System.Windows.Forms.TextBox textBoxXMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonNextStep;
        private System.Windows.Forms.Button buttonPreviousStep;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Label labelGridCreator;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specifyMaxSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeContradictionSchemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMainGrid;
        private System.Windows.Forms.Button buttonruleList;
        private System.Windows.Forms.ToolStripMenuItem toPriorityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toRandomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeTheGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aliveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deadToolStripMenuItem;
    }
}