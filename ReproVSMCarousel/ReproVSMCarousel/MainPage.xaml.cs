using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ReproVSMCarousel
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public List<string> Items { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Items = new List<string>();
            Items.Add("A");
            Items.Add("B");
            Items.Add("C");
            Items.Add("D");
            Items.Add("E");
            BindingContext = this;
        }
    }
}
