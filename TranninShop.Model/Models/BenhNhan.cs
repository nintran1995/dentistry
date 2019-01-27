using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TranninShop.Model.Abstract;

namespace TranninShop.Model.Models
{
	[Table("BenhNhans")]
	public class BenhNhan : Auditable

	{
		[Key]

		[DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Auto increase
		public int BenhNhanID { get; set; }

		[MaxLength(256)]
		public string IDNew { get; set; }

		[Required]
		[MaxLength(256)]
		public string HoTen { get; set; }

		public int NamSinh { get; set; }

		public DateTime? NgaySinh { get; set; }

		[Required]
		public DateTime? NgayKhamLanDau { get; set; }

		[MaxLength(256)]
		public string NgayKhamLanDauShow { get; set; }

		[Required]
		public bool GioiTinh { get; set; }

		[MaxLength(256)]
		public string DanToc { get; set; }

		[MaxLength(256)]
		public string TonGiao { get; set; }

		[MaxLength(256)]
		public string DiaChi { get; set; }

		[MaxLength(256)]
		public string DienThoai { get; set; }

		[MaxLength(256)]
		public string DiDong { get; set; }

		[MaxLength(256)]
		public string Email { get; set; }

		[MaxLength(256)]
		public string NgheNghiep { get; set; }

		[MaxLength(256)]
		public string MaVach { get; set; }

		[MaxLength(256)]
		public string TienBenhAn { get; set; }

		[MaxLength(256)]
		public string PathHinhAnh { get; set; }

		[MaxLength(256)]
		public string GhiChuTN { get; set; }

		[MaxLength(256)]
		public string GhiChuInfo { get; set; }

		[MaxLength(256)]
		public string HinhAnhHoSo { get; set; }

		[Required]
		public bool ThungRac { get; set; }
	}
}