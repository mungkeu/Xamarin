using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinStudy.Views
{
    public class ch_6_FlyoutPage2 : FlyoutPage
    {
        public ch_6_FlyoutPage2()
        {
            Flyout = new ch_2_ContentPage() { Title="플리이아웃페이지"};
            Detail = new NavigationPage(new ch_3_ToolbarPage1());
        }
    }
}

/*
 * Detail 페이지가 Flyout 페이지 보다 먼저 실행된다.
 * NavigationPage 사용해야 툴바페이지를 보여줄 수 있다.
 */