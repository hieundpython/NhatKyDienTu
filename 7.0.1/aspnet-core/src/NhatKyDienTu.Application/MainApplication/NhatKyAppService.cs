using Abp.Application.Services;
using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using NhatKyDienTu.MainApplication.Dto;
using NhatKyDienTu.MainModel.NhatKy;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhatKyDienTu.MainApplication
{
    public class NhatKyAppService : ApplicationService, INhatKyAppService
    {
        private readonly IRepository<NhatKy> _nhatKyRepo;

        public NhatKyAppService(IRepository<NhatKy> nhatKyRepo)
        {
            _nhatKyRepo = nhatKyRepo;
        }

        public async Task<NhatKyDto> AddNhatKy(CreateNhatKyDto input)
        {
            var newNhatKy = ObjectMapper.Map<NhatKy>(input);

            newNhatKy.TenantId = AbpSession.TenantId;

            var nhatKy = await _nhatKyRepo.InsertAsync(newNhatKy);

            CurrentUnitOfWork.SaveChanges();
            return ObjectMapper.Map<NhatKyDto>(nhatKy);
        }

        public async Task<List<NhatKyDto>> GetAllNhatKy(InputNhatKyDto input)
        {
            var query = _nhatKyRepo.GetAll();

            var list = await query.ToListAsync();
            var items = ObjectMapper.Map<List<NhatKyDto>>(list);

            return items;
        }

        public async Task<NhatKyDto> GetNhatKy(long id)
        {
            var nhatKy = await _nhatKyRepo.FirstOrDefaultAsync(e => e.Id == id);

            return ObjectMapper.Map<NhatKyDto>(nhatKy);
        }


        public async Task<List<NhatKyDto>> GetNhatKyByUserId(long userId)
        {
            var query = _nhatKyRepo.GetAll()
                .Where(e => e.UserId == userId);

            var list = await query.ToListAsync();
            var items = ObjectMapper.Map<List<NhatKyDto>>(list);

            return items;
        }
    }
}
