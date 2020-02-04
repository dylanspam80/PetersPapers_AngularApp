using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetersPapers.Models.ViewModels
{
    public class UserModel
    {
        public User user { get; set; }

        public UserModel(int Id)
        {
            using (Entities db = new Entities())
            {
                this.user = db.Users.Where(x => x.Id == Id).FirstOrDefault();
            }
        }
        public UserModel(string UserName)
        {
            using (Entities db = new Entities())
            {
                this.user = db.Users.Where(x => x.UserName == UserName).FirstOrDefault();
            }
        }

    }
}