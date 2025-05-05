namespace SMS.App.Views
{
    partial class AddStudentView
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
            textBoxName = new TextBox();
            textBoxEmail = new TextBox();
            comboBoxPrograms = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(304, 129);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(293, 27);
            textBoxName.TabIndex = 0;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(304, 177);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(293, 27);
            textBoxEmail.TabIndex = 1;
            // 
            // comboBoxPrograms
            // 
            comboBoxPrograms.FormattingEnabled = true;
            comboBoxPrograms.Location = new Point(304, 225);
            comboBoxPrograms.Name = "comboBoxPrograms";
            comboBoxPrograms.Size = new Size(293, 28);
            comboBoxPrograms.TabIndex = 2;
            comboBoxPrograms.SelectedIndexChanged += comboBoxPrograms_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(203, 136);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 184);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 4;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(203, 233);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 5;
            label3.Text = "Program";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(353, 292);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // AddStudentView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSave);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxPrograms);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxName);
            Name = "AddStudentView";
            Text = "AddStudentView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxEmail;
        private ComboBox comboBoxPrograms;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonSave;
    }
}