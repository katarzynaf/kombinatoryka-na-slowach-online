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

namespace Pasikonik
{
    public partial class Pasikonik : Form
    {
        bool GameEnded ;
        private string PasikonikRead = null;
        private int PossibleNoOfLetters = 0;
        private Cursor PasikonikPosition;
      
        private readonly Color PasikonikColor = Color.Green;
        private readonly Color PatternColor = Color.DarkRed;
 
        private char[] Alfabet;

        private AlfabetType alfabetType;
        private int alfabetLength;
        private GameLevel gameLevel;
        private Turn turn;
      



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
                gameLevel = (GameLevel)Enum.Parse(typeof(GameLevel), difficultyLevelComboBox.SelectedItem.ToString());
               
                turn = Turn.COMPUTER;
                PossibleNoOfLetters = 2;


                PlayGame();
   
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
                gameLevel = GameLevel.NONE; 

                startGameButton.Text = Properties.Resources.Game_START;
            }

        }

        private void PlayGame()
        {

                switch (turn)
                {
                    case Turn.COMPUTER:
                        turnInfo.Visible = false;
                        ComputerMovement();
                        turnInfo.Visible = true;
                        break;
                    case Turn.PLAYER:
                        if (!Validator.FindPattern(PasikonikRead))
                            turn = Turn.COMPUTER;
                        else
                        {
                            GameEnded = true;
                            MessageBox.Show(Properties.Resources.PLAYER_WIN,Properties.Resources.COMPUTER_WIN,MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        break;
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

        private void ComputerMovement()
        {
            var GameWord = gameRichTextBox.Text; //biezace slowo
            PasikonikPosition = gameRichTextBox.Cursor;

            if (!GameEnded)
            {
                //gdzie
              //  PasikonikPosition = GetPasikonikPos();
                //jakie litery
                switch (gameLevel)
                {
                    case GameLevel.NORMAL:
                        break;
                    case GameLevel.EASY:
                        GameWord = RandomLetters(PossibleNoOfLetters);
                        break;
                }


            }

            gameRichTextBox.Text = GameWord ;
          
            turn = Turn.PLAYER;
        }



        private string RandomLetters(int size)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                builder.Append(Alfabet[random.Next(alfabetLength)]);           
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

        enum AlfabetType
        {
            ABCD,
            QWERTY,
        }

        enum GameLevel
        {
            EASY,
            NORMAL,
            NONE
        }

         enum Turn
        {
             COMPUTER,
             PLAYER,
        }



}
