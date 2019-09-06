using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class Form1 : Form
    {
        private employee emp1;
        private employee emp2;
        private employee emp3;
        private employee clear;

        public Form1()
        {
            //storing information into data
            emp1 = new employee("Susan Meyers", "47899", "Accounting", "Vice President");
            emp2 = new employee("Mark JOnes", "39119", "IT", "Programmer");
            emp3 = new employee("Joy Rogers", "81774", "Manufacturing", "Engineer");
            clear = new employee("", "0", "", "");
            InitializeComponent();
        }

        private void emp1Btn_Click(object sender, EventArgs e)
        {
            //displaying information for employee 1
            nameLbl.Text = emp1.Name;
            idLbl.Text = emp1.ID;
            deptLbl.Text = emp1.Department;
            positionLbl.Text = emp1.Position;
        }

        private void emp2Btn_Click(object sender, EventArgs e)
        {
            //displaying information for employee 2
            nameLbl.Text = emp2.Name;
            idLbl.Text = emp2.ID;
            deptLbl.Text = emp2.Department;
            positionLbl.Text = emp2.Position;
        }

        private void emp3Btn_Click(object sender, EventArgs e)
        {
            //displaying information for employee 3
            nameLbl.Text = emp3.Name;
            idLbl.Text = emp3.ID;
            deptLbl.Text = emp3.Department;
            positionLbl.Text = emp3.Position;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close(); //closes form
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            nameLbl.Text = clear.Name; //clears name label
            idLbl.Text = clear.ID; //clears ID label
            deptLbl.Text = clear.Department; //clears department label
            positionLbl.Text = clear.Position; //clears position label
        }
    }
}
