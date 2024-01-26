namespace TextEditorApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loadButton = new Button();
            editButton = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // loadButton
            // 
            loadButton.Location = new Point(178, 262);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(120, 23);
            loadButton.TabIndex = 0;
            loadButton.Text = "завантажити файл";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(520, 262);
            editButton.Name = "editButton";
            editButton.Size = new Size(120, 23);
            editButton.TabIndex = 1;
            editButton.Text = "редагувати";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(164, 52);
            textBox1.MaxLength = 3276700;
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(487, 175);
            textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(editButton);
            Controls.Add(loadButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loadButton;
        private Button editButton;
        private TextBox textBox1;
    }
}
