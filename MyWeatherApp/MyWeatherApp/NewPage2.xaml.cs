using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

/*
 * 第三个页面，登录页
 */
namespace MyWeatherApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NewPage2 : Page
    {
        public NewPage2()
        {
            this.InitializeComponent();
        }

        /*
         * 后台运行与程序生命周期
         */
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

        }

        /*
         * 后台运行与程序生命周期
         */
        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {

        }

        /*
         * 文件管理，选择图片添加到头像框
         */
        private async void selectPicture(object sender, RoutedEventArgs e)
        {

        }
    }
}
