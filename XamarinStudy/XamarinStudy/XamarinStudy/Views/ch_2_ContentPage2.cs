using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinStudy.Views
{
    public class ch_2_ContentPage2 : ContentPage
    {
        public ch_2_ContentPage2()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to Xamarin.Forms!", FontSize=30, TextColor=Color.Red }
                }
            };
        }
    }
}

/*
    xaml은 바로 바로 실행시에 변경사항을 확인 할 수 있고
    c# 파일의 경우 재실행 하여야 한다.

    FontSize : 폰트 크기
    TextColor : 폰트 색상 
 */