using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private bool depositflag = false;
        private double distanceDiscount = 0;
        private Dictionary<string,int> map;
        
        public Form1()
        {
            InitializeComponent();
            map = new Dictionary<string, int>();
            map.Add("0", 0);
            map.Add("1", 300);
            map.Add("2", 120);
            map.Add("3", 120);
            map.Add("4", 100);
            map.Add("5", 100);
            map.Add("6", 100);
            map.Add("7", 90);
            map.Add("8", 90);
            map.Add("9", 90);
            map.Add("10", 90);
            disableCheckBox(checkBox_distance);

        }

        private void comboBox_customers_TextUpdate(object sender, EventArgs e)
        {
            ComboBox view = (ComboBox)sender;
            if (!view.Items.Contains(view.Text))
                view.Text = "";
            else if (view == comboBox_customers)
                comboBox_customers_SelectedIndexChanged(sender, null);
            else if (view == comboBox_kids)
                change_price(sender, null);
            else if (view == comboBox_soliders)
                change_price(sender, null);
            
        }

        private void comboBox_customers_SelectedIndexChanged(object sender, EventArgs e)
        {
            disableCheckBox(checkBox_distance);
            comboBox_kids.Text = "0";
            comboBox_soliders.Text = "0";
            comboBox_kids.Items.Clear();
            comboBox_soliders.Items.Clear();
            if (!checkBox_distance.Checked && Convert.ToInt32(((ComboBox)sender).Text)>=4)
            {
                enableCheckBox(checkBox_distance);
                for (int i = 0; i <= Convert.ToInt32(((ComboBox)sender).Text); i++)
                {
                    comboBox_kids.Items.Add(Convert.ToString(i));
                    comboBox_soliders.Items.Add(Convert.ToString(i));
                }
            }
            change_price(null,null);
        }

        

  

        private void change_price(object sender, EventArgs e)
        {

            if(Convert.ToInt32(comboBox_kids.Text)+ Convert.ToInt32(comboBox_soliders.Text)> Convert.ToInt32(comboBox_customers.Text))
            {
                MessageBox.Show("מספר ההנחות גדול ממספר המשתתפים","שגיאה",MessageBoxButtons.OK,MessageBoxIcon.Error);
                ((ComboBox)sender).Text = "0";
                return;
            }
            int pricePerson = map[Convert.ToString(comboBox_customers.Text)];
            double loweredPrice = ((0.1 * pricePerson) * Convert.ToInt32(comboBox_soliders.Text)) + ((0.1 * pricePerson) * Convert.ToInt32(comboBox_kids.Text)) + distanceDiscount;
            double finalPrice = pricePerson * Convert.ToInt32(comboBox_customers.Text) - loweredPrice;
            if (!depositflag)
                textBox_price.Text = finalPrice + "₪";
            else
                if( finalPrice==0)
                    textBox_price.Text = finalPrice + "₪";
                else
                    textBox_price.Text = (finalPrice-100) + "₪";
            label_PricePerson.Text = "מחיר לאדם:" +pricePerson + "₪";
            label_PriceKid.Text = "מחיר לילד:" + (pricePerson - (0.15 * pricePerson)) + "₪";
            label_PriceSolider.Text = "מחיר לחייל/סטודנט:" + (pricePerson - (0.1 * pricePerson)) + "₪";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
             CheckBox checkBox_deposit= (CheckBox) sender;
             if (checkBox_deposit.Checked)
             {
                 checkBox_deposit.Text = "לאחר פקדון (100-)";
                 depositflag = true;
                 change_price(sender, e);
             }
             else
             {
                 checkBox_deposit.Text = "לאחר פקדון";
                 depositflag = false;
                 change_price(sender, e);
             }
            
        }

        private void distanceDeposit(object sender, EventArgs e)
        {
            
            CheckBox checkBox_distance = (CheckBox)sender;
            
            if (checkBox_distance.Checked)
            {
                comboBox_soliders.Text = "0";
                comboBox_kids.Text = "0";
                comboBox_kids.Items.Clear();
                comboBox_soliders.Items.Clear();
                distanceDiscount = map[Convert.ToString(comboBox_customers.Text)] * (Convert.ToInt32(comboBox_customers.Text)) * 0.1;
                change_price(sender, e);
            }
            else
            {
                comboBox_soliders.Text = "0";
                comboBox_kids.Text = "0";
                for (int i = 0; i <= Convert.ToInt32((comboBox_customers.Text)); i++)
                {
                    comboBox_kids.Items.Add(Convert.ToString(i));
                    comboBox_soliders.Items.Add(Convert.ToString(i));
                }
                distanceDiscount = 0;
                change_price(sender, e);
            }
        }

        private void disableCheckBox(CheckBox cb)
        {
            cb.Checked = false;
            distanceDiscount = 0;
            cb.AutoCheck = false;
            cb.ForeColor = Color.Gray;
        }

        private void enableCheckBox(CheckBox cb)
        {
            
            cb.AutoCheck = true;
            cb.ForeColor = Color.Black;
        }

        
    }
}
