using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

/*
 * 第一个页面，天气查询页
 */
namespace MyWeatherApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /*
         * 后台运行与程序生命周期，程序间通信
         */
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

        }

        /*
         * 后台运行与程序生命周期，程序间通信
         */
        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {

        }

        /*
         * 点击分享时的click事件
         */
        private void shareWeather(object sender, RoutedEventArgs e)
        {

        }

        /*
         * 程序间通信
         */
        private async void OnShareRequested(DataTransferManager sender, DataRequestedEventArgs args)
        {

        }

        /*
         * 天气查找按钮的点击事件,当查询得出正确结果时，更新磁贴
         */
        private void searchWeather(object sender, RoutedEventArgs e)
        {

        }
    }
}
