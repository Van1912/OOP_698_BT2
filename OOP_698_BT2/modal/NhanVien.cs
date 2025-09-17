using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_698_BT2.modal
{
	internal class NhanVien : People
	{
		private string maNhanVien;
		private double heSoLuong;
		private const double LUONG_CO_BAN = 1600000;
		public NhanVien() : base()
		{
			this.maNhanVien = "Unknown";
			this.heSoLuong = 1.0;
		}

		public NhanVien(string name, bool gender, int year, string maNV, double heSoLuong)
			: base(name, gender, year)
		{
			this.maNhanVien = maNV;
			this.heSoLuong = heSoLuong;
		}

		public string MaNhanVien
		{
			get { return maNhanVien; }
			set { maNhanVien = value; }
		}

		public double HeSoLuong
		{
			get { return heSoLuong; }
			set { heSoLuong = value; }
		}
		public double Pc
		{
			get { return Pc; }
			set { Pc = value; }
		}
		// Cho phép override
		public virtual double TinhLuong()
		{
			return heSoLuong * LUONG_CO_BAN + Pc ;
		}

		public override string ToString()
		{
			return base.ToString() + $", Mã NV: {MaNhanVien}, Hệ số lương: {HeSoLuong}, Lương: {TinhLuong()}";
		}
	}
}

