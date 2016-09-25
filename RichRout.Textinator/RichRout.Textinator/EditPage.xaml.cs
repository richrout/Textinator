using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace RichRout.Textinator
{
    public partial class EditPage : ContentPage
    {
        public EditPage()
        {
            Title = "Create New";
            ToolbarItems.Add(new ToolbarItem("Filter", "ic_check_white_24dp.png", async () =>
            {
                var page = new ContentPage();
                var result = await page.DisplayAlert("Title", "Message", "Accept", "Cancel");
            }));
            InitializeComponent();
        }
    }

}
