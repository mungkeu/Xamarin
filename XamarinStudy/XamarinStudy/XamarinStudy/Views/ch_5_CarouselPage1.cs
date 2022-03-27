using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinStudy.Views
{
    // ContentPage가 아닌 CarouselPage를 상속받아야 한다. 
    // 회전 페이지로 실행 후 마우스로 드래그하면 페이지가 이동된다.
    public class ch_5_CarouselPage1 : CarouselPage
    {
        public ch_5_CarouselPage1()
        {
            Children.Add(new ch_2_ContentPage());
            Children.Add(new ch_2_ContentPage2());
        }
    }
}