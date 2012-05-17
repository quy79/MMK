using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DatabaseLayer;
namespace EmailSite
{
    public class UserDB
    {
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="username"></param>
        /// <param name="title"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="city"></param>
        /// <param name="province"></param>
        /// <param name="country"></param>
        /// <returns>
        /// 0 : add user fail
        /// 1 : add user successful
        /// 2 : this email is registered
        /// 3 : this user is registered
        /// </returns>
        public static int AddUser(string firstname, string lastname, string username, string password, string title, 
                                  string email, string phone, string city, string province, string country){

            Users user = new Users();
            user.FIRSTNAME = firstname;
            user.LASTNAME = lastname;
            user.USERNAME = username;
            user.PASSWORD = password;
            user.TITLE = title;
            user.EMAIL = email;
            user.PHONE = phone;
            user.CITY = city;
            user.PROVINCE = province;
            user.COUNTRY = country;
            
            //check username is existed
            if (user.IsExistEmail()) return 2;
            //check email is existed
            if (user.IsExistUsername()) return 3;
            //inseert new user
            if(user.Insert()) return 1;
            return 0;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool CheckUserPass(string username, string password)
        {
            Users user = new Users();
            user.USERNAME = username;
            user.PASSWORD = password;
            return user.CheckUserPass();            
        }
    }
}