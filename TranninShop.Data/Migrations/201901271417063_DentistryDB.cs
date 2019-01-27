namespace TranninShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DentistryDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BenhNhans",
                c => new
                    {
                        BenhNhanID = c.Int(nullable: false, identity: true),
                        IDNew = c.String(maxLength: 256),
                        HoTen = c.String(nullable: false, maxLength: 256),
                        NamSinh = c.Int(nullable: false),
                        NgaySinh = c.DateTime(),
                        NgayKhamLanDau = c.DateTime(nullable: false),
                        NgayKhamLanDauShow = c.String(maxLength: 256),
                        GioiTinh = c.Boolean(nullable: false),
                        DanToc = c.String(maxLength: 256),
                        TonGiao = c.String(maxLength: 256),
                        DiaChi = c.String(maxLength: 256),
                        DienThoai = c.String(maxLength: 256),
                        DiDong = c.String(maxLength: 256),
                        Email = c.String(maxLength: 256),
                        NgheNghiep = c.String(maxLength: 256),
                        MaVach = c.String(maxLength: 256),
                        TienBenhAn = c.String(maxLength: 256),
                        PathHinhAnh = c.String(maxLength: 256),
                        GhiChuTN = c.String(maxLength: 256),
                        GhiChuInfo = c.String(maxLength: 256),
                        HinhAnhHoSo = c.String(maxLength: 256),
                        ThungRac = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 256),
                        MetaKeyword = c.String(maxLength: 256),
                        MetaDescription = c.String(maxLength: 256),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.BenhNhanID);
            
            CreateTable(
                "dbo.DanhSachTiepNhans",
                c => new
                    {
                        DanhSachTiepNhanID = c.Int(nullable: false, identity: true),
                        HoTen = c.String(nullable: false, maxLength: 256),
                        NamSinh = c.Int(nullable: false),
                        NgayTiepNhan = c.DateTime(),
                        NgayDangKyDieuTri = c.DateTime(),
                        GioDangKy = c.String(maxLength: 256),
                        GioiTinh = c.Boolean(nullable: false),
                        DiaChi = c.String(maxLength: 256),
                        DienThoai = c.String(maxLength: 256),
                        ChuyenDieuTri = c.Boolean(nullable: false),
                        GhiChu = c.String(maxLength: 256),
                        MaBenhNhan = c.Int(nullable: false),
                        BacSyID = c.Int(nullable: false),
                        GheSo = c.Int(nullable: false),
                        Email = c.String(maxLength: 256),
                        NgheNghiep = c.String(maxLength: 256),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 256),
                        MetaKeyword = c.String(maxLength: 256),
                        MetaDescription = c.String(maxLength: 256),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.DanhSachTiepNhanID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DanhSachTiepNhans");
            DropTable("dbo.BenhNhans");
        }
    }
}
