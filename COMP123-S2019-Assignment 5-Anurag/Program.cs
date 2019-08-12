using COMP123_S2019_Assignment_5_Anurag.Data;
using COMP123_S2019_Assignment_5_Anurag.Views;
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
        //This is the data
        public static Product product { get; set; }
        //These are all the forms in the application
        public static SplashScreenForm splashScreenForm { get; set; }
        public static StartForm startForm { get; set; }
        public static SelectForm selectForm { get; set; }
        public static ProductInfoForm productInfoForm { get; set; }
        public static OrderForm orderForm { get; set; }
        public static AboutForm aboutForm { get; set; }
        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            product = new Product();
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
