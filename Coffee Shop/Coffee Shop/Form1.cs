using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop
{
    public partial class Sale : Form
    {
        List<string> customerNames = new List<string> { };
        List<string> contactNo = new List<string> { };
        List<string> addresses = new List<string> { };
        List<int> quantity = new List<int> { };
        List<string> order = new List<string> { };
        List<int> totalPrice = new List<int> { };

        int i = 0;
        //int index = 0;

        public Sale()
        {
            InitializeComponent();
        }

        private void AddInformation(string name, string contact, string address, int quan, string orderCB)
        {
            customerNames.Add(name);
            contactNo.Add(contact);
            addresses.Add(address);
            quantity.Add(quan);
            order.Add(orderCB);
        }

        private void ShowCustomer()
        {
            showRichTextBox.Text = "";
            for (int i=0; i<customerNames.Count(); i++)
            {
                try{
                    if (order[i] == "Black Coffee")
                    {
                        totalPrice.Add(quantity[i] * 120);
                        showRichTextBox.Text += ("Customer Name: " + customerNames[i] + "\n" + "Contact No.: " + contactNo[i] + "\n" +
                            "Address: " + addresses[i] + "\n" + "Ordered Item: " + order[i] + "\n" + "Quantity: " + quantity[i] + "\n" +
                            "Total Price: " + totalPrice[i] + "\n").ToString(); }
                    else if (order[i] == "Cold Coffee")
                    {
                        totalPrice.Add(quantity[i] * 100);
                        showRichTextBox.Text += ("Customer Name: " + customerNames[i] + "\n" + "Contact No.: " + contactNo[i] + "\n" +
                            "Address: " + addresses[i] + "\n" + "Ordered Item: " + order[i] + "\n" + "Quantity: " + quantity[i] + "\n" +
                            "Total Price: " + totalPrice[i] + "\n").ToString(); }
                    else if (order[i] == "Hot Coffee")
                    {
                        totalPrice.Add(quantity[i] * 90);
                        showRichTextBox.Text += ("Customer Name: " + customerNames[i] + "\n" + "Contact No.: " + contactNo[i] + "\n" +
                            "Address: " + addresses[i] + "\n" + "Ordered Item: " + order[i] + "\n" + "Quantity: " + quantity[i] + "\n" +
                            "Total Price: " + totalPrice[i] + "\n").ToString(); }
                    else if (order[i] == "Regular Coffee")
                    {
                        totalPrice.Add(quantity[i] * 80);
                        showRichTextBox.Text += ("Customer Name: " + customerNames[i] + "\n" + "Contact No.: " + contactNo[i] + "\n" +
                            "Address: " + addresses[i] + "\n" + "Ordered Item: " + order[i] + "\n" + "Quantity: " + quantity[i] + "\n" +
                            "Total Price: " + totalPrice[i] + "\n").ToString(); }
                }
                catch(ArgumentOutOfRangeException e)
                {
                    MessageBox.Show(e.Message);
                }
                
                
            }
            nameTB.Text = "";
            contactTB.Text = "";
            addressTB.Text = "";
            quantityTB.Text = "";
            orderComboBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowCustomer();
        }

        private Boolean IsExists(string current_Mobile)
        {
            for (int i = 0; i < customerNames.Count(); i++)
            {
                if (current_Mobile == contactNo[i])
                {
                    return true;
                }
            }
            return false;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsExists(contactTB.Text) == true)
                {
                    MessageBox.Show("User id or mobile number already exists!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (String.IsNullOrEmpty(nameTB.Text) || String.IsNullOrEmpty(contactTB.Text) || String.IsNullOrEmpty(addressTB.Text))
            {
                MessageBox.Show("You cannot keep it blank.");
            }

            try
            {
                if (!String.IsNullOrEmpty(orderComboBox.Text) && quantityTB.Text != null && 
                    (!String.IsNullOrEmpty(contactTB.Text) && contactTB.Text.Length == 11) && (IsExists(contactTB.Text) != true))
                {
                    AddInformation(nameTB.Text, contactTB.Text, addressTB.Text, Convert.ToInt32(quantityTB.Text), orderComboBox.Text);
                }
                else
                {
                    MessageBox.Show("Please enter all information correctly!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            showRichTextBox.Text = "";
            try
            {
                if (order[i] == "Black Coffee")
                {
                    totalPrice.Add(quantity[i] * 120);
                    showRichTextBox.Text = ("Customer Name: " + customerNames[i] + "\n" + "Contact No.: " + contactNo[i] + "\n" +
                         "Address: " + addresses[i] + "\n" + "Ordered Item: " + order[i] + "\n" + "Quantity: " + quantity[i] + "\n" +
                            "Total Price: " + totalPrice[i] + "\n").ToString();
                }
                else if (order[i] == "Cold Coffee")
                {
                    totalPrice.Add(quantity[i] * 100);
                    showRichTextBox.Text = ("Customer Name: " + customerNames[i] + "\n" + "Contact No.: " + contactNo[i] + "\n" +
                         "Address: " + addresses[i] + "\n" + "Ordered Item: " + order[i] + "\n" + "Quantity: " + quantity[i] + "\n" +
                            "Total Price: " + totalPrice[i] + "\n").ToString();
                }
                else if (order[i] == "Hot Coffee")
                {
                    totalPrice.Add(quantity[i] * 90);
                    showRichTextBox.Text = ("Customer Name: " + customerNames[i] + "\n" + "Contact No.: " + contactNo[i] + "\n" +
                        "Address: " + addresses[i] + "\n" + "Ordered Item: " + order[i] + "\n" + "Quantity: " + quantity[i] + "\n" +
                            "Total Price: " + totalPrice[i] + "\n").ToString();
                }
                else if (order[i] == "Regular Coffee")
                {
                    totalPrice.Add(quantity[i] * 80);
                    showRichTextBox.Text = ("Customer Name: " + customerNames[i] + "\n" + "Contact No.: " + contactNo[i] + "\n" +
                        "Address: " + addresses[i] + "\n" + "Ordered Item: " + order[i] + "\n" + "Quantity: " + quantity[i] + "\n" +
                            "Total Price: " + totalPrice[i] + "\n").ToString();
                }

                i++;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }

            nameTB.Text = "";
            contactTB.Text = "";
            addressTB.Text = "";
            quantityTB.Text = "";
            orderComboBox.Text = "";
        }

            //ShowCustomer();

            //string[] customerName = new string[100];
            //string[] contactNo = new string[50];
            //string[] address = new string[100];
            //int[] quantity = new int[50];
            //int[] pricePerOrder = new int[50];
            //int[] totalPrice = new int[50];
            //string[] orderCombo = new String[20];

            //customerName[index] = nameTB.Text;
            //contactNo[index] = contactTB.Text;
            //address[index] = addressTB.Text;
            //quantity[index] = Convert.ToInt32(quantityTB.Text);
            //pricePerOrder[index] = Convert.ToInt32(priceTB.Text);
            //orderCombo[index] = orderComboBox.Text;

            //if(nameTB.Text == null || contactTB.Text == null || addressTB.Text == null || 
            //    quantityTB.Text == null || priceTB.Text == null) {
            //    MessageBox.Show("You cannot keep it blank.");
            //}
            //else {
            //    MessageBox.Show("Sucessfully inserted an order.");
            //}

            //if(orderComboBox.Text == null) {
            //    MessageBox.Show("Selct item.");
            //}
            //else if(orderComboBox.Text == "Black Coffee") {
            //    totalPrice[index] = quantity[index] * pricePerOrder[index];
            //    showRichTextBox.Text += "Customer Name: " + customerName[index] + "\n" + "Contact No.: " + contactNo[index] + "\n" +
            //        "Address: " + address[index] + "\n" + "Odered item: " + orderCombo[index] + "\n" + "Quantity: " + quantity[index] + 
            //        "\n" + "Price Per " + orderCombo[index] + ": " + pricePerOrder[index] + "\n" + "Total Price: " + totalPrice[index] + "\n" + "\n";
            //}
            //else if (orderComboBox.Text == "Cold Coffee") {
            //    totalPrice[index] = quantity[index] * pricePerOrder[index];
            //    showRichTextBox.Text += "Customer Name: " + customerName[index] + "\n" + "Contact No.: " + contactNo[index] + "\n" +
            //        "Address: " + address[index] + "\n" + "Odered item: " + orderCombo[index] + "\n" + "Quantity: " + quantity[index] +
            //        "\n" + "Price Per " + orderCombo[index] + ": " + pricePerOrder[index] + "\n" + "Total Price: " + totalPrice[index] + "\n" + "\n";
            //}
            //else if (orderComboBox.Text == "Hot Coffee") {
            //    totalPrice[index] = quantity[index] * pricePerOrder[index];
            //    showRichTextBox.Text += "Customer Name: " + customerName[index] + "\n" + "Contact No.: " + contactNo[index] + "\n" +
            //        "Address: " + address[index] + "\n" + "Odered item: " + orderCombo[index] + "\n" + "Quantity: " + quantity[index] +
            //        "\n" + "Price Per " + orderCombo[index] + ": " + pricePerOrder[index] + "\n" + "Total Price: " + totalPrice[index] + "\n" + "\n";
            //}
            //else if (orderComboBox.Text == "Regular Coffee") {
            //    totalPrice[index] = quantity[index] * pricePerOrder[index];
            //    showRichTextBox.Text += "Customer Name: " + customerName[index] + "\n" + "Contact No.: " + contactNo[index] + "\n" +
            //        "Address: " + address[index] + "\n" + "Odered item: " + orderCombo[index] + "\n" + "Quantity: " + quantity[index] +
            //        "\n" + "Price Per " + orderCombo[index] + ": " + pricePerOrder[index] + "\n" + "Total Price: " + totalPrice[index] + "\n" + "\n";
            //}

            //index++;

            //string customerName, contactNo, address;
            //int quantity;
            //float pricePerOrder, totalPrice;

            //customerName = nameTB.Text;
            //contactNo = contactTB.Text;
            //address = addressTB.Text;
            //quantity = Convert.ToInt32(quantityTB.Text);
            //pricePerOrder = Convert.ToInt32(priceTB.Text);

            //if(quantityTB.Text == " ")
            //{
            //    MessageBox.Show("Insert a quantity");
            //}
            //if(orderComboBox.Text == null)
            //{
            //    MessageBox.Show("Selct item");
            //}
            //else if(orderComboBox.Text == "Black Coffee")
            //{
            //    totalPrice = quantity * pricePerOrder;
            //    showRichTextBox.Text = "Customer Name: " + customerName + "\n" + "Contact No.: " + contactNo + "\n" + 
            //        "Address: " + address + "\n" + "Odered item: " + orderComboBox.Text + "\n" + "Quantity: " + quantity + 
            //        "\n" + "Price Per " + orderComboBox.Text + ": " + pricePerOrder + "\n" + "Total Price: " + totalPrice;
            //}
            //else if (orderComboBox.Text == "Cold Coffee")
            //{
            //    totalPrice = quantity * pricePerOrder;
            //    showRichTextBox.Text = "Customer Name: " + customerName + "\n" + "Contact No.: " + contactNo + "\n" +
            //        "Address: " + address + "\n" + "Odered item: " + orderComboBox.Text + "\n" + "Quantity: " + quantity +
            //        "\n" + "Price Per " + orderComboBox.Text + ": " + pricePerOrder + "\n" + "Total Price: " + totalPrice;
            //}
            //else if (orderComboBox.Text == "Hot Coffee")
            //{
            //    totalPrice = quantity * pricePerOrder;
            //    showRichTextBox.Text = "Customer Name: " + customerName + "\n" + "Contact No.: " + contactNo + "\n" +
            //        "Address: " + address + "\n" + "Odered item: " + orderComboBox.Text + "\n" + "Quantity: " + quantity +
            //        "\n" + "Price Per " + orderComboBox.Text + ": " + pricePerOrder + "\n" + "Total Price: " + totalPrice;
            //}
            //else if (orderComboBox.Text == "Regular Coffee")
            //{
            //    totalPrice = quantity * pricePerOrder;
            //    showRichTextBox.Text = "Customer Name: " + customerName + "\n" + "Contact No.: " + contactNo + "\n" +
            //        "Address: " + address + "\n" + "Odered item: " + orderComboBox.Text + "\n" + "Quantity: " + quantity +
            //        "\n" + "Price Per " + orderComboBox.Text + ": " + pricePerOrder + "\n" + "Total Price: " + totalPrice;
            //}
    }
}

