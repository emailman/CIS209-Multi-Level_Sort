using System;
using System.Collections.Generic;

namespace CIS209_Multi_Level_Sort
{  
    class Program
    {
        static void Main(string[] args)
        {
            List<GraduationGroup> graduationList = new List<GraduationGroup>();
            graduationList.Add(new GraduationGroup("George", "CT", "CIS"));
            graduationList.Add(new GraduationGroup("Terry", "CT", "CIS"));
            graduationList.Add(new GraduationGroup("Owens", "CT", "CIS"));
            graduationList.Add(new GraduationGroup("George", "CT", "CSC"));
            graduationList.Add(new GraduationGroup("George", "CT", "CNE"));
            graduationList.Add(new GraduationGroup("Terry", "CT", "CNE"));
            graduationList.Add(new GraduationGroup("Owens", "CT", "CNE"));
            graduationList.Add(new GraduationGroup("Owens", "BUS", "MGT"));
            graduationList.Add(new GraduationGroup("Terry", "BUS", "MGT"));
            graduationList.Add(new GraduationGroup("George", "BUS", "MGT"));
            graduationList.Add(new GraduationGroup("Owens", "BUS", "ENT"));
            graduationList.Add(new GraduationGroup("Terry", "BUS", "ENT"));
            graduationList.Add(new GraduationGroup("George", "BUS", "ENT"));

            // Apply a custom sort to the list
            graduationList.Sort();
            
            Console.WriteLine("\n  DTCC Groups for Graduation\n");
            Console.WriteLine("Campus\tDepartment\tDegree\n");
            foreach (GraduationGroup each in graduationList)
                Console.WriteLine(each.campus + "\t" + each.department + "\t\t" + each.degree);
        }
    }
}

    

