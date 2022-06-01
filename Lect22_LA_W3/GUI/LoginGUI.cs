using Lect22_LA_W3.BL;
using Lect22_LA_W3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lect22_LA_W3
{
    public partial class LoginGU : Form
    {
        private LoginDTO _lgDTO;
        private LoginBL _lgBL;
        public LoginGU()
        {
            InitializeComponent();
            _lgDTO = new LoginDTO();
            _lgBL = new LoginBL();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //if()
            _lgDTO.Username = txt_Username.Text;
            _lgDTO.Password = txt_Pass.Text;
            if(_lgBL.VerifyUser(_lgDTO).Equals("admin"))
            {
                MessageBox.Show("Login Succesfull");

            }    
            else
            {
                MessageBox.Show("Wrong ");
            }
        }
    }
}
