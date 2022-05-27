using Employee_Mockup_WebDemo.Models;
using Employee_Mockup_WebDemo.Models.ValidationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employee_Mockup_WebDemo.Controllers
{
    public class EmployeeController : Controller
    {
        GFT_Architecture_ExerciseEntities db = new GFT_Architecture_ExerciseEntities();
        // GET: Employee
        public ActionResult Index(string searchString)
        {
            List<Employee> lst = new List<Employee>();
            @ViewData["CurrentFilter"] = searchString;

            if (!String.IsNullOrEmpty(searchString))
            {

                lst = db.Employee.Where(a => a.FirstName.Contains(searchString)).ToList();
         
            }
            else
            {
                lst = db.Employee.ToList();
            }
            return View(lst);
        }

        // GET: Employee/Details/5
        //public ActionResult Reset()
        //{
            
        //    return View();
        //}

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee_Model model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (GFT_Architecture_ExerciseEntities db = new GFT_Architecture_ExerciseEntities())
                    {

                        var employee = new Employee();
                        employee.FirstName = model.FirstName;
                        employee.LastName = model.LastName;
                        employee.Email = model.Email;


                        db.Employee.Add(employee);
                        db.SaveChanges();

                    }
                    return Redirect("~/Employee/Index/");

                }

                return View(model);

            }
            catch (Exception ex)
            {
                Console.WriteLine(" Employee_Mockup_WebDemo.EmployeeController.ActionResult_Index" + ex.Message);
                return null; //de otra forma retorne nulo

            }


        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            Employee_Model model = new Employee_Model();
            using (GFT_Architecture_ExerciseEntities db = new GFT_Architecture_ExerciseEntities())
            {
                try
                {
                    var employee = db.Employee.Find(id);

                    model.FirstName = employee.FirstName;
                    model.LastName = employee.LastName;
                    model.Email = employee.Email;

                }
                catch (Exception ex)
                {

                    Console.WriteLine(" Employee_Mockup_WebDemo.EmployeeController.ActionResult_Index" + ex.Message);
                }


            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Employee_Model model)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    using (GFT_Architecture_ExerciseEntities db = new GFT_Architecture_ExerciseEntities())
                    {
                        try
                        {
                            var employee = db.Employee.Find(model.Id);
                            employee.FirstName = model.FirstName;
                            employee.LastName = model.LastName;
                            employee.Email = model.Email;

                            db.Entry(employee).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(" Employee_Mockup_WebDemo.EmployeeController.ActionResult_Index" + ex.Message);

                        }

                    }

                    return Redirect("~/Employee/Index");
                }
                return View(model);

            }
            catch (Exception ex)
            {
                Console.WriteLine(" Employee_Mockup_WebDemo.EmployeeController.ActionResult_Index" + ex.Message);
                return null; //de otra forma retorne nulo

            }
        }

        // GET: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(FormCollection fromcollection)
        {
            try
            {
                GFT_Architecture_ExerciseEntities db = new GFT_Architecture_ExerciseEntities();
                string[] ids = fromcollection["employeeId"].Split(new char[] { ',' });
                foreach (string id in ids)
                {
                    var employee = db.Employee.Find(int.Parse(id));
                    db.Employee.Remove(employee);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Employee_Mockup_WebDemo.EmployeeController.ActionResult_Index" + ex.Message);

            }

            return Redirect("~/Employee/Index/");
        }
    }
}
