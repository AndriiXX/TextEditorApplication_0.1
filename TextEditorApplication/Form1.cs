namespace TextEditorApplication
{
    public partial class Form1 : Form
    {
        private string filePath;
        public Form1()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
            editButton.Enabled = false;
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                textBox1.Text = File.ReadAllText(filePath);
                editButton.Enabled = true;
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {     
                string originalText = File.ReadAllText(filePath);
                SecondForm secondForm = new SecondForm(originalText);
                secondForm.TextChanged += (s, ev) =>
                {
                    textBox1.Text = secondForm.EditedText;

                    File.WriteAllText(filePath, secondForm.EditedText);
                };
                secondForm.Show();           
        }

        private void SecondForm_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = ((SecondForm)sender).EditedText;
        }
    }
}
