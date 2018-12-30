using Project_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_System
{

    /// <summary>An Util class that contains various common functions.</summary>
    public static class Util
    {

        /// <summary>Returns a parsed integer given in a string format.</summary>
        /// <param name="message">
        ///   <para>String to be parsed</para>
        /// </param>
        public static int parseString(string message)
        {
            int parsed = 0;
            try
            {
                parsed = Int32.Parse(message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            return parsed;
        }

        /// <summary>Returns a splitted username.</summary>
        /// <param name="message">String to be splitted</param>
        public static string split(string message)
        {
            try
            {
                string[] splitted = message.Split(' ');
                return splitted[2];
            }
            catch (Exception e)
            {
                return "";
            }
        }

        /// <summary>Initializes combo box's items for status.</summary>
        /// <param name="box">ComboBox</param>
        public static void initStatus(ComboBox box)
        {
            box.Items.Add("New");
            box.Items.Add("InProgress");
            box.Items.Add("Finished");
        }

        /// <summary>Expands list columns.</summary>
        /// <param name="list">ListView</param>
        public static void expandListViewHeader(ListView list)
        {
            list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        /// <summary>Checks if a given input is an integer.</summary>
        /// <param name="message">
        ///   <para>String to be parsed</para>
        /// </param>
        public static bool isInt(string message)
        {
            int parsed = 0;
            try
            {
                parsed = Int32.Parse(message);
                return true;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }
    }
}
