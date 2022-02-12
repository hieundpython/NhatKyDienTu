using AutoMapper;
using NhatKyDienTu.MainApplication.Dto;
using NhatKyDienTu.MainModel.NhatKy;

namespace NhatKyDienTu.Users.Dto
{
    public class NhatKyMapProfile : Profile
    {
        public NhatKyMapProfile()
        {
            CreateMap<NhatKyDto, NhatKy>();
            CreateMap<NhatKy, NhatKyDto>();

            CreateMap<CreateNhatKyDto, NhatKy>();
            CreateMap<NhatKy, CreateNhatKyDto>();

        }
    }
}
