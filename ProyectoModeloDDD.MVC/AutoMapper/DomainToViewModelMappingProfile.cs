
using AutoMapper;
using ProyectoModeloDDD.Domain.Entities;
using ProyectoModeloDDD.MVC.ViewModels;

namespace ProyectoModeloDDD.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        public void Configure()
        {
            Mapper.Initialize(c =>
            {
                c.CreateMap<ClienteViewModels, Cliente>();
                c.CreateMap<ProductoViewModels, Producto>();
            });


        }
    }
}