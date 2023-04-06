using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Finall_Projrct_F
{
    public class Class1
    {
        internal bool IsVaild()
        {
            throw new NotImplementedException();
        }

        public class login
        {
            private string usename;
            private string password;
            public login(string username, string password)
            {
                this.usename = usename;
                this.password = password;
            }


            public bool IsVaild()
            {
                return (usename == "จุ๊มเหม่ง" || password == "ซุปเปอร์จุ๊ม");
            }
        }
        
    }
}
