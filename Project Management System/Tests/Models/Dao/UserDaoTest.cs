using NUnit.Framework;
using Project_Management_System.Models;
using Project_Management_System.Models.Dao;
using Project_Management_System.Models.Dao.Dao_Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_System.Tests.Models.Dao
{
    [TestFixture]
    public class UserDaoTest
    {
        [TestCase]
        public void isValidTest()
        {
            using (var context = new Sql())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.Users.Add(new User(1, "admin", "admin", "John", "Doe", "jdoe@mail.com", new Role()));
                        context.SaveChanges();

                        Assert.AreEqual(true, new UserDaoImpl(context).isValid("admin", "admin"));
                        Assert.AreEqual(false, new UserDaoImpl(context).isValid("xyz", "xyz"));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                    finally
                    {
                        transaction.Rollback();
                    }
                }
            }
        }

        [TestCase]
        public void existsTest()
        {
            using (var context = new Sql())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.Users.Add(new User(1, "admin", "admin", "John", "Doe", "jdoe@mail.com", new Role()));
                        context.SaveChanges();

                        Assert.AreEqual(true, new UserDaoImpl(context).exists("admin"));
                        Assert.AreEqual(false, new UserDaoImpl(context).exists("xyz"));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                    finally
                    {
                        transaction.Rollback();
                    }
                }
            }
        }

        [TestCase]
        public void getUserForUsernameTest()
        {
            using (var context = new Sql())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.Users.Add(new User(1, "admin", "admin", "John", "Doe", "jdoe@mail.com", new Role()));
                        context.SaveChanges();

                        Assert.AreEqual("admin", new UserDaoImpl(context).getUserForUsername("admin").Username);
                        Assert.AreEqual("admin", new UserDaoImpl(context).getUserForUsername("xyz").Username);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                    finally
                    {
                        transaction.Rollback();
                    }
                }
            }
        }
    }
}
