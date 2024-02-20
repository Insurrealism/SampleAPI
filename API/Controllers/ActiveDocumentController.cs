using API.ActiveDocument.Interfaces;
using API.ActiveDocument.Model;
using API.Infra;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pertamina.PRIME.Models.BaseModel;
using System.Data;

namespace API.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class ActiveDocumentController : ControllerBase
    {  
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IActiveDocument _service;

        public ActiveDocumentController(ILogger<WeatherForecastController> logger, IActiveDocument service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet("GetActiveDocumentHeader")]
        public Task<ResponseDataTable<List<ListActiveDocument>>> GetListActiveDocument([FromQuery] string? sortOrder = "", 
                                                                                       [FromQuery] string? searchText = "", 
                                                                                       [FromQuery] string? sortColumn = "", 
                                                                                       [FromQuery] int? page = 1,
                                                                                       [FromQuery] int? take = 0)            
        {
            var request = new RequestFormDataTable()
            {
               SearchValue = searchText,
               SortColumnDirection = sortOrder,
               Page = page.HasValue ? page.Value : 1,
               PageSize = take.HasValue ? take.Value : 0,
               SortColumn = sortColumn,
            };
            var res = _service.GetListActiveDocument(request);

            return res;
        }
    }
}
