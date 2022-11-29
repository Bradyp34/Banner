using System;
using System.Collections.Generic;
using System.Text;

namespace Banner
{
	public class Administrators
	{
		public const static int Clearance = 1;
		public string Name { get; private set; }

		public static int CheckClearance()
		{
			throw new NotImplementedException();
		}

        private Adviser(int adviserID, string name)
        {
            this.AdviserID = adviserID;
            this.Name = name;
        }
        private FacultyMember(string name, int facultyID, string college, string subject)
        {
            this.Name = name;
            this.FacultyID = facultyID;
            this.College = college;
            this.Subject = subject;
        }
    }
}
