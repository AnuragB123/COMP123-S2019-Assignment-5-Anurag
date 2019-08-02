using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment_5_Anurag
{
    public static class Program
    {
        public static SplashScreenForm splashScreenForm;

        public static StartForm startForm;

        public static SelectForm selectForm;

        public static ProductInfoForm productInfoForm;

        public static OrderForm orderForm;

        public static AboutForm aboutForm;

        


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            splashScreenForm = new SplashScreenForm();

            startForm = new StartForm();

            selectForm = new SelectForm();

            productInfoForm = new ProductInfoForm();

            orderForm = new OrderForm();

            aboutForm = new AboutForm();

            //aboutForm = new AboutForm();

            Application.Run(new SplashScreenForm());
        }
    }
}
