using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using ProyectoModeloDDD.Domain.Entities;
using ProyectoModeloDDD.MVC.ViewModels;

namespace ProyectoModeloDDD.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings";  } 
        }

        public void Configure()
        {
            Mapper.Initialize( c =>
            {
                c.CreateMap<Cliente, ClienteViewModels>();
                c.CreateMap<Producto, ProductoViewModels>();
            }
        );
        }
    }
}