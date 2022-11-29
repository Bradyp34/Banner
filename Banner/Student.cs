using System;
using System.Collections.Generic;
using System.Text;

namespace Banner
{
	public class Student
	{
		public string Name { get; private set; }
		public int age = 18;
		public int Age
		{
			get
			{
				return age;
			}
			private set
			{
				age = value;
			}
		}
		const public static int Clearance = 0;
		public int credits = 0;
		public int Credits
		{
			get
			{
				return credits;
			}
			private set
			{
				credits = value;
			}
		}

		private void SearchCourses()
		{
			throw new NotImplementedException();
		}

		private void Browse()
		{
			throw new NotImplementedException();
		}

		private void RegisterClass()
		{
			throw new NotImplementedException();
		}

		private void JoinWaitList()
		{
			throw new NotImplementedException();
		}

		private void DropClass()
		{
			throw new NotImplementedException();
		}

		private void CreatePlan()
		{
			throw new NotImplementedException();
		}

		private void EvaluatePlan()
		{
			throw new NotImplementedException();
		}

		private Student(string name)
		{
			this.Name = name;
		}

		private Student(string name, int age, int credits)
		{
			this.Name = name;
			this.Age = age;
			this.Credits = credits;
		}
	}
}
