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

namespace assignment5.Views
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// this is event handler for exit tool option click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SaveCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

            

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// this is event handler for cancel button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// this is event handler for next button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.orderForm.Show();
        }

        /// <summary>
        /// this is event handler for select another button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAnotherProductButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.selectForm.Show();
        }
        /// <summary>
        /// this is event handler for prodtinfoform activate event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoForm_Activated(object sender, EventArgs e)
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

                ProductIDDataLabel.Text = Program.Product.productID.ToString();
                CostDataLabel.Text = String.Format("0:C", Program.Product.cost);
                ManufacturerDataLabel.Text = Program.Product.manufacturer;
                ModelDataLabel.Text = Program.Product.model;
                MemoryDataLabel.Text = Program.Product.RAM_size;
                LCDSizeDataLabel.Text = Program.Product.screensize;
                CPUBrandDataLabel.Text = Program.Product.CPU_brand;
                CPUMODELdataLAbel.Text = Program.Product.CPU_type;
                CPUSpeedDataLabel.Text = Program.Product.CPU_speed;
                CPUNoDataLabel.Text = Program.Product.CPU_number;
                ConditionDataLabel.Text = Program.Product.condition;
                OSDataLabel.Text = Program.Product.OS;
                PlatformDataLabel.Text = Program.Product.platform;
                HDDDataLabel.Text = Program.Product.HDD_size;
                GPUTypeDataLabel.Text = Program.Product.GPU_Type;
                WebCamDataLabel.Text = Program.Product.webcam;
            }
            }
    }
}
