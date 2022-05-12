using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Login.MangeLogin;

namespace Login
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void TryLogin(object sender, EventArgs e)
        {
            SigninManager signinManager = new SigninManager();
            signinManager.login("test", PasswordInput.Text);
        }

    }
}