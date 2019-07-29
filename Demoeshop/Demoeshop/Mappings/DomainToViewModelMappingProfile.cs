using AutoMapper;
using Store.Model;
using Store.Model.Model;
using Demoeshop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demoeshop.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        public DomainToViewModelMappingProfile()
        {
            CreateMap<Category,CategoryViewModel>();
            CreateMap<Gadget, GadgetViewModel>();
        }

        //protected override void Configure()
        //{
        //    var conf=new MapperConfiguration(cfg => {
        //        cfg.CreateMap<Category,CategoryViewModel > ();
        //        cfg.CreateMap<Gadget, GadgetViewModel>();
        //    });
        //    //Mapper.CreateMap<Category,CategoryViewModel>();
        //    //Mapper.CreateMap<Gadget, GadgetViewModel>();
        //}
    }
}