using ActiveDocumentAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveDocumentAPI.Interface
{
    public interface IActiveDocument
    {
        Task<ListActiveDocument> GetListActiveDocument();
    }
}
