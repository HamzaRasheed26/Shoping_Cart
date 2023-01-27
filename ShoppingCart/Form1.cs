namespace ShoppingCart
{
    public partial class frmShoppingCart : Form
    {
        private double FinalPrice;
        private double Price1 = 0;
        private double Price2 = 0;
        private double Price3 = 0;

        public frmShoppingCart()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (isInputValid(txtQuantity1.Text) )
            {
                double quantity = double.Parse(txtQuantity1.Text);
                Price1 = quantity * 700;
                lblToatal1.Text = Price1.ToString();

                FinalPrice = Price1 + Price2 + Price3;

                lblFinalTotal.Text = FinalPrice.ToString();
            }
        }

        private void txtQuantity2_TextChanged(object sender, EventArgs e)
        {
            if (isInputValid(txtQuantity2.Text))
            {
                int quantity = int.Parse(txtQuantity2.Text);
                Price2 = quantity * 1000;
                lblToatal2.Text = Price2.ToString();
                FinalPrice = Price1 + Price2 + Price3;

                lblFinalTotal.Text = FinalPrice.ToString();
            }
        }

        private void txtQuantity3_TextChanged(object sender, EventArgs e)
        {
            if (isInputValid(txtQuantity3.Text))
            {
                int quantity = int.Parse(txtQuantity3.Text);
                Price3 = quantity * 1500;
                lblToatal3.Text = Price3.ToString();
                FinalPrice = Price1 + Price2 + Price3;

                lblFinalTotal.Text = FinalPrice.ToString();
            }
        }

        private void lblToatal1_Click(object sender, EventArgs e)
        {
           
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblItem3_Click(object sender, EventArgs e)
        {

        }

        private void linkRemove1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblToatal1.Text != "")
            {
                txtQuantity1.Text = "";
                string num = lblToatal1.Text;
                lblToatal1.Text = "0";
                string num2 = lblFinalTotal.Text;
                lblFinalTotal.Text = (int.Parse(num2) - int.Parse(num)).ToString();
            }
        }

        public bool isInputValid(string value)
        {
            if(value == "")
            {
                return false;
            }
            for(int i = 0; i < value.Length; i++)
            {
                if (value[i] >= '0' && value[i] <= '9' || value[i] == '.' )
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private void linkRemove2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblToatal2.Text != "")
            {
                txtQuantity2.Text = "";
                string num = lblToatal2.Text;
                lblToatal2.Text = "0";
                string num2 = lblFinalTotal.Text;
                lblFinalTotal.Text = (int.Parse(num2) - int.Parse(num)).ToString();
            }
        }

        private void linkRemove3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblToatal3.Text != "")
            {
                txtQuantity3.Text = "";
                string num = lblToatal3.Text;
                lblToatal3.Text = "0";
                string num2 = lblFinalTotal.Text;
                lblFinalTotal.Text = (int.Parse(num2) - int.Parse(num)).ToString();
            }
        }
    }
}