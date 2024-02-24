using EmptyMaui;
using Evergine.Framework.Graphics;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;

namespace EmptyMaui.MAUI
{
    public partial class MainPage : ContentPage
    {
        private readonly MyApplication evergineApplication;

        public MainPage()
        {
            InitializeComponent();
            this.evergineApplication = new MyApplication();
            this.evergineView.Application = this.evergineApplication;
        }
    }
}