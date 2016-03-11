using System;
using System.IO;
using System.Windows.Forms;

namespace Pasikonik
{
    partial class Pasikonik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pasikonik));
            this.gameParameters = new System.Windows.Forms.GroupBox();
            this.startGameButton = new System.Windows.Forms.Button();
            this.maxLengthTextBox = new System.Windows.Forms.TextBox();
            this.difficultyLevelComboBox = new System.Windows.Forms.ComboBox();
            this.difficultyLevelLabel = new System.Windows.Forms.Label();
            this.maxLengthLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.abcdAlphabet = new System.Windows.Forms.RadioButton();
            this.qwertyAlphabet = new System.Windows.Forms.RadioButton();
            this.alphabetLabel = new System.Windows.Forms.Label();
            this.patternTextBox = new System.Windows.Forms.TextBox();
            this.patternLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rulesTextBox = new System.Windows.Forms.GroupBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.gameGroupBox = new System.Windows.Forms.GroupBox();
            this.alphabetLengthLabel = new System.Windows.Forms.Label();
            this.alphabetLengthTextBox = new System.Windows.Forms.TextBox();
            this.gameParameters.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.rulesTextBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameParameters
            // 
            this.gameParameters.AutoSize = true;
            this.gameParameters.Controls.Add(this.alphabetLengthTextBox);
            this.gameParameters.Controls.Add(this.alphabetLengthLabel);
            this.gameParameters.Controls.Add(this.startGameButton);
            this.gameParameters.Controls.Add(this.maxLengthTextBox);
            this.gameParameters.Controls.Add(this.difficultyLevelComboBox);
            this.gameParameters.Controls.Add(this.difficultyLevelLabel);
            this.gameParameters.Controls.Add(this.maxLengthLabel);
            this.gameParameters.Controls.Add(this.panel1);
            this.gameParameters.Controls.Add(this.alphabetLabel);
            this.gameParameters.Controls.Add(this.patternTextBox);
            this.gameParameters.Controls.Add(this.patternLabel);
            this.gameParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameParameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameParameters.Location = new System.Drawing.Point(0, 0);
            this.gameParameters.Name = "gameParameters";
            this.gameParameters.Size = new System.Drawing.Size(433, 238);
            this.gameParameters.TabIndex = 0;
            this.gameParameters.TabStop = false;
            this.gameParameters.Text = "Parametry gry";
            // 
            // startGameButton
            // 
            this.startGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.startGameButton.Location = new System.Drawing.Point(298, 66);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(128, 100);
            this.startGameButton.TabIndex = 10;
            this.startGameButton.Text = "Start gry";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // maxLengthTextBox
            // 
            this.maxLengthTextBox.Location = new System.Drawing.Point(155, 144);
            this.maxLengthTextBox.Name = "maxLengthTextBox";
            this.maxLengthTextBox.Size = new System.Drawing.Size(127, 22);
            this.maxLengthTextBox.TabIndex = 9;
            // 
            // difficultyLevelComboBox
            // 
            this.difficultyLevelComboBox.FormattingEnabled = true;
            this.difficultyLevelComboBox.Items.AddRange(new object[] {
            "Easy",
            "Normal"});
            this.difficultyLevelComboBox.Location = new System.Drawing.Point(132, 192);
            this.difficultyLevelComboBox.Name = "difficultyLevelComboBox";
            this.difficultyLevelComboBox.Size = new System.Drawing.Size(150, 24);
            this.difficultyLevelComboBox.TabIndex = 8;
            // 
            // difficultyLevelLabel
            // 
            this.difficultyLevelLabel.AutoSize = true;
            this.difficultyLevelLabel.Location = new System.Drawing.Point(18, 195);
            this.difficultyLevelLabel.Name = "difficultyLevelLabel";
            this.difficultyLevelLabel.Size = new System.Drawing.Size(113, 16);
            this.difficultyLevelLabel.TabIndex = 7;
            this.difficultyLevelLabel.Text = "Poziom trudności:";
            // 
            // maxLengthLabel
            // 
            this.maxLengthLabel.AutoSize = true;
            this.maxLengthLabel.Location = new System.Drawing.Point(18, 147);
            this.maxLengthLabel.Name = "maxLengthLabel";
            this.maxLengthLabel.Size = new System.Drawing.Size(131, 16);
            this.maxLengthLabel.TabIndex = 6;
            this.maxLengthLabel.Text = "Max długość słowa:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.abcdAlphabet);
            this.panel1.Controls.Add(this.qwertyAlphabet);
            this.panel1.Location = new System.Drawing.Point(87, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 27);
            this.panel1.TabIndex = 5;
            // 
            // abcdAlphabet
            // 
            this.abcdAlphabet.AutoCheck = false;
            this.abcdAlphabet.AutoSize = true;
            this.abcdAlphabet.Location = new System.Drawing.Point(3, 3);
            this.abcdAlphabet.Name = "abcdAlphabet";
            this.abcdAlphabet.Size = new System.Drawing.Size(66, 20);
            this.abcdAlphabet.TabIndex = 3;
            this.abcdAlphabet.TabStop = true;
            this.abcdAlphabet.Text = "abcd...";
            this.abcdAlphabet.UseVisualStyleBackColor = true;
            // 
            // qwertyAlphabet
            // 
            this.qwertyAlphabet.AutoSize = true;
            this.qwertyAlphabet.Checked = true;
            this.qwertyAlphabet.Location = new System.Drawing.Point(101, 3);
            this.qwertyAlphabet.Name = "qwertyAlphabet";
            this.qwertyAlphabet.Size = new System.Drawing.Size(74, 20);
            this.qwertyAlphabet.TabIndex = 4;
            this.qwertyAlphabet.TabStop = true;
            this.qwertyAlphabet.Text = "qwerty...";
            this.qwertyAlphabet.UseVisualStyleBackColor = true;
            // 
            // alphabetLabel
            // 
            this.alphabetLabel.AutoSize = true;
            this.alphabetLabel.Location = new System.Drawing.Point(18, 71);
            this.alphabetLabel.Name = "alphabetLabel";
            this.alphabetLabel.Size = new System.Drawing.Size(53, 16);
            this.alphabetLabel.TabIndex = 2;
            this.alphabetLabel.Text = "Alfabet:";
            // 
            // patternTextBox
            // 
            this.patternTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.patternTextBox.ForeColor = System.Drawing.Color.Red;
            this.patternTextBox.Location = new System.Drawing.Point(87, 28);
            this.patternTextBox.Name = "patternTextBox";
            this.patternTextBox.ReadOnly = true;
            this.patternTextBox.Size = new System.Drawing.Size(195, 23);
            this.patternTextBox.TabIndex = 1;
            this.patternTextBox.Text = "XX";
            this.patternTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // patternLabel
            // 
            this.patternLabel.AutoSize = true;
            this.patternLabel.Location = new System.Drawing.Point(18, 31);
            this.patternLabel.Name = "patternLabel";
            this.patternLabel.Size = new System.Drawing.Size(63, 16);
            this.patternLabel.TabIndex = 0;
            this.patternLabel.Text = "Wzorzec:";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(734, 238);
            this.panel2.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rulesTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gameParameters);
            this.splitContainer1.Size = new System.Drawing.Size(734, 238);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 5;
            // 
            // rulesTextBox
            // 
            this.rulesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rulesTextBox.Controls.Add(this.richTextBox);
            this.rulesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rulesTextBox.Location = new System.Drawing.Point(0, 0);
            this.rulesTextBox.Name = "rulesTextBox";
            this.rulesTextBox.Size = new System.Drawing.Size(300, 238);
            this.rulesTextBox.TabIndex = 0;
            this.rulesTextBox.TabStop = false;
            this.rulesTextBox.Text = "Zasady gry";
            // 
            // richTextBox
            // 
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.richTextBox.Location = new System.Drawing.Point(3, 18);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(294, 217);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // gameGroupBox
            // 
            this.gameGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameGroupBox.ForeColor = System.Drawing.Color.Black;
            this.gameGroupBox.Location = new System.Drawing.Point(0, 238);
            this.gameGroupBox.Margin = new System.Windows.Forms.Padding(10);
            this.gameGroupBox.Name = "gameGroupBox";
            this.gameGroupBox.Padding = new System.Windows.Forms.Padding(10);
            this.gameGroupBox.Size = new System.Drawing.Size(734, 423);
            this.gameGroupBox.TabIndex = 6;
            this.gameGroupBox.TabStop = false;
            this.gameGroupBox.Text = "Gra";
            // 
            // alphabetLengthLabel
            // 
            this.alphabetLengthLabel.AutoSize = true;
            this.alphabetLengthLabel.Location = new System.Drawing.Point(18, 109);
            this.alphabetLengthLabel.Name = "alphabetLengthLabel";
            this.alphabetLengthLabel.Size = new System.Drawing.Size(115, 16);
            this.alphabetLengthLabel.TabIndex = 11;
            this.alphabetLengthLabel.Text = "Długość alfabetu:";
            // 
            // alphabetLengthTextBox
            // 
            this.alphabetLengthTextBox.Location = new System.Drawing.Point(155, 109);
            this.alphabetLengthTextBox.Name = "alphabetLengthTextBox";
            this.alphabetLengthTextBox.Size = new System.Drawing.Size(127, 22);
            this.alphabetLengthTextBox.TabIndex = 12;
            // 
            // Pasikonik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 661);
            this.Controls.Add(this.gameGroupBox);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(750, 700);
            this.Name = "Pasikonik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pasikonik";
            this.gameParameters.ResumeLayout(false);
            this.gameParameters.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.rulesTextBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gameParameters;
        private System.Windows.Forms.TextBox patternTextBox;
        private System.Windows.Forms.Label patternLabel;
        private System.Windows.Forms.Label alphabetLabel;
        private System.Windows.Forms.RadioButton abcdAlphabet;
        private System.Windows.Forms.RadioButton qwertyAlphabet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox maxLengthTextBox;
        private System.Windows.Forms.ComboBox difficultyLevelComboBox;
        private System.Windows.Forms.Label difficultyLevelLabel;
        private System.Windows.Forms.Label maxLengthLabel;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox rulesTextBox;
        private System.Windows.Forms.GroupBox gameGroupBox;
        private RichTextBox richTextBox;
        private Label alphabetLengthLabel;
        private TextBox alphabetLengthTextBox;
    }
}

