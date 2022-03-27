using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinStudy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ElementsPage1 : ContentPage
    {
        public ElementsPage1()
        {
            InitializeComponent();
        }

        private void btn1_Clicked(object sender, EventArgs e) // xaml에서 지정한 이름으로 이벤트생성.
        {
            BackgroundColor = Color.Yellow;
        }
    }
}