namespace TextEditorApplication
{
    partial class SecondForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            saveButton = new Button();
            cancelButton = new Button();
            textBox = new TextBox();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.Location = new Point(200, 260);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 49);
            saveButton.TabIndex = 0;
            saveButton.Text = "Зберегти";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(512, 260);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 49);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Відмінити";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // textBox
            // 
            textBox.Location = new Point(142, 73);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(511, 145);
            textBox.TabIndex = 2;
            // 
            // SecondForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Name = "SecondForm";
            Text = "SecondForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveButton;
        private Button cancelButton;
        private TextBox textBox;
    }
}