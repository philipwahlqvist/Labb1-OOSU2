using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    class Expedit
    {
        public int employeID { get; private set; }
        public string name { get; private set; }
        public string role { get; private set; }
        public string password { get; private set; }

        public Expedit(int employeID, string name, string role, string password)
        {
            this.employeID = employeID;
            this.name = name;
            this.role = role;
            this.password = password;
        }
    }
}
