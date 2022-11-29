using System;
using System.Collections.Generic;
using System.Text;

namespace Banner
{
	public class FacultyMember : Administrators
	{
		public string College { get; private set; }
		public string Subject { get; private set; }
		public int FacultyID { get; private set; }
		public string Name { get; private set; }

		private void ViewSchedule()
		{
			throw new NotImplementedException();
		}

		private void Browse()
		{
			throw new NotImplementedException();
		}

		private void SubmitGrade()
		{
			throw new NotImplementedException();
		}

		private void ViewWaitList()
		{
			throw new NotImplementedException();
		}

		private void OverridePre()
		{
			throw new NotImplementedException();
		}

		private FacultyMember(string name, int facultyID, string college, string subject)
		{
			this.Name = name;
			this.FacultyID = facultyID;
			this.College= college;
			this.Subject = subject;
		}
	}
}
