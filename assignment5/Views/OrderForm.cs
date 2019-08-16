using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment5
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is event handler for back button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.productInfoForm.Show();
        }
        /// <summary>
        /// This is event handler for cancel button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is event handler for finish button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinishButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// this is event handler for order form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_Load(object sender, EventArgs e)
        {
            //opened File To Stream to read
            using (StreamReader inputStream = new StreamReader(
                File.Open("Product.txt", FileMode.Open)))
            {
                //Read stuff to the file into the product Object
                Program.Product.productID = short.Parse(inputStream.ReadLine());
                Program.Product.cost = decimal.Parse(inputStream.ReadLine());
                Program.Product.manufacturer = inputStream.ReadLine();
                Program.Product.model = inputStream.ReadLine();
                Program.Product.RAM_size = inputStream.ReadLine();
                Program.Product.screensize = inputStream.ReadLine();
                Program.Product.CPU_brand = inputStream.ReadLine();
                Program.Product.CPU_type = inputStream.ReadLine();
                Program.Product.CPU_speed = inputStream.ReadLine();
                Program.Product.CPU_number = inputStream.ReadLine();
                Program.Product.condition = inputStream.ReadLine();
                Program.Product.OS = inputStream.ReadLine();
                Program.Product.platform = inputStream.ReadLine();
                Program.Product.HDD_size = inputStream.ReadLine();
                Program.Product.GPU_Type = inputStream.ReadLine();
                Program.Product.webcam = inputStream.ReadLine();

                //cleanup
                inputStream.Close();
                inputStream.Dispose();

              
                PriceDataLabel.Text = String.Format("{0:C}", Program.Product.cost);
                ManufacturerDataLabel.Text = Program.Product.manufacturer;
                ModelDataLabel.Text = Program.Product.model;
                MemoryDataLabel.Text = Program.Product.RAM_size;
                LCDDataLabel.Text = Program.Product.screensize;
                CPUBrandDataLabel.Text = Program.Product.CPU_brand;
                CPUTypeDataLabel.Text = Program.Product.CPU_type;
                ConditonDataFinalLabel.Text = Program.Product.condition;
                OSDataLabel.Text = Program.Product.OS;
                PlatfromDataLabel.Text = Program.Product.platform;
                HDDDataLabel.Text = Program.Product.HDD_size;
                GPUDataLabel.Text = Program.Product.GPU_Type;
                WebCamDataLabel.Text = Program.Product.webcam;

                var taxPrice = Program.Product.cost * 15 / 100;
                SalesTaxDataLabel.Text = String.Format("{0:C}", taxPrice);
                var totalPrice = Program.Product.cost + taxPrice;
                TotalDataLabel.Text = String.Format("{0:C}", totalPrice);
            }
        }
    }
}
