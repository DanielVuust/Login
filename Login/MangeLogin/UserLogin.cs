using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Login.Data;

namespace Login.MangeLogin
{
    public class UserLogin
    {
        public bool login(string username, string password)
        {
            UserPassword userPassword = new UserPassword();

            userPassword.getUserPassword(username); 


        }
    }
}