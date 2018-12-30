using NUnit.Framework;
using Project_Management_System.Models;
using Project_Management_System.Models.Dao.Dao_Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_System.Tests.Models.Dao
{
    [TestFixture]
    public class ProjectDaoTest
    {
        [TestCase]
        public void existsTest()
        {
            using (var context = new Sql())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.Projects.Add(new Project("Project 1", "project1", null));
                        context.SaveChanges();

                        Assert.AreEqual(true, new ProjectDaoImpl(context).exists("project1"));
                        Assert.AreEqual(false, new ProjectDaoImpl(context).exists("xyz"));
                    } catch(Exception e)
                    {
                        Console.WriteLine(e);
                    } finally
                    {
                        transaction.Rollback();
                    }
                }
            }
        }

        [TestCase]
        public void getProjectForCodeTest()
        {
            using (var context = new Sql())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.Projects.Add(new Project("Project 1", "project1", null));
                        context.SaveChanges();

                        Assert.AreEqual("project1", new ProjectDaoImpl(context).getProjectForCode("project1").Code);
                        Assert.AreNotEqual("project1", new ProjectDaoImpl(context).getProjectForCode("xyz").Code);
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
        public void getProjectsTest()
        {
            using (var context = new Sql())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.Projects.Add(new Project("Project 1", "project1", null));
                        context.Projects.Add(new Project("Project 2", "project2", null));
                        context.Projects.Add(new Project("Project 3", "project3", null));
                        context.SaveChanges();

                        Assert.AreEqual(3, new ProjectDaoImpl(context).getProjects().Count());
                        Assert.AreNotEqual(1, new ProjectDaoImpl(context).getProjects().Count());
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
