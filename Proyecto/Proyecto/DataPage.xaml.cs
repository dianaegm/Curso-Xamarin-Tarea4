using System;
using System.Collections.Generic;
using Proyecto.Model;
using Proyecto.Service;

using Xamarin.Forms;

namespace Proyecto
{
    public partial class DataPage : ContentPage
    {
        public DataPage()
        {
           InitializeComponent();
        }

        public DataPage (Persona persona) {
          
           // BindingContext persona;
            InitializeComponent();

        }
    }
}
