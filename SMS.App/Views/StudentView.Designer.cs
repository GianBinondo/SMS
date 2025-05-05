namespace SMS.App.Views
{
    partial class StudentView
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
            dataGridViewStudents = new DataGridView();
            buttonAddNewStudents = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Location = new Point(12, 57);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.RowHeadersWidth = 51;
            dataGridViewStudents.Size = new Size(776, 381);
            dataGridViewStudents.TabIndex = 0;
            // 
            // buttonAddNewStudents
            // 
            buttonAddNewStudents.Location = new Point(12, 12);
            buttonAddNewStudents.Name = "buttonAddNewStudents";
            buttonAddNewStudents.Size = new Size(150, 29);
            buttonAddNewStudents.TabIndex = 1;
            buttonAddNewStudents.Text = "Add New Students";
            buttonAddNewStudents.UseVisualStyleBackColor = true;
            buttonAddNewStudents.Click += buttonAddNewStudents_Click;
            // 
            // StudentView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAddNewStudents);
            Controls.Add(dataGridViewStudents);
            Name = "StudentView";
            Text = "StudentView";
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewStudents;
        private Button buttonAddNewStudents;
    }
}