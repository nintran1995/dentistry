namespace TranninShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private TranninShopDbContext dbContext;

        public TranninShopDbContext Init()
        {
            return dbContext ?? (dbContext = new TranninShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}