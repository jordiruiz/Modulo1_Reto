using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Modulo1_Reto.Views
{
    public partial class MainView : ContentPage
    {
        int count = 1;

        public MainView()
        {
            InitializeComponent();

            MyButton.Clicked += (sender, args) =>
            {
                MyLabel.Text = $"Has pulsado {count++} veces!";
            };
        }
    }
}
