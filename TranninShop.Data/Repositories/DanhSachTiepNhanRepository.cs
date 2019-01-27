using TranninShop.Data.Infrastructure;
using TranninShop.Model.Models;

namespace TranninShop.Data.Repositories
{
	public interface IDanhSachTiepNhanRepository : IRepository<DanhSachTiepNhan>
	{
	}

	public class DanhSachTiepNhanRepository : RepositoryBase<DanhSachTiepNhan>, IDanhSachTiepNhanRepository
	{
		public DanhSachTiepNhanRepository(IDbFactory dbFactory) : base(dbFactory)
		{
		}
	}
}