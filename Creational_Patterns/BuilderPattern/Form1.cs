using BuilderPattern.Abstract;
using BuilderPattern.Concrete;
using System;
using System.Windows.Forms;

namespace BuilderPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Methods
        void ListView()
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = employee.Employee.Firstname;
            lvi.SubItems.Add(employee.Employee.LastName);
            lvi.SubItems.Add(employee.Employee.Salary.ToString("C2"));
            lvi.SubItems.Add(employee.Employee.IsManager.ToString());
            lvi.SubItems.Add(employee.Deparment());

            listView1.Items.Add(lvi);
        }
        EmployeeBuilder employee;

        //Array
        string[] departmentList = { "Human Resource", "Quality Assurance" };
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDepartment.DataSource = departmentList;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            switch (cmbDepartment.Text)
            {
                case "Human Resource":
                    employee = new HumanResource();
                        break;
                case "Quality Assurance":
                    employee = new QualityAssurance();
                    break;
            }
            CreateEmployee newEmployee = new CreateEmployee();
            bool isManager = rbYes.Checked ? true : false;

            newEmployee.AddEmployee(employee,txtFirstName.Text,txtLastName.Text,nudSalary.Value,isManager);

            ListView(); 
        }
    }
}
