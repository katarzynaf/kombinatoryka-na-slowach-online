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
        bool GameEnded;
        private int PossibleNoOfLetters = 0;
        private int currentPasikonikPosition;
        private int prevPasikonikPosition;
        private string PasikonikRead { get; set; }

        private readonly Color PatternColor = Color.DarkRed;

        private char[] Alfabet;

        private AlfabetType alfabetType;
        private int alfabetLength;
        private GameLevel gameLevel;
        private Turn turn;




        public Pasikonik()
        {
            InitializeComponent();
            rulesTextBox.Text = Properties.Resources.rules;

        }

        private void startGameButton_Click(object sender, EventArgs e)
        {

            if (startGameButton.Text == Properties.Resources.Game_START)
            {
                if (!Validator.CheckGameParameters(this)) return;
                GameEnded = false;


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
                prevPasikonikPosition = 0;

                PlayGame();

            }
            else if (startGameButton.Text == Properties.Resources.GAME_END)
            {
                GameEnded = true;
                GameEnd();

               
            }

        }

        private void GameEnd()
        {
            gameRichTextBox.ReadOnly = true;
            gameRichTextBox.BackColor = Color.LightGray;

            abcdAlphabet.Enabled = true;
            qwertyAlphabet.Enabled = true;
            alphabetLengthTextBox.Enabled = true;
            maxLengthTextBox.Enabled = true;
            difficultyLevelComboBox.Enabled = true;
            gameRichTextBox.Text = "";
            gameLevel = GameLevel.NONE;
            currentPasikonikPosition = 0;
            prevPasikonikPosition = 0;
            PasikonikRead = "";
            logDownInfo.Text = "";
            startGameButton.Text = Properties.Resources.Game_START;
        }

        private void PlayGame()
        {

            switch (turn)
            {
                case Turn.COMPUTER:
                    ComputerMovement();
                    break;
                case Turn.PLAYER:

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
           // logDownInfo.Visible = false;
            var insertWord = ""; //biezace slowo

            if (!GameEnded)
            {
                //jakie litery
                switch (gameLevel)
                {
                    case GameLevel.NORMAL:
                        break;
                    case GameLevel.EASY:
                        insertWord = RandomLetters(PossibleNoOfLetters);
                        break;
                }

                AddWord(insertWord, currentPasikonikPosition);

            }


            turn = Turn.PLAYER;
            PossibleNoOfLetters = 0;
            logDownInfo.Visible = true;
        }

        private void AddWord(string insertWord, int currentPosition)
        {
             gameRichTextBox.Text = gameRichTextBox.Text.Insert(currentPosition, insertWord);
             //gameRichTextBox.SelectionStart = currentPosition + insertWord.Length;
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
            var checkedRB = (RadioButton)sender;
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

        private void gameRichTextBox_MouseDown(object sender, EventArgs e)
        {
            prevPasikonikPosition = currentPasikonikPosition;
            //start Selecting
        }



        private void gameRichTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            DialogResult? result = null;
            //end selecting
            currentPasikonikPosition = gameRichTextBox.SelectionStart + gameRichTextBox.SelectionLength;


            if (!Validator.ValidateMove(prevPasikonikPosition, currentPasikonikPosition)) return;

            

            // ilosc liter do nastepnej rundy
            if (currentPasikonikPosition - prevPasikonikPosition == 2) PossibleNoOfLetters = 1;
            if (currentPasikonikPosition - prevPasikonikPosition == 1) PossibleNoOfLetters = 2;

 
         //   var prev_read = PasikonikRead;
      //       if( prev_read!=null)
        //         gameRichTextBox.SelectedText = gameRichTextBox.SelectedText.Remove(prev_read.Length);
            PasikonikRead += gameRichTextBox.SelectedText;




            //szukanie wzrorca
            var max = int.Parse(maxLengthTextBox.Text);
            var pattern = Validator.FindPattern(PasikonikRead, max);

            logDownInfo.Text = "Tekst pasikonika  " + PasikonikRead;

            if (string.IsNullOrEmpty(pattern)) //nie znaleziono wzorca
            {
                if (PasikonikRead.Length >= max)
                {
                    GameEnded = true;
                    result = MessageBox.Show(Properties.Resources.PLAYER_WIN, Properties.Resources.PLAYER_WIN,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                else
                {
                    turn = Turn.COMPUTER;
                    PlayGame();
                }



                gameRichTextBox.SelectionStart = currentPasikonikPosition;
                gameRichTextBox.SelectionLength = 0;
                // gameRichTextBox.SelectionColor = gameRichTextBox.ForeColor;

            }

            else
            {
                GameEnded = true;

                result = MessageBox.Show(Properties.Resources.FOUND_PATTERN +" "+ pattern, Properties.Resources.COMPUTER_WIN,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                gameRichTextBox.SelectionBullet = true;
                gameRichTextBox.Find(pattern);
                gameRichTextBox.SelectionColor = PatternColor;
                gameRichTextBox.SelectionBullet = false;
            }

           

            if (GameEnded && result == DialogResult.OK) GameEnd();
          
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
