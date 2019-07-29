using AutoMapper;
using Demoeshop.ViewModels;
using Store.Model;
using Store.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demoeshop.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }

        }

        public ViewModelToDomainMappingProfile()
        {
            CreateMap<GadgetFormViewModel, Gadget>()
                .ForMember(g => g.Name, map => map.MapFrom(vm => vm.GadgetTitle))
                .ForMember(g => g.Descripction, map => map.MapFrom(vm => vm.GadgetDescription))
                .ForMember(g => g.Price, map => map.MapFrom(vm => vm.GadgetPrice))
                .ForMember(g => g.Image, map => map.MapFrom(vm => vm.File.FileName))
                .ForMember(g => g.CategoryID, map => map.MapFrom(vm => vm.GadgetCategory));
        }

        //protected override void Configure()
        //{
        //    Mapper.
        //}
    }
}