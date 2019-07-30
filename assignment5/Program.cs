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

            Application.Run(splashScreen);
        }
    }
}
