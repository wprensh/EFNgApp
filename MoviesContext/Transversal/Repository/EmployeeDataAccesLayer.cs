﻿using Microsoft.EntityFrameworkCore;
using MoviesContext.Transversal.Interfaces;
using MoviesContext;
using MoviesContext.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoviesContext.Transversal.Clases;

namespace MoviesContext.Transversal.Repository
{
    public class EmployeeDataAccesLayer : IEmployee
    {
        private MovieContext db;

        public EmployeeDataAccesLayer(MovieContext _db)
        {
            db = _db;
        }

        public IEnumerable<TblEmployee> GetAllEmployees()
        {
            try
            {
                return db.TblEmployee.ToList().OrderBy(x => x.EmployeeId);
            }
            catch
            {
                throw;
            }
        }

        //To Add new employee record 
        public int AddEmployee(TblEmployee employee)
        {
            try
            {
                db.TblEmployee.Add(employee);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar employee
        public int UpdateEmployee(TblEmployee employee)
        {
            try
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular employee
        public TblEmployee GetEmployeeData(int id)
        {
            try
            {
                TblEmployee employee = db.TblEmployee.Find(id);
                return employee;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record on a particular employee
        public int DeleteEmployee(int id)
        {
            try
            {
                TblEmployee emp = db.TblEmployee.Find(id);
                db.TblEmployee.Remove(emp);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        //To Get the list of Cities
        public List<TblCities> GetCities()
        {
            List<TblCities> lstCity = new List<TblCities>();
            lstCity = (from CityList in db.TblCities select CityList).ToList();

            return lstCity;
        }
    }
}
