using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DAO
{
    /// <summary>
    /// Đay là lớp trung gian nhận dữ liệu và đổ dữ liệu về Form(View), tương tự Controller
    /// </summary>
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
            if (instance == null) instance = new AccountDAO();
                return AccountDAO.instance;
                    }
            private set { AccountDAO.instance = value; }
        }
        private AccountDAO() { }
        public bool Login1(string username,string password)
        {
            string query = "exec proc_Login @username , @password";
            var result = DataProvider.Instance.ExecuteQuery(query,new object[] {username,password});
            return result.Rows.Count >0 ;
        }
    }
}
