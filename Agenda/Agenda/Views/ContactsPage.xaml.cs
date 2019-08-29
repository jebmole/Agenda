using Agenda.Domain;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Agenda.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsPage : ContentPage
    {
        public ContactsPage()
        {
            InitializeComponent();
            LoadContacts();
        }

        private void LoadContacts()
        {
            var contactsList = new List<Contact>
            {
                new Contact { FullName = "Juan Perez", Email="juan@gmail.com", LinkedIn = "juanpa", PhoneNumber = "3045568990", SkypeId= "juanpm", ImageUrl="login.png" },
                new Contact { FullName = "Andres Lopez", Email="andres@gmail.com", LinkedIn = "juanpa", PhoneNumber = "3045568990", SkypeId= "juanpm", ImageUrl="login.png" },
                new Contact { FullName = "Camilo Ramirez", Email="camilo@gmail.com", LinkedIn = "juanpa", PhoneNumber = "3045568990", SkypeId= "juanpm", ImageUrl="login.png" },
                new Contact { FullName = "Diana Lopera", Email="diana@gmail.com", LinkedIn = "juanpa", PhoneNumber = "3045568990", SkypeId= "juanpm", ImageUrl="login.png" },
                new Contact { FullName = "Ana Perez", Email="ana@gmail.com", LinkedIn = "juanpa", PhoneNumber = "3045568990", SkypeId= "juanpm", ImageUrl="login.png" }
            };

            lsContacts.ItemsSource = contactsList;
        }

        private async void Contact_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            var contactSelected = (Contact)e.SelectedItem;
            await Navigation.PushAsync(new DetailContactPage(contactSelected));
        }
    }
}