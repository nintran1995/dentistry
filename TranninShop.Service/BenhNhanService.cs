using System.Collections.Generic;
using TranninShop.Data.Infrastructure;
using TranninShop.Data.Repositories;
using TranninShop.Model.Models;

namespace TranninShop.Service
{
	public interface IBenhNhanService
	{
		BenhNhan Add(BenhNhan BenhNhan);

		void Update(BenhNhan BenhNhan);

		BenhNhan Delete(int id);

		IEnumerable<BenhNhan> GetAll();

		IEnumerable<BenhNhan> GetAll(string keyword);

		BenhNhan GetById(int id);

		void Save();
	}

	public class BenhNhanService : IBenhNhanService
	{
		private IBenhNhanRepository _benhNhanRepository;
		private IUnitOfWork _unitOfWork;

		public BenhNhanService(IBenhNhanRepository benhNhanRepository, IUnitOfWork unitOfWork)
		{
			this._benhNhanRepository = benhNhanRepository;
			this._unitOfWork = unitOfWork;
		}

		public BenhNhan Add(BenhNhan BenhNhan)
		{
			var benhNhan = _benhNhanRepository.Add(BenhNhan);
			_unitOfWork.Commit();
			
			return benhNhan;
		}

		public BenhNhan Delete(int id)
		{
			return _benhNhanRepository.Delete(id);
		}

		public IEnumerable<BenhNhan> GetAll()
		{
			return _benhNhanRepository.GetAll();
		}

		public IEnumerable<BenhNhan> GetAll(string keyword)
		{
			if (!string.IsNullOrEmpty(keyword))
				return _benhNhanRepository.GetMulti(x => x.HoTen.Contains(keyword) || x.GhiChuInfo.Contains(keyword));
			else
				return _benhNhanRepository.GetAll();
		}

		public BenhNhan GetById(int id)
		{
			return _benhNhanRepository.GetSingleById(id);
		}

		public void Save()
		{
			_unitOfWork.Commit();
		}

		public void Update(BenhNhan BenhNhan)
		{
			_benhNhanRepository.Update(BenhNhan);
		}
	}
}