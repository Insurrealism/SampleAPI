using API.ActiveDocument.Interfaces;
using API.ActiveDocument.Model;
using API.Infra;
using AutoMapper;
using Data.Entity.Data;
using LinqKit;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Pertamina.PRIME.Models.BaseModel;
using Pertamina.PRIME.Repositories.Core;
using Pertamina.PRIME.Repositories.Repository;
using System;
using System.Data;

namespace API.ActiveDocument.Service
{
    public class ActiveDocument : BaseRepository<TbltActiveDocument>, IActiveDocument
    {
        private readonly DBPrimeContext _context;

        public ActiveDocument(DBPrimeContext context, IMapper mapper): base(context, mapper)
        {
            _context = context;
        }

        public async Task<ResponseDataTable<List<ListActiveDocument>>> GetListActiveDocument(RequestFormDataTable request)
        {
            try
            {

                var query = _context.TbltActiveDocumentHeaderSenders
                        .AsQueryable();

                // Filtering data`
                var predicate = PredicateBuilder.New<TbltActiveDocumentHeaderSender>(true);

                if (!string.IsNullOrEmpty(request.SearchValue))
                {
                    predicate = predicate.Or(x => (x.RequestNumber.Contains(request.SearchValue)));
                }                

                //var predicateFilters = PredicateBuilder.New<TbltActiveDocumentHeaderSender>(true);
                
                query = query.Where(predicate);
                query = query.Where(x => x.DeletedDate == null);

                var joinquery = query.Join(_context.TblmActiveDocumentStatusFiles, ad => ad.StatusId, sf => sf.Id, (ad, sf) =>
                                 new TbltActiveDocument()
                                 {
                                     Status = sf.StatusName,
                                     Id = ad.Id,
                                     CreatedBy = ad.CreatedBy,
                                     CreatedDate = ad.CreatedDate,
                                     UpdatedBy = ad.UpdatedBy,
                                     UpdatedDate = ad.UpdatedDate,
                                     DeletedDate = ad.DeletedDate,
                                     Perusahaan = ad.CompanyCode,
                                     Direktorat = ad.Direktorat,
                                     Fungsi = ad.Fungsi,
                                     Kbo = ad.Kbo,
                                     NoSkOrganisasi = ad.NoSkOrganisasi,
                                     NamaPimpinan = ad.NamaPimpinan,
                                     Alamat = ad.Alamat,
                                     ContactPersonName = ad.ContactPersonName,
                                     ContactPersonEmail = ad.ContactPersonEmail,
                                     ContactPersonMobileNumber = ad.ContactPersonMobileNumber,
                                     RequestNumber = ad.RequestNumber,
                                     StatusId = ad.StatusId,
                                     SubmittedBy = ad.SubmittedBy,
                                     SubmittedDate = ad.SubmittedDate,
                                     ApprovedBy = ad.ApprovedBy,
                                     ApprovedDate = ad.ApprovedDate,
                                     AssignedTo = ad.AssignedTo,
                                     AssignedDate = ad.AssignedDate,
                                     ActionName = sf.ActionName,
                                     Icon = sf.Icon,
                                     IsDeleted = sf.IsDeleted.Value,
                                     Tooltip = sf.Tooltip,
                                     RoleAccess = sf.RoleAccess
                                 }).AsQueryable();         

                // Sorting data
                if (!(string.IsNullOrEmpty(request.SortColumn) && string.IsNullOrEmpty(request.SortColumnDirection)))
                {
                    if (request.SortColumnDirection == "asc")
                        joinquery = joinquery.OrderBy(c => EF.Property<string>(c, request.SortColumn));
                    else
                        joinquery = joinquery.OrderByDescending(c => EF.Property<string>(c, request.SortColumn));
                }
                else
                {
                    joinquery = joinquery.OrderByDescending(x => x.UpdatedDate ?? DateTime.MaxValue).AsQueryable();
                }

                var list = await PaginatedList<TbltActiveDocument, ListActiveDocument>.CreateAsync(joinquery, request.PageValue, request.PageSize, joinquery.Count(), _mapper);

                return new ResponseDataTable<List<ListActiveDocument>>("", list, list.ListInfo.TotalRecord, list.ListInfo.Page);
            }
            catch (Exception ex)
            {
                return new ResponseDataTable<List<ListActiveDocument>>(false, ex.Message);
            }
        }
    }
}
//var client = new HttpClient();

//var response = await client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
//{
//    Address = "https://login.qa.idaman.pertamina.com/.well-known/openid-configuration",
//    ClientId = "1081ed3e-7eb3-4fb3-bcb3-135246e20227",
//    ClientSecret = "70883c2c-8893-4675-a06f-4eba71f19d55",
//    Scope = "api.auth position.readAll user.readAll user.read unit.read unit.readAll position.read"
//});
//var response = await client.SendAsync(request);

//var responseString = await response;



