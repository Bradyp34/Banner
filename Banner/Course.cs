using System;
using System.Collections.Generic;
using System.Text;

namespace Banner
{
	public class Course
	{
		public string Name { get; private set; }
		public int CourseID { get; private set; }
		public int Credits { get; private set; }
		public seasonyear Semester { get; private set; }

		private bool ViewAvailability()
		{
			throw new NotImplementedException();
		}

		private Course(string name, int courseID, int credits, seasonyear semester)
		{
			this.Name = name;
			this.Semester = semester;
			this.CourseID = courseID;
			this.Credits = credits;
		}

		private Course(string name, int courseID, seasonyear semester)
		{
			this.Name = name;
			this.CourseID = courseID;
			this.Semester = semester;
			this.Credits = 3;
		}
	}
}
