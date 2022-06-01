using Lect22_LA_W3.DL;
using Lect22_LA_W3.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect22_LA_W3.BL
{
    class LoginBL
    {
        private LoginDL _lgDL;
        public LoginBL()
        {
            _lgDL = new LoginDL();
        }
        public string VerifyUser(LoginDTO lgDTO)
        {
            if(_lgDL.VerifyUserFromDB(lgDTO).Role.Equals("admin"))
            {
                return "admin";

            }
            return null;

        }
    }
}
