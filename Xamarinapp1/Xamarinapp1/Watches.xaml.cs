using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarinapp1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Watches : ContentPage
    {
        public Watches()
        {
            InitializeComponent();
        }

        private void Button1_OnClicked(object sender, EventArgs e)
        {
            label1.Text = "Sepete Eklendi".ToString();
        }

        private void Button2_OnClicked(object sender, EventArgs e)
        {
            label2.Text = "Sepete Eklendi".ToString();
        }

        private void Button3_OnClicked(object sender, EventArgs e)
        {
            label3.Text = "Sepete Eklendi".ToString();
        }

        private void Button4_OnClicked(object sender, EventArgs e)
        {
            label4.Text = "Sepete Eklendi".ToString();
        }

        private void Button5_OnClicked(object sender, EventArgs e)
        {
            label5.Text = "Sepete Eklendi".ToString();
        }

        private void Button6_OnClicked(object sender, EventArgs e)
        {
            label6.Text = "Sepete Eklendi".ToString();
        }
    }
}