﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using TranninShop.Data.Infrastructure;
using TranninShop.Data.Repositories;
using TranninShop.Model.Models;

namespace TranninShop.UnitTest.RepositoryTest
{
    [TestClass]
    public class PostCategoryRepositoryTest
    {
        IDbFactory dbFactory;
        IPostCategoryRepository objRepository;
        IUnitOfWork unitOfWork;

        [TestInitialize]
        public void Initialize()
        {
            dbFactory = new DbFactory();
            objRepository = new PostCategoryRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }

        [TestMethod]
        public void PostCategory_Repository_GetAll()
        {
            var list = objRepository.GetAll().ToList();
            Assert.AreEqual(3, list.Count);
        }

        [TestMethod]
        public void PostCategory_Repository_Create()
        {
			PostCategory category = new PostCategory
			{
				Name = "Test category",
				Alias = "Test-category",
				Status = true
			};

			var result = objRepository.Add(category);
            unitOfWork.Commit();

            Assert.IsNotNull(result);
            Assert.AreEqual(4, result.ID);
        }
    }
}