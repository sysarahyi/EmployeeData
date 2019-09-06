using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class employee
    {
        private string name; //string of name
        private string id; //string of ID
        private string dept; //string of department
        private string position; //string of position

        public employee(string name, string id, string dept, string position)
        {
            //costructor
            this.name = name;
            this.id = id;
            this.dept = dept;
            this.position = position;
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String ID
        {
            get { return id; }
            set { id = value; }
        }

        public String Department
        {
            get { return dept; }
            set { dept = value; }
        }

        public String Position
        {
            get { return position; }
            set { position = value; }
        }
    }
}
