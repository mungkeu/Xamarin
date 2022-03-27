using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinStudy.Services;
using XamarinStudy.Views;

namespace XamarinStudy
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            //MainPage = new AppShell();
            //MainPage = new Ch_2_ContentPage2();
            //MainPage = new NavigationPage(new ch_3_ToolbarPage1());
            //MainPage = new ch_4_TabbedPage1();

            //TabbedPage tabbed = new TabbedPage(); // views에서 클래스나 xaml로 만든게 아니라 직빵으로 클래스로 생성.
            //tabbed.Children.Add(new ch_2_ContentPage() { Title="페이지1"}); // 해당 페이지들을 탭들과 연결
            //tabbed.Children.Add(new ch_2_ContentPage2() { Title = "페이지2" }); // Title로 제목을 안만들면 제목이 표시안된다.
            //tabbed.Children.Add(new ch_3_ToolbarPage1() { Title = "페이지3" });
            //MainPage = tabbed; // 생성한 탭페이지를 메인페이지에 연결.

            //MainPage = new ch_6_FlyoutPage1();
            //MainPage = new ch_6_FlyoutPage2();
            //MainPage = new NavigationPage(new ch_7_navigationPage1());

            TabbedPage tabbed = new TabbedPage(); // views에서 클래스나 xaml로 만든게 아니라 직빵으로 클래스로 생성.
            tabbed.Children.Add(new ElementsPage1() { Title = "Xaml" }); // 해당 페이지들을 탭들과 연결
            tabbed.Children.Add(new ElementsPage2() { Title = "CS" }); // Title로 제목을 안만들면 제목이 표시안된다.
            MainPage = tabbed;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

/*
      <ContentPage.ToolbarItems>의 툴바 아이템을 사용하기 위해서는 NavigationPage 클래스의
      생성자로 넣어줘야 한다.
 */