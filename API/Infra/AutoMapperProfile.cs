using API.ActiveDocument.Model;
using AutoMapper;
using Data.Entity.Data;

namespace API.Infra
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            #region Transaction
            CreateMap<TbltActiveDocument, ListActiveDocument>().ReverseMap();           
            #endregion
        }
    }
}
