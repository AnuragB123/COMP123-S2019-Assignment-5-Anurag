using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Name: Anurag Bhattacharya
/// Lab 12 - Assignment 5 UI
/// 301050634
/// </summary>
namespace COMP123_S2019_Assignment_5_Anurag
{
    public static class Program
    {
        //These are all the forms in the application
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
            //This intializes each of the forms
            splashScreenForm = new SplashScreenForm();
            startForm = new StartForm();
            selectForm = new SelectForm();
            productInfoForm = new ProductInfoForm();
            orderForm = new OrderForm();
            aboutForm = new AboutForm();
            //Runs the Splash Screen First
            Application.Run(new SplashScreenForm());
        }
    }
}
