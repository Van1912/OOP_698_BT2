using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_698_BT2.modal
{
	internal class NhanVienVanPhong : NhanVien
	{
		private const double PhuCap = 200000;

		public NhanVienVanPhong(string name, bool gender, int year, string maNV, double heSoLuong)
			: base(name, gender, year, maNV, heSoLuong) { }

		public override double TinhLuong()
		{
			return base.HeSoLuong * 1600000 + PhuCap;
		}
		public override string ToString()
		{
			return base.ToString() + $", Chức vụ: VP";
		}
	}
}
