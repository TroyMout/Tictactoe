namespace Assignment2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            textBoxSymbol2 = new TextBox();
            textBoxSymbol1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBoxName2 = new TextBox();
            textBoxName1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBoxGameArea = new GroupBox();
            textBoxNextTurn = new TextBox();
            label6 = new Label();
            buttonReset = new Button();
            buttonContinue = new Button();
            buttonStart = new Button();
            buttonBottomRight = new Button();
            buttonBottomCenter = new Button();
            buttonBottomLeft = new Button();
            buttonCenterRight = new Button();
            buttonCenter = new Button();
            buttonCenterLeft = new Button();
            buttonTopRight = new Button();
            buttonTopCenter = new Button();
            buttonTopLeft = new Button();
            groupBoxStats = new GroupBox();
            textBoxStats = new TextBox();
            textBoxWinner = new TextBox();
            label5 = new Label();
            toolTip1 = new ToolTip(components);
            groupBox1.SuspendLayout();
            groupBoxGameArea.SuspendLayout();
            groupBoxStats.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxSymbol2);
            groupBox1.Controls.Add(textBoxSymbol1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxName2);
            groupBox1.Controls.Add(textBoxName1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(606, 117);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Game Setup";
            toolTip1.SetToolTip(groupBox1, "Player information");
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBoxSymbol2
            // 
            textBoxSymbol2.Location = new Point(452, 74);
            textBoxSymbol2.Name = "textBoxSymbol2";
            textBoxSymbol2.Size = new Size(125, 27);
            textBoxSymbol2.TabIndex = 7;
            toolTip1.SetToolTip(textBoxSymbol2, "Insert symbol that will represent the second player");
            // 
            // textBoxSymbol1
            // 
            textBoxSymbol1.Location = new Point(452, 34);
            textBoxSymbol1.Name = "textBoxSymbol1";
            textBoxSymbol1.Size = new Size(125, 27);
            textBoxSymbol1.TabIndex = 6;
            toolTip1.SetToolTip(textBoxSymbol1, "Insert symbol that will represent the first player");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(328, 77);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 5;
            label4.Text = "Player 2 Symbol:";
            toolTip1.SetToolTip(label4, "Insert symbol that will represent the second player");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(328, 37);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 4;
            label3.Text = "Player 1 Symbol:";
            toolTip1.SetToolTip(label3, "Insert symbol that will represent the first player");
            // 
            // textBoxName2
            // 
            textBoxName2.Location = new Point(137, 74);
            textBoxName2.Name = "textBoxName2";
            textBoxName2.Size = new Size(125, 27);
            textBoxName2.TabIndex = 3;
            toolTip1.SetToolTip(textBoxName2, "Insert name of second player");
            // 
            // textBoxName1
            // 
            textBoxName1.Location = new Point(137, 34);
            textBoxName1.Name = "textBoxName1";
            textBoxName1.Size = new Size(125, 27);
            textBoxName1.TabIndex = 2;
            toolTip1.SetToolTip(textBoxName1, "Insert name of first player");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 77);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 1;
            label2.Text = "Player 2 Name:";
            toolTip1.SetToolTip(label2, "Insert name of second player");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 37);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 0;
            label1.Text = "Player 1 Name:";
            toolTip1.SetToolTip(label1, "Insert name of first player");
            // 
            // groupBoxGameArea
            // 
            groupBoxGameArea.Controls.Add(textBoxNextTurn);
            groupBoxGameArea.Controls.Add(label6);
            groupBoxGameArea.Controls.Add(buttonReset);
            groupBoxGameArea.Controls.Add(buttonContinue);
            groupBoxGameArea.Controls.Add(buttonStart);
            groupBoxGameArea.Controls.Add(buttonBottomRight);
            groupBoxGameArea.Controls.Add(buttonBottomCenter);
            groupBoxGameArea.Controls.Add(buttonBottomLeft);
            groupBoxGameArea.Controls.Add(buttonCenterRight);
            groupBoxGameArea.Controls.Add(buttonCenter);
            groupBoxGameArea.Controls.Add(buttonCenterLeft);
            groupBoxGameArea.Controls.Add(buttonTopRight);
            groupBoxGameArea.Controls.Add(buttonTopCenter);
            groupBoxGameArea.Controls.Add(buttonTopLeft);
            groupBoxGameArea.Location = new Point(12, 135);
            groupBoxGameArea.Name = "groupBoxGameArea";
            groupBoxGameArea.Size = new Size(397, 323);
            groupBoxGameArea.TabIndex = 1;
            groupBoxGameArea.TabStop = false;
            groupBoxGameArea.Text = "Game Area";
            toolTip1.SetToolTip(groupBoxGameArea, "Game information");
            // 
            // textBoxNextTurn
            // 
            textBoxNextTurn.Enabled = false;
            textBoxNextTurn.Location = new Point(117, 286);
            textBoxNextTurn.Name = "textBoxNextTurn";
            textBoxNextTurn.Size = new Size(125, 27);
            textBoxNextTurn.TabIndex = 9;
            toolTip1.SetToolTip(textBoxNextTurn, "Who's turn is next");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 290);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 9;
            label6.Text = "Next Turn:";
            toolTip1.SetToolTip(label6, "Who's turn is next");
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(280, 156);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(94, 29);
            buttonReset.TabIndex = 11;
            buttonReset.Text = "Reset";
            toolTip1.SetToolTip(buttonReset, "Reset the game and player info");
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonContinue
            // 
            buttonContinue.Enabled = false;
            buttonContinue.Location = new Point(280, 109);
            buttonContinue.Name = "buttonContinue";
            buttonContinue.Size = new Size(94, 29);
            buttonContinue.TabIndex = 10;
            buttonContinue.Text = "Continue";
            toolTip1.SetToolTip(buttonContinue, "Start next round ");
            buttonContinue.UseVisualStyleBackColor = true;
            buttonContinue.Click += buttonContinue_Click;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(280, 62);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(94, 29);
            buttonStart.TabIndex = 9;
            buttonStart.Text = "Start";
            toolTip1.SetToolTip(buttonStart, "Start the game once player info is entered");
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonBottomRight
            // 
            buttonBottomRight.Enabled = false;
            buttonBottomRight.Location = new Point(187, 201);
            buttonBottomRight.Name = "buttonBottomRight";
            buttonBottomRight.Size = new Size(75, 75);
            buttonBottomRight.TabIndex = 8;
            buttonBottomRight.UseVisualStyleBackColor = true;
            buttonBottomRight.Click += buttonBottomRight_Click;
            // 
            // buttonBottomCenter
            // 
            buttonBottomCenter.Enabled = false;
            buttonBottomCenter.Location = new Point(104, 201);
            buttonBottomCenter.Name = "buttonBottomCenter";
            buttonBottomCenter.Size = new Size(75, 75);
            buttonBottomCenter.TabIndex = 7;
            buttonBottomCenter.UseVisualStyleBackColor = true;
            buttonBottomCenter.Click += buttonBottomCenter_Click;
            // 
            // buttonBottomLeft
            // 
            buttonBottomLeft.Enabled = false;
            buttonBottomLeft.Location = new Point(23, 201);
            buttonBottomLeft.Name = "buttonBottomLeft";
            buttonBottomLeft.Size = new Size(75, 75);
            buttonBottomLeft.TabIndex = 6;
            buttonBottomLeft.UseVisualStyleBackColor = true;
            buttonBottomLeft.Click += buttonBottomLeft_Click;
            // 
            // buttonCenterRight
            // 
            buttonCenterRight.Enabled = false;
            buttonCenterRight.Location = new Point(187, 120);
            buttonCenterRight.Name = "buttonCenterRight";
            buttonCenterRight.Size = new Size(75, 75);
            buttonCenterRight.TabIndex = 5;
            buttonCenterRight.UseVisualStyleBackColor = true;
            buttonCenterRight.Click += buttonCenterRight_Click;
            // 
            // buttonCenter
            // 
            buttonCenter.Enabled = false;
            buttonCenter.Location = new Point(104, 120);
            buttonCenter.Name = "buttonCenter";
            buttonCenter.Size = new Size(75, 75);
            buttonCenter.TabIndex = 4;
            buttonCenter.UseVisualStyleBackColor = true;
            buttonCenter.Click += buttonCenter_Click;
            // 
            // buttonCenterLeft
            // 
            buttonCenterLeft.Enabled = false;
            buttonCenterLeft.Location = new Point(23, 120);
            buttonCenterLeft.Name = "buttonCenterLeft";
            buttonCenterLeft.Size = new Size(75, 75);
            buttonCenterLeft.TabIndex = 3;
            buttonCenterLeft.UseVisualStyleBackColor = true;
            buttonCenterLeft.Click += buttonCenterLeft_Click;
            // 
            // buttonTopRight
            // 
            buttonTopRight.Enabled = false;
            buttonTopRight.Location = new Point(187, 39);
            buttonTopRight.Name = "buttonTopRight";
            buttonTopRight.Size = new Size(75, 75);
            buttonTopRight.TabIndex = 2;
            buttonTopRight.UseVisualStyleBackColor = true;
            buttonTopRight.Click += buttonTopRight_Click;
            // 
            // buttonTopCenter
            // 
            buttonTopCenter.Enabled = false;
            buttonTopCenter.Location = new Point(104, 39);
            buttonTopCenter.Name = "buttonTopCenter";
            buttonTopCenter.Size = new Size(75, 75);
            buttonTopCenter.TabIndex = 1;
            buttonTopCenter.UseVisualStyleBackColor = true;
            buttonTopCenter.Click += buttonTopCenter_Click;
            // 
            // buttonTopLeft
            // 
            buttonTopLeft.Enabled = false;
            buttonTopLeft.Location = new Point(23, 39);
            buttonTopLeft.Name = "buttonTopLeft";
            buttonTopLeft.Size = new Size(75, 75);
            buttonTopLeft.TabIndex = 0;
            buttonTopLeft.UseVisualStyleBackColor = true;
            buttonTopLeft.Click += buttonTopLeft_Click;
            // 
            // groupBoxStats
            // 
            groupBoxStats.Controls.Add(textBoxStats);
            groupBoxStats.Controls.Add(textBoxWinner);
            groupBoxStats.Controls.Add(label5);
            groupBoxStats.Location = new Point(415, 135);
            groupBoxStats.Name = "groupBoxStats";
            groupBoxStats.Size = new Size(203, 323);
            groupBoxStats.TabIndex = 2;
            groupBoxStats.TabStop = false;
            groupBoxStats.Text = "Game Stats";
            toolTip1.SetToolTip(groupBoxStats, "Information on game history");
            // 
            // textBoxStats
            // 
            textBoxStats.Enabled = false;
            textBoxStats.Location = new Point(9, 26);
            textBoxStats.Multiline = true;
            textBoxStats.Name = "textBoxStats";
            textBoxStats.Size = new Size(188, 255);
            textBoxStats.TabIndex = 9;
            toolTip1.SetToolTip(textBoxStats, "Displays game outcome history");
            // 
            // textBoxWinner
            // 
            textBoxWinner.Enabled = false;
            textBoxWinner.Location = new Point(72, 287);
            textBoxWinner.Name = "textBoxWinner";
            textBoxWinner.Size = new Size(125, 27);
            textBoxWinner.TabIndex = 8;
            toolTip1.SetToolTip(textBoxWinner, "Winner of the current game");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 289);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 1;
            label5.Text = "Winner:";
            toolTip1.SetToolTip(label5, "Winner of the current game");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 468);
            Controls.Add(groupBoxStats);
            Controls.Add(groupBoxGameArea);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tic-Tac-Toe";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxGameArea.ResumeLayout(false);
            groupBoxGameArea.PerformLayout();
            groupBoxStats.ResumeLayout(false);
            groupBoxStats.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxName2;
        private TextBox textBoxName1;
        private Label label2;
        private Label label1;
        private TextBox textBoxSymbol2;
        private TextBox textBoxSymbol1;
        private Label label4;
        private Label label3;
        private GroupBox groupBoxGameArea;
        private Button buttonReset;
        private Button buttonContinue;
        private Button buttonStart;
        private Button buttonBottomRight;
        private Button buttonBottomCenter;
        private Button buttonBottomLeft;
        private Button buttonCenterRight;
        private Button buttonCenter;
        private Button buttonCenterLeft;
        private Button buttonTopRight;
        private Button buttonTopCenter;
        private Button buttonTopLeft;
        private GroupBox groupBoxStats;
        private Label label5;
        private TextBox textBoxNextTurn;
        private Label label6;
        private TextBox textBoxWinner;
        private TextBox textBoxStats;
        private ToolTip toolTip1;
    }
}