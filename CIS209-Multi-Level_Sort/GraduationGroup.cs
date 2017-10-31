using System;

namespace CIS209_Multi_Level_Sort
{
    class GraduationGroup : IComparable<GraduationGroup>
    {
        public string campus;
        public string department;
        public string degree;

        public GraduationGroup(string camp, string dept, string deg)
        {
            campus = camp;
            department = dept;
            degree = deg;
        }

        public int CompareTo(GraduationGroup o2)
        {
            int value1 = campus.CompareTo(o2.campus);
            if (value1 == 0)
            {
                int value2 = department.CompareTo(o2.department);
                if (value2 == 0)
                    return degree.CompareTo(o2.degree);
                else
                    return value2;
            }
            return value1;
        }
    }
}
