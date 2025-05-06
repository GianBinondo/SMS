namespace Sample
{
    partial class FoodCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodCard));
            pictureBoxItem = new PictureBox();
            labelFoodName = new Label();
            labelPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxItem).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxItem
            // 
            pictureBoxItem.Image = (Image)resources.GetObject("pictureBoxItem.Image");
            pictureBoxItem.Location = new Point(12, 13);
            pictureBoxItem.Name = "pictureBoxItem";
            pictureBoxItem.Size = new Size(125, 80);
            pictureBoxItem.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxItem.TabIndex = 0;
            pictureBoxItem.TabStop = false;
            pictureBoxItem.Click += pictureBox1_Click;
            // 
            // labelFoodName
            // 
            labelFoodName.AutoSize = true;
            labelFoodName.Location = new Point(12, 96);
            labelFoodName.Name = "labelFoodName";
            labelFoodName.Size = new Size(87, 20);
            labelFoodName.TabIndex = 1;
            labelFoodName.Text = "Food Name";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(96, 116);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(41, 20);
            labelPrice.TabIndex = 2;
            labelPrice.Text = "Price";
            // 
            // FoodCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            Controls.Add(labelPrice);
            Controls.Add(labelFoodName);
            Controls.Add(pictureBoxItem);
            Name = "FoodCard";
            ((System.ComponentModel.ISupportInitialize)pictureBoxItem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        public Label labelFoodName;
        public Label labelPrice;
        private Label label2;
        public PictureBox pictureBoxItem;
    }
}
