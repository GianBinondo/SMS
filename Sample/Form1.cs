using Sample.Properties;

namespace Sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void foodCard1_Load(object sender, EventArgs e)
        {

        }

        private void foodCard1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CLicked food card 1");
        }

        public static Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var foodcard1 = new FoodCard();
            foodcard1.pictureBoxItem.Image = ByteArrayToImage(Resources.availability);
            foodcard1.labelFoodName.Text = "Chicken w/ Rice";
            foodcard1.labelPrice.Text = "P 99.00";
            var foodcard2 = new FoodCard();
            foodcard2.pictureBoxItem.Image = ByteArrayToImage(Resources.branch);
            foodcard2.labelFoodName.Text = "Pork w/ Rice";
            foodcard2.labelPrice.Text = "P 109.00";

            List<FoodCard> foodCards = [foodcard1, foodcard2];

            foreach (var item in foodCards)
            {
                flowLayoutPanel1.Controls.Add(item);
            }
        }
    }
}
