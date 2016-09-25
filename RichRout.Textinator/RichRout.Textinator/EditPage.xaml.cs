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
        public EditTemplateModel Model { get; set; }
        public EditPage()
        {
            Model = new EditTemplateModel();
            Title = "Create New";
            ToolbarItems.Add(new ToolbarItem("Filter", "ic_check_white_24dp.png", OnSave));

            BindingContext = Model;
            InitializeComponent();
        }

        private async void OnSave()
        {
            var page = new ContentPage();
            var result = await page.DisplayAlert(Model.Contact, Model.Message, "Accept", "Cancel");
            await this.Navigation.PopAsync();
        }
    }

}
