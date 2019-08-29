using Agenda.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Agenda.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailContactPage : ContentPage
    {
        public DetailContactPage(Contact contact)
        {
            InitializeComponent();
            LoadData(contact);
        }

        private void LoadData(Contact contact)
        {
            gridDatos.BindingContext = contact;
        }
    }
}