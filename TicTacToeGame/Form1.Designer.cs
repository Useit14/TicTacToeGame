namespace TicTacToeGame
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
            groupBoxCells = new GroupBox();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            buttonFindStrategies = new Button();
            buttonShowStrategies = new Button();
            buttonStartOrNext = new Button();
            radioXPlayer = new RadioButton();
            radioOPlayer = new RadioButton();
            buttonSchowArchiveGames = new Button();
            groupBoxCells.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCells
            // 
            groupBoxCells.AutoSize = true;
            groupBoxCells.Controls.Add(textBox9);
            groupBoxCells.Controls.Add(textBox8);
            groupBoxCells.Controls.Add(textBox7);
            groupBoxCells.Controls.Add(textBox6);
            groupBoxCells.Controls.Add(textBox5);
            groupBoxCells.Controls.Add(textBox4);
            groupBoxCells.Controls.Add(textBox3);
            groupBoxCells.Controls.Add(textBox2);
            groupBoxCells.Controls.Add(textBox1);
            groupBoxCells.Location = new Point(0, 0);
            groupBoxCells.Name = "groupBoxCells";
            groupBoxCells.Size = new Size(467, 380);
            groupBoxCells.TabIndex = 0;
            groupBoxCells.TabStop = false;
            groupBoxCells.Text = "Крестики-нолики";
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox9.Location = new Point(229, 239);
            textBox9.MinimumSize = new Size(100, 100);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 39);
            textBox9.TabIndex = 8;
            textBox9.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox8.Location = new Point(123, 239);
            textBox8.MinimumSize = new Size(100, 100);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 39);
            textBox8.TabIndex = 7;
            textBox8.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(17, 238);
            textBox7.MinimumSize = new Size(100, 100);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 39);
            textBox7.TabIndex = 6;
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(229, 133);
            textBox6.MinimumSize = new Size(100, 100);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 39);
            textBox6.TabIndex = 5;
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(123, 133);
            textBox5.MinimumSize = new Size(100, 100);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 39);
            textBox5.TabIndex = 4;
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(17, 132);
            textBox4.MinimumSize = new Size(100, 100);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 39);
            textBox4.TabIndex = 3;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(229, 26);
            textBox3.MinimumSize = new Size(100, 100);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 39);
            textBox3.TabIndex = 2;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(123, 26);
            textBox2.MinimumSize = new Size(100, 100);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 39);
            textBox2.TabIndex = 1;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(17, 26);
            textBox1.MinimumSize = new Size(100, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 39);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonFindStrategies
            // 
            buttonFindStrategies.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonFindStrategies.Location = new Point(12, 499);
            buttonFindStrategies.Name = "buttonFindStrategies";
            buttonFindStrategies.Size = new Size(173, 29);
            buttonFindStrategies.TabIndex = 1;
            buttonFindStrategies.Text = "Найти все стратегии";
            buttonFindStrategies.UseVisualStyleBackColor = true;
            buttonFindStrategies.Click += buttonFindStrategies_Click;
            // 
            // buttonShowStrategies
            // 
            buttonShowStrategies.Anchor = AnchorStyles.Bottom;
            buttonShowStrategies.Enabled = false;
            buttonShowStrategies.Location = new Point(389, 499);
            buttonShowStrategies.Name = "buttonShowStrategies";
            buttonShowStrategies.Size = new Size(173, 29);
            buttonShowStrategies.TabIndex = 9;
            buttonShowStrategies.Text = "Все стратегии";
            buttonShowStrategies.UseVisualStyleBackColor = true;
            buttonShowStrategies.Click += buttonShowStrategies_Click;
            // 
            // buttonStartOrNext
            // 
            buttonStartOrNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonStartOrNext.Enabled = false;
            buttonStartOrNext.Location = new Point(832, 499);
            buttonStartOrNext.Name = "buttonStartOrNext";
            buttonStartOrNext.Size = new Size(127, 29);
            buttonStartOrNext.TabIndex = 2;
            buttonStartOrNext.Text = "Начать";
            buttonStartOrNext.UseVisualStyleBackColor = true;
            buttonStartOrNext.Click += buttonStartOrNext_Click;
            // 
            // radioXPlayer
            // 
            radioXPlayer.AutoSize = true;
            radioXPlayer.Location = new Point(886, 0);
            radioXPlayer.Name = "radioXPlayer";
            radioXPlayer.Size = new Size(83, 24);
            radioXPlayer.TabIndex = 3;
            radioXPlayer.TabStop = true;
            radioXPlayer.Text = "X игрок";
            radioXPlayer.UseVisualStyleBackColor = true;
            // 
            // radioOPlayer
            // 
            radioOPlayer.AutoSize = true;
            radioOPlayer.Location = new Point(801, 0);
            radioOPlayer.Name = "radioOPlayer";
            radioOPlayer.Size = new Size(85, 24);
            radioOPlayer.TabIndex = 4;
            radioOPlayer.TabStop = true;
            radioOPlayer.Text = "O игрок";
            radioOPlayer.UseVisualStyleBackColor = true;
            // 
            // buttonSchowArchiveGames
            // 
            buttonSchowArchiveGames.Anchor = AnchorStyles.Bottom;
            buttonSchowArchiveGames.Location = new Point(568, 499);
            buttonSchowArchiveGames.Name = "buttonSchowArchiveGames";
            buttonSchowArchiveGames.Size = new Size(173, 29);
            buttonSchowArchiveGames.TabIndex = 10;
            buttonSchowArchiveGames.Text = "Архив игр";
            buttonSchowArchiveGames.UseVisualStyleBackColor = true;
            buttonSchowArchiveGames.Click += buttonSchowArchiveGames_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 540);
            Controls.Add(buttonSchowArchiveGames);
            Controls.Add(buttonShowStrategies);
            Controls.Add(buttonFindStrategies);
            Controls.Add(buttonStartOrNext);
            Controls.Add(radioOPlayer);
            Controls.Add(radioXPlayer);
            Controls.Add(groupBoxCells);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            groupBoxCells.ResumeLayout(false);
            groupBoxCells.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxCells;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button buttonFindStrategies;
        private Button buttonStartOrNext;
        private RadioButton radioXPlayer;
        private RadioButton radioOPlayer;
        private Button buttonShowStrategies;
        private Button buttonSchowArchiveGames;
    }
}