using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RichRout.Textinator.Interfaces;
using RichRout.Textinator.Repository;
using Xamarin.Forms;

namespace RichRout.Textinator
{
    public partial class MainPage : ContentPage
    {
        TemplatesRepository repo;

        public MainPage()
        {
            repo = new TemplatesRepository();
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            TemplateList.ItemsSource = repo.GetItems();
        }

        async void Handle_FabClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditPage());
        }
        
        private async void OnEdit(object sender, EventArgs e)
        {
            var mi = (MenuItem)sender;
            await Navigation.PushAsync(new EditPage((TemplateItem)mi.CommandParameter));
        }

        private void OnDelete(object sender, EventArgs e)
        {
            var mi = (MenuItem)sender;
            repo.DeleteItem(((TemplateItem)mi.CommandParameter).Id);

            TemplateList.ItemsSource = repo.GetItems();
        }

        private async void TemplateList_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var templateItem = e.SelectedItem as TemplateItem;
            if (templateItem == null)
            {
                return;
            }

            var result = await DisplayAlert("Send To " + templateItem.Contact, templateItem.Message, "Send", "Cancel");
            if (result)
            {
                var sms = DependencyService.Get<ISmsService>();
                sms.Send(templateItem.Contact, templateItem.Message);
            }
            ((ListView)sender).SelectedItem = null;
        }
    }
}
