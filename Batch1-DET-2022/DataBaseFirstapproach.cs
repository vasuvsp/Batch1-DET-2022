using Batch1_DET_2022.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Batch1_DET_2022
{
    internal class DataBaseFirstapproach
    {
        public static void Main()
        {
            // GetAllEmpDetails();
            //GetEmpDetailsByID();
            //AddNewEmployee();
            //DeleteEmployee();
            //UpdateEmployee();
            //GetEmployeeSP();
            //GetEmployee();
            //Allemployee();
            CallStoredProcwithSQLParamater_insert();


            Console.ReadLine();
           
        }

        private static void GetEmpDetailsByID()
        {
            var ctx = new TSQ_TrainingContext();
            var emp = ctx.Emps.Where(e => e.Empno == 7499).SingleOrDefault();
            Console.WriteLine(emp.Ename + "   " + emp.Sal + "  " + emp.Job);
            //  foreach (var emp in emps)
            //  {
            //   Console.WriteLine(emp.Ename + "   " + emp.Sal + emp.Job);
            // }

        }
        private static void AddNewEmployee()
        {
            var ctx = new TSQ_TrainingContext();
            try
            {
                Emp Employee = new Emp();
                Employee.Empno = 7499;
                Employee.Ename = "Allen";
                Employee.Deptno = 30;
                Employee.Job = "Trainee";
                ctx.Add(Employee);
                ctx.SaveChanges();
                Console.WriteLine("New employee Added");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }

        private static void DeleteEmployee()
        {
            var ctx = new TSQ_TrainingContext();
           
         
                Emp Employee = new Emp();
                Employee.Empno = 7499;
                Employee.Ename = "ALLEN";
                Employee.Sal = 1600;
                Employee.Deptno = 30;
                Employee.Job = "SALESMAN";
                ctx.Update(Employee);
                ctx.SaveChanges();
                Console.WriteLine("New employee Added");
           
             
           
        }
        private static void UpdateEmployee()
        {
            var ctx = new TSQ_TrainingContext();
            try
            {
                Emp Employee = new Emp();
                Employee.Empno = 2289;
                Employee.Ename = "Patil";
                Employee.Sal = 10000;
                Employee.Deptno = 30;
                Employee.Job = "Traine";
                ctx.Update(Employee);
                ctx.SaveChanges();
                Console.WriteLine("New employee Added");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }
        private static void GetEmployeeSP()
        {
            var ctx = new Models.TSQ_TrainingContext();
            var employee = ctx.Emps.FromSqlRaw("GetEmployeeEname").ToList();

            foreach (var e in employee)
            {
                Console.WriteLine(e.Ename);
            }
        }


        private static void GetEmployee()
        {
            var ctx = new Models.TSQ_TrainingContext();
            var employee = ctx.Emps.FromSqlRaw("GetEmployeeEname @p0" , 7521).ToList();

            foreach (var e in employee)
            {
                Console.WriteLine(e.Ename);
            }
        }

        //Insert
        //private static void InsertEmp()
        //{
        //    using (var context = new DatabaseEntities())
        //    {
        //        var t = new test
        //        {
        //            ID = Guid.NewGuid(),
        //            name = "blah",
        //        };
        //        context.AddTotest(t);
        //        context.SaveChanges();
        //    }
        //}



        private static void CallStoredProcwithSQLParamater_insert()
        {
           
                var ctx = new TSQ_TrainingContext();
                var param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@empno",
                            SqlDbType =  System.Data.SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 4455},


                         new SqlParameter() {
                            ParameterName = "@ename",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "Bheema"},

                          new SqlParameter() {
                            ParameterName = "@job",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "Trainer"},

                          new SqlParameter() {
                            ParameterName = "@sal",
                            SqlDbType =  System.Data.
                            SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 30000},

                           new SqlParameter() {
                            ParameterName = "@deptno",
                            SqlDbType =  System.Data.
                            SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 30 }

                           };
                try
                {

                    //var result = ctx.Database.ExecuteSqlRaw("newemppployy @empno, @ename, @job , @sal, @deptno", param);

                    //var result = ctx.Database.ExecuteSqlCommand("AddNewBook @id, @name, @price", param);
                    //// var result = ctx.Emps.FromSqlRaw("newemppployy @empno, @ename, @job , @sal, @deptno", param);
                    //var result =ctx.Database.ExecuteSqlCommand("newemppployy @empno, @ename, @job , @sal, @deptno", param);

                    ctx.SaveChanges();
                    Console.WriteLine("inserted");
                }
                catch (Exception ex)
                {

                    throw;
                }


                Console.WriteLine("update successful");
        }

            //private static void Allemployee()
            //{
            //    var ctx = new Models.TSQ_TrainingContext();
            //    var employee = ctx.Emps.FromSqlRaw("SelectAllemployee  @p0", 7521).ToList();

            //    foreach (var e in employee)
            //    {
            //        Console.WriteLine(e.Ename);
            //    }
            //}


        }
    }



