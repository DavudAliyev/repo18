using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_11
{
    internal class Studentclass
    {

        public Studentclass (string Fullname, int Point)
        {
            this.FullName = Fullname;
            this.Point = Point;
        }

        public string FullName;
        public DateTime BirthDate;
        public string GroupNo;
        public int Point;


        public void ShowInfo()
        {
            Console.WriteLine($"Fullname: {FullName} - Birthdate: {BirthDate.ToString("dd.MM.yyyy")} - GroupNo: {GroupNo} - Point: {Point}");
        }
    }
}
