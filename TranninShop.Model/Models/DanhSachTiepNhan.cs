using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TranninShop.Model.Abstract;

namespace TranninShop.Model.Models
{
	[Table("DanhSachTiepNhans")]
	public class DanhSachTiepNhan: Auditable
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Auto increase
		public int DanhSachTiepNhanID { get; set; }

		[Required]
		[MaxLength(256)]
		public string HoTen { get; set; }

		public int NamSinh { get; set; }

		public DateTime? NgayTiepNhan { get; set; }

		public DateTime? NgayDangKyDieuTri { get; set; }

		[MaxLength(256)]
		public string GioDangKy { get; set; }

		public bool GioiTinh { get; set; }

		[MaxLength(256)]
		public string DiaChi { get; set; }

		[MaxLength(256)]
		public string DienThoai { get; set; }

		public bool ChuyenDieuTri { get; set; }

		[MaxLength(256)]
		public string GhiChu { get; set; }

		public int MaBenhNhan { get; set; }

		public int BacSyID { get; set; }

		public int GheSo { get; set; }

		[MaxLength(256)]
		public string Email { get; set; }

		[MaxLength(256)]
		public string NgheNghiep { get; set; }
	}
}