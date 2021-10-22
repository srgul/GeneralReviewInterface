using System;

namespace GeneralReviewInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //EmployeeManager employee = new EmployeeManager();
            //employee.Add();
            //employee.Update();

            /* IPersonManager interfae  */

            //IPersonManager personelManager = new EmployeeManager();
            //personelManager.Add();
            //personelManager.Update();


            /* IPersonManager interface */

            IPersonManager customerManager = new CustomerManager();
            //customerManager.Add();
            //customerManager.Update();
            IPersonManager employeeManager = new EmployeeManager();

            ProjectManager projectManager = new ProjectManager();
            projectManager.AddCustomer(new InternManager());

        }
    }

    interface IPersonManager
    {
        void Add();
        void Update();
    }

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Customer add success");
        }

        public void Update()
        {
            Console.WriteLine("Customer updated");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Employee add success");
        }

        public void Update()
        {
            Console.WriteLine("Employee updated");
        }
    }

    class ProjectManager
    {
        public void AddCustomer(IPersonManager personManager)
        {
            personManager.Add();
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Intern Added");
        }

        public void Update()
        {
            Console.WriteLine("Intern Updated");
        }
    }
}
