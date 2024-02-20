using API.ActiveDocument.Model;
using API.Infra;
using Pertamina.PRIME.Models.BaseModel;

namespace API.ActiveDocument.Interfaces
{
    public interface IActiveDocument
    {
        Task<ResponseDataTable<List<ListActiveDocument>>> GetListActiveDocument(RequestFormDataTable request);
    }
}
