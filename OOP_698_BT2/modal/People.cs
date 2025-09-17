using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_698_BT2.modal
{
	internal class People
	{
		private string name;
		private bool gender;
		private int year;
		public People()
		{
			name = "No name";
			gender = false;
			year = 0;
		}

		public People(string name, bool gender, int year)
		{
			this.name = name;
			this.gender = gender;
			this.year = year;
		}
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public bool Gender
		{
			get { return gender; }
			set { gender = value; }
		}

		public int Year
		{
			get { return year; }
			set { year = value; }
		}
		public override string ToString()
		{
			string gt = gender ? "Nam" : "Nữ";
			return $"Tên: {name}, Giới tính: {gt}, Năm sinh: {year}";
		}
	}
}
	