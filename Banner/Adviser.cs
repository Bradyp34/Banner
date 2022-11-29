using System;
using System.Collections.Generic;
using System.Text;

namespace Banner
{
	public class Adviser : Administrators
	{
		public string Department { get; private set; }
		public int AdviserID { get; private set; }

		private void ViewAdvisees()
		{
			throw new NotImplementedException();
		}

		private void RemoveHold()
		{
			throw new NotImplementedException();
		}

		private void ViewStudentProfile()
		{
			throw new NotImplementedException();
		}

		private void EvaluateProgress()
		{
			throw new NotImplementedException();
		}

		private void ViewRegistrations()
		{
			throw new NotImplementedException();
		}

		private Adviser(int adviserID, string name)
		{
			this.AdviserID = adviserID;
			this.Name = name;
		}
	}
}
