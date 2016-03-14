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

        public static bool FindPattern(string passikonikText)
        {
            bool found = false;

            return found;
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
