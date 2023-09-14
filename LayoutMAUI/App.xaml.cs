using LayoutMAUI.Pages;

namespace LayoutMAUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            //MainPage = new StackLayoutTut();
            //MainPage = new HorizontalStackLayoutTut();
            //MainPage = new VerticalStackLayoutTut();
            //MainPage = new GridLayoutTut();
            MainPage = new AbsoluteLayoutTut();
            //MainPage = new FlexLayoutTut();
        }
    }
}