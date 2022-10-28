using System.Linq;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Collections;

namespace MorseTexting
{
    public partial class MainPage : ContentPage
    {
        public string dotsAndDashesUpper { get; set; }
        public string dotsAndDashesLower { get; set; }
        public string spaceBarUpper { get; set; }
        public string spaceBarLower { get; set; }
        public MainPage()
        {
            InitializeComponent();
            dotsAndDashesUpper = "";
            spaceBarUpper = "";
            dotsAndDashesLower = "";
            spaceBarLower = "";
        }
        
        void Btn_UpperDotClick(object sender, System.EventArgs e)
        {
            dotsAndDashesUpper += ".";
            lbl4_UpperMorse.Text = dotsAndDashesUpper;
        }

        void Btn_UpperDashClick(object sender, System.EventArgs e)
        {
            dotsAndDashesUpper += "-";
            lbl4_UpperMorse.Text = dotsAndDashesUpper;
        }

        void Btn_UpperSpaceBarClick(object sender, System.EventArgs e)
        {
            if (dotsAndDashesUpper.Length != 0)
            {
                lbl4_UpperTextScreen.Text += MorseAlpha.DeCoder(dotsAndDashesUpper);
                dotsAndDashesUpper = "";
                lbl4_UpperMorse.Text = dotsAndDashesUpper;
            }
            else
            {
                lbl4_UpperTextScreen.Text += " ";
                dotsAndDashesUpper = "";
            }

        }

        //----------------------------------------------

        void Btn_LowerDotClick(object sender, System.EventArgs e)
        {
            dotsAndDashesLower += ".";
            lbl6_LowerMorse.Text = dotsAndDashesLower;
        }

        void Btn_LowerDashClick(object sender, System.EventArgs e)
        {
            dotsAndDashesLower += "-";
            lbl6_LowerMorse.Text = dotsAndDashesLower;
        }

        void Btn_LowerSpaceBarClick(object sender, System.EventArgs e)
        {
            if (dotsAndDashesLower.Length != 0)
            {
                lbl6_LowerTextScreen.Text += MorseAlpha.DeCoder(dotsAndDashesLower);
                dotsAndDashesLower = "";
                lbl6_LowerMorse.Text = dotsAndDashesLower;
            }
            else
            {
                lbl6_LowerTextScreen.Text += " ";
                dotsAndDashesLower = "";
            }
        }

        
    }
}
