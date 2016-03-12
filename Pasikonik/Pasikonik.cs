using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Pasikonik
{
    public partial class Pasikonik : Form
    {
        bool GameEnded ;
        private string PasikonikRead = null;
        private string GameWord = null;
        private char[] Alfabet;

        private AlfabetType alfabetType;
        private int alfabetLength;
        private GameLevel gameLevel;

        private enum AlfabetType
        {
            ABCD,
            QWERTY,
        }

        private enum GameLevel
        {
            EASY,
            NORMAL
        }

        public Pasikonik()
        {

            InitializeComponent();
            rulesTextBox.Text =  Properties.Resources.rules;
            
            
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
           
            if (startGameButton.Text == Properties.Resources.Game_START)
            {
                if (!Validator.CheckGameParameters(this)) return;
                GameEnded = false;

                gameRichTextBox.ReadOnly = false;
                gameRichTextBox.BackColor = Color.White;

                ConstructAlfabet();
                abcdAlphabet.Enabled = false;
                qwertyAlphabet.Enabled = false;
                alphabetLengthTextBox.Enabled = false;
                maxLengthTextBox.Enabled = false;
                difficultyLevelComboBox.Enabled = false;

                startGameButton.Text = Properties.Resources.GAME_END;

                ComputerMovement(difficultyLevelComboBox.SelectedItem.ToString());
            }
            else if (startGameButton.Text == Properties.Resources.GAME_END)
            {
                GameEnded = true;

                gameRichTextBox.ReadOnly = true;
                gameRichTextBox.BackColor = Color.LightGray;

                abcdAlphabet.Enabled = true;
                qwertyAlphabet.Enabled = true;
                alphabetLengthTextBox.Enabled = true;
                maxLengthTextBox.Enabled = true;
                difficultyLevelComboBox.Enabled = true;
                gameRichTextBox.Text = "";

                startGameButton.Text = Properties.Resources.Game_START;
            }

        }

        private void ConstructAlfabet()
        {

            alfabetLength = int.Parse(alphabetLengthTextBox.Text);
            if (alfabetType.Equals(AlfabetType.ABCD))
                Alfabet = "abcdefghijklmnopqrstuvwxyz".Substring(0, alfabetLength).ToCharArray();
            else if (alfabetType.Equals(AlfabetType.QWERTY))
                Alfabet = "qwertyuiopasdfghjklzxcvbnm".Substring(0, alfabetLength).ToCharArray();

        }

        private void ComputerMovement(string difficultyLevel)
        {
            if (!GameEnded)
            {
                //ile liter
                StringBuilder builder = new StringBuilder();
                //jakie litery
                if (difficultyLevel.Equals("Normal"))
                {
                    
                }
                else
                {
                    //randomowo
                    
                
                }

            }
            
        }


        private string RandomLetters(int size)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                builder.Append(random.Next(alfabetLength));           
            }

            return builder.ToString();
        }



        private void alphabet_Click(Object sender, EventArgs e)
        {
            var checkedRB = (RadioButton) sender;
            foreach (RadioButton rb in alphabetGroupBox.Controls)
            {
                if (checkedRB.Equals(rb))
                {
                    checkedRB.Checked = true;
                    
                }
                else
                    rb.Checked = false;
            }

            if (checkedRB.Name.Equals(abcdAlphabet.Text)) alfabetType = AlfabetType.ABCD;
            if (checkedRB.Name.Equals(qwertyAlphabet.Text)) alfabetType = AlfabetType.QWERTY;
        }
    }



}
