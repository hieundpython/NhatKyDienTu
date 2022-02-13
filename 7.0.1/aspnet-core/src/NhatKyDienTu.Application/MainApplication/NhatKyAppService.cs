using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Microsoft.EntityFrameworkCore;
using NhatKyDienTu.MainApplication.Dto;
using NhatKyDienTu.MainModel.NhatKy;
using NhatKyDienTu.MainModel.ThongTinChung;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhatKyDienTu.MainApplication
{
    public class NhatKyAppService : ApplicationService, INhatKyAppService
    {
        private readonly IRepository<NhatKy> _nhatKyRepo;
        private readonly IRepository<ThongTinChung> _thongtinChungRepo;

        public NhatKyAppService(IRepository<NhatKy> nhatKyRepo, IRepository<ThongTinChung> thongtinChungRepo)
        {
            _nhatKyRepo = nhatKyRepo;
            _thongtinChungRepo = thongtinChungRepo;
        }

        public async Task<NhatKyDto> AddNhatKy(CreateNhatKyDto input)
        {
            var newNhatKy = ObjectMapper.Map<NhatKy>(input);

            newNhatKy.TenantId = AbpSession.TenantId;

            var nhatKy = await _nhatKyRepo.InsertAsync(newNhatKy);

            CurrentUnitOfWork.SaveChanges();
            return ObjectMapper.Map<NhatKyDto>(nhatKy);
        }

        public async Task<ThongKeDto> GetThongKeNhatKy(InputNhatKyDto input)
        {
            var listUserId = new List<long>();
            if (input.DaiDoi != null || input.TieuDoan != null)
            {
                var listUserIdMatch = await _thongtinChungRepo.GetAll()
                    .WhereIf(input.DaiDoi != null, e => e.DaiDoi == input.DaiDoi)
                    .WhereIf(input.TieuDoan != null, e => e.TieuDoan == input.TieuDoan)
                    .Select(e => e.UserId)
                    .Distinct()
                    .ToListAsync();

                listUserId = listUserIdMatch;

                if (listUserId.Count == 0)
                {
                    return new ThongKeDto();
                }
            }

            var query = _nhatKyRepo
                .GetAll()
                .WhereIf(listUserId.Count > 0, e => listUserId.Contains(e.UserId))
                .WhereIf(input.StartTime != null, e => e.CreationTime >= input.StartTime)
                .WhereIf(input.EndTime != null, e => e.CreationTime <= input.EndTime);

            var list = await query.ToListAsync();


            // Thống kê cảm xúc 
            var camXucs = list.GroupBy(e => e.CamXuc)
                .Select(g => new CamXuc
                {
                    TenCamXuc = g.Key,
                    SoLuong = g.Count()
                }).ToList();

            // Thống kê theo hashtag
            var hashtagsDB = list.Select(e => new
            {
                Tags = e.HashTag.Split(", ").ToList(),
                CamXuc = e.CamXuc
            }).ToList();


            var hashtagNodes = new List<HashTagNode>();
            foreach (var hashtag in hashtagsDB)
            {
                foreach (var tag in hashtag.Tags)
                {
                    hashtagNodes.Add(new HashTagNode
                    {
                        TenHashTag = tag,
                        TenCamXuc = hashtag.CamXuc
                    });
                }
            }

            var hashTags = hashtagNodes
                .GroupBy(e => e.TenHashTag)
                .Select(g => new HashTag
                {
                    TenHashTag = g.Key,
                    ListCamXuc = g.GroupBy(i => i.TenCamXuc)
                    .Select(e => new CamXuc
                    {
                        TenCamXuc = e.Key,
                        SoLuong = e.Count()
                    }).ToList()
                }).ToList();



            return new ThongKeDto
            {
                CamXucs = camXucs,
                HashTags = hashTags
            };
        }

        public async Task<NhatKyDto> GetNhatKy(long id)
        {
            var nhatKy = await _nhatKyRepo.FirstOrDefaultAsync(e => e.Id == id);

            return ObjectMapper.Map<NhatKyDto>(nhatKy);
        }


        public async Task<List<NhatKyDto>> GetNhatKyByUserId(long userId)
        {
            var query = _nhatKyRepo.GetAll()
                .Where(e => e.UserId == userId)
                .OrderBy(e => e.CreationTime);

            var list = await query.ToListAsync();
            var items = ObjectMapper.Map<List<NhatKyDto>>(list);

            return items;
        }
    }
}
