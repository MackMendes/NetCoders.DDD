using AutoMapper;
using NetCoders.MicroErpDDD.UI.Mvc.AutoMapper.Profiles;

namespace NetCoders.MicroErpDDD.UI.Mvc.App_Start
{
    public static class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.AddProfile(new ModelProfile());
        }
    }
}