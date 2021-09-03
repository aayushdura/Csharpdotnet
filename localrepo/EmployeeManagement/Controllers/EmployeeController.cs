using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
public class EmployeeController: Controller
{
    public ActionResult Index()
    {
        person emp1= new person()
        {
            Name = "Aayush Dura",
            address="Satungal",
            Salary=20000
        };
        person emp2= new person()
        {
            Name = "Kishan Dura",
            address="Rambazar",
            Salary= 32000
        };
        person emp3= new person()
        {
            Name = "Nischal Shrestha",
            address="talchikhel",
            Salary= 32000
        };
         person emp4= new person()
        {
            Name = "Sabita rai",
            address="satungal",
            Gender='F',
            Salary= 32000
        };
         var employee= new List<person>(){emp1,emp2,emp3,emp4};
        return View(employee);
    }

}
