using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RichRout.Textinator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void Handle_FabClicked(object sender, System.EventArgs e)
        {
            this.DisplayAlert("Floating Action Button", "You clicked the FAB!", "Awesome!");
        }
    }
}
