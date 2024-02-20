using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveDocumentAPI.Model
{
    public class ListActiveDocument
    {
        public Guid Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string RequestNumber { get; set; }
        public Guid? StatusId { get; set; }
        public string Status { get; set; }
        public string Perusahaan { get; set; }
        public string Direktorat { get; set; }
        public string Fungsi { get; set; }
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
        public string Kbo { get; set; }

        [NotMapped]
        public string DirektoratFungsi
        {
            get
            {
                if (!String.IsNullOrEmpty(this.Direktorat) || !String.IsNullOrEmpty(this.Fungsi))
                {
                    if (!String.IsNullOrEmpty(this.Direktorat) && !String.IsNullOrEmpty(this.Fungsi))
                    {
                        return this.Direktorat + " / " + this.Fungsi;
                    }
                    else if (!String.IsNullOrEmpty(this.Direktorat))
                    {
                        return this.Direktorat;
                    }
                    else return this.Fungsi;
                }
                else return null;
            }
        }
    }
}
