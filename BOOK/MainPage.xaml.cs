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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BOOK
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private BookAccount userAccount ;
        public MainPage()
        {
            this.InitializeComponent();
            userAccount = new BookAccount("anhhao", "hao123");

        }

        private async void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string inputAccount = UsernameTextBox.Text;
            string inputPassword = PasswordBox.Password;

            try
            {
                userAccount.VerifyLogin(inputAccount, inputPassword);

                ContentDialog successDialog = new ContentDialog
                {
                    Title = "Đăng nhập thành công",
                    Content = $"Chào mừng {userAccount.Account}!",
                    CloseButtonText = "OK"
                };

                await successDialog.ShowAsync(); // Hiện hộp thoại rồi đợi bấm OK

                // Sau khi bấm OK thì mới chuyển trang
                Frame.Navigate(typeof(HomeBook));
            }
            catch (ArgumentException ex)
            {
                await new ContentDialog
                {
                    Title = "Sai tài khoản",
                    Content = ex.Message,
                    CloseButtonText = "Thử lại"
                }.ShowAsync();
            }
            catch (UnauthorizedAccessException ex)
            {
                await new ContentDialog
                {
                    Title = "Sai mật khẩu",
                    Content = ex.Message,
                    CloseButtonText = "Thử lại"
                }.ShowAsync();
            }
        }
    }
}


