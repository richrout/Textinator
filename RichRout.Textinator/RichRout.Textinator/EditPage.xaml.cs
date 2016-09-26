using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RichRout.Textinator.Interfaces;
using RichRout.Textinator.Repository;
using Xamarin.Forms;

namespace RichRout.Textinator
{
    public partial class EditPage : ContentPage
    {
        public TemplateItem Model { get; set; }
        public EditPage() : this(new TemplateItem())
        {
            Title = "Create New";
        }

        public EditPage(TemplateItem model)
        {
            Model = model;
            Title = "Edit";
            ToolbarItems.Add(new ToolbarItem("Filter", "ic_check_white_24dp.png", OnSave));

            BindingContext = Model;
            InitializeComponent();
        }

        private async void OnSave()
        {
            var repo = new TemplatesRepository();
            repo.Save(Model);
            await this.Navigation.PopAsync();
        }

    }

}
