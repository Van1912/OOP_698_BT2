using OOP_698_BT2.modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_698_BT2
{
	internal class Program
	{
	
			static void Main(string[] args)
			{
			Console.OutputEncoding = Encoding.UTF8;
				NhanVienQuanLy nvQL = new NhanVienQuanLy("Nguyễn Văn A", true, 1985, "QL01", 3.5);
				NhanVienVanPhong nvVP = new NhanVienVanPhong("Trần Thị B", false, 1992, "VP01", 3.5);

				Console.WriteLine(nvQL.ToString());
				Console.WriteLine(nvVP.ToString());

				Console.ReadKey();
			}
		}
	}
