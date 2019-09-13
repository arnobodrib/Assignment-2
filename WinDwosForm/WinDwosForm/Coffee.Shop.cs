using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDwosForm
{
    public partial class Coffee : Form
    {
        public Coffee()
        {
            InitializeComponent();
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            string item = comboBoxItem.Text;
            int quantity = Convert.ToInt32(textBoxQuantity.Text);
            double price = 0 ;


            if (item =="Black")
            {
                price = 120 * quantity;
            }
            else if(item=="Cold") 
            {
                price = 100 * quantity;
            }
            else if(item== "Regular")
            {
                price = 80 * quantity;
            }
            else if(item=="Hot")
            {
                price = 90 * quantity;
            }


            else
            {
                MessageBox.Show("Select an item");
            }

            richTextBoxShow.Text = "Name :" + textBoxName.Text + "\n" + "Contact No: " + textBoxContract.Text + "\n" +
                                   "Address :" + textBoxAddress.Text + "\n" + "Item : " + item + "\n" + "Price :" + price;
        
            
          
             
        }

     
    }
}
