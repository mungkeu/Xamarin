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
    public partial class ch_7_navigationPage1 : ContentPage
    {
        public ch_7_navigationPage1()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushModalAsync(new ch_2_ContentPage()); // 스택 구조로 뒤로가기 버튼이 없다.
            Navigation.PushAsync(new ch_2_ContentPage());   // 화면이 아에 이동한 것이기 때문에 뒤로가기 버튼이 존재한다.
        }
    }
}