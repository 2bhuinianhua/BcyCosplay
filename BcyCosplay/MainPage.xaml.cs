using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace BcyCosplay
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static bool isLogin
        {
            get
            {
                var baseUri = new Uri("https://bcy.net");
                var filter = new Windows.Web.Http.Filters.HttpBaseProtocolFilter();
                var cookies = filter.CookieManager.GetCookies(baseUri);
                foreach (var item in cookies)
                {
                    if (item.Name == "_bcy_user_id")
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        public static MainPage currenMainPage;

        public MainPage()
        {
            currenMainPage = this;
            this.InitializeComponent();

            Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().TryEnterFullScreenMode();
            var c = Windows.ApplicationModel.Core.CoreApplication.GetCurrentView().TitleBar;
            c.ExtendViewIntoTitleBar = true;


            if (isLogin)
            {
                contentFrame.Navigate(typeof(FollowPage));
            }
            else
            {
                backPage = typeof(FollowPage);
                contentFrame.Navigate(typeof(LoginPage));
            }
        }

        private string uid = null;
        public async Task<string> GetUid()
        {
            if (uid != null)
            {
                return uid;
            }
            if (!isLogin)
            {
                return null;
            }
            var baseUri = new Uri("https://bcy.net");
            var filter = new Windows.Web.Http.Filters.HttpBaseProtocolFilter();
            var cookies = filter.CookieManager.GetCookies(baseUri);
            CookieContainer cookie = new CookieContainer();
            foreach (var item in cookies)
            {
                cookie.SetCookies(baseUri, item.Name + "=" + item.Value);
            }
            var rq = HttpWebRequest.CreateHttp(baseUri.ToString());
            rq.CookieContainer = cookie;
            var rs = await rq.GetResponseAsync();
            var s = rs.GetResponseStream();
            var sr = new StreamReader(s);
            var str = await sr.ReadToEndAsync();
            sr.Close();
            s.Close();
            rs.Close();
            string keyword = "\\\"uid\\\":\\\"";
            int index = str.IndexOf(keyword);
            if (index < 0)
            {
                return null;
            }
            index += keyword.Length;
            int end = str.IndexOf("\\", index);
            if (end < 0)
            {
                return null;
            }
            uid = str.Substring(index, end - index);
            return uid;
        }

        public void NvInvoked(Type t)
        {
            contentFrame.Navigate(t);
        }

        public void NvInvoked(Type t, object parameter)
        {
            contentFrame.Navigate(t, parameter);
        }

        Type backPage = null;
        public void NvBack()
        {
            if (backPage != null)
            {
                contentFrame.Navigate(backPage);
            }
        }

        private void Nv_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.IsSettingsInvoked)
            {
                contentFrame.Navigate(typeof(SettingPage));
                return;
            }
            NavigationViewItem itemContainer = (NavigationViewItem)args.InvokedItemContainer;
            if (itemContainer == nvHome)
            {
                if (isLogin)
                {
                    contentFrame.Navigate(typeof(HomePage));
                }
                else
                {
                    backPage = typeof(HomePage);
                    contentFrame.Navigate(typeof(LoginPage));
                }
            }
            else if (itemContainer == nvFollow)
            {
                if (isLogin)
                {
                    contentFrame.Navigate(typeof(FollowPage));
                }
                else
                {
                    backPage = typeof(FollowPage);
                    contentFrame.Navigate(typeof(LoginPage));
                }
            }
            else if (itemContainer == nvFind)
            {
                contentFrame.Navigate(typeof(FindPage));
            }
            else if (itemContainer == nvCos)
            {
                contentFrame.Navigate(typeof(CosPage));
            }
            else if (itemContainer == nvVideo)
            {
                contentFrame.Navigate(typeof(VideoPage));
            }
            else if (itemContainer == nvDraw)
            {
                contentFrame.Navigate(typeof(DrawPage));
            }
            else if (itemContainer == nvWrite)
            {
                contentFrame.Navigate(typeof(WritePage));
            }
            else if (itemContainer == nvAnswer)
            {
                contentFrame.Navigate(typeof(AnswerPage));
            }
            else if (itemContainer == nvCircle)
            {
                contentFrame.Navigate(typeof(CirclePage));
            }
        }

        private void NvFavor_Tapped(object sender, TappedRoutedEventArgs e)
        {
            contentFrame.Navigate(typeof(FavorPage));
        }


        public static void WebView_NewWindowRequested(WebView sender, WebViewNewWindowRequestedEventArgs args)
        {
            Type t = null;
            object parameter = null;
            string url = args.Uri.ToString();
            if (DetailPage.isSupport(url))
            {
                t = typeof(DetailPage);
                parameter = DetailPage.getItemId(url);
            }

            if (t != null)
            {
                args.Handled = true;
                if (parameter == null)
                {
                    MainPage.currenMainPage.NvInvoked(t);
                }
                else
                {
                    MainPage.currenMainPage.NvInvoked(t, parameter);
                }
            }
        }
    }
}
