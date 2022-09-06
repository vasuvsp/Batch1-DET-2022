﻿using Batch1_DET_2022.Data;
using Batch1_DET_2022.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class CodeFirstApproach
    {
        private static Book book;

        public static void Main()
        {
            //AddNewBook();
            //DeleteBook();
            //updatebook();
            //Getallbooks();
            //AddnewcustomerAndOrder();
            neworder();
            GetAllCustomersWithOrder_ExplicitLoading();
            Disconnectedarchitecture();
            Console.ReadLine();
        }
        private static void AddNewBook()
        {
            var ctx = new BookContext();
            Book book = new Book();
            book.BookID = 1;
            book.BookName = "EF Core";
            book.author = "Jack";
            book.price = 100;


            book.BookID = 2;
            book.BookName = "Rich Dad Poor Dad";
            book.author = "Robert";
            book.price = 450;

            book.BookID = 3;
            book.BookName = "Mission Overseas";
            book.author = "Sushant";
            book.price = 600;

            book.BookID = 4;
            book.BookName = "India's Most Fearless";
            book.author = "Rahul Singh";
            book.price = 950;

            book.BookID = 5;
            book.BookName = "Battle Born";
            book.author = "MaxiMilian";
            book.price = 1200;

            book.BookID = 6;
            book.BookName = "India's Most Fearless";
            book.author = "Rahul Singh";
            book.price = 950;


            try
            {
                ctx.Books.Add(book);
                ctx.SaveChanges();
                Console.WriteLine("New Book Added Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }

        private static object Add(Book book)
        {
            throw new NotImplementedException();
        }

        private static void updatebook()
        {
            var ctx = new BookContext();
            var Books = ctx.Books.Where(b => b.BookID == 4).SingleOrDefault();
            try
            {


                Books.BookName = "India's Most Fearless 3";
                Books.price = 960;
                ctx.Update(Books);

                ctx.SaveChanges();

                Console.WriteLine("New book updated successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }
        private static void DeleteBook()
        {
            var ctx = new BookContext();
            var Books = ctx.Books.Where(b => b.BookID == 6).SingleOrDefault();

            try
            {
                ctx.Remove(Books);

                ctx.SaveChanges();
                Console.WriteLine(" book Deleted successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }
        private static void Getallbooks()
        {
            var ctx = new BookContext();
            foreach (var book in ctx.Books)
            {
                Console.WriteLine(book.BookID + "   " + book.BookName + "   " + book.author + "  " + book.price);
            }
        }

        private static void AddnewcustomerAndOrder()
        {
            var ctx = new BookContext();
            Customer customer = new Customer();
            customer.ID = 1;
            customer.Name = "Vasu";
            customer.Age = 35;

            Order ord = new Order();
            ord.Order_ID = 100;
            ord.Amount = 2000;
            ord.OrderDate = DateTime.Now;
            ord.cust = customer;
            try
            {
                ctx.Orders.Add(ord);
                ctx.SaveChanges();
                Console.WriteLine(" Customer and MyOrder tables are created ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }

        }
        private static void neworder()
        {
            var ctx = new BookContext();
            Order ord = new Order();
            var customer = ctx.Customers.Where(b => b.ID == 1).SingleOrDefault();
            ord.Order_ID = 101;
            ord.Amount = 30000;
            ord.OrderDate = DateTime.Now;
            ord.cust = customer;

            try
            {
                ctx.Orders.Add(ord);
                ctx.SaveChanges();
                Console.WriteLine(" Customer and MyOrder tables are created ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }


        private static void GetAllCustomersWithOrder_EagerLoading()
        {
            //Eager loading means that the related data is loaded          
            //from the database as part of the initial query.         
            var ctx = new BookContext();
            try
            {
                var customers = ctx.Customers.Include("Orders");
                //var customers = ctx.Customers.Include(o => o.Orders);                   

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.Name);
                    Console.WriteLine("----->");

                    foreach (var order in customer.Orders) 
                    {
                        Console.WriteLine(order.Amount.ToString() + " " + order.Order_ID);
                    }
                    Console.WriteLine("-----");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
        private static void GetAllCustomersWithOrder_ExplicitLoading()
        {
            //Explicit loading means that the related data is
            //explicitly loaded from the database at a later time.
            //Needs MARS to be set to TRUE in connection string
            var ctx = new BookContext();
            try
            {
                var customers = ctx.Customers;



                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.Name);
                    Console.WriteLine("----->");



                    ctx.Entry(customer).Collection(o => o.Orders).Load();

                    foreach (var order in customer.Orders)
                    {
                        Console.WriteLine(order.Amount.ToString() + "  " + order.OrderDate.ToString());



                    }
                    Console.WriteLine("-----");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void Disconnectedarchitecture()
        {
            var ctx = new BookContext();
            var customer = ctx.Customers.Where(c => c.ID == 1).SingleOrDefault();
            ctx.Dispose();
            UpdateCustomerName(customer);

        }
        private static void UpdateCustomerName(Customer customer)
        {
            var ctx = new BookContext();
            customer.Name = "Mike";
            Console.WriteLine(ctx.Entry(customer).State.ToString());
            //ctx.Update<Customer>(customer);
            //OR
            ctx.Update(customer);
            //OR
            //ctx.Customers.Update(customer);
            //OR
            //  ctx.Attach(customer).State = EntityState.Modified;
            ctx.SaveChanges();
            Console.WriteLine("customer name is updated via disconnected mode");
        }

    }
}







   

