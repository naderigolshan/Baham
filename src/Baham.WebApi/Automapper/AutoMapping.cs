using AutoMapper;
using Baham.Entities;
using Baham.ViewModels.Auth;

namespace Baham.WebApi.Automapper;

public class AutoMapping : Profile
{
    public AutoMapping()
    {
        CreateMap<User, RegisterViewModel>().ReverseMap();
    }
}
