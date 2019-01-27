using System.Collections.Generic;
using TranninShop.Data.Infrastructure;
using TranninShop.Model.Models;

namespace TranninShop.Data.Repositories
{
	public interface IDanhSachTiepNhanService
	{
		DanhSachTiepNhan Add(DanhSachTiepNhan DanhSachTiepNhan);

		void Update(DanhSachTiepNhan DanhSachTiepNhan);

		DanhSachTiepNhan Delete(int id);

		IEnumerable<DanhSachTiepNhan> GetAll();

		IEnumerable<DanhSachTiepNhan> GetAll(string keyword);

		DanhSachTiepNhan GetById(int id);

		void Save();
	}

	public class DanhSachTiepNhanService : IDanhSachTiepNhanService
	{
		private IDanhSachTiepNhanRepository _danhSachTiepNhanRepository;
		private IUnitOfWork _unitOfWork;

		public DanhSachTiepNhanService(IDanhSachTiepNhanRepository danhSachTiepNhanRepository, IUnitOfWork unitOfWork)
		{
			this._danhSachTiepNhanRepository = danhSachTiepNhanRepository;
			this._unitOfWork = unitOfWork;
		}

		public DanhSachTiepNhan Add(DanhSachTiepNhan DanhSachTiepNhan)
		{
			return _danhSachTiepNhanRepository.Add(DanhSachTiepNhan);
		}

		public DanhSachTiepNhan Delete(int id)
		{
			return _danhSachTiepNhanRepository.Delete(id);
		}

		public IEnumerable<DanhSachTiepNhan> GetAll()
		{
			return _danhSachTiepNhanRepository.GetAll();
		}

		public IEnumerable<DanhSachTiepNhan> GetAll(string keyword)
		{
			if (!string.IsNullOrEmpty(keyword))
				return _danhSachTiepNhanRepository.GetMulti(x => x.HoTen.Contains(keyword) || x.GhiChu.Contains(keyword));
			else
				return _danhSachTiepNhanRepository.GetAll();
		}

		public DanhSachTiepNhan GetById(int id)
		{
			return _danhSachTiepNhanRepository.GetSingleById(id);
		}

		public void Save()
		{
			_unitOfWork.Commit();
		}

		public void Update(DanhSachTiepNhan DanhSachTiepNhan)
		{
			_danhSachTiepNhanRepository.Update(DanhSachTiepNhan);
		}
	}
}