using AutoMapper;
using NetCoders.MicroErpDD.Domain.Entities;
using NetCoders.MicroErpDDD.UI.Mvc.AutoMapper.Mappings;
using NetCoders.MicroErpDDD.UI.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetCoders.MicroErpDDD.UI.Mvc.AutoMapper.Profiles
{
    public class ModelProfile : Profile
    {
        // Informar qual é o nome dele
        public override string ProfileName
        {
            get
            {
                return GetType().Name;
            }
        }

        // Configurar todos os nossos mapeamentos
        protected override void Configure()
        {
            // Fazendo o De/Para
            Mapper.CreateMap<CompraModel, Compra>().ConstructUsing(CompraMapping.OutCompra);
            Mapper.CreateMap<Compra, CompraModel>().ConstructUsing(CompraMapping.OutCompraModel);

            Mapper.CreateMap<CompraItemModel, CompraItem>();
            Mapper.CreateMap<CompraItem, CompraItemModel>();
        }
    }
}