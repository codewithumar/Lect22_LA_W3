using Lect22_LA_W3.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect22_LA_W3.DL
{
    class LoginDL
    {
        DBConnection _dbCon;
        public LoginDL()
        {
            _dbCon = new DBConnection();
        }
        public LoginDTO VerifyUserFromDB(LoginDTO dto)
        {
            LoginDTO retDTO = new LoginDTO();
            _dbCon.Con.Open();
            string queryString = "SELECT Username,Password,Role FROM MyUser WHERE Username='"+dto.Username+"' AND Password='"+dto.Password+"';" ;
            SqlCommand com = new SqlCommand(queryString,_dbCon.Con);
            SqlDataReader reader =  com.ExecuteReader();
            while(reader.Read())
            {

                retDTO.Username= reader["Username"].ToString();
                retDTO.Password= reader["Password"].ToString();
                retDTO.Role= reader["Role"].ToString();
                return retDTO;


            }
            return retDTO;

        }
    
    }
}
