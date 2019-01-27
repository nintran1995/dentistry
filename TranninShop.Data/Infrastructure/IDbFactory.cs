using System;

namespace TranninShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        TranninShopDbContext Init();
    }
}