using TranninShop.Data.Infrastructure;
using TranninShop.Model.Models;

namespace TranninShop.Data.Repositories
{
	public interface IBenhNhanRepository : IRepository<BenhNhan>
	{
	}

	public class BenhNhanRepository : RepositoryBase<BenhNhan>, IBenhNhanRepository
	{
		public BenhNhanRepository(IDbFactory dbFactory) : base(dbFactory)
		{
		}
	}
}