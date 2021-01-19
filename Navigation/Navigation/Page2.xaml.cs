using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2(string name , string anh ,string thongtin , string noidung )
        {
            InitializeComponent();
            name1.Text = name;
            images.Source = anh;
            thongtin1.Text = thongtin;
        }
    }
}