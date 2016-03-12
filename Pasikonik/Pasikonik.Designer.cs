using System;
using System.Drawing;
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
            this.gameParameters = new System.Windows.Forms.GroupBox();
            this.parametersPanel = new System.Windows.Forms.Panel();
            this.startGameButton = new System.Windows.Forms.Button();
            this.alphabetLengthTextBox = new System.Windows.Forms.TextBox();
            this.maxLengthTextBox = new System.Windows.Forms.TextBox();
            this.alphabetGroupBox = new System.Windows.Forms.GroupBox();
            this.abcdAlphabet = new System.Windows.Forms.RadioButton();
            this.qwertyAlphabet = new System.Windows.Forms.RadioButton();
            this.maxLengthLabel = new System.Windows.Forms.Label();
            this.alphabetLengthLabel = new System.Windows.Forms.Label();
            this.difficultyLevelComboBox = new System.Windows.Forms.ComboBox();
            this.patternRichTextBox = new System.Windows.Forms.RichTextBox();
            this.difficultyLevelLabel = new System.Windows.Forms.Label();
            this.patternLabel = new System.Windows.Forms.Label();
            this.alphabetLabel = new System.Windows.Forms.Label();
            this.upperPanel = new System.Windows.Forms.Panel();
            this.upperSplitContainer = new System.Windows.Forms.SplitContainer();
            this.rulesGroupBox = new System.Windows.Forms.GroupBox();
            this.rulesTextBox = new System.Windows.Forms.RichTextBox();
            this.gameGroupBox = new System.Windows.Forms.GroupBox();
            this.gameRichTextBox = new System.Windows.Forms.RichTextBox();
            this.gameParameters.SuspendLayout();
            this.parametersPanel.SuspendLayout();
            this.alphabetGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upperSplitContainer)).BeginInit();
            this.upperSplitContainer.Panel1.SuspendLayout();
            this.upperSplitContainer.Panel2.SuspendLayout();
            this.upperSplitContainer.SuspendLayout();
            this.rulesGroupBox.SuspendLayout();
            this.gameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameParameters
            // 
            this.gameParameters.AutoSize = true;
            this.gameParameters.Controls.Add(this.parametersPanel);
            this.gameParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameParameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameParameters.Location = new System.Drawing.Point(0, 0);
            this.gameParameters.Name = "gameParameters";
            this.gameParameters.Size = new System.Drawing.Size(458, 238);
            this.gameParameters.TabIndex = 0;
            this.gameParameters.TabStop = false;
            this.gameParameters.Text = "Parametry gry";
            // 
            // parametersPanel
            // 
            this.parametersPanel.Controls.Add(this.startGameButton);
            this.parametersPanel.Controls.Add(this.alphabetLengthTextBox);
            this.parametersPanel.Controls.Add(this.maxLengthTextBox);
            this.parametersPanel.Controls.Add(this.alphabetGroupBox);
            this.parametersPanel.Controls.Add(this.maxLengthLabel);
            this.parametersPanel.Controls.Add(this.alphabetLengthLabel);
            this.parametersPanel.Controls.Add(this.difficultyLevelComboBox);
            this.parametersPanel.Controls.Add(this.patternRichTextBox);
            this.parametersPanel.Controls.Add(this.difficultyLevelLabel);
            this.parametersPanel.Controls.Add(this.patternLabel);
            this.parametersPanel.Controls.Add(this.alphabetLabel);
            this.parametersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parametersPanel.Location = new System.Drawing.Point(3, 18);
            this.parametersPanel.Name = "parametersPanel";
            this.parametersPanel.Size = new System.Drawing.Size(452, 217);
            this.parametersPanel.TabIndex = 15;
            // 
            // startGameButton
            // 
            this.startGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.startGameButton.Location = new System.Drawing.Point(293, 131);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(150, 70);
            this.startGameButton.TabIndex = 10;
            this.startGameButton.Text = "Start gry";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // alphabetLengthTextBox
            // 
            this.alphabetLengthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.alphabetLengthTextBox.Location = new System.Drawing.Point(140, 146);
            this.alphabetLengthTextBox.Name = "alphabetLengthTextBox";
            this.alphabetLengthTextBox.Size = new System.Drawing.Size(96, 22);
            this.alphabetLengthTextBox.TabIndex = 12;
            // 
            // maxLengthTextBox
            // 
            this.maxLengthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maxLengthTextBox.Location = new System.Drawing.Point(140, 179);
            this.maxLengthTextBox.Name = "maxLengthTextBox";
            this.maxLengthTextBox.Size = new System.Drawing.Size(96, 22);
            this.maxLengthTextBox.TabIndex = 9;
            // 
            // alphabetGroupBox
            // 
            this.alphabetGroupBox.Controls.Add(this.abcdAlphabet);
            this.alphabetGroupBox.Controls.Add(this.qwertyAlphabet);
            this.alphabetGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.alphabetGroupBox.Location = new System.Drawing.Point(80, 86);
            this.alphabetGroupBox.Name = "alphabetGroupBox";
            this.alphabetGroupBox.Size = new System.Drawing.Size(156, 41);
            this.alphabetGroupBox.TabIndex = 14;
            this.alphabetGroupBox.TabStop = false;
            // 
            // abcdAlphabet
            // 
            this.abcdAlphabet.AutoCheck = false;
            this.abcdAlphabet.AutoSize = true;
            this.abcdAlphabet.Location = new System.Drawing.Point(6, 12);
            this.abcdAlphabet.Name = "abcdAlphabet";
            this.abcdAlphabet.Size = new System.Drawing.Size(66, 20);
            this.abcdAlphabet.TabIndex = 3;
            this.abcdAlphabet.TabStop = true;
            this.abcdAlphabet.Text = "abcd...";
            this.abcdAlphabet.UseVisualStyleBackColor = true;
            this.abcdAlphabet.Click += new System.EventHandler(this.alphabet_Click);
            // 
            // qwertyAlphabet
            // 
            this.qwertyAlphabet.AutoSize = true;
            this.qwertyAlphabet.Location = new System.Drawing.Point(78, 12);
            this.qwertyAlphabet.Name = "qwertyAlphabet";
            this.qwertyAlphabet.Size = new System.Drawing.Size(74, 20);
            this.qwertyAlphabet.TabIndex = 4;
            this.qwertyAlphabet.Text = "qwerty...";
            this.qwertyAlphabet.UseVisualStyleBackColor = true;
            this.qwertyAlphabet.Click += new System.EventHandler(this.alphabet_Click);
            // 
            // maxLengthLabel
            // 
            this.maxLengthLabel.AutoSize = true;
            this.maxLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maxLengthLabel.Location = new System.Drawing.Point(21, 185);
            this.maxLengthLabel.Name = "maxLengthLabel";
            this.maxLengthLabel.Size = new System.Drawing.Size(91, 16);
            this.maxLengthLabel.TabIndex = 6;
            this.maxLengthLabel.Text = "Max dl. slowa:";
            // 
            // alphabetLengthLabel
            // 
            this.alphabetLengthLabel.AutoSize = true;
            this.alphabetLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.alphabetLengthLabel.Location = new System.Drawing.Point(21, 149);
            this.alphabetLengthLabel.Name = "alphabetLengthLabel";
            this.alphabetLengthLabel.Size = new System.Drawing.Size(78, 16);
            this.alphabetLengthLabel.TabIndex = 11;
            this.alphabetLengthLabel.Text = "Dl. alfabetu:";
            // 
            // difficultyLevelComboBox
            // 
            this.difficultyLevelComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.difficultyLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficultyLevelComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.difficultyLevelComboBox.FormattingEnabled = true;
            this.difficultyLevelComboBox.Items.AddRange(new object[] {
            "Easy",
            "Normal"});
            this.difficultyLevelComboBox.Location = new System.Drawing.Point(24, 44);
            this.difficultyLevelComboBox.Name = "difficultyLevelComboBox";
            this.difficultyLevelComboBox.Size = new System.Drawing.Size(212, 24);
            this.difficultyLevelComboBox.TabIndex = 8;
            // 
            // patternRichTextBox
            // 
            this.patternRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.patternRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.patternRichTextBox.ForeColor = System.Drawing.Color.Red;
            this.patternRichTextBox.Location = new System.Drawing.Point(343, 55);
            this.patternRichTextBox.MaxLength = 2;
            this.patternRichTextBox.Multiline = false;
            this.patternRichTextBox.Name = "patternRichTextBox";
            this.patternRichTextBox.ReadOnly = true;
            this.patternRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.patternRichTextBox.Size = new System.Drawing.Size(50, 32);
            this.patternRichTextBox.TabIndex = 13;
            this.patternRichTextBox.Text = "XX";
            // 
            // difficultyLevelLabel
            // 
            this.difficultyLevelLabel.AutoSize = true;
            this.difficultyLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.difficultyLevelLabel.Location = new System.Drawing.Point(21, 16);
            this.difficultyLevelLabel.Name = "difficultyLevelLabel";
            this.difficultyLevelLabel.Size = new System.Drawing.Size(113, 16);
            this.difficultyLevelLabel.TabIndex = 7;
            this.difficultyLevelLabel.Text = "Poziom trudności:";
            // 
            // patternLabel
            // 
            this.patternLabel.AutoSize = true;
            this.patternLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.patternLabel.Location = new System.Drawing.Point(290, 16);
            this.patternLabel.Name = "patternLabel";
            this.patternLabel.Size = new System.Drawing.Size(149, 16);
            this.patternLabel.TabIndex = 0;
            this.patternLabel.Text = "Zabroniony wzorzec:";
            // 
            // alphabetLabel
            // 
            this.alphabetLabel.AutoSize = true;
            this.alphabetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.alphabetLabel.Location = new System.Drawing.Point(21, 100);
            this.alphabetLabel.Name = "alphabetLabel";
            this.alphabetLabel.Size = new System.Drawing.Size(53, 16);
            this.alphabetLabel.TabIndex = 2;
            this.alphabetLabel.Text = "Alfabet:";
            // 
            // upperPanel
            // 
            this.upperPanel.Location = new System.Drawing.Point(0, 0);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(734, 238);
            this.upperPanel.TabIndex = 2;
            // 
            // upperSplitContainer
            // 
            this.upperSplitContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperSplitContainer.IsSplitterFixed = true;
            this.upperSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.upperSplitContainer.Name = "upperSplitContainer";
            // 
            // upperSplitContainer.Panel1
            // 
            this.upperSplitContainer.Panel1.Controls.Add(this.rulesGroupBox);
            // 
            // upperSplitContainer.Panel2
            // 
            this.upperSplitContainer.Panel2.Controls.Add(this.gameParameters);
            this.upperSplitContainer.Size = new System.Drawing.Size(784, 238);
            this.upperSplitContainer.SplitterDistance = 325;
            this.upperSplitContainer.SplitterWidth = 1;
            this.upperSplitContainer.TabIndex = 5;
            // 
            // rulesGroupBox
            // 
            this.rulesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rulesGroupBox.Controls.Add(this.rulesTextBox);
            this.rulesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rulesGroupBox.Location = new System.Drawing.Point(3, 0);
            this.rulesGroupBox.Name = "rulesGroupBox";
            this.rulesGroupBox.Size = new System.Drawing.Size(325, 238);
            this.rulesGroupBox.TabIndex = 0;
            this.rulesGroupBox.TabStop = false;
            this.rulesGroupBox.Text = "Zasady gry";
            // 
            // rulesTextBox
            // 
            this.rulesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rulesTextBox.CausesValidation = false;
            this.rulesTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.rulesTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rulesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rulesTextBox.Location = new System.Drawing.Point(3, 18);
            this.rulesTextBox.Name = "rulesTextBox";
            this.rulesTextBox.ReadOnly = true;
            this.rulesTextBox.Size = new System.Drawing.Size(319, 217);
            this.rulesTextBox.TabIndex = 0;
            this.rulesTextBox.Text = "";
            // 
            // gameGroupBox
            // 
            this.gameGroupBox.Controls.Add(this.gameRichTextBox);
            this.gameGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameGroupBox.ForeColor = System.Drawing.Color.Black;
            this.gameGroupBox.Location = new System.Drawing.Point(0, 238);
            this.gameGroupBox.Margin = new System.Windows.Forms.Padding(10);
            this.gameGroupBox.Name = "gameGroupBox";
            this.gameGroupBox.Padding = new System.Windows.Forms.Padding(10);
            this.gameGroupBox.Size = new System.Drawing.Size(784, 323);
            this.gameGroupBox.TabIndex = 6;
            this.gameGroupBox.TabStop = false;
            this.gameGroupBox.Text = "Gra";
            // 
            // gameRichTextBox
            // 
            this.gameRichTextBox.BackColor = System.Drawing.Color.LightGray;
            this.gameRichTextBox.DetectUrls = false;
            this.gameRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameRichTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gameRichTextBox.Location = new System.Drawing.Point(10, 27);
            this.gameRichTextBox.Name = "gameRichTextBox";
            this.gameRichTextBox.ReadOnly = true;
            this.gameRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.gameRichTextBox.Size = new System.Drawing.Size(764, 286);
            this.gameRichTextBox.TabIndex = 0;
            this.gameRichTextBox.Text = "";
            // 
            // Pasikonik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gameGroupBox);
            this.Controls.Add(this.upperSplitContainer);
            this.Controls.Add(this.upperPanel);
            this.Icon = global::Pasikonik.Properties.Resources.grasshopper;
            this.MinimumSize = new System.Drawing.Size(750, 550);
            this.Name = "Pasikonik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[ P A S I K O N I K ]";
            this.gameParameters.ResumeLayout(false);
            this.parametersPanel.ResumeLayout(false);
            this.parametersPanel.PerformLayout();
            this.alphabetGroupBox.ResumeLayout(false);
            this.alphabetGroupBox.PerformLayout();
            this.upperSplitContainer.Panel1.ResumeLayout(false);
            this.upperSplitContainer.Panel2.ResumeLayout(false);
            this.upperSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upperSplitContainer)).EndInit();
            this.upperSplitContainer.ResumeLayout(false);
            this.rulesGroupBox.ResumeLayout(false);
            this.gameGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gameParameters;
        private Label patternLabel;
        private Label alphabetLabel;
        private Label maxLengthLabel;
        private Button startGameButton;
        private Panel upperPanel;
        private SplitContainer upperSplitContainer;
        private GroupBox rulesGroupBox;
        private GroupBox gameGroupBox;
        private RichTextBox rulesTextBox;
        private Label alphabetLengthLabel;    
        private Label difficultyLevelLabel;
        private RichTextBox patternRichTextBox;
        private RichTextBox gameRichTextBox;
        private GroupBox alphabetGroupBox;
        private Panel parametersPanel;

        public TextBox alphabetLengthTextBox;
        public TextBox maxLengthTextBox;
        public RadioButton abcdAlphabet;
        public RadioButton qwertyAlphabet;
        public ComboBox difficultyLevelComboBox;

    }
}

