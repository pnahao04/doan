using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOOK
{
    internal class BookAccount
    {
        private string account;
        private string password;
        private bool isVerified;
        public string Account
        {
            get { return account; }
            set { account = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public BookAccount(string account, string password)
        {
            this.account = account;
            this.password = password;
            isVerified = false;
        }

        public void VerifyLogin(string inputAccount, string inputPassword)
        {
            if (inputAccount != this.account)
                throw new ArgumentException("Tài khoản không đúng!");

            if (inputPassword != this.password)
                throw new UnauthorizedAccessException("Mật khẩu không đúng!");

            isVerified = true;
        }

        public bool IsVerified => isVerified;


}
}
