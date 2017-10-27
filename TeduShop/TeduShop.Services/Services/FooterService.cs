using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Infrastructure.Interfaces;
using TeduShop.Data.Repositories.Interfaces;
using TeduShop.Model.Models;
using TeduShop.Services.Interfaces;

namespace TeduShop.Services.Services
{
    public class FooterService : IFooterService
    {
        private readonly IFooterRepository _footerRepository;
        private readonly IUnitOfWork _unitOfWork;
        public FooterService(IFooterRepository footerRepository, IUnitOfWork unitOfWork)
        {
            _footerRepository = footerRepository;
            _unitOfWork = unitOfWork;
        }
        public void Add(Footer post)
        {
            _footerRepository.Add(post);
        }

        public void Delete(int id)
        {
            _footerRepository.Delete(id);
        }

        public IEnumerable<Footer> GetAll()
        {
            return _footerRepository.GetAll();
        }

        public IEnumerable<Footer> GetAllPaging(int page, int pageSize, out int totalRows)
        {
            return _footerRepository.GetMultiPaging(x => x.Status, out totalRows, page, pageSize);
        }

        public Footer GetById(int id)
        {
            return _footerRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Footer post)
        {
            _footerRepository.Update(post);
        }
    }
}
