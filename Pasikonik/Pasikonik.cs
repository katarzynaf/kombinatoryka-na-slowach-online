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


        public Pasikonik()
        {
            
            InitializeComponent();
            rulesTextBox.Text =  Properties.Resources.rules;
            
            
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            if (!Validator.CheckGameParameters(this)) return;
            gameRichTextBox.ReadOnly = false;
            gameRichTextBox.BackColor = Color.White;
        }






        private void alphabet_Click(Object sender, EventArgs e)
        {
            var checkedRB = (RadioButton) sender;
            foreach (RadioButton rb in alphabetGroupBox.Controls)
            {
                if (checkedRB.Equals(rb))
                    checkedRB.Checked = true;
                else
                    rb.Checked = false;
            }
        }
    }
}
