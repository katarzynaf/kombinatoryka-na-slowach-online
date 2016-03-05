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
            const string removeString = "\\bin\\Debug";
            string path = Path.GetDirectoryName(Application.ExecutablePath);
            int index = path.IndexOf(removeString, StringComparison.Ordinal);
            string cleanPath = path.Remove(index, removeString.Length);
            cleanPath += "\\rules.txt";


            string[] lines = File.ReadAllLines(cleanPath);
            if (string.IsNullOrWhiteSpace(this.richTextBox.Text))
            {
                foreach (var line in lines)
                {

                    this.richTextBox.Text += (line + '\n');
                }
            }
            this.richTextBox.ReadOnly = true;

        }

        private void startGameButton_Click(object sender, EventArgs e)
        {

        }
    }
}
