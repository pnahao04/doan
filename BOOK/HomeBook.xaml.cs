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


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace BOOK
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomeBook : Page
    {
        public HomeBook()
        {
            this.InitializeComponent();
        }
        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            // Điều hướng sang trang tìm kiếm sách
            Frame.Navigate(typeof(SearchPage));
        }

        private void BorrowButton_Click(object sender, RoutedEventArgs e)
        {
            // Điều hướng sang trang mượn sách
            Frame.Navigate(typeof(BorrowPage));
        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            // Điều hướng sang trang trả sách
            Frame.Navigate(typeof(ReturnPage));
        }

        private void HistoryButton_Click(object sender, RoutedEventArgs e)
        {
            // Điều hướng sang trang lịch sử mượn trả
            Frame.Navigate(typeof(HistoryPage));
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            // Quay lại trang đăng nhập (MainPage)
            Frame.Navigate(typeof(MainPage));
        }



    }
}
