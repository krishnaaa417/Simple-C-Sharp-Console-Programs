using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisingC_
{
    public class Genrics2
    {
        public string UserName { get; set; }
        public string Token { get; set; }

        public RoleInfo Role { get; set; }
    }

    public class RoleInfo
    {
        public string RoleName { get; set; }
        public string Permissions { get; set; }

        public void GetMethodd()
        {
            var response = new Genrics2
            {
                UserName = "venkatkrishna",
                Token = "xyz-1234",
                Role = new RoleInfo
                {
                    RoleName = "Admin",
                    Permissions = "Read,Write,Delete"
                }
            };
        }
    }
}
