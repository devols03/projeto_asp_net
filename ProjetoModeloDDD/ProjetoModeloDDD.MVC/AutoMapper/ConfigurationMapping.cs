using AutoMapper;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModels;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class ConfigurationMapping : Profile
    {
        public ConfigurationMapping() {

            CreateMap<Client, ClientViewModel>()
                .ReverseMap();

            CreateMap<Product, ProductViewModel>()
                .ReverseMap();
        }
    }
}
