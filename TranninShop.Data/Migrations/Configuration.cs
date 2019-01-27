namespace TranninShop.Data.Migrations
{
	using Microsoft.AspNet.Identity;
	using Microsoft.AspNet.Identity.EntityFramework;
	using System;
	using System.Collections.Generic;
	using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
	using TranninShop.Model.Models;

	internal sealed class Configuration : DbMigrationsConfiguration<TranninShop.Data.TranninShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TranninShop.Data.TranninShopDbContext context)
        {
			CreateProductCategorySample(context);
			CreateUser(context);
		}

		private void CreateProductCategorySample(TranninShopDbContext context)
		{
			if (context.ProductCategories.Count() == 0)
			{
				List<ProductCategory> listProductCategory = new List<ProductCategory>()
			{
				new ProductCategory() { Name="Điện lạnh",Alias="dien-lanh",Status=true },
				 new ProductCategory() { Name="Viễn thông",Alias="vien-thong",Status=true },
				  new ProductCategory() { Name="Đồ gia dụng",Alias="do-gia-dung",Status=true },
				   new ProductCategory() { Name="Mỹ phẩm",Alias="my-pham",Status=true }
			};
				context.ProductCategories.AddRange(listProductCategory);
				context.SaveChanges();
			}
		}

		private void CreateUser(TranninShopDbContext context)
		{
			var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new TranninShopDbContext()));

			var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new TranninShopDbContext()));

			var user = new ApplicationUser()
			{
				UserName = "nintran",
				Email = "nintran1995@gmail.com",
				EmailConfirmed = true,
				BirthDay = DateTime.Now,
				FullName = "Trannin Shop"
			};

			manager.Create(user, "123654$");

			if (!roleManager.Roles.Any())
			{
				roleManager.Create(new IdentityRole { Name = "Admin" });
				roleManager.Create(new IdentityRole { Name = "User" });
			}

			var adminUser = manager.FindByEmail("nintran1995@gmail.com");

			manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
		}
	}
}
