using GeneratePDF.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace GeneratePDF.Controllers
{
    public class GeneratePDFController : Controller
    {
        #region Grid Portion
        public ActionResult Employees()
        {
            return View(LoadEmployees());
        }

        public ActionResult Employee(int id)
        {
            var employee = LoadEmployees().Where(a => a.ID == id).FirstOrDefault();
            return View(employee);
        }

        #endregion

        #region Rotativa
        /// <summary>
        /// Print Employees details
        /// </summary>
        /// <returns></returns>
        public ActionResult PrintAllEmployee()
        {
            var report = new Rotativa.ActionAsPdf("Employees");
            return report;
        }

        /// <summary>
        /// Print employee details
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult PrintEmployee(int id)
        {
            var report = new Rotativa.ActionAsPdf("Employee", new { id = id });
            return report;
        }

        /// <summary>
        /// employee details as image
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult EmployeeImage(int id)
        {
            var report = new Rotativa.ActionAsImage("Employee", new { id = id });
            return report;
        }



        #endregion

        /// <summary>
        /// Load all Employees
        /// </summary>
        /// <returns></returns>
        private List<EmployeeModel> LoadEmployees()
        {
            List<EmployeeModel> employees = new List<EmployeeModel>() {
        new EmployeeModel() {ID = 1, Name = "Gnanavel Sekar", Designation = "Sr.Software Engineer", Salary = 1500000 },
        new EmployeeModel() {ID = 2, Name = "Subash S", Designation = "Sr.Software Engineer", Salary = 1700000},
        new EmployeeModel() {ID = 3, Name = "Robert A", Designation = "Sr.Application Developer", Salary = 1800000 },
        new EmployeeModel() { ID = 4, Name = "Ammaiyappan", Designation = "Sr.Software Developer", Salary = 1200000 }
        };
            return employees;
        }
    }
}