using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LYY_SnacksWeb.Models
{
    public class RUsers:IUsers
    {
        SnacksEntities2 db = new SnacksEntities2();
       void IUsers.Create(Users users)
        {
            db.Users.Add(users);
            db.SaveChanges();
            //return true;
            
        }
    
    }
}