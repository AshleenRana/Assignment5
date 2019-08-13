using assignment5.Models;
using assignment5.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment5
{
    public static class Program
    {
        public static SplashScreen splashScreen;
        public static StartForm startForm;
        public static SelectForm selectForm;
        public static ProductInfoForm productInfoForm;
        public static OrderForm orderForm;
        public static Products productclass;
        public static product Product;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            splashScreen = new SplashScreen();
            startForm = new StartForm();
            orderForm = new OrderForm();
            productInfoForm = new ProductInfoForm();
            selectForm = new SelectForm();
            productclass = new Products();
            Product = new product();

            Application.Run(splashScreen);
        }
    }
}
