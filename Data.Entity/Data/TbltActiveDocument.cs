using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity.Data
{
    public class TbltActiveDocument
    {
        public Guid Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string Perusahaan { get; set; }
        public string Direktorat { get; set; }
        public string Fungsi { get; set; }
        public string Kbo { get; set; }
        public string NoSkOrganisasi { get; set; }
        public string NamaPimpinan { get; set; }
        public string Alamat { get; set; }
        public string ContactPersonName { get; set; }
        public string ContactPersonEmail { get; set; }
        public string ContactPersonMobileNumber { get; set; }
        public string RequestNumber { get; set; }
        public Guid? StatusId { get; set; }
        public string SubmittedBy { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string AssignedTo { get; set; }
        public DateTime? AssignedDate { get; set; }
        public string Status { get; set; }
        public string ActionName { get; set; }
        public bool IsDeleted { get; set; }
        public string Icon { get; set; }
        public string Tooltip { get; set; }
        public string JenisSeriesArsip { get; set; }
        public string UraianInformasi { get; set; }
        public string NamaBerkas { get; set; }
        public int? JumlahBerkas { get; set; }
        public string KodeSubPemberkasan { get; set; }
        public string KeteranganAksesKeamanan { get; set; }
        public string NomorBoksSementara { get; set; }
        public string RoleAccess { get; set; }
    }
}
