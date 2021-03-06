﻿using MoviesContext;
using MoviesContext.Transversal.Clases;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesContext.Transversal.Interfaces
{
    public interface IEmployee
    {
        IEnumerable<TblEmployee> GetAllEmployees();
        int AddEmployee(TblEmployee employee);
        int UpdateEmployee(TblEmployee employee);
        TblEmployee GetEmployeeData(int id);
        int DeleteEmployee(int id);
        List<TblCities> GetCities();
    }
}
