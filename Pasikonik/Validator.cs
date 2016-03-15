using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pasikonik.Properties;

namespace Pasikonik
{
    static class Validator
    {
        private static string found_Pattern = "";

        public static bool CheckGameParameters(Pasikonik pasikonik)
        {
            string errorMsg = null;
            var isOk = false;

            if (!IsNumber(pasikonik.alphabetLengthTextBox.Text))
            {
                errorMsg += ("Dlugosc alfabetu musi byc liczba" + Environment.NewLine);
            }
            else if (pasikonik.alphabetLengthTextBox.Text != null)
            {
                var length = int.Parse(pasikonik.alphabetLengthTextBox.Text);
                if (length < 1 || length > 26) errorMsg += ("Alfabet może być dlugosci od 1 do 26" + Environment.NewLine);
            }


            if (!IsNumber(pasikonik.maxLengthTextBox.Text))
                errorMsg += ("Dlugosc slowa musi byc liczba" + Environment.NewLine);

            if (!pasikonik.abcdAlphabet.Checked && !pasikonik.qwertyAlphabet.Checked)
                errorMsg += ("Prosze wybrac typ alfabetu" + Environment.NewLine);

            if (pasikonik.difficultyLevelComboBox.SelectedItem == null)
                errorMsg += ("Prosze wybrac poziom trudnosci" + Environment.NewLine);


            if (!string.IsNullOrEmpty(errorMsg))
                MessageBox.Show(errorMsg, Resources.Validator__ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else isOk = true;

            return isOk;
        }

        public static string FindPattern(string passikonikText, int max)
        {
            
            string pattern = null;
            //słowa długosci od 1 do max/2
            for (var i = 1; i <= max/2; i++)
            {
                if (passikonikText.Length >= i)
                {
                    string substring = passikonikText.Substring(0, i);
                
                string rest = passikonikText.Substring(i);

                string compareTo = "";
                if (rest.Length >= i) compareTo = rest.Substring(0, i);

                if (substring == compareTo)
                {

                    pattern = substring + compareTo;
                    return pattern;
                }
            }
        }


            return null;
        }
        public static bool ValidateMove(int prevPasikonikPosition, int currentPasikonikPosition)
        {
            bool isOk = false;

            var pasikonikMove = currentPasikonikPosition - prevPasikonikPosition;
            if (pasikonikMove == 2 || pasikonikMove == 1) isOk = true;
            else
            {
                
                MessageBox.Show(Resources.ValidateMove_Niewlasciwy_ruch_pasikonika, Resources.Validator__ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return isOk;
        }

        private static bool IsNumber(String str)
        {
            return Regex.IsMatch(str, "^[0-9]+$");
        }

        private static bool OnlyLetters(String str)
        {
            return Regex.IsMatch(str, "^[a-zA-Z]+$");
        }

    }
}
