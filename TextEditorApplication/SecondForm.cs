using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TextEditorApplication
{
    public partial class SecondForm : Form
    {
        public event EventHandler TextChanged;
        public string EditedText
        {
            get { return textBox.Text; }
        }
        public SecondForm(string text)
        {
            InitializeComponent();
            textBox.Text = text;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            TextChanged?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
