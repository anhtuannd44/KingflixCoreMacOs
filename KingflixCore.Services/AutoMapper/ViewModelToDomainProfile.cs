using Profile = AutoMapper.Profile;
using KingflixCore.Domain.DomainModel;
using KingflixCore.Services.Models.Blog;

namespace KingflixCore.Services.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<BlogViewModel, Blog>();
        }
    }
}
