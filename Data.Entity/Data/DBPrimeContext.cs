using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity.Data
{
    public class DBPrimeContext: DbContext
    {
        public DBPrimeContext()
        {
        }

        public DBPrimeContext(DbContextOptions<DBPrimeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblmActiveDocumentStatusFile> TblmActiveDocumentStatusFiles { get; set; } = null!;
        public virtual DbSet<TblmAlihMediaSigningStatusFile> TblmAlihMediaSigningStatusFiles { get; set; } = null!;
        public virtual DbSet<TblmAlihMediaStatusFile> TblmAlihMediaStatusFiles { get; set; } = null!;
        public virtual DbSet<TblmAmbalan> TblmAmbalans { get; set; } = null!;
        public virtual DbSet<TblmBahasa> TblmBahasas { get; set; } = null!;
        public virtual DbSet<TblmBentukItem> TblmBentukItems { get; set; } = null!;
        public virtual DbSet<TblmDigitalSignature> TblmDigitalSignatures { get; set; } = null!;
        public virtual DbSet<TblmDirectory> TblmDirectories { get; set; } = null!;
        public virtual DbSet<TblmFeature> TblmFeatures { get; set; } = null!;
        public virtual DbSet<TblmFileTransferSigningStatusFile> TblmFileTransferSigningStatusFiles { get; set; } = null!;
        public virtual DbSet<TblmFileTransferStatusFile> TblmFileTransferStatusFiles { get; set; } = null!;
        public virtual DbSet<TblmGedung> TblmGedungs { get; set; } = null!;
        public virtual DbSet<TblmHtmlTemplate> TblmHtmlTemplates { get; set; } = null!;
        public virtual DbSet<TblmIdamanCustomParameter> TblmIdamanCustomParameters { get; set; } = null!;
        public virtual DbSet<TblmIdamanUrl> TblmIdamanUrls { get; set; } = null!;
        public virtual DbSet<TblmInactiveActiveDocumentStatusFile> TblmInactiveActiveDocumentStatusFiles { get; set; } = null!;
        public virtual DbSet<TblmInactiveArchiveManagementStatusFile> TblmInactiveArchiveManagementStatusFiles { get; set; } = null!;
        public virtual DbSet<TblmIndeksMasalah> TblmIndeksMasalahs { get; set; } = null!;
        public virtual DbSet<TblmJenisMedium> TblmJenisMedia { get; set; } = null!;
        public virtual DbSet<TblmJrdpReference> TblmJrdpReferences { get; set; } = null!;
        public virtual DbSet<TblmJustifikasiAkse> TblmJustifikasiAkses { get; set; } = null!;
        public virtual DbSet<TblmKategoriArsip> TblmKategoriArsips { get; set; } = null!;
        public virtual DbSet<TblmKesesuaianDaftarFisikArsip> TblmKesesuaianDaftarFisikArsips { get; set; } = null!;
        public virtual DbSet<TblmKeteranganAksesKeamanan> TblmKeteranganAksesKeamanans { get; set; } = null!;
        public virtual DbSet<TblmKodeKlasifikasiPemberkasan> TblmKodeKlasifikasiPemberkasans { get; set; } = null!;
        public virtual DbSet<TblmKodePokokPemberkasan> TblmKodePokokPemberkasans { get; set; } = null!;
        public virtual DbSet<TblmKodeSubPemberkasan> TblmKodeSubPemberkasans { get; set; } = null!;
        public virtual DbSet<TblmKondisiArsip> TblmKondisiArsips { get; set; } = null!;
        public virtual DbSet<TblmKotaKabupaten> TblmKotaKabupatens { get; set; } = null!;
        public virtual DbSet<TblmLokasiPengolahan> TblmLokasiPengolahans { get; set; } = null!;
        public virtual DbSet<TblmPerangkat> TblmPerangkats { get; set; } = null!;
        public virtual DbSet<TblmProvinsi> TblmProvinsis { get; set; } = null!;
        public virtual DbSet<TblmRak> TblmRaks { get; set; } = null!;
        public virtual DbSet<TblmRcPenyimpanan> TblmRcPenyimpanans { get; set; } = null!;
        public virtual DbSet<TblmRecordServiceRequestDuplicationType> TblmRecordServiceRequestDuplicationTypes { get; set; } = null!;
        public virtual DbSet<TblmRecordServiceSigningStatusFile> TblmRecordServiceSigningStatusFiles { get; set; } = null!;
        public virtual DbSet<TblmRecordServiceTransactionType> TblmRecordServiceTransactionTypes { get; set; } = null!;
        public virtual DbSet<TblmRecordServicesStatusFile> TblmRecordServicesStatusFiles { get; set; } = null!;
        public virtual DbSet<TblmRekomendasiArsip> TblmRekomendasiArsips { get; set; } = null!;
        public virtual DbSet<TblmRole> TblmRoles { get; set; } = null!;
        public virtual DbSet<TblmRoleFeature> TblmRoleFeatures { get; set; } = null!;
        public virtual DbSet<TblmRuangan> TblmRuangans { get; set; } = null!;
        public virtual DbSet<TblmSequenceCounter> TblmSequenceCounters { get; set; } = null!;
        public virtual DbSet<TblmSubPermasalahan> TblmSubPermasalahans { get; set; } = null!;
        public virtual DbSet<TblmSubyekMasalah> TblmSubyekMasalahs { get; set; } = null!;
        public virtual DbSet<TblmSyncDirektorat> TblmSyncDirektorats { get; set; } = null!;
        public virtual DbSet<TblmTingkatPerkembanganDocument> TblmTingkatPerkembanganDocuments { get; set; } = null!;
        public virtual DbSet<TbltActiveDocumentFile> TbltActiveDocumentFiles { get; set; } = null!;
        public virtual DbSet<TbltActiveDocumentHeaderSender> TbltActiveDocumentHeaderSenders { get; set; } = null!;
        public virtual DbSet<TbltActiveDocumentHistory> TbltActiveDocumentHistories { get; set; } = null!;
        public virtual DbSet<TbltActiveDocumentItem> TbltActiveDocumentItems { get; set; } = null!;
        public virtual DbSet<TbltAlihMediaAlatPerangkat> TbltAlihMediaAlatPerangkats { get; set; } = null!;
        public virtual DbSet<TbltAlihMediaBaSigning> TbltAlihMediaBaSignings { get; set; } = null!;
        public virtual DbSet<TbltAlihMediaDummyFileSelection> TbltAlihMediaDummyFileSelections { get; set; } = null!;
        public virtual DbSet<TbltAlihMediaFile> TbltAlihMediaFiles { get; set; } = null!;
        public virtual DbSet<TbltAlihMediaFileSigning> TbltAlihMediaFileSignings { get; set; } = null!;
        public virtual DbSet<TbltAlihMediaHeaderSender> TbltAlihMediaHeaderSenders { get; set; } = null!;
        public virtual DbSet<TbltAlihMediaHistory> TbltAlihMediaHistories { get; set; } = null!;
        public virtual DbSet<TbltAlihMediaInventory> TbltAlihMediaInventories { get; set; } = null!;
        public virtual DbSet<TbltAlihMediaItem> TbltAlihMediaItems { get; set; } = null!;
        public virtual DbSet<TbltAlihMediaProposal> TbltAlihMediaProposals { get; set; } = null!;
        public virtual DbSet<TbltAlihMediaSignParallel> TbltAlihMediaSignParallels { get; set; } = null!;
        public virtual DbSet<TbltAlihMediaSigning> TbltAlihMediaSignings { get; set; } = null!;
        public virtual DbSet<TbltAlihMediaSigningHistory> TbltAlihMediaSigningHistories { get; set; } = null!;
        public virtual DbSet<TbltEmailStatus> TbltEmailStatuses { get; set; } = null!;
        public virtual DbSet<TbltFileSigning> TbltFileSignings { get; set; } = null!;
        public virtual DbSet<TbltFileTransferFile> TbltFileTransferFiles { get; set; } = null!;
        public virtual DbSet<TbltFileTransferHeaderSender> TbltFileTransferHeaderSenders { get; set; } = null!;
        public virtual DbSet<TbltFileTransferHistory> TbltFileTransferHistories { get; set; } = null!;
        public virtual DbSet<TbltFileTransferItem> TbltFileTransferItems { get; set; } = null!;
        public virtual DbSet<TbltFileTransferSignParallel> TbltFileTransferSignParallels { get; set; } = null!;
        public virtual DbSet<TbltFileTransferSigning> TbltFileTransferSignings { get; set; } = null!;
        public virtual DbSet<TbltFileTransferSigningHistory> TbltFileTransferSigningHistories { get; set; } = null!;
        public virtual DbSet<TbltFileTransferSurvey> TbltFileTransferSurveys { get; set; } = null!;
        public virtual DbSet<TbltInactiveActiveDocumentFile> TbltInactiveActiveDocumentFiles { get; set; } = null!;
        public virtual DbSet<TbltInactiveActiveDocumentHeaderSender> TbltInactiveActiveDocumentHeaderSenders { get; set; } = null!;
        public virtual DbSet<TbltInactiveActiveDocumentHistory> TbltInactiveActiveDocumentHistories { get; set; } = null!;
        public virtual DbSet<TbltInactiveActiveDocumentItem> TbltInactiveActiveDocumentItems { get; set; } = null!;
        public virtual DbSet<TbltInactiveArchiveManagementFile> TbltInactiveArchiveManagementFiles { get; set; } = null!;
        public virtual DbSet<TbltInactiveArchiveManagementHeaderSender> TbltInactiveArchiveManagementHeaderSenders { get; set; } = null!;
        public virtual DbSet<TbltInactiveArchiveManagementHistory> TbltInactiveArchiveManagementHistories { get; set; } = null!;
        public virtual DbSet<TbltInactiveArchiveManagementInventory> TbltInactiveArchiveManagementInventories { get; set; } = null!;
        public virtual DbSet<TbltInactiveArchiveManagementItem> TbltInactiveArchiveManagementItems { get; set; } = null!;
        public virtual DbSet<TbltNotificationBell> TbltNotificationBells { get; set; } = null!;
        public virtual DbSet<TbltRecordServiceAttachment> TbltRecordServiceAttachments { get; set; } = null!;
        public virtual DbSet<TbltRecordServiceBaSigning> TbltRecordServiceBaSignings { get; set; } = null!;
        public virtual DbSet<TbltRecordServiceFile> TbltRecordServiceFiles { get; set; } = null!;
        public virtual DbSet<TbltRecordServiceHeaderSender> TbltRecordServiceHeaderSenders { get; set; } = null!;
        public virtual DbSet<TbltRecordServiceHistory> TbltRecordServiceHistories { get; set; } = null!;
        public virtual DbSet<TbltRecordServiceSignParallel> TbltRecordServiceSignParallels { get; set; } = null!;
        public virtual DbSet<TbltRecordServiceSigning> TbltRecordServiceSignings { get; set; } = null!;
        public virtual DbSet<TbltRecordServiceSigningHistory> TbltRecordServiceSigningHistories { get; set; } = null!;
        public virtual DbSet<VwDimCompany> VwDimCompanies { get; set; } = null!;
        public virtual DbSet<VwDimDirektorat> VwDimDirektorats { get; set; } = null!;
        public virtual DbSet<VwDimFungsi> VwDimFungsis { get; set; } = null!;
        public virtual DbSet<VwDimKategoriArsip> VwDimKategoriArsips { get; set; } = null!;
        public virtual DbSet<VwDimKbo> VwDimKbos { get; set; } = null!;
        public virtual DbSet<VwDimKodePemberkasan> VwDimKodePemberkasans { get; set; } = null!;
        public virtual DbSet<VwDimYear> VwDimYears { get; set; } = null!;
        public virtual DbSet<VwFactActiveDocument> VwFactActiveDocuments { get; set; } = null!;
        public virtual DbSet<VwFactAlihMedium> VwFactAlihMedia { get; set; } = null!;
        public virtual DbSet<VwFactFileTransfer> VwFactFileTransfers { get; set; } = null!;
        public virtual DbSet<VwFactInactiveDocument> VwFactInactiveDocuments { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblmActiveDocumentStatusFile>(entity =>
            {
                entity.ToTable("TBLM_Active_Document_Status_File");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ActionName)
                    .HasMaxLength(100)
                    .HasColumnName("Action_Name");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.EmailBody).HasColumnName("Email_Body");

                entity.Property(e => e.EmailReceiver)
                    .HasMaxLength(200)
                    .HasColumnName("Email_Receiver");

                entity.Property(e => e.EmailSubject)
                    .HasMaxLength(1000)
                    .HasColumnName("Email_Subject");

                entity.Property(e => e.Icon).HasMaxLength(50);

                entity.Property(e => e.IsCaculateRetensiAktif).HasColumnName("Is_Caculate_Retensi_Aktif");

                entity.Property(e => e.IsDeleted).HasColumnName("Is_Deleted");

                entity.Property(e => e.MenuText)
                    .HasMaxLength(1000)
                    .HasColumnName("Menu_Text");

                entity.Property(e => e.NextStepCode)
                    .HasMaxLength(200)
                    .HasColumnName("Next_Step_Code");

                entity.Property(e => e.RejectStepCode)
                    .HasMaxLength(200)
                    .HasColumnName("Reject_Step_Code");

                entity.Property(e => e.ReviseStepCode)
                    .HasMaxLength(200)
                    .HasColumnName("Revise_Step_Code");

                entity.Property(e => e.RoleAccess).HasColumnName("Role_Access");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(200)
                    .HasColumnName("Status_Name");

                entity.Property(e => e.StepCode)
                    .HasMaxLength(50)
                    .HasColumnName("Step_Code");

                entity.Property(e => e.StepDescription)
                    .HasMaxLength(200)
                    .HasColumnName("Step_Description");

                entity.Property(e => e.SubmenuText)
                    .HasMaxLength(1000)
                    .HasColumnName("Submenu_Text");

                entity.Property(e => e.Tooltip).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.Property(e => e.UserPelaku)
                    .HasMaxLength(200)
                    .HasColumnName("User_Pelaku");

                entity.Property(e => e.UserTahapLanjut)
                    .HasMaxLength(200)
                    .HasColumnName("User_Tahap_Lanjut");

                entity.Property(e => e.WarnaStatus)
                    .HasMaxLength(50)
                    .HasColumnName("Warna_Status");
            });

            modelBuilder.Entity<TblmAlihMediaSigningStatusFile>(entity =>
            {
                entity.ToTable("TBLM_Alih_Media_Signing_Status_File");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ActionName)
                    .HasMaxLength(100)
                    .HasColumnName("Action_Name");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.EmailBody).HasColumnName("Email_Body");

                entity.Property(e => e.EmailReceiver)
                    .HasMaxLength(200)
                    .HasColumnName("Email_Receiver");

                entity.Property(e => e.EmailSubject)
                    .HasMaxLength(1000)
                    .HasColumnName("Email_Subject");

                entity.Property(e => e.Icon).HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasColumnName("Is_Deleted");

                entity.Property(e => e.MenuText)
                    .HasMaxLength(1000)
                    .HasColumnName("Menu_Text");

                entity.Property(e => e.NextStepCode)
                    .HasMaxLength(200)
                    .HasColumnName("Next_Step_Code");

                entity.Property(e => e.RejectStepCode)
                    .HasMaxLength(200)
                    .HasColumnName("Reject_Step_Code");

                entity.Property(e => e.ReviseStepCode)
                    .HasMaxLength(200)
                    .HasColumnName("Revise_Step_Code");

                entity.Property(e => e.RoleAccess).HasColumnName("Role_Access");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(200)
                    .HasColumnName("Status_Name");

                entity.Property(e => e.StepCode)
                    .HasMaxLength(50)
                    .HasColumnName("Step_Code");

                entity.Property(e => e.StepDescription)
                    .HasMaxLength(200)
                    .HasColumnName("Step_Description");

                entity.Property(e => e.SubmenuText)
                    .HasMaxLength(1000)
                    .HasColumnName("Submenu_Text");

                entity.Property(e => e.Tooltip).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.Property(e => e.UserPelaku)
                    .HasMaxLength(200)
                    .HasColumnName("User_Pelaku");

                entity.Property(e => e.UserTahapLanjut)
                    .HasMaxLength(200)
                    .HasColumnName("User_Tahap_Lanjut");

                entity.Property(e => e.WarnaStatus)
                    .HasMaxLength(50)
                    .HasColumnName("Warna_Status");
            });

            modelBuilder.Entity<TblmAlihMediaStatusFile>(entity =>
            {
                entity.ToTable("TBLM_Alih_Media_Status_File");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ActionName)
                    .HasMaxLength(100)
                    .HasColumnName("Action_Name");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.EmailBody).HasColumnName("Email_Body");

                entity.Property(e => e.EmailReceiver)
                    .HasMaxLength(200)
                    .HasColumnName("Email_Receiver");

                entity.Property(e => e.EmailSubject)
                    .HasMaxLength(1000)
                    .HasColumnName("Email_Subject");

                entity.Property(e => e.Icon).HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasColumnName("Is_Deleted");

                entity.Property(e => e.MenuText)
                    .HasMaxLength(1000)
                    .HasColumnName("Menu_Text");

                entity.Property(e => e.NextStepCode)
                    .HasMaxLength(200)
                    .HasColumnName("Next_Step_Code");

                entity.Property(e => e.RejectStepCode)
                    .HasMaxLength(200)
                    .HasColumnName("Reject_Step_Code");

                entity.Property(e => e.ReviseStepCode)
                    .HasMaxLength(200)
                    .HasColumnName("Revise_Step_Code");

                entity.Property(e => e.RoleAccess).HasColumnName("Role_Access");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(200)
                    .HasColumnName("Status_Name");

                entity.Property(e => e.StepCode)
                    .HasMaxLength(50)
                    .HasColumnName("Step_Code");

                entity.Property(e => e.StepDescription)
                    .HasMaxLength(200)
                    .HasColumnName("Step_Description");

                entity.Property(e => e.SubmenuText)
                    .HasMaxLength(1000)
                    .HasColumnName("Submenu_Text");

                entity.Property(e => e.Tooltip).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.Property(e => e.UserPelaku)
                    .HasMaxLength(200)
                    .HasColumnName("User_Pelaku");

                entity.Property(e => e.UserTahapLanjut)
                    .HasMaxLength(200)
                    .HasColumnName("User_Tahap_Lanjut");

                entity.Property(e => e.WarnaStatus)
                    .HasMaxLength(50)
                    .HasColumnName("Warna_Status");
            });

            modelBuilder.Entity<TblmAmbalan>(entity =>
            {
                entity.ToTable("TBLM_Ambalan");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");
            });

            modelBuilder.Entity<TblmBahasa>(entity =>
            {
                entity.ToTable("TBLM_Bahasa");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");
            });

            modelBuilder.Entity<TblmBentukItem>(entity =>
            {
                entity.ToTable("TBLM_Bentuk_Item");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");
            });

            modelBuilder.Entity<TblmDigitalSignature>(entity =>
            {
                entity.ToTable("TBLM_Digital_Signature");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.EndPointUrl)
                    .HasMaxLength(500)
                    .HasColumnName("End_Point_Url");

                entity.Property(e => e.NameEndPoint)
                    .HasMaxLength(250)
                    .HasColumnName("Name_End_Point");

                entity.Property(e => e.ParameterTake)
                    .HasMaxLength(500)
                    .HasColumnName("Parameter_Take");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");
            });

            modelBuilder.Entity<TblmDirectory>(entity =>
            {
                entity.ToTable("TBLM_Directory");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.FeatureName)
                    .HasMaxLength(200)
                    .HasColumnName("Feature_Name");

                entity.Property(e => e.Path).HasMaxLength(200);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");
            });

            modelBuilder.Entity<TblmFeature>(entity =>
            {
                entity.ToTable("TBLM_Feature");

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.ActionName)
                    .HasMaxLength(200)
                    .HasColumnName("Action_Name");

                entity.Property(e => e.AreaName)
                    .HasMaxLength(200)
                    .HasColumnName("Area_Name");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.ControllerName)
                    .HasMaxLength(200)
                    .HasColumnName("Controller_Name");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.FeatureName)
                    .HasMaxLength(200)
                    .HasColumnName("Feature_Name");

                entity.Property(e => e.IsCatalog)
                    .HasColumnName("Is_Catalog")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsMenu).HasColumnName("Is_Menu");

                entity.Property(e => e.MenuIcon)
                    .HasMaxLength(200)
                    .HasColumnName("Menu_Icon");

                entity.Property(e => e.MenuLink)
                    .HasMaxLength(50)
                    .HasColumnName("Menu_Link");

                entity.Property(e => e.ParentFeatureCode)
                    .HasMaxLength(50)
                    .HasColumnName("Parent_Feature_Code");

                entity.Property(e => e.SequenceChild).HasColumnName("Sequence_Child");

                entity.Property(e => e.SubMenuDesc)
                    .HasMaxLength(200)
                    .HasColumnName("Sub_Menu_Desc");

                entity.Property(e => e.SubMenuIcon)
                    .HasMaxLength(50)
                    .HasColumnName("Sub_Menu_Icon");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");
            });

            modelBuilder.Entity<TblmFileTransferSigningStatusFile>(entity =>
            {
                entity.ToTable("TBLM_File_Transfer_Signing_Status_File");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ActionName)
                    .HasMaxLength(100)
                    .HasColumnName("Action_Name");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.EmailBody).HasColumnName("Email_Body");

                entity.Property(e => e.EmailReceiver)
                    .HasMaxLength(200)
                    .HasColumnName("Email_Receiver");

                entity.Property(e => e.EmailSubject)
                    .HasMaxLength(1000)
                    .HasColumnName("Email_Subject");

                entity.Property(e => e.Icon).HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasColumnName("Is_Deleted");

                entity.Property(e => e.MenuText)
                    .HasMaxLength(1000)
                    .HasColumnName("Menu_Text");

                entity.Property(e => e.NextStepCode)
                    .HasMaxLength(200)
                    .HasColumnName("Next_Step_Code");

                entity.Property(e => e.RejectStepCode)
                    .HasMaxLength(200)
                    .HasColumnName("Reject_Step_Code");

                entity.Property(e => e.ReviseStepCode)
                    .HasMaxLength(200)
                    .HasColumnName("Revise_Step_Code");

                entity.Property(e => e.RoleAccess).HasColumnName("Role_Access");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(200)
                    .HasColumnName("Status_Name");

                entity.Property(e => e.StepCode)
                    .HasMaxLength(50)
                    .HasColumnName("Step_Code");

                entity.Property(e => e.StepDescription)
                    .HasMaxLength(200)
                    .HasColumnName("Step_Description");

                entity.Property(e => e.SubmenuText)
                    .HasMaxLength(1000)
                    .HasColumnName("Submenu_Text");

                entity.Property(e => e.Tooltip).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.Property(e => e.UserPelaku)
                    .HasMaxLength(200)
                    .HasColumnName("User_Pelaku");

                entity.Property(e => e.UserTahapLanjut)
                    .HasMaxLength(200)
                    .HasColumnName("User_Tahap_Lanjut");

                entity.Property(e => e.WarnaStatus)
                    .HasMaxLength(50)
                    .HasColumnName("Warna_Status");
            });

            modelBuilder.Entity<TblmFileTransferStatusFile>(entity =>
            {
                entity.ToTable("TBLM_File_Transfer_Status_File");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ActionName)
                    .HasMaxLength(100)
                    .HasColumnName("Action_Name");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.EmailBody).HasColumnName("Email_Body");

                entity.Property(e => e.EmailReceiver)
                    .HasMaxLength(200)
                    .HasColumnName("Email_Receiver");

                entity.Property(e => e.EmailSubject)
                    .HasMaxLength(1000)
                    .HasColumnName("Email_Subject");

                entity.Property(e => e.Icon).HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasColumnName("Is_Deleted");

                entity.Property(e => e.MenuText)
                    .HasMaxLength(1000)
                    .HasColumnName("Menu_Text");

                entity.Property(e => e.NextStepCode)
                    .HasMaxLength(200)
                    .HasColumnName("Next_Step_Code");

                entity.Property(e => e.RejectStepCode)
                    .HasMaxLength(200)
                    .HasColumnName("Reject_Step_Code");

                entity.Property(e => e.ReviseStepCode)
                    .HasMaxLength(200)
                    .HasColumnName("Revise_Step_Code");

                entity.Property(e => e.RoleAccess).HasColumnName("Role_Access");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(200)
                    .HasColumnName("Status_Name");

                entity.Property(e => e.StepCode)
                    .HasMaxLength(50)
                    .HasColumnName("Step_Code");

                entity.Property(e => e.StepDescription)
                    .HasMaxLength(200)
                    .HasColumnName("Step_Description");

                entity.Property(e => e.SubmenuText)
                    .HasMaxLength(1000)
                    .HasColumnName("Submenu_Text");

                entity.Property(e => e.Tooltip).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.Property(e => e.UserPelaku)
                    .HasMaxLength(200)
                    .HasColumnName("User_Pelaku");

                entity.Property(e => e.UserTahapLanjut)
                    .HasMaxLength(200)
                    .HasColumnName("User_Tahap_Lanjut");

                entity.Property(e => e.WarnaStatus)
                    .HasMaxLength(50)
                    .HasColumnName("Warna_Status");
            });

            modelBuilder.Entity<TblmGedung>(entity =>
            {
                entity.ToTable("TBLM_Gedung");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ActiveStatus).HasColumnName("Active_Status");

                entity.Property(e => e.Alamat).HasMaxLength(250);

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(50)
                    .HasColumnName("Company_Code");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.Deskripsi).HasMaxLength(250);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");
            });

            modelBuilder.Entity<TblmHtmlTemplate>(entity =>
            {
                entity.ToTable("TBLM_Html_Template");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.HtmlTemplate).HasColumnName("Html_Template");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");
            });

            modelBuilder.Entity<TblmIdamanCustomParameter>(entity =>
            {
                entity.ToTable("TBLM_Idaman_Custom_Parameter");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AuthParam)
                    .HasMaxLength(200)
                    .HasColumnName("Auth_Param");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.NameEndPoint)
                    .HasMaxLength(250)
                    .HasColumnName("Name_End_Point");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");
            });

            modelBuilder.Entity<TblmIdamanUrl>(entity =>
            {
                entity.ToTable("TBLM_Idaman_Url");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.EndPointUrl)
                    .HasMaxLength(500)
                    .HasColumnName("End_Point_Url");

                entity.Property(e => e.NameEndPoint)
                    .HasMaxLength(250)
                    .HasColumnName("Name_End_Point");

                entity.Property(e => e.ParameterTake)
                    .HasMaxLength(500)
                    .HasColumnName("Parameter_Take");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");
            });

            modelBuilder.Entity<TblmInactiveActiveDocumentStatusFile>(entity =>
            {
                entity.ToTable("TBLM_Inactive_Active_Document_Status_File");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ActionName)
                    .HasMaxLength(100)
                    .HasColumnName("Action_Name");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.EmailBody).HasColumnName("Email_Body");

                entity.Property(e => e.EmailReceiver)
                    .HasMaxLength(200)
                    .HasColumnName("Email_Receiver");

                entity.Property(e => e.EmailSubject)
                    .HasMaxLength(1000)
                    .HasColumnName("Email_Subject");

                entity.Property(e => e.Icon).HasMaxLength(50);

                entity.Property(e => e.IsCaculateRetensiAktif).HasColumnName("Is_Caculate_Retensi_Aktif");

                entity.Property(e => e.IsDeleted).HasColumnName("Is_Deleted");

                entity.Property(e => e.MenuText)
                    .HasMaxLength(1000)
                    .HasColumnName("Menu_Text");

                entity.Property(e => e.NextStepCode)
                    .HasMaxLength(200)
                    .HasColumnName("Next_Step_Code");

                entity.Property(e => e.RejectStepCode)
                    .HasMaxLength(200)
                    .HasColumnName("Reject_Step_Code");

                entity.Property(e => e.ReviseStepCode)
                    .HasMaxLength(200)
                    .HasColumnName("Revise_Step_Code");

                entity.Property(e => e.RoleAccess).HasColumnName("Role_Access");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(200)
                    .HasColumnName("Status_Name");

                entity.Property(e => e.StepCode)
                    .HasMaxLength(50)
                    .HasColumnName("Step_Code");

                entity.Property(e => e.StepDescription)
                    .HasMaxLength(200)
                    .HasColumnName("Step_Description");

                entity.Property(e => e.SubmenuText)
                    .HasMaxLength(1000)
                    .HasColumnName("Submenu_Text");

                entity.Property(e => e.Tooltip).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.Property(e => e.UserPelaku)
                    .HasMaxLength(200)
                    .HasColumnName("User_Pelaku");

                entity.Property(e => e.UserTahapLanjut)
                    .HasMaxLength(200)
                    .HasColumnName("User_Tahap_Lanjut");

                entity.Property(e => e.WarnaStatus)
                    .HasMaxLength(50)
                    .HasColumnName("Warna_Status");
            });

            modelBuilder.Entity<TblmInactiveArchiveManagementStatusFile>(entity =>
            {
                entity.ToTable("TBLM_Inactive_Archive_Management_Status_File");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ActionName)
                    .HasMaxLength(100)
                    .HasColumnName("Action_Name");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.EmailBody).HasColumnName("Email_Body");

                entity.Property(e => e.EmailReceiver)
                    .HasMaxLength(200)
                    .HasColumnName("Email_Receiver");

                entity.Property(e => e.EmailSubject)
                    .HasMaxLength(1000)
                    .HasColumnName("Email_Subject");

                entity.Property(e => e.Icon).HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasColumnName("Is_Deleted");

                entity.Property(e => e.IsInventory).HasColumnName("Is_Inventory");

                entity.Property(e => e.MenuText)
                    .HasMaxLength(1000)
                    .HasColumnName("Menu_Text");

                entity.Property(e => e.NextStepCode)
                    .HasMaxLength(200)
                    .HasColumnName("Next_Step_Code");

                entity.Property(e => e.RejectStepCode)
                    .HasMaxLength(200)
                    .HasColumnName("Reject_Step_Code");

                entity.Property(e => e.ReviseStepCode)
                    .HasMaxLength(200)
                    .HasColumnName("Revise_Step_Code");

                entity.Property(e => e.RoleAccess).HasColumnName("Role_Access");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(200)
                    .HasColumnName("Status_Name");

                entity.Property(e => e.StepCode)
                    .HasMaxLength(50)
                    .HasColumnName("Step_Code");

                entity.Property(e => e.StepDescription)
                    .HasMaxLength(200)
                    .HasColumnName("Step_Description");

                entity.Property(e => e.SubmenuText)
                    .HasMaxLength(1000)
                    .HasColumnName("Submenu_Text");

                entity.Property(e => e.Tooltip).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.Property(e => e.UserPelaku)
                    .HasMaxLength(200)
                    .HasColumnName("User_Pelaku");

                entity.Property(e => e.UserTahapLanjut)
                    .HasMaxLength(200)
                    .HasColumnName("User_Tahap_Lanjut");

                entity.Property(e => e.WarnaStatus)
                    .HasMaxLength(50)
                    .HasColumnName("Warna_Status");
            });

            modelBuilder.Entity<TblmIndeksMasalah>(entity =>
            {
                entity.ToTable("TBLM_Indeks_Masalah");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");
            });

            modelBuilder.Entity<TblmJenisMedium>(entity =>
            {
                entity.ToTable("TBLM_Jenis_Media");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");
            });

            modelBuilder.Entity<TblmJrdpReference>(entity =>
            {
                entity.ToTable("TBLM_Jrdp_Reference");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AngkaPerhitungan).HasColumnName("Angka_Perhitungan");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.TextDeskripsi)
                    .HasMaxLength(100)
                    .HasColumnName("Text_Deskripsi");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");
            });

            modelBuilder.Entity<TblmJustifikasiAkse>(entity =>
            {
                entity.ToTable("TBLM_Justifikasi_Akses");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.Deskrepsi)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Nama)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");
            });

            modelBuilder.Entity<TblmKategoriArsip>(entity =>
            {
                entity.ToTable("TBLM_Kategori_Arsip");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ActiveStatus).HasColumnName("Active_Status");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.Deskripsi).HasMaxLength(250);

                entity.Property(e => e.Kategori)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");
            });

            modelBuilder.Entity<TblmKesesuaianDaftarFisikArsip>(entity =>
            {
                entity.ToTable("TBLM_Kesesuaian_Daftar_Fisik_Arsip");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.Kesesuaian).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");
            });

            modelBuilder.Entity<TblmKeteranganAksesKeamanan>(entity =>
            {
                entity.ToTable("TBLM_Keterangan_Akses_Keamanan");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ActiveStatus).HasColumnName("Active_Status");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.Deskripsi).HasMaxLength(250);

                entity.Property(e => e.Keterangan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");
            });

            modelBuilder.Entity<TblmKodeKlasifikasiPemberkasan>(entity =>
            {
                entity.ToTable("TBLM_Kode_Klasifikasi_Pemberkasan");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ActiveStatus).HasColumnName("Active_Status");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.Deskripsi).HasMaxLength(1000);

                entity.Property(e => e.Kode).HasMaxLength(50);

                entity.Property(e => e.KodeSubPemberkasanId).HasColumnName("Kode_Sub_Pemberkasan_Id");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.HasOne(d => d.KodeSubPemberkasan)
                    .WithMany(p => p.TblmKodeKlasifikasiPemberkasans)
                    .HasForeignKey(d => d.KodeSubPemberkasanId)
                    .HasConstraintName("FK_TBLM_Kode_Klasifikasi_Pemberkasan_TBLM_Kode_Sub_Pemberkasan");
            });

            modelBuilder.Entity<TblmKodePokokPemberkasan>(entity =>
            {
                entity.ToTable("TBLM_Kode_Pokok_Pemberkasan");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.Kode).HasMaxLength(50);

                entity.Property(e => e.PokokPermasalahan)
                    .HasMaxLength(1000)
                    .HasColumnName("Pokok_Permasalahan");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");
            });

            modelBuilder.Entity<TblmKodeSubPemberkasan>(entity =>
            {
                entity.ToTable("TBLM_Kode_Sub_Pemberkasan");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ActiveIsOthers).HasColumnName("Active_Is_Others");

                entity.Property(e => e.ActiveIsPermanen).HasColumnName("Active_Is_Permanen");

                entity.Property(e => e.ActiveIsPermanenTerbatas).HasColumnName("Active_Is_Permanen_Terbatas");

                entity.Property(e => e.ActiveStatus).HasColumnName("Active_Status");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.Deskripsi).HasMaxLength(1000);

                entity.Property(e => e.InactiveIsOthers).HasColumnName("Inactive_Is_Others");

                entity.Property(e => e.InactiveIsPermanen).HasColumnName("Inactive_Is_Permanen");

                entity.Property(e => e.InactiveIsPermanenTerbatas).HasColumnName("Inactive_Is_Permanen_Terbatas");

                entity.Property(e => e.Keterangan).HasMaxLength(200);

                entity.Property(e => e.Kode).HasMaxLength(50);

                entity.Property(e => e.KodePokokPemberkasanId).HasColumnName("Kode_Pokok_Pemberkasan_Id");

                entity.Property(e => e.MasaRetensiActive).HasColumnName("Masa_Retensi_Active");

                entity.Property(e => e.MasaRetensiInactive).HasColumnName("Masa_Retensi_Inactive");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.HasOne(d => d.KodePokokPemberkasan)
                    .WithMany(p => p.TblmKodeSubPemberkasans)
                    .HasForeignKey(d => d.KodePokokPemberkasanId)
                    .HasConstraintName("FK_TBLM_Kode_Sub_Pemberkasan_TBLM_Kode_Pokok_Pemberkasan");
            });

            modelBuilder.Entity<TblmKondisiArsip>(entity =>
            {
                entity.ToTable("TBLM_Kondisi_Arsip");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.Kondisi).HasMaxLength(100);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(100)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");
            });

            modelBuilder.Entity<TblmKotaKabupaten>(entity =>
            {
                entity.ToTable("TBLM_Kota_Kabupaten");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProvinsiId).HasColumnName("Provinsi_Id");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.HasOne(d => d.Provinsi)
                    .WithMany(p => p.TblmKotaKabupatens)
                    .HasForeignKey(d => d.ProvinsiId)
                    .HasConstraintName("FK_TBLM_Kota_Kabupaten_TBLM_Provinsi");
            });

            modelBuilder.Entity<TblmLokasiPengolahan>(entity =>
            {
                entity.ToTable("TBLM_Lokasi_Pengolahan");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeleteDate).HasColumnName("Delete_Date");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");
            });

            modelBuilder.Entity<TblmPerangkat>(entity =>
            {
                entity.ToTable("TBLM_Perangkat");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ActiveStatus).HasColumnName("Active_Status");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(50)
                    .HasColumnName("Company_Code");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.Deskripsi).HasMaxLength(250);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");
            });

            modelBuilder.Entity<TblmProvinsi>(entity =>
            {
                entity.ToTable("TBLM_Provinsi");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeleteDate).HasColumnName("Delete_Date");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");
            });

            modelBuilder.Entity<TblmRak>(entity =>
            {
                entity.ToTable("TBLM_Rak");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");
            });

            modelBuilder.Entity<TblmRcPenyimpanan>(entity =>
            {
                entity.ToTable("TBLM_RC_Penyimpanan");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.RecordPenyimpanan)
                    .HasMaxLength(50)
                    .HasColumnName("Record_Penyimpanan");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");
            });

            modelBuilder.Entity<TblmRecordServiceRequestDuplicationType>(entity =>
            {
                entity.ToTable("TBLM_Record_Service_Request_Duplication_Type");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");
            });

            modelBuilder.Entity<TblmRecordServiceSigningStatusFile>(entity =>
            {
                entity.ToTable("TBLM_Record_Service_Signing_Status_File");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ActionName)
                    .HasMaxLength(100)
                    .HasColumnName("Action_Name");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.EmailBody).HasColumnName("Email_Body");

                entity.Property(e => e.EmailReceiver)
                    .HasMaxLength(200)
                    .HasColumnName("Email_Receiver");

                entity.Property(e => e.EmailSubject)
                    .HasMaxLength(1000)
                    .HasColumnName("Email_Subject");

                entity.Property(e => e.Icon).HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasColumnName("Is_Deleted");

                entity.Property(e => e.MenuText)
                    .HasMaxLength(1000)
                    .HasColumnName("Menu_Text");

                entity.Property(e => e.NextStepCode)
                    .HasMaxLength(200)
                    .HasColumnName("Next_Step_Code");

                entity.Property(e => e.RejectStepCode)
                    .HasMaxLength(200)
                    .HasColumnName("Reject_Step_Code");

                entity.Property(e => e.ReviseStepCode)
                    .HasMaxLength(200)
                    .HasColumnName("Revise_Step_Code");

                entity.Property(e => e.RoleAccess).HasColumnName("Role_Access");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(200)
                    .HasColumnName("Status_Name");

                entity.Property(e => e.StepCode)
                    .HasMaxLength(50)
                    .HasColumnName("Step_Code");

                entity.Property(e => e.StepDescription)
                    .HasMaxLength(200)
                    .HasColumnName("Step_Description");

                entity.Property(e => e.SubmenuText)
                    .HasMaxLength(1000)
                    .HasColumnName("Submenu_Text");

                entity.Property(e => e.Tooltip).HasMaxLength(50);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(50)
                    .HasColumnName("Transaction_Type");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.Property(e => e.UserPelaku)
                    .HasMaxLength(200)
                    .HasColumnName("User_Pelaku");

                entity.Property(e => e.UserTahapLanjut)
                    .HasMaxLength(200)
                    .HasColumnName("User_Tahap_Lanjut");

                entity.Property(e => e.WarnaStatus)
                    .HasMaxLength(50)
                    .HasColumnName("Warna_Status");
            });

            modelBuilder.Entity<TblmRecordServiceTransactionType>(entity =>
            {
                entity.ToTable("TBLM_Record_Service_Transaction_Type");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.IsReturned)
                    .HasColumnName("Is_Returned")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");
            });

            modelBuilder.Entity<TblmRecordServicesStatusFile>(entity =>
            {
                entity.ToTable("TBLM_Record_Services_Status_File");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ActionName)
                    .HasMaxLength(100)
                    .HasColumnName("Action_Name");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.EmailBody).HasColumnName("Email_Body");

                entity.Property(e => e.EmailReceiver)
                    .HasMaxLength(200)
                    .HasColumnName("Email_Receiver");

                entity.Property(e => e.EmailSubject)
                    .HasMaxLength(1000)
                    .HasColumnName("Email_Subject");

                entity.Property(e => e.Icon).HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasColumnName("Is_Deleted");

                entity.Property(e => e.MenuText)
                    .HasMaxLength(1000)
                    .HasColumnName("Menu_Text");

                entity.Property(e => e.NextStepCode)
                    .HasMaxLength(200)
                    .HasColumnName("Next_Step_Code");

                entity.Property(e => e.RejectStepCode)
                    .HasMaxLength(200)
                    .HasColumnName("Reject_Step_Code");

                entity.Property(e => e.ReviseStepCode)
                    .HasMaxLength(200)
                    .HasColumnName("Revise_Step_Code");

                entity.Property(e => e.RoleAccess).HasColumnName("Role_Access");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(200)
                    .HasColumnName("Status_Name");

                entity.Property(e => e.StepCode)
                    .HasMaxLength(50)
                    .HasColumnName("Step_Code");

                entity.Property(e => e.StepDescription)
                    .HasMaxLength(200)
                    .HasColumnName("Step_Description");

                entity.Property(e => e.SubmenuText)
                    .HasMaxLength(1000)
                    .HasColumnName("Submenu_Text");

                entity.Property(e => e.Tooltip).HasMaxLength(50);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(50)
                    .HasColumnName("Transaction_Type");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.Property(e => e.UserPelaku)
                    .HasMaxLength(200)
                    .HasColumnName("User_Pelaku");

                entity.Property(e => e.UserTahapLanjut)
                    .HasMaxLength(200)
                    .HasColumnName("User_Tahap_Lanjut");

                entity.Property(e => e.WarnaStatus)
                    .HasMaxLength(50)
                    .HasColumnName("Warna_Status");
            });

            modelBuilder.Entity<TblmRekomendasiArsip>(entity =>
            {
                entity.ToTable("TBLM_Rekomendasi_Arsip");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ActiveStatus).HasColumnName("Active_Status");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.Deskripsi).HasMaxLength(250);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");
            });

            modelBuilder.Entity<TblmRole>(entity =>
            {
                entity.ToTable("TBLM_Role");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.IsAdd).HasColumnName("Is_Add");

                entity.Property(e => e.IsAddAlihMedia)
                    .HasColumnName("Is_Add_Alih_Media")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsAddFileTransfer).HasColumnName("Is_Add_File_Transfer");

                entity.Property(e => e.IsApprove).HasColumnName("Is_Approve");

                entity.Property(e => e.IsApproveAlihMedia)
                    .HasColumnName("Is_Approve_Alih_Media")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsAssign).HasColumnName("Is_Assign");

                entity.Property(e => e.IsBorrowed).HasColumnName("Is_Borrowed");

                entity.Property(e => e.IsComplete).HasColumnName("Is_Complete");

                entity.Property(e => e.IsDownload).HasColumnName("Is_Download");

                entity.Property(e => e.IsExpired).HasColumnName("Is_Expired");

                entity.Property(e => e.IsExtend).HasColumnName("Is_Extend");

                entity.Property(e => e.IsReassign).HasColumnName("Is_Reassign");

                entity.Property(e => e.IsReject).HasColumnName("Is_Reject");

                entity.Property(e => e.IsRejectAlihMedia)
                    .HasColumnName("Is_Reject_Alih_Media")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsReturned).HasColumnName("Is_Returned");

                entity.Property(e => e.IsReview).HasColumnName("Is_Review");

                entity.Property(e => e.IsRevise).HasColumnName("Is_Revise");

                entity.Property(e => e.IsReviseAlihMedia)
                    .HasColumnName("Is_Revise_Alih_Media")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSelect).HasColumnName("Is_Select");

                entity.Property(e => e.IsSignDocument).HasColumnName("Is_Sign_Document");

                entity.Property(e => e.IsSubmit).HasColumnName("Is_Submit");

                entity.Property(e => e.IsSubmitAll).HasColumnName("Is_Submit_All");

                entity.Property(e => e.IsSurvey).HasColumnName("Is_Survey");

                entity.Property(e => e.IsUpdateInventory).HasColumnName("Is_Update_Inventory");

                entity.Property(e => e.IsUpload).HasColumnName("Is_Upload");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");
            });

            modelBuilder.Entity<TblmRoleFeature>(entity =>
            {
                entity.ToTable("TBLM_Role_Feature");

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.FeatureId)
                    .HasMaxLength(50)
                    .HasColumnName("Feature_Id");

                entity.Property(e => e.IsCreate).HasColumnName("Is_Create");

                entity.Property(e => e.IsDelete).HasColumnName("Is_Delete");

                entity.Property(e => e.IsRead).HasColumnName("Is_Read");

                entity.Property(e => e.IsUpdate).HasColumnName("Is_Update");

                entity.Property(e => e.RoleId).HasColumnName("Role_Id");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.HasOne(d => d.Feature)
                    .WithMany(p => p.TblmRoleFeatures)
                    .HasForeignKey(d => d.FeatureId)
                    .HasConstraintName("FK_TBLM_Role_Feature_TBLM_Feature");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.TblmRoleFeatures)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_TBLM_Role_Feature_TBLM_Role");
            });

            modelBuilder.Entity<TblmRuangan>(entity =>
            {
                entity.ToTable("TBLM_Ruangan");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ActiveStatus).HasColumnName("Active_Status");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(50)
                    .HasColumnName("Company_Code");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.Deskripsi).HasMaxLength(250);

                entity.Property(e => e.GedungId).HasColumnName("Gedung_Id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.HasOne(d => d.Gedung)
                    .WithMany(p => p.TblmRuangans)
                    .HasForeignKey(d => d.GedungId)
                    .HasConstraintName("FK_TBLM_Ruangan_TBLM_Gedung");
            });

            modelBuilder.Entity<TblmSequenceCounter>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PK_TBLM_Sequence_Counter_1");

                entity.ToTable("TBLM_Sequence_Counter");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<TblmSubPermasalahan>(entity =>
            {
                entity.ToTable("TBLM_Sub_Permasalahan");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.KodeKlasifikasiPemberkasanId).HasColumnName("Kode_Klasifikasi_Pemberkasan_Id");

                entity.Property(e => e.Name)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.HasOne(d => d.KodeKlasifikasiPemberkasan)
                    .WithMany(p => p.TblmSubPermasalahans)
                    .HasForeignKey(d => d.KodeKlasifikasiPemberkasanId)
                    .HasConstraintName("FK_TBLM_Sub_Permasalahan_TBLM_Kode_Klasifikasi_Pemberkasan");
            });

            modelBuilder.Entity<TblmSubyekMasalah>(entity =>
            {
                entity.ToTable("TBLM_Subyek_Masalah");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeleteDate).HasColumnName("Delete_Date");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");
            });

            modelBuilder.Entity<TblmSyncDirektorat>(entity =>
            {
                entity.ToTable("TBLM_Sync_Direktorat");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(50)
                    .HasColumnName("Company_Code");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.DirectorateLevel).HasColumnName("Directorate_Level");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");
            });

            modelBuilder.Entity<TblmTingkatPerkembanganDocument>(entity =>
            {
                entity.ToTable("TBLM_Tingkat_Perkembangan_Document");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");
            });

            modelBuilder.Entity<TbltActiveDocumentFile>(entity =>
            {
                entity.ToTable("TBLT_Active_Document_File");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ActiveDocumentHeaderSenderId).HasColumnName("Active_Document_Header_Sender_Id");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.FileTransferFileId).HasColumnName("File_Transfer_File_Id");

                entity.Property(e => e.JenisSeriesArsip)
                    .HasMaxLength(200)
                    .HasColumnName("Jenis_Series_Arsip");

                entity.Property(e => e.JumlahBerkas).HasColumnName("Jumlah_Berkas");

                entity.Property(e => e.KategoriArsipId).HasColumnName("Kategori_Arsip_Id");

                entity.Property(e => e.KeteranganAksesKeamananId).HasColumnName("Keterangan_Akses_Keamanan_Id");

                entity.Property(e => e.KeteranganRetensi)
                    .HasMaxLength(200)
                    .HasColumnName("Keterangan_Retensi");

                entity.Property(e => e.KodeSubPemberkasanId).HasColumnName("Kode_Sub_Pemberkasan_Id");

                entity.Property(e => e.KurunWaktuBerkasAkhir).HasColumnName("Kurun_Waktu_Berkas_Akhir");

                entity.Property(e => e.KurunWaktuBerkasMulai).HasColumnName("Kurun_Waktu_Berkas_Mulai");

                entity.Property(e => e.NamaBerkas)
                    .HasMaxLength(200)
                    .HasColumnName("Nama_Berkas");

                entity.Property(e => e.Nominal).HasMaxLength(200);

                entity.Property(e => e.NomorBoksSementara)
                    .HasMaxLength(200)
                    .HasColumnName("Nomor_Boks_Sementara");

                entity.Property(e => e.RequestNumber)
                    .HasMaxLength(200)
                    .HasColumnName("Request_Number");

                entity.Property(e => e.RetensiAktif).HasColumnName("Retensi_Aktif");

                entity.Property(e => e.RetensiAktifText)
                    .HasMaxLength(100)
                    .HasColumnName("Retensi_Aktif_Text");

                entity.Property(e => e.RetensiInaktif).HasColumnName("Retensi_Inaktif");

                entity.Property(e => e.RetensiInaktifText)
                    .HasMaxLength(100)
                    .HasColumnName("Retensi_Inaktif_Text");

                entity.Property(e => e.SelectedStatus).HasColumnName("Selected_Status");

                entity.Property(e => e.TingkatPerkembanganBerkasId).HasColumnName("Tingkat_Perkembangan_Berkas_Id");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.Property(e => e.UraianInformasi).HasColumnName("Uraian_Informasi");

                entity.HasOne(d => d.ActiveDocumentHeaderSender)
                    .WithMany(p => p.TbltActiveDocumentFiles)
                    .HasForeignKey(d => d.ActiveDocumentHeaderSenderId)
                    .HasConstraintName("FK_TBLT_Active_Document_File_TBLT_Active_Document_Header_Sender");

                entity.HasOne(d => d.KategoriArsip)
                    .WithMany(p => p.TbltActiveDocumentFiles)
                    .HasForeignKey(d => d.KategoriArsipId)
                    .HasConstraintName("FK_TBLT_Active_Document_File_TBLM_Kategori_Arsip");

                entity.HasOne(d => d.KeteranganAksesKeamanan)
                    .WithMany(p => p.TbltActiveDocumentFiles)
                    .HasForeignKey(d => d.KeteranganAksesKeamananId)
                    .HasConstraintName("FK_TBLT_Active_Document_File_TBLM_Keterangan_Akses_Keamanan");

                entity.HasOne(d => d.KodeSubPemberkasan)
                    .WithMany(p => p.TbltActiveDocumentFiles)
                    .HasForeignKey(d => d.KodeSubPemberkasanId)
                    .HasConstraintName("FK_TBLT_Active_Document_File_TBLM_Kode_Sub_Pemberkasan");

                entity.HasOne(d => d.TingkatPerkembanganBerkas)
                    .WithMany(p => p.TbltActiveDocumentFiles)
                    .HasForeignKey(d => d.TingkatPerkembanganBerkasId)
                    .HasConstraintName("FK_TBLT_Active_Document_File_TBLM_Tingkat_Perkembangan_Dokumen");
            });

            modelBuilder.Entity<TbltActiveDocumentHeaderSender>(entity =>
            {
                entity.ToTable("TBLT_Active_Document_Header_Sender");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Alamat).HasMaxLength(200);

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Approved_By");

                entity.Property(e => e.ApprovedDate).HasColumnName("Approved_Date");

                entity.Property(e => e.AssignedDate).HasColumnName("Assigned_Date");

                entity.Property(e => e.AssignedTo)
                    .HasMaxLength(50)
                    .HasColumnName("Assigned_To");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(50)
                    .HasColumnName("Company_Code");

                entity.Property(e => e.ContactPersonEmail)
                    .HasMaxLength(200)
                    .HasColumnName("Contact_Person_Email");

                entity.Property(e => e.ContactPersonMobileNumber)
                    .HasMaxLength(200)
                    .HasColumnName("Contact_Person_Mobile_Number");

                entity.Property(e => e.ContactPersonName)
                    .HasMaxLength(200)
                    .HasColumnName("Contact_Person_Name");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.Direktorat).HasMaxLength(200);

                entity.Property(e => e.DirektoratId)
                    .HasMaxLength(50)
                    .HasColumnName("Direktorat_Id");

                entity.Property(e => e.Fungsi).HasMaxLength(200);

                entity.Property(e => e.FungsiId)
                    .HasMaxLength(50)
                    .HasColumnName("Fungsi_Id");

                entity.Property(e => e.Kbo)
                    .HasMaxLength(200)
                    .HasColumnName("KBO");

                entity.Property(e => e.NamaPimpinan)
                    .HasMaxLength(200)
                    .HasColumnName("Nama_Pimpinan");

                entity.Property(e => e.NoSkOrganisasi)
                    .HasMaxLength(200)
                    .HasColumnName("No_SK_Organisasi");

                entity.Property(e => e.RequestNumber)
                    .HasMaxLength(50)
                    .HasColumnName("Request_Number");

                entity.Property(e => e.StatusId).HasColumnName("Status_Id");

                entity.Property(e => e.SubmittedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Submitted_By");

                entity.Property(e => e.SubmittedDate).HasColumnName("Submitted_Date");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TbltActiveDocumentHeaderSenders)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_TBLT_Header_Sender_Active_Document_TBLM_Status_File_Active_Document");
            });

            modelBuilder.Entity<TbltActiveDocumentHistory>(entity =>
            {
                entity.ToTable("TBLT_Active_Document_History");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ActiveDocumentHeaderSenderId).HasColumnName("Active_Document_Header_Sender_Id");

                entity.Property(e => e.ActiveDocumentStatusFileId).HasColumnName("Active_Document_Status_File_Id");

                entity.Property(e => e.CommentsText)
                    .HasMaxLength(1000)
                    .HasColumnName("Comments_Text");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.MenuText)
                    .HasMaxLength(1000)
                    .HasColumnName("Menu_Text");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(200)
                    .HasColumnName("Status_Name");

                entity.Property(e => e.StepCode)
                    .HasMaxLength(50)
                    .HasColumnName("Step_Code");

                entity.Property(e => e.SubmenuText)
                    .HasMaxLength(1000)
                    .HasColumnName("Submenu_Text");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.Property(e => e.UserPelaku)
                    .HasMaxLength(200)
                    .HasColumnName("User_Pelaku");

                entity.HasOne(d => d.ActiveDocumentHeaderSender)
                    .WithMany(p => p.TbltActiveDocumentHistories)
                    .HasForeignKey(d => d.ActiveDocumentHeaderSenderId)
                    .HasConstraintName("FK_TBLT_Active_Document_History_TBLT_Active_Document_Header_Sender");

                entity.HasOne(d => d.ActiveDocumentStatusFile)
                    .WithMany(p => p.TbltActiveDocumentHistories)
                    .HasForeignKey(d => d.ActiveDocumentStatusFileId)
                    .HasConstraintName("FK_TBLT_Active_Document_History_TBLM_Active_Document_Status_File");
            });

            modelBuilder.Entity<TbltActiveDocumentItem>(entity =>
            {
                entity.ToTable("TBLT_Active_Document_Item");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ActiveDocumentFileId).HasColumnName("Active_Document_File_Id");

                entity.Property(e => e.BentukItemId).HasColumnName("Bentuk_Item_Id");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.FileNameSystem)
                    .HasMaxLength(200)
                    .HasColumnName("File_Name_System");

                entity.Property(e => e.FileNameUser)
                    .HasMaxLength(200)
                    .HasColumnName("File_Name_User");

                entity.Property(e => e.NoItemArsip)
                    .HasMaxLength(100)
                    .HasColumnName("No_Item_Arsip");

                entity.Property(e => e.TingkatPerkembanganDokumenId).HasColumnName("Tingkat_Perkembangan_Dokumen_Id");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.Property(e => e.UraianInformasi).HasColumnName("Uraian_Informasi");

                entity.HasOne(d => d.ActiveDocumentFile)
                    .WithMany(p => p.TbltActiveDocumentItems)
                    .HasForeignKey(d => d.ActiveDocumentFileId)
                    .HasConstraintName("FK_TBLT_Active_Document_Item_TBLT_Active_Document_File");

                entity.HasOne(d => d.BentukItem)
                    .WithMany(p => p.TbltActiveDocumentItems)
                    .HasForeignKey(d => d.BentukItemId)
                    .HasConstraintName("FK_TBLT_Active_Document_Item_TBLM_Bentuk_Item");

                entity.HasOne(d => d.TingkatPerkembanganDokumen)
                    .WithMany(p => p.TbltActiveDocumentItems)
                    .HasForeignKey(d => d.TingkatPerkembanganDokumenId)
                    .HasConstraintName("FK_TBLT_Active_Document_Item_TBLM_Tingkat_Perkembangan_Dokumen");
            });

            modelBuilder.Entity<TbltAlihMediaAlatPerangkat>(entity =>
            {
                entity.ToTable("TBLT_Alih_Media_Alat_Perangkat");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AlihMediaHeaderSenderId).HasColumnName("Alih_Media_Header_Sender_Id");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.PerangkatId).HasColumnName("Perangkat_Id");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.HasOne(d => d.AlihMediaHeaderSender)
                    .WithMany(p => p.TbltAlihMediaAlatPerangkats)
                    .HasForeignKey(d => d.AlihMediaHeaderSenderId)
                    .HasConstraintName("FK_TBLT_Alih_Media_Alat_Perangkat_TBLT_Alih_Media_Header_Sender");

                entity.HasOne(d => d.Perangkat)
                    .WithMany(p => p.TbltAlihMediaAlatPerangkats)
                    .HasForeignKey(d => d.PerangkatId)
                    .HasConstraintName("FK_TBLT_Alih_Media_Alat_Perangkat_TBLM_Perangkat");
            });

            modelBuilder.Entity<TbltAlihMediaBaSigning>(entity =>
            {
                entity.ToTable("TBLT_Alih_Media_BA_Signing");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AlihMediaSigningId).HasColumnName("Alih_Media_Signing_Id");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.RoleId).HasColumnName("Role_Id");

                entity.Property(e => e.RoleName).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.Property(e => e.Username).HasMaxLength(200);

                entity.HasOne(d => d.AlihMediaSigning)
                    .WithMany(p => p.TbltAlihMediaBaSignings)
                    .HasForeignKey(d => d.AlihMediaSigningId)
                    .HasConstraintName("FK_TBLT_Alih_Media_BA_Signing_TBLT_Alih_Media_Signing");
            });

            modelBuilder.Entity<TbltAlihMediaDummyFileSelection>(entity =>
            {
                entity.ToTable("TBLT_Alih_Media_Dummy_File_Selection");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.InactiveArchiveManagementId).HasColumnName("Inactive_Archive_Management_Id");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.Property(e => e.Username).HasMaxLength(200);

                entity.HasOne(d => d.InactiveArchiveManagement)
                    .WithMany(p => p.TbltAlihMediaDummyFileSelections)
                    .HasForeignKey(d => d.InactiveArchiveManagementId)
                    .HasConstraintName("FK_TBLT_Alih_Media_Dummy_File_Selection_TBLT_Inactive_Archive_Management_File");
            });

            modelBuilder.Entity<TbltAlihMediaFile>(entity =>
            {
                entity.ToTable("TBLT_Alih_Media_File");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AlihMediaHeaderSenderId).HasColumnName("Alih_Media_Header_Sender_Id");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.InactiveArchiveManagementInventoryId).HasColumnName("Inactive_Archive_Management_Inventory_Id");

                entity.Property(e => e.JenisSeriesArsip)
                    .HasMaxLength(200)
                    .HasColumnName("Jenis_Series_Arsip");

                entity.Property(e => e.JumlahBerkas).HasColumnName("Jumlah_Berkas");

                entity.Property(e => e.KategoriArsipId).HasColumnName("Kategori_Arsip_Id");

                entity.Property(e => e.KeteranganAksesKeamananId).HasColumnName("Keterangan_Akses_Keamanan_Id");

                entity.Property(e => e.KeteranganRetensi)
                    .HasMaxLength(200)
                    .HasColumnName("Keterangan_Retensi");

                entity.Property(e => e.KodeSubPemberkasanId).HasColumnName("Kode_Sub_Pemberkasan_Id");

                entity.Property(e => e.KurunWaktuBerkasAkhir).HasColumnName("Kurun_Waktu_Berkas_Akhir");

                entity.Property(e => e.KurunWaktuBerkasMulai).HasColumnName("Kurun_Waktu_Berkas_Mulai");

                entity.Property(e => e.LokasiTersimpan)
                    .HasMaxLength(200)
                    .HasColumnName("Lokasi_Tersimpan");

                entity.Property(e => e.NamaBerkas)
                    .HasMaxLength(200)
                    .HasColumnName("Nama_Berkas");

                entity.Property(e => e.Nominal).HasMaxLength(200);

                entity.Property(e => e.RequestNumber)
                    .HasMaxLength(200)
                    .HasColumnName("Request_Number");

                entity.Property(e => e.RetensiAktif).HasColumnName("Retensi_Aktif");

                entity.Property(e => e.RetensiInaktif).HasColumnName("Retensi_Inaktif");

                entity.Property(e => e.TingkatPerkembanganBerkasId).HasColumnName("Tingkat_Perkembangan_Berkas_Id");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.Property(e => e.UraianInformasi).HasColumnName("Uraian_Informasi");

                entity.HasOne(d => d.AlihMediaHeaderSender)
                    .WithMany(p => p.TbltAlihMediaFiles)
                    .HasForeignKey(d => d.AlihMediaHeaderSenderId)
                    .HasConstraintName("FK_TBLT_Alih_Media_File_TBLT_Alih_Media_Header_Sender");

                entity.HasOne(d => d.InactiveArchiveManagementInventory)
                    .WithMany(p => p.TbltAlihMediaFiles)
                    .HasForeignKey(d => d.InactiveArchiveManagementInventoryId)
                    .HasConstraintName("FK_TBLT_Alih_Media_File_TBLT_Inactive_Archive_Management_Inventory");

                entity.HasOne(d => d.KategoriArsip)
                    .WithMany(p => p.TbltAlihMediaFiles)
                    .HasForeignKey(d => d.KategoriArsipId)
                    .HasConstraintName("FK_TBLT_Alih_Media_File_TBLM_Kategori_Arsip");

                entity.HasOne(d => d.KeteranganAksesKeamanan)
                    .WithMany(p => p.TbltAlihMediaFiles)
                    .HasForeignKey(d => d.KeteranganAksesKeamananId)
                    .HasConstraintName("FK_TBLT_Alih_Media_File_TBLM_Keterangan_Akses_Keamanan");

                entity.HasOne(d => d.KodeSubPemberkasan)
                    .WithMany(p => p.TbltAlihMediaFiles)
                    .HasForeignKey(d => d.KodeSubPemberkasanId)
                    .HasConstraintName("FK_TBLT_Alih_Media_File_TBLM_Kode_Sub_Pemberkasan");

                entity.HasOne(d => d.TingkatPerkembanganBerkas)
                    .WithMany(p => p.TbltAlihMediaFiles)
                    .HasForeignKey(d => d.TingkatPerkembanganBerkasId)
                    .HasConstraintName("FK_TBLT_Alih_Media_File_TBLM_Tingkat_Perkembangan_Document");
            });

            modelBuilder.Entity<TbltAlihMediaFileSigning>(entity =>
            {
                entity.ToTable("TBLT_Alih_Media_File_Signing");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AlihMediaSigningId).HasColumnName("Alih_Media_Signing_Id");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.RoleId).HasColumnName("Role_Id");

                entity.Property(e => e.RoleName).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.Property(e => e.Username).HasMaxLength(200);

                entity.HasOne(d => d.AlihMediaSigning)
                    .WithMany(p => p.TbltAlihMediaFileSignings)
                    .HasForeignKey(d => d.AlihMediaSigningId)
                    .HasConstraintName("FK_TBLT_Alih_Media_File_Signing_TBLT_Alih_Media_Signing");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.TbltAlihMediaFileSignings)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_TBLT_Alih_Media_File_Signing_TBLM_Role");
            });

            modelBuilder.Entity<TbltAlihMediaHeaderSender>(entity =>
            {
                entity.ToTable("TBLT_Alih_Media_Header_Sender");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Alamat).HasMaxLength(200);

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Approved_By");

                entity.Property(e => e.ApprovedDate).HasColumnName("Approved_Date");

                entity.Property(e => e.AssignedDate).HasColumnName("Assigned_Date");

                entity.Property(e => e.AssignedTo)
                    .HasMaxLength(50)
                    .HasColumnName("Assigned_To");

                entity.Property(e => e.CompanyBerkas)
                    .HasMaxLength(200)
                    .HasColumnName("Company_Berkas");

                entity.Property(e => e.CompanyBerkasId)
                    .HasMaxLength(50)
                    .HasColumnName("Company_Berkas_Id");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(50)
                    .HasColumnName("Company_Code");

                entity.Property(e => e.ContactPersonEmail)
                    .HasMaxLength(200)
                    .HasColumnName("Contact_Person_Email");

                entity.Property(e => e.ContactPersonMobileNumber)
                    .HasMaxLength(200)
                    .HasColumnName("Contact_Person_Mobile_Number");

                entity.Property(e => e.ContactPersonName)
                    .HasMaxLength(200)
                    .HasColumnName("Contact_Person_Name");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.Direktorat).HasMaxLength(200);

                entity.Property(e => e.DirektoratBerkas)
                    .HasMaxLength(200)
                    .HasColumnName("Direktorat_Berkas");

                entity.Property(e => e.DirektoratBerkasId)
                    .HasMaxLength(50)
                    .HasColumnName("Direktorat_Berkas_Id");

                entity.Property(e => e.DirektoratId)
                    .HasMaxLength(50)
                    .HasColumnName("Direktorat_Id");

                entity.Property(e => e.FileTransferHeaderSenderId).HasColumnName("File_Transfer_Header_Sender_Id");

                entity.Property(e => e.FormatDigitalId).HasColumnName("Format_Digital_Id");

                entity.Property(e => e.Fungsi).HasMaxLength(200);

                entity.Property(e => e.FungsiBerkas)
                    .HasMaxLength(200)
                    .HasColumnName("Fungsi_Berkas");

                entity.Property(e => e.FungsiBerkasId)
                    .HasMaxLength(50)
                    .HasColumnName("Fungsi_Berkas_Id");

                entity.Property(e => e.FungsiId)
                    .HasMaxLength(50)
                    .HasColumnName("Fungsi_Id");

                entity.Property(e => e.InactiveArchiveManagementInventoryId).HasColumnName("Inactive_Archive_Management_Inventory_Id");

                entity.Property(e => e.InventoryNumber)
                    .HasMaxLength(50)
                    .HasColumnName("Inventory_Number");

                entity.Property(e => e.JumlahBerkas).HasColumnName("Jumlah_Berkas");

                entity.Property(e => e.Kbo)
                    .HasMaxLength(200)
                    .HasColumnName("KBO");

                entity.Property(e => e.NamaPimpinan)
                    .HasMaxLength(200)
                    .HasColumnName("Nama_Pimpinan");

                entity.Property(e => e.NoSkOrganisasi)
                    .HasMaxLength(200)
                    .HasColumnName("No_SK_Organisasi");

                entity.Property(e => e.RequestNumber)
                    .HasMaxLength(50)
                    .HasColumnName("Request_Number");

                entity.Property(e => e.StatusId).HasColumnName("Status_Id");

                entity.Property(e => e.SubmittedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Submitted_By");

                entity.Property(e => e.SubmittedDate).HasColumnName("Submitted_Date");

                entity.Property(e => e.TempatPelaksanaan)
                    .HasMaxLength(200)
                    .HasColumnName("Tempat_Pelaksanaan");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.HasOne(d => d.FileTransferHeaderSender)
                    .WithMany(p => p.TbltAlihMediaHeaderSenders)
                    .HasForeignKey(d => d.FileTransferHeaderSenderId)
                    .HasConstraintName("FK_TBLT_Alih_Media_Header_Sender_TBLT_File_Transfer_Header_Sender");

                entity.HasOne(d => d.FormatDigital)
                    .WithMany(p => p.TbltAlihMediaHeaderSenders)
                    .HasForeignKey(d => d.FormatDigitalId)
                    .HasConstraintName("FK_TBLT_Alih_Media_Header_Sender_TBLM_Jenis_Media");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TbltAlihMediaHeaderSenders)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_TBLT_Alih_Media_Header_Sender_TBLM_Alih_Media_Status_File");
            });

            modelBuilder.Entity<TbltAlihMediaHistory>(entity =>
            {
                entity.ToTable("TBLT_Alih_Media_History");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AlihMediaHeaderSenderId).HasColumnName("Alih_Media_Header_Sender_Id");

                entity.Property(e => e.AlihMediaStatusFileId).HasColumnName("Alih_Media_Status_File_Id");

                entity.Property(e => e.CommentsText)
                    .HasMaxLength(1000)
                    .HasColumnName("Comments_Text");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.MenuText)
                    .HasMaxLength(1000)
                    .HasColumnName("Menu_Text");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(200)
                    .HasColumnName("Status_Name");

                entity.Property(e => e.StepCode)
                    .HasMaxLength(50)
                    .HasColumnName("Step_Code");

                entity.Property(e => e.SubmenuText)
                    .HasMaxLength(1000)
                    .HasColumnName("Submenu_Text");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.Property(e => e.UserPelaku)
                    .HasMaxLength(200)
                    .HasColumnName("User_Pelaku");

                entity.HasOne(d => d.AlihMediaHeaderSender)
                    .WithMany(p => p.TbltAlihMediaHistories)
                    .HasForeignKey(d => d.AlihMediaHeaderSenderId)
                    .HasConstraintName("FK_TBLT_Alih_Media_History_TBLT_Alih_Media_Header_Sender");

                entity.HasOne(d => d.AlihMediaStatusFile)
                    .WithMany(p => p.TbltAlihMediaHistories)
                    .HasForeignKey(d => d.AlihMediaStatusFileId)
                    .HasConstraintName("FK_TBLT_Alih_Media_History_TBLM_Alih_Media_Status_File");
            });

            modelBuilder.Entity<TbltAlihMediaInventory>(entity =>
            {
                entity.ToTable("TBLT_Alih_Media_Inventory");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AlihMediaHeaderSenderId).HasColumnName("Alih_Media_Header_Sender_Id");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.InactiveArchiveManagementHeaderSenderId).HasColumnName("Inactive_Archive_Management_Header_Sender_Id");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.HasOne(d => d.AlihMediaHeaderSender)
                    .WithMany(p => p.TbltAlihMediaInventories)
                    .HasForeignKey(d => d.AlihMediaHeaderSenderId)
                    .HasConstraintName("FK_TBLT_Alih_Media_Inventory_TBLT_Alih_Media_Header_Sender");

                entity.HasOne(d => d.InactiveArchiveManagementHeaderSender)
                    .WithMany(p => p.TbltAlihMediaInventories)
                    .HasForeignKey(d => d.InactiveArchiveManagementHeaderSenderId)
                    .HasConstraintName("FK_TBLT_Alih_Media_Inventory_TBLT_IAM_Header_Sender");
            });

            modelBuilder.Entity<TbltAlihMediaItem>(entity =>
            {
                entity.ToTable("TBLT_Alih_Media_Item");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AlihMediaFileId).HasColumnName("Alih_Media_File_Id");

                entity.Property(e => e.BentukItemId).HasColumnName("Bentuk_Item_Id");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.FileNameSystem)
                    .HasMaxLength(200)
                    .HasColumnName("File_Name_System");

                entity.Property(e => e.FileNameSystemAlihMedia)
                    .HasMaxLength(200)
                    .HasColumnName("File_Name_System_Alih_Media");

                entity.Property(e => e.FileNameUser)
                    .HasMaxLength(200)
                    .HasColumnName("File_Name_User");

                entity.Property(e => e.FileNameUserAlihMedia)
                    .HasMaxLength(200)
                    .HasColumnName("File_Name_User_Alih_Media");

                entity.Property(e => e.InactiveArchiveManagementItemId).HasColumnName("Inactive_Archive_Management_Item_Id");

                entity.Property(e => e.IsDone).HasColumnName("Is_Done");

                entity.Property(e => e.IsUpload).HasColumnName("Is_Upload");

                entity.Property(e => e.NoItemArsip)
                    .HasMaxLength(100)
                    .HasColumnName("No_Item_Arsip");

                entity.Property(e => e.TingkatPerkembanganDokumenId).HasColumnName("Tingkat_Perkembangan_Dokumen_Id");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.Property(e => e.UraianInformasi).HasColumnName("Uraian_Informasi");

                entity.HasOne(d => d.AlihMediaFile)
                    .WithMany(p => p.TbltAlihMediaItems)
                    .HasForeignKey(d => d.AlihMediaFileId)
                    .HasConstraintName("FK_TBLT_Alih_Media_Item_TBLT_Alih_Media_File");

                entity.HasOne(d => d.BentukItem)
                    .WithMany(p => p.TbltAlihMediaItems)
                    .HasForeignKey(d => d.BentukItemId)
                    .HasConstraintName("FK_TBLT_Alih_Media_Item_TBLM_Bentuk_Item");

                entity.HasOne(d => d.InactiveArchiveManagementItem)
                    .WithMany(p => p.TbltAlihMediaItems)
                    .HasForeignKey(d => d.InactiveArchiveManagementItemId)
                    .HasConstraintName("FK_TBLT_Alih_Media_Item_TBLT_Inactive_Archive_Management_Item");

                entity.HasOne(d => d.TingkatPerkembanganDokumen)
                    .WithMany(p => p.TbltAlihMediaItems)
                    .HasForeignKey(d => d.TingkatPerkembanganDokumenId)
                    .HasConstraintName("FK_TBLT_Alih_Media_Item_TBLM_Tingkat_Perkembangan_Document");
            });

            modelBuilder.Entity<TbltAlihMediaProposal>(entity =>
            {
                entity.ToTable("TBLT_Alih_Media_Proposal");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AlihMediaFileId).HasColumnName("Alih_Media_File_Id");

                entity.Property(e => e.AlihMediaHeaderSenderId).HasColumnName("Alih_Media_Header_Sender_Id");

                entity.Property(e => e.Biaya).HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.JenisMediaId).HasColumnName("Jenis_Media_Id");

                entity.Property(e => e.JenisMediaMenjadiId).HasColumnName("Jenis_Media_Menjadi_Id");

                entity.Property(e => e.JumlahHalaman).HasColumnName("Jumlah_Halaman");

                entity.Property(e => e.Keterangan).HasMaxLength(1000);

                entity.Property(e => e.PerangkatId).HasColumnName("Perangkat_Id");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.Property(e => e.WaktuAkhir).HasColumnName("Waktu_Akhir");

                entity.Property(e => e.WaktuAwal).HasColumnName("Waktu_Awal");

                entity.HasOne(d => d.AlihMediaFile)
                    .WithMany(p => p.TbltAlihMediaProposals)
                    .HasForeignKey(d => d.AlihMediaFileId)
                    .HasConstraintName("FK_TBLT_Alih_Media_Proposal_TBLT_File_Transfer_File");

                entity.HasOne(d => d.AlihMediaHeaderSender)
                    .WithMany(p => p.TbltAlihMediaProposals)
                    .HasForeignKey(d => d.AlihMediaHeaderSenderId)
                    .HasConstraintName("FK_TBLT_Alih_Media_Proposal_TBLT_Alih_Media_Header_Sender");

                entity.HasOne(d => d.JenisMedia)
                    .WithMany(p => p.TbltAlihMediaProposals)
                    .HasForeignKey(d => d.JenisMediaId)
                    .HasConstraintName("FK_TBLT_Alih_Media_Proposal_TBLM_Jenis_Media");

                entity.HasOne(d => d.Perangkat)
                    .WithMany(p => p.TbltAlihMediaProposals)
                    .HasForeignKey(d => d.PerangkatId)
                    .HasConstraintName("FK_TBLT_Alih_Media_Proposal_TBLM_Perangkat");
            });

            modelBuilder.Entity<TbltAlihMediaSignParallel>(entity =>
            {
                entity.ToTable("TBLT_Alih_Media_Sign_Parallel");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AlihMediaSigningId).HasColumnName("Alih_Media_Signing_Id");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.DocumentId).HasColumnName("Document_Id");

                entity.Property(e => e.FileName)
                    .HasMaxLength(200)
                    .HasColumnName("File_Name");

                entity.Property(e => e.ProcessId).HasColumnName("Process_Id");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.HasOne(d => d.AlihMediaSigning)
                    .WithMany(p => p.TbltAlihMediaSignParallels)
                    .HasForeignKey(d => d.AlihMediaSigningId)
                    .HasConstraintName("FK_TBLT_Alih_Media_Sign_Parallel_TBLT_Alih_Media_Signing");
            });

            modelBuilder.Entity<TbltAlihMediaSigning>(entity =>
            {
                entity.ToTable("TBLT_Alih_Media_Signing");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AlihMediaHeaderSenderId).HasColumnName("Alih_Media_Header_Sender_Id");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(200)
                    .HasColumnName("Approved_By");

                entity.Property(e => e.ApprovedDate).HasColumnName("Approved_Date");

                entity.Property(e => e.AssignedBy)
                    .HasMaxLength(200)
                    .HasColumnName("Assigned_By");

                entity.Property(e => e.AssignedDate).HasColumnName("Assigned_Date");

                entity.Property(e => e.AssignedTo)
                    .HasMaxLength(200)
                    .HasColumnName("Assigned_To");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(50)
                    .HasColumnName("Company_Code");

                entity.Property(e => e.ContactPersonEmail)
                    .HasMaxLength(200)
                    .HasColumnName("Contact_Person_Email");

                entity.Property(e => e.ContactPersonName)
                    .HasMaxLength(200)
                    .HasColumnName("Contact_Person_Name");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.Direktorat).HasMaxLength(200);

                entity.Property(e => e.DirektoratId)
                    .HasMaxLength(50)
                    .HasColumnName("Direktorat_Id");

                entity.Property(e => e.FileNameSystem)
                    .HasMaxLength(200)
                    .HasColumnName("File_Name_System");

                entity.Property(e => e.Fungsi).HasMaxLength(200);

                entity.Property(e => e.FungsiId)
                    .HasMaxLength(200)
                    .HasColumnName("Fungsi_Id");

                entity.Property(e => e.JumlahBerkas).HasColumnName("Jumlah_Berkas");

                entity.Property(e => e.Kbo)
                    .HasMaxLength(200)
                    .HasColumnName("KBO");

                entity.Property(e => e.RequestNumber)
                    .HasMaxLength(50)
                    .HasColumnName("Request_Number");

                entity.Property(e => e.StatusId).HasColumnName("Status_Id");

                entity.Property(e => e.StatusSigning).HasColumnName("Status_Signing");

                entity.Property(e => e.SubmittedBy)
                    .HasMaxLength(200)
                    .HasColumnName("Submitted_By");

                entity.Property(e => e.SubmittedDate).HasColumnName("Submitted_Date");

                entity.Property(e => e.SurveyBy)
                    .HasMaxLength(200)
                    .HasColumnName("Survey_By");

                entity.Property(e => e.SurveyDate).HasColumnName("Survey_Date");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.HasOne(d => d.AlihMediaHeaderSender)
                    .WithMany(p => p.TbltAlihMediaSignings)
                    .HasForeignKey(d => d.AlihMediaHeaderSenderId)
                    .HasConstraintName("FK_TBLT_Alih_Media_Signing_TBLT_Alih_Media_Header_Sender");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TbltAlihMediaSignings)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_TBLT_Alih_Media_Signing_TBLM_Alih_Media_Signing_Status_File");
            });

            modelBuilder.Entity<TbltAlihMediaSigningHistory>(entity =>
            {
                entity.ToTable("TBLT_Alih_Media_Signing_History");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AlihMediaSigningId).HasColumnName("Alih_Media_Signing_Id");

                entity.Property(e => e.AlihMediaSigningStatusFileId).HasColumnName("Alih_Media_Signing_Status_File_Id");

                entity.Property(e => e.CommentsText)
                    .HasMaxLength(1000)
                    .HasColumnName("Comments_Text");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.MenuText)
                    .HasMaxLength(1000)
                    .HasColumnName("Menu_Text");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(1000)
                    .HasColumnName("Status_Name");

                entity.Property(e => e.StepCode)
                    .HasMaxLength(50)
                    .HasColumnName("Step_Code");

                entity.Property(e => e.SubmenuText)
                    .HasMaxLength(1000)
                    .HasColumnName("Submenu_Text");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.Property(e => e.UserPelaku)
                    .HasMaxLength(1000)
                    .HasColumnName("User_Pelaku");

                entity.HasOne(d => d.AlihMediaSigning)
                    .WithMany(p => p.TbltAlihMediaSigningHistories)
                    .HasForeignKey(d => d.AlihMediaSigningId)
                    .HasConstraintName("FK_TBLT_Alih_Media_Signing_History_TBLT_Alih_Media_Signing");

                entity.HasOne(d => d.AlihMediaSigningStatusFile)
                    .WithMany(p => p.TbltAlihMediaSigningHistories)
                    .HasForeignKey(d => d.AlihMediaSigningStatusFileId)
                    .HasConstraintName("FK_TBLT_Alih_Media_Signing_History_TBLM_Alih_Media_Signing_Status_File");
            });

            modelBuilder.Entity<TbltEmailStatus>(entity =>
            {
                entity.ToTable("TBLT_Email_Status");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.EmailSentTo).HasMaxLength(1000);

                entity.Property(e => e.EmailStatus).HasMaxLength(50);

                entity.Property(e => e.EmailSubject).HasMaxLength(1000);

                entity.Property(e => e.FeatureName).HasMaxLength(100);
            });

            modelBuilder.Entity<TbltFileSigning>(entity =>
            {
                entity.ToTable("TBLT_File_Signing");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.FileTransferSigningId).HasColumnName("File_Transfer_Signing_Id");

                entity.Property(e => e.RoleId).HasColumnName("Role_Id");

                entity.Property(e => e.RoleName).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.Property(e => e.Username).HasMaxLength(200);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.TbltFileSignings)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_TBLT_File_Signing_TBLM_Role");
            });

            modelBuilder.Entity<TbltFileTransferFile>(entity =>
            {
                entity.ToTable("TBLT_File_Transfer_File");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.FileTransferHeaderSenderId).HasColumnName("File_Transfer_Header_Sender_Id");

                entity.Property(e => e.JenisSeriesArsip)
                    .HasMaxLength(200)
                    .HasColumnName("Jenis_Series_Arsip");

                entity.Property(e => e.JumlahBerkas).HasColumnName("Jumlah_Berkas");

                entity.Property(e => e.KategoriArsipId).HasColumnName("Kategori_Arsip_Id");

                entity.Property(e => e.KeteranganAksesKeamananId).HasColumnName("Keterangan_Akses_Keamanan_Id");

                entity.Property(e => e.KeteranganRetensi)
                    .HasMaxLength(200)
                    .HasColumnName("Keterangan_Retensi");

                entity.Property(e => e.KodeSubPemberkasanId).HasColumnName("Kode_Sub_Pemberkasan_Id");

                entity.Property(e => e.KurunWaktuBerkasAkhir).HasColumnName("Kurun_Waktu_Berkas_Akhir");

                entity.Property(e => e.KurunWaktuBerkasMulai).HasColumnName("Kurun_Waktu_Berkas_Mulai");

                entity.Property(e => e.LokasiTersimpan)
                    .HasMaxLength(200)
                    .HasColumnName("Lokasi_Tersimpan");

                entity.Property(e => e.NamaBerkas)
                    .HasMaxLength(200)
                    .HasColumnName("Nama_Berkas");

                entity.Property(e => e.Nominal).HasMaxLength(200);

                entity.Property(e => e.RequestNumber)
                    .HasMaxLength(200)
                    .HasColumnName("Request_Number");

                entity.Property(e => e.RetensiAktif).HasColumnName("Retensi_Aktif");

                entity.Property(e => e.RetensiAktifText)
                    .HasMaxLength(100)
                    .HasColumnName("Retensi_Aktif_Text");

                entity.Property(e => e.RetensiInaktif).HasColumnName("Retensi_Inaktif");

                entity.Property(e => e.RetensiInaktifText)
                    .HasMaxLength(100)
                    .HasColumnName("Retensi_Inaktif_Text");

                entity.Property(e => e.StatusSurvey).HasColumnName("Status_Survey");

                entity.Property(e => e.TingkatPerkembanganBerkasId).HasColumnName("Tingkat_Perkembangan_Berkas_Id");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.Property(e => e.UraianInformasi).HasColumnName("Uraian_Informasi");

                entity.HasOne(d => d.FileTransferHeaderSender)
                    .WithMany(p => p.TbltFileTransferFiles)
                    .HasForeignKey(d => d.FileTransferHeaderSenderId)
                    .HasConstraintName("FK_TBLT_File_Transfer_File_TBLT_File_Transfer_Header_Sender");

                entity.HasOne(d => d.KategoriArsip)
                    .WithMany(p => p.TbltFileTransferFiles)
                    .HasForeignKey(d => d.KategoriArsipId)
                    .HasConstraintName("FK_TBLT_File_TBLM_Kategori_Arsip");

                entity.HasOne(d => d.KeteranganAksesKeamanan)
                    .WithMany(p => p.TbltFileTransferFiles)
                    .HasForeignKey(d => d.KeteranganAksesKeamananId)
                    .HasConstraintName("FK_TBLT_File_TBLM_Keterangan_Akses_Keamanan");

                entity.HasOne(d => d.KodeSubPemberkasan)
                    .WithMany(p => p.TbltFileTransferFiles)
                    .HasForeignKey(d => d.KodeSubPemberkasanId)
                    .HasConstraintName("FK_TBLT_File_Transfer_File_TBLM_Kode_Sub_Pemberkasan");

                entity.HasOne(d => d.TingkatPerkembanganBerkas)
                    .WithMany(p => p.TbltFileTransferFiles)
                    .HasForeignKey(d => d.TingkatPerkembanganBerkasId)
                    .HasConstraintName("FK_TBLT_File_TBLM_Tingkat_Perkembangan_Dokumen");
            });

            modelBuilder.Entity<TbltFileTransferHeaderSender>(entity =>
            {
                entity.ToTable("TBLT_File_Transfer_Header_Sender");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Alamat).HasMaxLength(200);

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Approved_By");

                entity.Property(e => e.ApprovedDate).HasColumnName("Approved_Date");

                entity.Property(e => e.AssignedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Assigned_By");

                entity.Property(e => e.AssignedDate).HasColumnName("Assigned_Date");

                entity.Property(e => e.AssignedTo)
                    .HasMaxLength(50)
                    .HasColumnName("Assigned_To");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(50)
                    .HasColumnName("Company_Code");

                entity.Property(e => e.ContactPersonEmail)
                    .HasMaxLength(200)
                    .HasColumnName("Contact_Person_Email");

                entity.Property(e => e.ContactPersonMobileNumber)
                    .HasMaxLength(200)
                    .HasColumnName("Contact_Person_Mobile_Number");

                entity.Property(e => e.ContactPersonName)
                    .HasMaxLength(200)
                    .HasColumnName("Contact_Person_Name");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.Direktorat).HasMaxLength(200);

                entity.Property(e => e.DirektoratId)
                    .HasMaxLength(50)
                    .HasColumnName("Direktorat_Id");

                entity.Property(e => e.FileTransferSigningId).HasColumnName("File_Transfer_Signing_Id");

                entity.Property(e => e.Fungsi).HasMaxLength(200);

                entity.Property(e => e.FungsiId)
                    .HasMaxLength(200)
                    .HasColumnName("Fungsi_Id");

                entity.Property(e => e.Kbo)
                    .HasMaxLength(200)
                    .HasColumnName("KBO");

                entity.Property(e => e.NamaPimpinan)
                    .HasMaxLength(200)
                    .HasColumnName("Nama_Pimpinan");

                entity.Property(e => e.NoSkOrganisasi)
                    .HasMaxLength(200)
                    .HasColumnName("No_SK_Organisasi");

                entity.Property(e => e.RequestNumber)
                    .HasMaxLength(50)
                    .HasColumnName("Request_Number");

                entity.Property(e => e.StatusId).HasColumnName("Status_Id");

                entity.Property(e => e.SubmittedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Submitted_By");

                entity.Property(e => e.SubmittedDate).HasColumnName("Submitted_Date");

                entity.Property(e => e.SurveyBy)
                    .HasMaxLength(50)
                    .HasColumnName("Survey_By");

                entity.Property(e => e.SurveyDate).HasColumnName("Survey_Date");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.HasOne(d => d.FileTransferSigning)
                    .WithMany(p => p.TbltFileTransferHeaderSenders)
                    .HasForeignKey(d => d.FileTransferSigningId)
                    .HasConstraintName("FK_TBLT_File_Transfer_Header_Sender_TBLT_File_Transfer_Signing");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TbltFileTransferHeaderSenders)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_TBLT_File_Transfer_Header_Sender_TBLM_File_Transfer_Status_File");
            });

            modelBuilder.Entity<TbltFileTransferHistory>(entity =>
            {
                entity.ToTable("TBLT_File_Transfer_History");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CommentsText)
                    .HasMaxLength(1000)
                    .HasColumnName("Comments_Text");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.FileTransferHeaderSenderId).HasColumnName("File_Transfer_Header_Sender_Id");

                entity.Property(e => e.FileTransferStatusFileId).HasColumnName("File_Transfer_Status_File_Id");

                entity.Property(e => e.MenuText)
                    .HasMaxLength(1000)
                    .HasColumnName("Menu_Text");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(1000)
                    .HasColumnName("Status_Name");

                entity.Property(e => e.StepCode)
                    .HasMaxLength(50)
                    .HasColumnName("Step_Code");

                entity.Property(e => e.SubmenuText)
                    .HasMaxLength(1000)
                    .HasColumnName("Submenu_Text");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.Property(e => e.UserPelaku)
                    .HasMaxLength(1000)
                    .HasColumnName("User_Pelaku");

                entity.HasOne(d => d.FileTransferHeaderSender)
                    .WithMany(p => p.TbltFileTransferHistories)
                    .HasForeignKey(d => d.FileTransferHeaderSenderId)
                    .HasConstraintName("FK_TBLT_File_Transfer_History_TBLT_File_Transfer_Header_Sender");

                entity.HasOne(d => d.FileTransferStatusFile)
                    .WithMany(p => p.TbltFileTransferHistories)
                    .HasForeignKey(d => d.FileTransferStatusFileId)
                    .HasConstraintName("FK_TBLT_File_Transfer_History_TBLM_File_Transfer_Status_File");
            });

            modelBuilder.Entity<TbltFileTransferItem>(entity =>
            {
                entity.ToTable("TBLT_File_Transfer_Item");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BentukItemId).HasColumnName("Bentuk_Item_Id");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.FileNameSystem)
                    .HasMaxLength(200)
                    .HasColumnName("File_Name_System");

                entity.Property(e => e.FileNameUser)
                    .HasMaxLength(200)
                    .HasColumnName("File_Name_User");

                entity.Property(e => e.FileTransferFileId).HasColumnName("File_Transfer_File_Id");

                entity.Property(e => e.NoItemArsip)
                    .HasMaxLength(100)
                    .HasColumnName("No_Item_Arsip");

                entity.Property(e => e.TingkatPerkembanganDokumenId).HasColumnName("Tingkat_Perkembangan_Dokumen_Id");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.Property(e => e.UraianInformasi).HasColumnName("Uraian_Informasi");

                entity.HasOne(d => d.BentukItem)
                    .WithMany(p => p.TbltFileTransferItems)
                    .HasForeignKey(d => d.BentukItemId)
                    .HasConstraintName("FK_TBLT_File_Transfer_Item_TBLM_Bentuk_Item");

                entity.HasOne(d => d.FileTransferFile)
                    .WithMany(p => p.TbltFileTransferItems)
                    .HasForeignKey(d => d.FileTransferFileId)
                    .HasConstraintName("FK_TBLT_File_Transfer_Item_TBLT_File_Transfer_File");

                entity.HasOne(d => d.TingkatPerkembanganDokumen)
                    .WithMany(p => p.TbltFileTransferItems)
                    .HasForeignKey(d => d.TingkatPerkembanganDokumenId)
                    .HasConstraintName("FK_TBLT_Item_TBLM_Tingkat_Perkembangan_Dokumen");
            });

            modelBuilder.Entity<TbltFileTransferSignParallel>(entity =>
            {
                entity.ToTable("TBLT_File_Transfer_Sign_Parallel");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.DocumentId).HasColumnName("Document_Id");

                entity.Property(e => e.FileName)
                    .HasMaxLength(200)
                    .HasColumnName("File_Name");

                entity.Property(e => e.FileTransferSigningId).HasColumnName("File_Transfer_Signing_Id");

                entity.Property(e => e.ProcessId).HasColumnName("Process_Id");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");
            });

            modelBuilder.Entity<TbltFileTransferSigning>(entity =>
            {
                entity.ToTable("TBLT_File_Transfer_Signing");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(200)
                    .HasColumnName("Approved_By");

                entity.Property(e => e.ApprovedDate).HasColumnName("Approved_Date");

                entity.Property(e => e.AssignedBy)
                    .HasMaxLength(200)
                    .HasColumnName("Assigned_By");

                entity.Property(e => e.AssignedDate).HasColumnName("Assigned_Date");

                entity.Property(e => e.AssignedTo)
                    .HasMaxLength(200)
                    .HasColumnName("Assigned_To");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(50)
                    .HasColumnName("Company_Code");

                entity.Property(e => e.ContactPersonEmail)
                    .HasMaxLength(200)
                    .HasColumnName("Contact_Person_Email");

                entity.Property(e => e.ContactPersonName)
                    .HasMaxLength(200)
                    .HasColumnName("Contact_Person_Name");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.Direktorat).HasMaxLength(200);

                entity.Property(e => e.DirektoratId)
                    .HasMaxLength(50)
                    .HasColumnName("Direktorat_Id");

                entity.Property(e => e.FileNameSystem)
                    .HasMaxLength(200)
                    .HasColumnName("File_Name_System");

                entity.Property(e => e.FileTransferHeaderSenderId).HasColumnName("File_Transfer_Header_Sender_Id");

                entity.Property(e => e.Fungsi).HasMaxLength(200);

                entity.Property(e => e.FungsiId)
                    .HasMaxLength(200)
                    .HasColumnName("Fungsi_Id");

                entity.Property(e => e.JumlahBerkas).HasColumnName("Jumlah_Berkas");

                entity.Property(e => e.Kbo)
                    .HasMaxLength(200)
                    .HasColumnName("KBO");

                entity.Property(e => e.RequestNumber)
                    .HasMaxLength(50)
                    .HasColumnName("Request_Number");

                entity.Property(e => e.StatusId).HasColumnName("Status_Id");

                entity.Property(e => e.StatusSigning).HasColumnName("Status_Signing");

                entity.Property(e => e.SubmittedBy)
                    .HasMaxLength(200)
                    .HasColumnName("Submitted_By");

                entity.Property(e => e.SubmittedDate).HasColumnName("Submitted_Date");

                entity.Property(e => e.SurveyBy)
                    .HasMaxLength(200)
                    .HasColumnName("Survey_By");

                entity.Property(e => e.SurveyDate).HasColumnName("Survey_Date");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.HasOne(d => d.FileTransferHeaderSender)
                    .WithMany(p => p.TbltFileTransferSignings)
                    .HasForeignKey(d => d.FileTransferHeaderSenderId)
                    .HasConstraintName("FK_TBLT_File_Transfer_Signing_TBLT_File_Transfer_Header_Sender");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TbltFileTransferSignings)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_TBLT_File_Transfer_Signing_TBLM_File_Transfer_Signing_Status_File");
            });

            modelBuilder.Entity<TbltFileTransferSigningHistory>(entity =>
            {
                entity.ToTable("TBLT_File_Transfer_Signing_History");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CommentsText)
                    .HasMaxLength(1000)
                    .HasColumnName("Comments_Text");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.FileTransferSigningId).HasColumnName("File_Transfer_Signing_Id");

                entity.Property(e => e.FileTransferSigningStatusFileId).HasColumnName("File_Transfer_Signing_Status_File_Id");

                entity.Property(e => e.MenuText)
                    .HasMaxLength(1000)
                    .HasColumnName("Menu_Text");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(1000)
                    .HasColumnName("Status_Name");

                entity.Property(e => e.StepCode)
                    .HasMaxLength(50)
                    .HasColumnName("Step_Code");

                entity.Property(e => e.SubmenuText)
                    .HasMaxLength(1000)
                    .HasColumnName("Submenu_Text");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.Property(e => e.UserPelaku)
                    .HasMaxLength(1000)
                    .HasColumnName("User_Pelaku");

                entity.HasOne(d => d.FileTransferSigning)
                    .WithMany(p => p.TbltFileTransferSigningHistories)
                    .HasForeignKey(d => d.FileTransferSigningId)
                    .HasConstraintName("FK_TBLT_File_Transfer_Signing_History_TBLT_File_Transfer_Signing");

                entity.HasOne(d => d.FileTransferSigningStatusFile)
                    .WithMany(p => p.TbltFileTransferSigningHistories)
                    .HasForeignKey(d => d.FileTransferSigningStatusFileId)
                    .HasConstraintName("FK_TBLT_File_Transfer_Signing_History_TBLM_File_Transfer_Signing_Status_File");
            });

            modelBuilder.Entity<TbltFileTransferSurvey>(entity =>
            {
                entity.ToTable("TBLT_File_Transfer_Survey");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BerkasArsipId).HasColumnName("Berkas_Arsip_Id");

                entity.Property(e => e.Catatan).HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.FileNameSystem)
                    .HasMaxLength(200)
                    .HasColumnName("File_Name_System");

                entity.Property(e => e.FileNameUser)
                    .HasMaxLength(200)
                    .HasColumnName("File_Name_User");

                entity.Property(e => e.FileTransferHeaderSenderId).HasColumnName("File_Transfer_Header_Sender_Id");

                entity.Property(e => e.FileTransferStatusFileId).HasColumnName("File_Transfer_Status_File_Id");

                entity.Property(e => e.KondisiArsipId).HasColumnName("Kondisi_Arsip_Id");

                entity.Property(e => e.KurunWaktu).HasColumnName("Kurun_Waktu");

                entity.Property(e => e.LokasiArsip)
                    .HasMaxLength(100)
                    .HasColumnName("Lokasi_Arsip");

                entity.Property(e => e.MediaArsip)
                    .HasMaxLength(50)
                    .HasColumnName("Media_Arsip");

                entity.Property(e => e.NomorPermintaan)
                    .HasMaxLength(50)
                    .HasColumnName("Nomor_Permintaan");

                entity.Property(e => e.PelaksanaSurvey)
                    .HasMaxLength(100)
                    .HasColumnName("Pelaksana_Survey");

                entity.Property(e => e.PenanggungJawabFungsi)
                    .HasMaxLength(100)
                    .HasColumnName("Penanggung_Jawab_Fungsi");

                entity.Property(e => e.RcPenyimpananId).HasColumnName("RC_Penyimpanan_Id");

                entity.Property(e => e.RekomendasiArsipId).HasColumnName("Rekomendasi_Arsip_Id");

                entity.Property(e => e.RetensiArsipId).HasColumnName("Retensi_Arsip_Id");

                entity.Property(e => e.SaranaSimpanId).HasColumnName("Sarana_Simpan_Id");

                entity.Property(e => e.SistemPenataan)
                    .HasMaxLength(50)
                    .HasColumnName("Sistem_Penataan");

                entity.Property(e => e.TanggalSurvey).HasColumnName("Tanggal_Survey");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.HasOne(d => d.BerkasArsip)
                    .WithMany(p => p.TbltFileTransferSurveyBerkasArsips)
                    .HasForeignKey(d => d.BerkasArsipId)
                    .HasConstraintName("FK_TBLT_File_Transfer_Survey_Berkas_Arsip_TBLM_Kesesuaian_Daftar_Fisik_Arsip");

                entity.HasOne(d => d.FileTransferHeaderSender)
                    .WithMany(p => p.TbltFileTransferSurveys)
                    .HasForeignKey(d => d.FileTransferHeaderSenderId)
                    .HasConstraintName("FK_TBLT_File_Transfer_Survey_TBLT_File_Transfer_Header_Sender");

                entity.HasOne(d => d.KondisiArsip)
                    .WithMany(p => p.TbltFileTransferSurveys)
                    .HasForeignKey(d => d.KondisiArsipId)
                    .HasConstraintName("FK_TBLT_File_Transfer_Survey_TBLM_Kondisi_Arsip");

                entity.HasOne(d => d.RcPenyimpanan)
                    .WithMany(p => p.TbltFileTransferSurveys)
                    .HasForeignKey(d => d.RcPenyimpananId)
                    .HasConstraintName("FK_TBLT_File_Transfer_Survey_TBLM_RC_Penyimpanan");

                entity.HasOne(d => d.RekomendasiArsip)
                    .WithMany(p => p.TbltFileTransferSurveys)
                    .HasForeignKey(d => d.RekomendasiArsipId)
                    .HasConstraintName("FK_TBLT_File_Transfer_Survey_TBLM_Rekomendasi_Arsip");

                entity.HasOne(d => d.RetensiArsip)
                    .WithMany(p => p.TbltFileTransferSurveyRetensiArsips)
                    .HasForeignKey(d => d.RetensiArsipId)
                    .HasConstraintName("FK_TBLT_File_Transfer_Survey_Retensi_Arsip_TBLM_Kesesuaian_Daftar_Fisik_Arsip");

                entity.HasOne(d => d.SaranaSimpan)
                    .WithMany(p => p.TbltFileTransferSurveySaranaSimpans)
                    .HasForeignKey(d => d.SaranaSimpanId)
                    .HasConstraintName("FK_TBLT_File_Transfer_Survey_Sarana_Simpan_TBLM_Kesesuaian_Daftar_Fisik_Arsip");
            });

            modelBuilder.Entity<TbltInactiveActiveDocumentFile>(entity =>
            {
                entity.ToTable("TBLT_Inactive_Active_Document_File");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.FileTransferFileId).HasColumnName("File_Transfer_File_Id");

                entity.Property(e => e.InactiveActiveDocumentHeaderSenderId).HasColumnName("Inactive_Active_Document_Header_Sender_Id");

                entity.Property(e => e.JenisSeriesArsip)
                    .HasMaxLength(200)
                    .HasColumnName("Jenis_Series_Arsip");

                entity.Property(e => e.JumlahBerkas).HasColumnName("Jumlah_Berkas");

                entity.Property(e => e.KategoriArsipId).HasColumnName("Kategori_Arsip_Id");

                entity.Property(e => e.KeteranganAksesKeamananId).HasColumnName("Keterangan_Akses_Keamanan_Id");

                entity.Property(e => e.KeteranganRetensi)
                    .HasMaxLength(200)
                    .HasColumnName("Keterangan_Retensi");

                entity.Property(e => e.KodeSubPemberkasanId).HasColumnName("Kode_Sub_Pemberkasan_Id");

                entity.Property(e => e.KurunWaktuBerkasAkhir).HasColumnName("Kurun_Waktu_Berkas_Akhir");

                entity.Property(e => e.KurunWaktuBerkasMulai).HasColumnName("Kurun_Waktu_Berkas_Mulai");

                entity.Property(e => e.NamaBerkas)
                    .HasMaxLength(200)
                    .HasColumnName("Nama_Berkas");

                entity.Property(e => e.Nominal).HasMaxLength(200);

                entity.Property(e => e.NomorBoksSementara)
                    .HasMaxLength(200)
                    .HasColumnName("Nomor_Boks_Sementara");

                entity.Property(e => e.RequestNumber)
                    .HasMaxLength(200)
                    .HasColumnName("Request_Number");

                entity.Property(e => e.RetensiAktif).HasColumnName("Retensi_Aktif");

                entity.Property(e => e.RetensiAktifText)
                    .HasMaxLength(100)
                    .HasColumnName("Retensi_Aktif_Text");

                entity.Property(e => e.RetensiInaktif).HasColumnName("Retensi_Inaktif");

                entity.Property(e => e.RetensiInaktifText)
                    .HasMaxLength(100)
                    .HasColumnName("Retensi_Inaktif_Text");

                entity.Property(e => e.SelectedStatus).HasColumnName("Selected_Status");

                entity.Property(e => e.TingkatPerkembanganBerkasId).HasColumnName("Tingkat_Perkembangan_Berkas_Id");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.Property(e => e.UraianInformasi).HasColumnName("Uraian_Informasi");

                entity.HasOne(d => d.InactiveActiveDocumentHeaderSender)
                    .WithMany(p => p.TbltInactiveActiveDocumentFiles)
                    .HasForeignKey(d => d.InactiveActiveDocumentHeaderSenderId)
                    .HasConstraintName("FK_TBLT_Inactive_Active_Document_File_TBLT_Inactive_Active_Document_Header_Sender");

                entity.HasOne(d => d.KategoriArsip)
                    .WithMany(p => p.TbltInactiveActiveDocumentFiles)
                    .HasForeignKey(d => d.KategoriArsipId)
                    .HasConstraintName("FK_TBLT_Inactive_Active_Document_File_TBLM_Kategori_Arsip");

                entity.HasOne(d => d.KeteranganAksesKeamanan)
                    .WithMany(p => p.TbltInactiveActiveDocumentFiles)
                    .HasForeignKey(d => d.KeteranganAksesKeamananId)
                    .HasConstraintName("FK_TBLT_Inactive_Active_Document_File_TBLM_Keterangan_Akses_Keamanan");

                entity.HasOne(d => d.KodeSubPemberkasan)
                    .WithMany(p => p.TbltInactiveActiveDocumentFiles)
                    .HasForeignKey(d => d.KodeSubPemberkasanId)
                    .HasConstraintName("FK_TBLT_Inactive_Active_Document_File_TBLM_Kode_Sub_Pemberkasan");

                entity.HasOne(d => d.TingkatPerkembanganBerkas)
                    .WithMany(p => p.TbltInactiveActiveDocumentFiles)
                    .HasForeignKey(d => d.TingkatPerkembanganBerkasId)
                    .HasConstraintName("FK_TBLT_Inactive_Active_Document_File_TBLM_Tingkat_Perkembangan_Document");
            });

            modelBuilder.Entity<TbltInactiveActiveDocumentHeaderSender>(entity =>
            {
                entity.ToTable("TBLT_Inactive_Active_Document_Header_Sender");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ActiveDocumentHeaderSenderId).HasColumnName("Active_Document_Header_Sender_Id");

                entity.Property(e => e.Alamat).HasMaxLength(200);

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Approved_By");

                entity.Property(e => e.ApprovedDate).HasColumnName("Approved_Date");

                entity.Property(e => e.AssignedDate).HasColumnName("Assigned_Date");

                entity.Property(e => e.AssignedTo)
                    .HasMaxLength(50)
                    .HasColumnName("Assigned_To");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(50)
                    .HasColumnName("Company_Code");

                entity.Property(e => e.ContactPersonEmail)
                    .HasMaxLength(200)
                    .HasColumnName("Contact_Person_Email");

                entity.Property(e => e.ContactPersonMobileNumber)
                    .HasMaxLength(200)
                    .HasColumnName("Contact_Person_Mobile_Number");

                entity.Property(e => e.ContactPersonName)
                    .HasMaxLength(200)
                    .HasColumnName("Contact_Person_Name");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.Direktorat).HasMaxLength(200);

                entity.Property(e => e.DirektoratId)
                    .HasMaxLength(50)
                    .HasColumnName("Direktorat_Id");

                entity.Property(e => e.Fungsi).HasMaxLength(200);

                entity.Property(e => e.FungsiId)
                    .HasMaxLength(50)
                    .HasColumnName("Fungsi_Id");

                entity.Property(e => e.Kbo)
                    .HasMaxLength(200)
                    .HasColumnName("KBO");

                entity.Property(e => e.NamaPimpinan)
                    .HasMaxLength(200)
                    .HasColumnName("Nama_Pimpinan");

                entity.Property(e => e.NoSkOrganisasi)
                    .HasMaxLength(200)
                    .HasColumnName("No_SK_Organisasi");

                entity.Property(e => e.RequestNumber)
                    .HasMaxLength(50)
                    .HasColumnName("Request_Number");

                entity.Property(e => e.StatusId).HasColumnName("Status_Id");

                entity.Property(e => e.SubmittedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Submitted_By");

                entity.Property(e => e.SubmittedDate).HasColumnName("Submitted_Date");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.HasOne(d => d.ActiveDocumentHeaderSender)
                    .WithMany(p => p.TbltInactiveActiveDocumentHeaderSenders)
                    .HasForeignKey(d => d.ActiveDocumentHeaderSenderId)
                    .HasConstraintName("TBLT_Inactive_Active_Document_Header_Sender_TBLT_Active_Document_Header_Sender");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TbltInactiveActiveDocumentHeaderSenders)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_TBLT_Inactive_Active_Document_Header_Sender_TBLM_Inactive_Active_Document_Status_File");
            });

            modelBuilder.Entity<TbltInactiveActiveDocumentHistory>(entity =>
            {
                entity.ToTable("TBLT_Inactive_Active_Document_History");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CommentsText)
                    .HasMaxLength(1000)
                    .HasColumnName("Comments_Text");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.InactiveActiveDocumentHeaderSenderId).HasColumnName("Inactive_Active_Document_Header_Sender_Id");

                entity.Property(e => e.InactiveActiveDocumentStatusFileId).HasColumnName("Inactive_Active_Document_Status_File_Id");

                entity.Property(e => e.MenuText)
                    .HasMaxLength(1000)
                    .HasColumnName("Menu_Text");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(200)
                    .HasColumnName("Status_Name");

                entity.Property(e => e.StepCode)
                    .HasMaxLength(50)
                    .HasColumnName("Step_Code");

                entity.Property(e => e.SubmenuText)
                    .HasMaxLength(1000)
                    .HasColumnName("Submenu_Text");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.Property(e => e.UserPelaku)
                    .HasMaxLength(200)
                    .HasColumnName("User_Pelaku");

                entity.HasOne(d => d.InactiveActiveDocumentHeaderSender)
                    .WithMany(p => p.TbltInactiveActiveDocumentHistories)
                    .HasForeignKey(d => d.InactiveActiveDocumentHeaderSenderId)
                    .HasConstraintName("FK_TBLT_Inactive_Active_Document_History_TBLT_Inactive_Active_Document_Header_Sender");

                entity.HasOne(d => d.InactiveActiveDocumentStatusFile)
                    .WithMany(p => p.TbltInactiveActiveDocumentHistories)
                    .HasForeignKey(d => d.InactiveActiveDocumentStatusFileId)
                    .HasConstraintName("FK_TBLT_Inactive_Active_Document_History_TBLM_Inactive_Active_Document_Status_File");
            });

            modelBuilder.Entity<TbltInactiveActiveDocumentItem>(entity =>
            {
                entity.ToTable("TBLT_Inactive_Active_Document_Item");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BentukItemId).HasColumnName("Bentuk_Item_Id");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.FileNameSystem)
                    .HasMaxLength(200)
                    .HasColumnName("File_Name_System");

                entity.Property(e => e.FileNameUser)
                    .HasMaxLength(200)
                    .HasColumnName("File_Name_User");

                entity.Property(e => e.InactiveActiveDocumentFileId).HasColumnName("Inactive_Active_Document_File_Id");

                entity.Property(e => e.NoItemArsip)
                    .HasMaxLength(100)
                    .HasColumnName("No_Item_Arsip");

                entity.Property(e => e.TingkatPerkembanganDokumenId).HasColumnName("Tingkat_Perkembangan_Dokumen_Id");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.Property(e => e.UraianInformasi).HasColumnName("Uraian_Informasi");

                entity.HasOne(d => d.BentukItem)
                    .WithMany(p => p.TbltInactiveActiveDocumentItems)
                    .HasForeignKey(d => d.BentukItemId)
                    .HasConstraintName("FK_TBLT_Inactive_Active_Document_Item_TBLM_Bentuk_Item");

                entity.HasOne(d => d.InactiveActiveDocumentFile)
                    .WithMany(p => p.TbltInactiveActiveDocumentItems)
                    .HasForeignKey(d => d.InactiveActiveDocumentFileId)
                    .HasConstraintName("FK_TBLT_Inactive_Active_Document_Item_TBLT_Inactive_Active_Document_File");

                entity.HasOne(d => d.TingkatPerkembanganDokumen)
                    .WithMany(p => p.TbltInactiveActiveDocumentItems)
                    .HasForeignKey(d => d.TingkatPerkembanganDokumenId)
                    .HasConstraintName("FK_TBLT_Inactive_Active_Document_Item_TBLM_Tingkat_Perkembangan_Document");
            });

            modelBuilder.Entity<TbltInactiveArchiveManagementFile>(entity =>
            {
                entity.ToTable("TBLT_Inactive_Archive_Management_File");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.InactiveArchiveManagementHeaderSenderId).HasColumnName("Inactive_Archive_Management_Header_Sender_Id");

                entity.Property(e => e.IsSubmitAlihMedia).HasColumnName("Is_Submit_Alih_Media");

                entity.Property(e => e.JenisSeriesArsip)
                    .HasMaxLength(200)
                    .HasColumnName("Jenis_Series_Arsip");

                entity.Property(e => e.JumlahBerkas).HasColumnName("Jumlah_Berkas");

                entity.Property(e => e.KategoriArsipId).HasColumnName("Kategori_Arsip_Id");

                entity.Property(e => e.KeteranganAksesKeamananId).HasColumnName("Keterangan_Akses_Keamanan_Id");

                entity.Property(e => e.KeteranganRetensi)
                    .HasMaxLength(200)
                    .HasColumnName("Keterangan_Retensi");

                entity.Property(e => e.KodeSubPemberkasanId).HasColumnName("Kode_Sub_Pemberkasan_Id");

                entity.Property(e => e.KurunWaktuBerkasAkhir).HasColumnName("Kurun_Waktu_Berkas_Akhir");

                entity.Property(e => e.KurunWaktuBerkasMulai).HasColumnName("Kurun_Waktu_Berkas_Mulai");

                entity.Property(e => e.NamaBerkas)
                    .HasMaxLength(200)
                    .HasColumnName("Nama_Berkas");

                entity.Property(e => e.Nominal).HasMaxLength(200);

                entity.Property(e => e.NomorBoksSementara)
                    .HasMaxLength(200)
                    .HasColumnName("Nomor_Boks_Sementara");

                entity.Property(e => e.RequestNumber)
                    .HasMaxLength(200)
                    .HasColumnName("Request_Number");

                entity.Property(e => e.RetensiAktif).HasColumnName("Retensi_Aktif");

                entity.Property(e => e.RetensiInaktif).HasColumnName("Retensi_Inaktif");

                entity.Property(e => e.TingkatPerkembanganBerkasId).HasColumnName("Tingkat_Perkembangan_Berkas_Id");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.Property(e => e.UraianInformasi).HasColumnName("Uraian_Informasi");

                entity.HasOne(d => d.InactiveArchiveManagementHeaderSender)
                    .WithMany(p => p.TbltInactiveArchiveManagementFiles)
                    .HasForeignKey(d => d.InactiveArchiveManagementHeaderSenderId)
                    .HasConstraintName("FK_TBLT_Inactive_Archive_Management_File_TBLT_Inactive_Archive_Management_Header_Sender");

                entity.HasOne(d => d.KategoriArsip)
                    .WithMany(p => p.TbltInactiveArchiveManagementFiles)
                    .HasForeignKey(d => d.KategoriArsipId)
                    .HasConstraintName("FK_TBLT_Inactive_Archive_Management_File_TBLM_Kategori_Arsip");

                entity.HasOne(d => d.KeteranganAksesKeamanan)
                    .WithMany(p => p.TbltInactiveArchiveManagementFiles)
                    .HasForeignKey(d => d.KeteranganAksesKeamananId)
                    .HasConstraintName("FK_TBLT_Inactive_Archive_Management_File_TBLM_Keterangan_Akses_Keamanan");

                entity.HasOne(d => d.KodeSubPemberkasan)
                    .WithMany(p => p.TbltInactiveArchiveManagementFiles)
                    .HasForeignKey(d => d.KodeSubPemberkasanId)
                    .HasConstraintName("FK_TBLT_Inactive_Archive_Management_File_TBLM_Kode_Sub_Pemberkasan");

                entity.HasOne(d => d.TingkatPerkembanganBerkas)
                    .WithMany(p => p.TbltInactiveArchiveManagementFiles)
                    .HasForeignKey(d => d.TingkatPerkembanganBerkasId)
                    .HasConstraintName("FK_TBLT_Inactive_Archive_Management_File_TBLM_Tingkat_Perkembangan_Document");
            });

            modelBuilder.Entity<TbltInactiveArchiveManagementHeaderSender>(entity =>
            {
                entity.ToTable("TBLT_Inactive_Archive_Management_Header_Sender");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Alamat).HasMaxLength(200);

                entity.Property(e => e.AlihMediaHeaderSenderId).HasColumnName("Alih_Media_Header_Sender_Id");

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Approved_By");

                entity.Property(e => e.ApprovedDate).HasColumnName("Approved_Date");

                entity.Property(e => e.AssignedDate).HasColumnName("Assigned_Date");

                entity.Property(e => e.AssignedTo)
                    .HasMaxLength(50)
                    .HasColumnName("Assigned_To");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(50)
                    .HasColumnName("Company_Code");

                entity.Property(e => e.ContactPersonEmail)
                    .HasMaxLength(200)
                    .HasColumnName("Contact_Person_Email");

                entity.Property(e => e.ContactPersonMobileNumber)
                    .HasMaxLength(200)
                    .HasColumnName("Contact_Person_Mobile_Number");

                entity.Property(e => e.ContactPersonName)
                    .HasMaxLength(200)
                    .HasColumnName("Contact_Person_Name");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.Direktorat).HasMaxLength(200);

                entity.Property(e => e.DirektoratId)
                    .HasMaxLength(50)
                    .HasColumnName("Direktorat_Id");

                entity.Property(e => e.FileTransferHeaderSenderId).HasColumnName("File_Transfer_Header_Sender_Id");

                entity.Property(e => e.Fungsi).HasMaxLength(200);

                entity.Property(e => e.FungsiId)
                    .HasMaxLength(50)
                    .HasColumnName("Fungsi_Id");

                entity.Property(e => e.JumlahBerkas).HasColumnName("Jumlah_Berkas");

                entity.Property(e => e.Kbo)
                    .HasMaxLength(200)
                    .HasColumnName("KBO");

                entity.Property(e => e.NamaPimpinan)
                    .HasMaxLength(200)
                    .HasColumnName("Nama_Pimpinan");

                entity.Property(e => e.NoSkOrganisasi)
                    .HasMaxLength(200)
                    .HasColumnName("No_SK_Organisasi");

                entity.Property(e => e.RecordServiceHeaderSenderId).HasColumnName("Record_Service_Header_Sender_Id");

                entity.Property(e => e.RequestNumber)
                    .HasMaxLength(50)
                    .HasColumnName("Request_Number");

                entity.Property(e => e.StatusAlihMedia).HasColumnName("Status_Alih_Media");

                entity.Property(e => e.StatusId).HasColumnName("Status_Id");

                entity.Property(e => e.SubmittedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Submitted_By");

                entity.Property(e => e.SubmittedDate).HasColumnName("Submitted_Date");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.HasOne(d => d.AlihMediaHeaderSender)
                    .WithMany(p => p.TbltInactiveArchiveManagementHeaderSenders)
                    .HasForeignKey(d => d.AlihMediaHeaderSenderId)
                    .HasConstraintName("FK_TBLT_Inactive_Archive_Management_Header_Sender_TBLT_Alih_Media_Header_Sender");

                entity.HasOne(d => d.FileTransferHeaderSender)
                    .WithMany(p => p.TbltInactiveArchiveManagementHeaderSenders)
                    .HasForeignKey(d => d.FileTransferHeaderSenderId)
                    .HasConstraintName("FK_TBLT_Inactive_Archive_Management_Header_Sender_TBLT_File_Transfer_Header_Sender");

                entity.HasOne(d => d.RecordServiceHeaderSender)
                    .WithMany(p => p.TbltInactiveArchiveManagementHeaderSenders)
                    .HasForeignKey(d => d.RecordServiceHeaderSenderId)
                    .HasConstraintName("FK_TBLT_Inactive_Archive_Management_Header_Sender_TBLT_Record_Service_Header_Sender");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TbltInactiveArchiveManagementHeaderSenders)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_TBLT_Inactive_Archive_Management_Header_Sender_TBLM_Inactive_Archive_Management_Status_File");
            });

            modelBuilder.Entity<TbltInactiveArchiveManagementHistory>(entity =>
            {
                entity.ToTable("TBLT_Inactive_Archive_Management_History");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CommentText)
                    .HasMaxLength(1000)
                    .HasColumnName("Comment_Text");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.InactiveArchiveManagementHeaderSenderId).HasColumnName("Inactive_Archive_Management_Header_Sender_Id");

                entity.Property(e => e.InactiveArchiveManagementStatusFileId).HasColumnName("Inactive_Archive_Management_Status_File_Id");

                entity.Property(e => e.MenuText)
                    .HasMaxLength(1000)
                    .HasColumnName("Menu_Text");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(200)
                    .HasColumnName("Status_Name");

                entity.Property(e => e.StepCode)
                    .HasMaxLength(50)
                    .HasColumnName("Step_Code");

                entity.Property(e => e.SubmenuText)
                    .HasMaxLength(1000)
                    .HasColumnName("Submenu_Text");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.Property(e => e.UserPelaku)
                    .HasMaxLength(200)
                    .HasColumnName("User_Pelaku");

                entity.HasOne(d => d.InactiveArchiveManagementHeaderSender)
                    .WithMany(p => p.TbltInactiveArchiveManagementHistories)
                    .HasForeignKey(d => d.InactiveArchiveManagementHeaderSenderId)
                    .HasConstraintName("FK_TBLT_Inactive_Archive_Management_History_TBLT_Inactive_Archive_Management_Header_Sender");

                entity.HasOne(d => d.InactiveArchiveManagementStatusFile)
                    .WithMany(p => p.TbltInactiveArchiveManagementHistories)
                    .HasForeignKey(d => d.InactiveArchiveManagementStatusFileId)
                    .HasConstraintName("FK_TBLT_Inactive_Archive_Management_History_TBLT_Inactive_Archive_Management_File");
            });

            modelBuilder.Entity<TbltInactiveArchiveManagementInventory>(entity =>
            {
                entity.ToTable("TBLT_Inactive_Archive_Management_Inventory");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AmbalanId).HasColumnName("Ambalan_Id");

                entity.Property(e => e.Boks).HasMaxLength(200);

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(50)
                    .HasColumnName("Company_Code");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.Direktorat).HasMaxLength(200);

                entity.Property(e => e.DirektoratId)
                    .HasMaxLength(50)
                    .HasColumnName("Direktorat_Id");

                entity.Property(e => e.Folder).HasMaxLength(200);

                entity.Property(e => e.Fungsi).HasMaxLength(200);

                entity.Property(e => e.FungsiId)
                    .HasMaxLength(50)
                    .HasColumnName("Fungsi_Id");

                entity.Property(e => e.GedungId).HasColumnName("Gedung_Id");

                entity.Property(e => e.InactiveArchiveManagementFileId).HasColumnName("Inactive_Archive_Management_File_Id");

                entity.Property(e => e.Kbo)
                    .HasMaxLength(200)
                    .HasColumnName("KBO");

                entity.Property(e => e.RakId).HasColumnName("Rak_Id");

                entity.Property(e => e.RuanganId).HasColumnName("Ruangan_Id");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.HasOne(d => d.Ambalan)
                    .WithMany(p => p.TbltInactiveArchiveManagementInventories)
                    .HasForeignKey(d => d.AmbalanId)
                    .HasConstraintName("FK_TBLT_Inventory_TBLM_Ambalan");

                entity.HasOne(d => d.Gedung)
                    .WithMany(p => p.TbltInactiveArchiveManagementInventories)
                    .HasForeignKey(d => d.GedungId)
                    .HasConstraintName("FK_TBLT_Inventory_TBLM_Gedung");

                entity.HasOne(d => d.InactiveArchiveManagementFile)
                    .WithMany(p => p.TbltInactiveArchiveManagementInventories)
                    .HasForeignKey(d => d.InactiveArchiveManagementFileId)
                    .HasConstraintName("FK_TBLT_Inventory_TBLT_Inactive_Archive_Management_File");

                entity.HasOne(d => d.Rak)
                    .WithMany(p => p.TbltInactiveArchiveManagementInventories)
                    .HasForeignKey(d => d.RakId)
                    .HasConstraintName("FK_TBLT_Inventory_TBLM_Rak");

                entity.HasOne(d => d.Ruangan)
                    .WithMany(p => p.TbltInactiveArchiveManagementInventories)
                    .HasForeignKey(d => d.RuanganId)
                    .HasConstraintName("FK_TBLT_Inventory_TBLM_Ruangan");
            });

            modelBuilder.Entity<TbltInactiveArchiveManagementItem>(entity =>
            {
                entity.ToTable("TBLT_Inactive_Archive_Management_Item");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BentukItemId).HasColumnName("Bentuk_Item_Id");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.FileNameSystem)
                    .HasMaxLength(200)
                    .HasColumnName("File_Name_System");

                entity.Property(e => e.FileNameUser)
                    .HasMaxLength(200)
                    .HasColumnName("File_Name_User");

                entity.Property(e => e.InactiveArchiveManagementFileId).HasColumnName("Inactive_Archive_Management_File_Id");

                entity.Property(e => e.KodeSubPemberkasanId).HasColumnName("Kode_Sub_Pemberkasan_Id");

                entity.Property(e => e.NoItemArsip)
                    .HasMaxLength(100)
                    .HasColumnName("No_Item_Arsip");

                entity.Property(e => e.TingkatPerkembanganDokumenId).HasColumnName("Tingkat_Perkembangan_Dokumen_Id");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.Property(e => e.UraianInformasi).HasColumnName("Uraian_Informasi");

                entity.HasOne(d => d.BentukItem)
                    .WithMany(p => p.TbltInactiveArchiveManagementItems)
                    .HasForeignKey(d => d.BentukItemId)
                    .HasConstraintName("FK_TBLT_Inactive_Archive_Management_Item_TBLM_Bentuk_Item");

                entity.HasOne(d => d.InactiveArchiveManagementFile)
                    .WithMany(p => p.TbltInactiveArchiveManagementItems)
                    .HasForeignKey(d => d.InactiveArchiveManagementFileId)
                    .HasConstraintName("FK_TBLT_Inactive_Archive_Management_Item_TBLT_Inactive_Archive_Management_File");

                entity.HasOne(d => d.KodeSubPemberkasan)
                    .WithMany(p => p.TbltInactiveArchiveManagementItems)
                    .HasForeignKey(d => d.KodeSubPemberkasanId)
                    .HasConstraintName("FK_TBLT_Inactive_Archive_Management_Item_TBLM_Kode_Sub_Pemberkasan");

                entity.HasOne(d => d.TingkatPerkembanganDokumen)
                    .WithMany(p => p.TbltInactiveArchiveManagementItems)
                    .HasForeignKey(d => d.TingkatPerkembanganDokumenId)
                    .HasConstraintName("FK_TBLT_Inactive_Archive_Management_Item_TBLM_Tingkat_Perkembangan_Document");
            });

            modelBuilder.Entity<TbltNotificationBell>(entity =>
            {
                entity.ToTable("TBLT_Notification_Bell");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.FeatureName)
                    .HasMaxLength(50)
                    .HasColumnName("Feature_Name");

                entity.Property(e => e.HeaderId).HasColumnName("Header_Id");

                entity.Property(e => e.SenderName)
                    .HasMaxLength(200)
                    .HasColumnName("Sender_Name");

                entity.Property(e => e.SentTo)
                    .HasMaxLength(200)
                    .HasColumnName("Sent_To");

                entity.Property(e => e.StatusId).HasColumnName("Status_Id");

                entity.Property(e => e.StatusNotifRead).HasColumnName("Status_Notif_Read");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");
            });

            modelBuilder.Entity<TbltRecordServiceAttachment>(entity =>
            {
                entity.ToTable("TBLT_Record_Service_Attachment");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.FileNameSystem)
                    .HasMaxLength(200)
                    .HasColumnName("File_Name_System");

                entity.Property(e => e.FileNameUser)
                    .HasMaxLength(200)
                    .HasColumnName("File_Name_User");

                entity.Property(e => e.RecordServiceHeaderSenderId).HasColumnName("Record_Service_Header_Sender_Id");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.HasOne(d => d.RecordServiceHeaderSender)
                    .WithMany(p => p.TbltRecordServiceAttachments)
                    .HasForeignKey(d => d.RecordServiceHeaderSenderId)
                    .HasConstraintName("FK_TBLT_Record_Service_Attachment_TBLT_Record_Service_Header_Sender");
            });

            modelBuilder.Entity<TbltRecordServiceBaSigning>(entity =>
            {
                entity.ToTable("TBLT_Record_Service_BA_Signing");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.RecordServiceSigningId).HasColumnName("Record_Service_Signing_Id");

                entity.Property(e => e.RoleId).HasColumnName("Role_Id");

                entity.Property(e => e.RoleName).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.Property(e => e.Username).HasMaxLength(200);

                entity.HasOne(d => d.RecordServiceSigning)
                    .WithMany(p => p.TbltRecordServiceBaSignings)
                    .HasForeignKey(d => d.RecordServiceSigningId)
                    .HasConstraintName("FK_TBLT_Record_Service_BA_Signing_TBLT_Record_Service_Signing");
            });

            modelBuilder.Entity<TbltRecordServiceFile>(entity =>
            {
                entity.ToTable("TBLT_Record_Service_File");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.InactiveArchiveManagementHeaderSenderId).HasColumnName("Inactive_Archive_Management_Header_Sender_Id");

                entity.Property(e => e.RecordServiceHeaderSenderId).HasColumnName("Record_Service_Header_Sender_Id");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.HasOne(d => d.InactiveArchiveManagementHeaderSender)
                    .WithMany(p => p.TbltRecordServiceFiles)
                    .HasForeignKey(d => d.InactiveArchiveManagementHeaderSenderId)
                    .HasConstraintName("FK_TBLT_Record_Service_File_TBLT_Inactive_Archive_Management_Header_Sender");

                entity.HasOne(d => d.RecordServiceHeaderSender)
                    .WithMany(p => p.TbltRecordServiceFiles)
                    .HasForeignKey(d => d.RecordServiceHeaderSenderId)
                    .HasConstraintName("FK_TBLT_Record_Service_File_TBLT_Record_Service_Header_Sender");
            });

            modelBuilder.Entity<TbltRecordServiceHeaderSender>(entity =>
            {
                entity.ToTable("TBLT_Record_Service_Header_Sender");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Alamat).HasMaxLength(1000);

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Approved_By");

                entity.Property(e => e.ApprovedDate).HasColumnName("Approved_Date");

                entity.Property(e => e.AssignedDate).HasColumnName("Assigned_Date");

                entity.Property(e => e.AssignedTo)
                    .HasMaxLength(50)
                    .HasColumnName("Assigned_To");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(50)
                    .HasColumnName("Company_Code");

                entity.Property(e => e.CompanyCodeOwner)
                    .HasMaxLength(50)
                    .HasColumnName("Company_Code_Owner");

                entity.Property(e => e.ContactPersonEmail)
                    .HasMaxLength(200)
                    .HasColumnName("Contact_Person_Email");

                entity.Property(e => e.ContactPersonMobileNumber)
                    .HasMaxLength(200)
                    .HasColumnName("Contact_Person_Mobile_Number");

                entity.Property(e => e.ContactPersonName)
                    .HasMaxLength(200)
                    .HasColumnName("Contact_Person_Name");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.Direktorat).HasMaxLength(200);

                entity.Property(e => e.DirektoratId)
                    .HasMaxLength(200)
                    .HasColumnName("Direktorat_Id");

                entity.Property(e => e.ExpectedReturnDate).HasColumnName("Expected_Return_Date");

                entity.Property(e => e.ExpiredDate).HasColumnName("Expired_Date");

                entity.Property(e => e.Fungsi).HasMaxLength(200);

                entity.Property(e => e.FungsiId)
                    .HasMaxLength(50)
                    .HasColumnName("Fungsi_Id");

                entity.Property(e => e.JenisSeriesArsip)
                    .HasMaxLength(200)
                    .HasColumnName("Jenis_Series_Arsip");

                entity.Property(e => e.JustifikasiAksesId).HasColumnName("Justifikasi_Akses_Id");

                entity.Property(e => e.Kbo)
                    .HasMaxLength(200)
                    .HasColumnName("KBO");

                entity.Property(e => e.NamaPimpinan)
                    .HasMaxLength(200)
                    .HasColumnName("Nama_Pimpinan");

                entity.Property(e => e.NoSkOrganisasi)
                    .HasMaxLength(200)
                    .HasColumnName("No_SK_Organisasi");

                entity.Property(e => e.Referensi).HasMaxLength(250);

                entity.Property(e => e.RequestNumber)
                    .HasMaxLength(50)
                    .HasColumnName("Request_Number");

                entity.Property(e => e.ReturnDate).HasColumnName("Return_Date");

                entity.Property(e => e.StatusId).HasColumnName("Status_Id");

                entity.Property(e => e.SubmitApprovedBy)
                    .HasMaxLength(50)
                    .HasColumnName("SubmitApproved_By");

                entity.Property(e => e.SubmitApprovedDate).HasColumnName("SubmitApproved_Date");

                entity.Property(e => e.SubmittedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Submitted_By");

                entity.Property(e => e.SubmittedDate).HasColumnName("Submitted_Date");

                entity.Property(e => e.TransactionTypeId).HasColumnName("Transaction_Type_Id");

                entity.Property(e => e.TransferDate).HasColumnName("Transfer_Date");

                entity.Property(e => e.TypeOfDuplicationId).HasColumnName("Type_Of_Duplication_Id");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.Property(e => e.UraianInformasi)
                    .HasMaxLength(300)
                    .HasColumnName("Uraian_Informasi");

                entity.HasOne(d => d.JustifikasiAkses)
                    .WithMany(p => p.TbltRecordServiceHeaderSenders)
                    .HasForeignKey(d => d.JustifikasiAksesId)
                    .HasConstraintName("FK_TBLT_Record_Service_Header_Sender_TBLM_Justifikasi_Akses");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TbltRecordServiceHeaderSenders)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_TBLT_Record_Service_Header_Sender_TBLM_Record_Services_Status_File");

                entity.HasOne(d => d.TransactionType)
                    .WithMany(p => p.TbltRecordServiceHeaderSenders)
                    .HasForeignKey(d => d.TransactionTypeId)
                    .HasConstraintName("FK_TBLT_Record_Service_Header_Sender_TBLM_Record_Service_Transaction_Type");

                entity.HasOne(d => d.TypeOfDuplication)
                    .WithMany(p => p.TbltRecordServiceHeaderSenders)
                    .HasForeignKey(d => d.TypeOfDuplicationId)
                    .HasConstraintName("FK_TBLT_Record_Service_Header_Sender_TBLM_Record_Service_Request_Duplication_Type");
            });

            modelBuilder.Entity<TbltRecordServiceHistory>(entity =>
            {
                entity.ToTable("TBLT_Record_Service_History");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CommentText)
                    .HasMaxLength(1000)
                    .HasColumnName("Comment_Text");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.MenuText)
                    .HasMaxLength(1000)
                    .HasColumnName("Menu_Text");

                entity.Property(e => e.RecordServiceHeaderSenderId).HasColumnName("Record_Service_Header_Sender_Id");

                entity.Property(e => e.RecordServiceStatusFileId).HasColumnName("Record_Service_Status_File_Id");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(200)
                    .HasColumnName("Status_Name");

                entity.Property(e => e.StepCode)
                    .HasMaxLength(50)
                    .HasColumnName("Step_Code");

                entity.Property(e => e.SubmenuText)
                    .HasMaxLength(1000)
                    .HasColumnName("Submenu_Text");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.Property(e => e.UserPelaku)
                    .HasMaxLength(200)
                    .HasColumnName("User_Pelaku");

                entity.HasOne(d => d.RecordServiceHeaderSender)
                    .WithMany(p => p.TbltRecordServiceHistories)
                    .HasForeignKey(d => d.RecordServiceHeaderSenderId)
                    .HasConstraintName("FK_TBLT_Record_Service_History_TBLT_Record_Service_Header_Sender");

                entity.HasOne(d => d.RecordServiceStatusFile)
                    .WithMany(p => p.TbltRecordServiceHistories)
                    .HasForeignKey(d => d.RecordServiceStatusFileId)
                    .HasConstraintName("FK_TBLT_Record_Service_History_TBLM_Record_Services_Status_File");
            });

            modelBuilder.Entity<TbltRecordServiceSignParallel>(entity =>
            {
                entity.ToTable("TBLT_Record_Service_Sign_Parallel");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.DocumentId).HasColumnName("Document_Id");

                entity.Property(e => e.FileName)
                    .HasMaxLength(200)
                    .HasColumnName("File_Name");

                entity.Property(e => e.ProcessId).HasColumnName("Process_Id");

                entity.Property(e => e.RecordServiceSigningId).HasColumnName("Record_Service_Signing_Id");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.HasOne(d => d.RecordServiceSigning)
                    .WithMany(p => p.TbltRecordServiceSignParallels)
                    .HasForeignKey(d => d.RecordServiceSigningId)
                    .HasConstraintName("FK_TBLT_Record_Service_Sign_Parallel_TBLT_Record_Service_Signing");
            });

            modelBuilder.Entity<TbltRecordServiceSigning>(entity =>
            {
                entity.ToTable("TBLT_Record_Service_Signing");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(200)
                    .HasColumnName("Approved_By");

                entity.Property(e => e.ApprovedDate).HasColumnName("Approved_Date");

                entity.Property(e => e.AssignedBy)
                    .HasMaxLength(200)
                    .HasColumnName("Assigned_By");

                entity.Property(e => e.AssignedDate).HasColumnName("Assigned_Date");

                entity.Property(e => e.AssignedTo)
                    .HasMaxLength(200)
                    .HasColumnName("Assigned_To");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(50)
                    .HasColumnName("Company_Code");

                entity.Property(e => e.ContactPersonEmail)
                    .HasMaxLength(200)
                    .HasColumnName("Contact_Person_Email");

                entity.Property(e => e.ContactPersonName)
                    .HasMaxLength(200)
                    .HasColumnName("Contact_Person_Name");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.Direktorat).HasMaxLength(200);

                entity.Property(e => e.DirektoratId)
                    .HasMaxLength(50)
                    .HasColumnName("Direktorat_Id");

                entity.Property(e => e.FileNameSystem)
                    .HasMaxLength(200)
                    .HasColumnName("File_Name_System");

                entity.Property(e => e.Fungsi).HasMaxLength(200);

                entity.Property(e => e.FungsiId)
                    .HasMaxLength(200)
                    .HasColumnName("Fungsi_Id");

                entity.Property(e => e.JumlahBerkas).HasColumnName("Jumlah_Berkas");

                entity.Property(e => e.Kbo)
                    .HasMaxLength(200)
                    .HasColumnName("KBO");

                entity.Property(e => e.RecordServiceHeaderSenderId).HasColumnName("Record_Service_Header_Sender_Id");

                entity.Property(e => e.RequestNumber)
                    .HasMaxLength(50)
                    .HasColumnName("Request_Number");

                entity.Property(e => e.StatusId).HasColumnName("Status_Id");

                entity.Property(e => e.StatusSigning).HasColumnName("Status_Signing");

                entity.Property(e => e.SubmittedBy)
                    .HasMaxLength(200)
                    .HasColumnName("Submitted_By");

                entity.Property(e => e.SubmittedDate).HasColumnName("Submitted_Date");

                entity.Property(e => e.SurveyBy)
                    .HasMaxLength(200)
                    .HasColumnName("Survey_By");

                entity.Property(e => e.SurveyDate).HasColumnName("Survey_Date");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(200)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.HasOne(d => d.RecordServiceHeaderSender)
                    .WithMany(p => p.TbltRecordServiceSignings)
                    .HasForeignKey(d => d.RecordServiceHeaderSenderId)
                    .HasConstraintName("FK_TBLT_Record_Service_Signing_TBLT_Record_Service_Header_Sender");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.TbltRecordServiceSignings)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_TBLT_Record_Service_Signing_TBLM_Record_Service_Signing_Status_File");
            });

            modelBuilder.Entity<TbltRecordServiceSigningHistory>(entity =>
            {
                entity.ToTable("TBLT_Record_Service_Signing_History");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CommentsText)
                    .HasMaxLength(1000)
                    .HasColumnName("Comments_Text");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate).HasColumnName("Created_Date");

                entity.Property(e => e.DeletedDate).HasColumnName("Deleted_Date");

                entity.Property(e => e.MenuText)
                    .HasMaxLength(1000)
                    .HasColumnName("Menu_Text");

                entity.Property(e => e.RecordServiceSigningId).HasColumnName("Record_Service_Signing_Id");

                entity.Property(e => e.RecordServiceSigningStatusFileId).HasColumnName("Record_Service_Signing_Status_File_Id");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(1000)
                    .HasColumnName("Status_Name");

                entity.Property(e => e.StepCode)
                    .HasMaxLength(50)
                    .HasColumnName("Step_Code");

                entity.Property(e => e.SubmenuText)
                    .HasMaxLength(1000)
                    .HasColumnName("Submenu_Text");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Updated_By");

                entity.Property(e => e.UpdatedDate).HasColumnName("Updated_Date");

                entity.Property(e => e.UserPelaku)
                    .HasMaxLength(1000)
                    .HasColumnName("User_Pelaku");

                entity.HasOne(d => d.RecordServiceSigning)
                    .WithMany(p => p.TbltRecordServiceSigningHistories)
                    .HasForeignKey(d => d.RecordServiceSigningId)
                    .HasConstraintName("FK_TBLT_Record_Service_Signing_History_TBLT_Record_Service_Signing");
            });

            modelBuilder.Entity<VwDimCompany>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Dim_Company");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(50)
                    .HasColumnName("Company_Code");
            });

            modelBuilder.Entity<VwDimDirektorat>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Dim_Direktorat");

                entity.Property(e => e.Direktorat).HasMaxLength(200);

                entity.Property(e => e.DirektoratId)
                    .HasMaxLength(50)
                    .HasColumnName("Direktorat_Id");
            });

            modelBuilder.Entity<VwDimFungsi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Dim_Fungsi");

                entity.Property(e => e.Fungsi).HasMaxLength(200);

                entity.Property(e => e.FungsiId)
                    .HasMaxLength(200)
                    .HasColumnName("Fungsi_Id");
            });

            modelBuilder.Entity<VwDimKategoriArsip>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Dim_Kategori_Arsip");

                entity.Property(e => e.KategoriArsip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Kategori_Arsip");

                entity.Property(e => e.KategoriId).HasColumnName("Kategori_Id");
            });

            modelBuilder.Entity<VwDimKbo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Dim_KBO");

                entity.Property(e => e.Kbo)
                    .HasMaxLength(200)
                    .HasColumnName("KBO");
            });

            modelBuilder.Entity<VwDimKodePemberkasan>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Dim_Kode_Pemberkasan");

                entity.Property(e => e.KppCode)
                    .HasMaxLength(50)
                    .HasColumnName("KPP_Code");

                entity.Property(e => e.KppDescription)
                    .HasMaxLength(1000)
                    .HasColumnName("KPP_Description");

                entity.Property(e => e.KppId).HasColumnName("KPP_ID");

                entity.Property(e => e.KspCode)
                    .HasMaxLength(50)
                    .HasColumnName("KSP_Code");

                entity.Property(e => e.KspDescription)
                    .HasMaxLength(1000)
                    .HasColumnName("KSP_Description");

                entity.Property(e => e.KspId).HasColumnName("KSP_ID");
            });

            modelBuilder.Entity<VwDimYear>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Dim_Year");
            });

            modelBuilder.Entity<VwFactActiveDocument>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Fact_Active_Document");

                entity.Property(e => e.ActiveDocumentFileId).HasColumnName("Active_Document_File_Id");

                entity.Property(e => e.ActiveDocumentHeaderSenderId).HasColumnName("Active_Document_Header_Sender_ID");

                entity.Property(e => e.ActiveDocumentItemId).HasColumnName("Active_Document_Item_Id");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(50)
                    .HasColumnName("Company_Code");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasColumnName("Create_Date");

                entity.Property(e => e.DescSubPemberkasan)
                    .HasMaxLength(1000)
                    .HasColumnName("Desc_Sub_Pemberkasan");

                entity.Property(e => e.Direktorat).HasMaxLength(200);

                entity.Property(e => e.FileNameUser)
                    .HasMaxLength(200)
                    .HasColumnName("File_Name_User");

                entity.Property(e => e.Fungsi).HasMaxLength(200);

                entity.Property(e => e.KategoriArsip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Kategori_Arsip");

                entity.Property(e => e.Kbo)
                    .HasMaxLength(200)
                    .HasColumnName("KBO");

                entity.Property(e => e.KeteranganRetensi)
                    .HasMaxLength(200)
                    .HasColumnName("Keterangan_Retensi");

                entity.Property(e => e.KodeSubPemberkasan)
                    .HasMaxLength(50)
                    .HasColumnName("Kode_Sub_Pemberkasan");

                entity.Property(e => e.KurunWaktuBerkasAkhir).HasColumnName("Kurun_Waktu_Berkas_Akhir");

                entity.Property(e => e.KurunWaktuBerkasMulai).HasColumnName("Kurun_Waktu_Berkas_Mulai");

                entity.Property(e => e.Mm).HasColumnName("MM");

                entity.Property(e => e.NamaBerkas)
                    .HasMaxLength(200)
                    .HasColumnName("Nama_Berkas");

                entity.Property(e => e.RetensiAktif).HasColumnName("Retensi_Aktif");

                entity.Property(e => e.RetensiAktifText)
                    .HasMaxLength(100)
                    .HasColumnName("Retensi_Aktif_Text");

                entity.Property(e => e.RetensiInaktif).HasColumnName("Retensi_Inaktif");

                entity.Property(e => e.RetensiInaktifText)
                    .HasMaxLength(100)
                    .HasColumnName("Retensi_Inaktif_Text");

                entity.Property(e => e.StatusFile)
                    .HasMaxLength(200)
                    .HasColumnName("Status_File");

                entity.Property(e => e.Tanggal).HasColumnType("date");

                entity.Property(e => e.TingkatDocument)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Tingkat_Document");

                entity.Property(e => e.UraianInformasi).HasColumnName("Uraian_Informasi");

                entity.Property(e => e.Yyyy).HasColumnName("YYYY");
            });

            modelBuilder.Entity<VwFactAlihMedium>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Fact_Alih_Media");

                entity.Property(e => e.AksesKeamanan)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Akses_Keamanan");

                entity.Property(e => e.AlihMediaFileId).HasColumnName("Alih_Media_File_Id");

                entity.Property(e => e.AlihMediaHeaderId).HasColumnName("Alih_Media_Header_Id");

                entity.Property(e => e.AlihMediaItemId).HasColumnName("Alih_Media_Item_Id");

                entity.Property(e => e.BentukItem)
                    .HasMaxLength(100)
                    .HasColumnName("Bentuk_item");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(50)
                    .HasColumnName("Company_Code");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasColumnName("Create_Date");

                entity.Property(e => e.Direktorat).HasMaxLength(200);

                entity.Property(e => e.FileNameUser)
                    .HasMaxLength(200)
                    .HasColumnName("File_Name_User");

                entity.Property(e => e.Fungsi).HasMaxLength(200);

                entity.Property(e => e.KategoriArsip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Kategori_Arsip");

                entity.Property(e => e.Kbo)
                    .HasMaxLength(200)
                    .HasColumnName("KBO");

                entity.Property(e => e.Keterangan).HasMaxLength(200);

                entity.Property(e => e.KeteranganRetensi)
                    .HasMaxLength(200)
                    .HasColumnName("Keterangan_Retensi");

                entity.Property(e => e.KodeSubPemberkasanId)
                    .HasMaxLength(50)
                    .HasColumnName("Kode_Sub_Pemberkasan_Id");

                entity.Property(e => e.KurunWaktuBerkasAkhir).HasColumnName("Kurun_Waktu_Berkas_Akhir");

                entity.Property(e => e.KurunWaktuBerkasMulai).HasColumnName("Kurun_Waktu_Berkas_Mulai");

                entity.Property(e => e.Mm).HasColumnName("MM");

                entity.Property(e => e.NamaBerkas)
                    .HasMaxLength(200)
                    .HasColumnName("Nama_Berkas");

                entity.Property(e => e.RetensiAktif).HasColumnName("Retensi_Aktif");

                entity.Property(e => e.RetensiInaktif).HasColumnName("Retensi_Inaktif");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(200)
                    .HasColumnName("Status_Name");

                entity.Property(e => e.Tanggal).HasColumnType("date");

                entity.Property(e => e.TingkatPerkembanganDokumen)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Tingkat_Perkembangan_Dokumen");

                entity.Property(e => e.UraianInformasi).HasColumnName("Uraian_Informasi");

                entity.Property(e => e.Yyyy).HasColumnName("YYYY");
            });

            modelBuilder.Entity<VwFactFileTransfer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Fact_File_Transfer");

                entity.Property(e => e.ApprovedDate)
                    .HasColumnType("date")
                    .HasColumnName("Approved_Date");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(50)
                    .HasColumnName("Company_Code");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasColumnName("Create_Date");

                entity.Property(e => e.Direktorat).HasMaxLength(200);

                entity.Property(e => e.FileNameUser)
                    .HasMaxLength(200)
                    .HasColumnName("File_Name_User");

                entity.Property(e => e.FileTranferHeaderId).HasColumnName("File_Tranfer_Header_ID");

                entity.Property(e => e.FileTranferItemId).HasColumnName("File_Tranfer_Item_ID");

                entity.Property(e => e.FileTransferFileId).HasColumnName("File_Transfer_File_ID");

                entity.Property(e => e.Fungsi).HasMaxLength(200);

                entity.Property(e => e.JenisSeriesArsip)
                    .HasMaxLength(200)
                    .HasColumnName("Jenis_Series_Arsip");

                entity.Property(e => e.KategoriArsip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Kategori_Arsip");

                entity.Property(e => e.Kbo)
                    .HasMaxLength(200)
                    .HasColumnName("KBO");

                entity.Property(e => e.KodeSubPemberkasan)
                    .HasMaxLength(50)
                    .HasColumnName("Kode_Sub_Pemberkasan");

                entity.Property(e => e.KurunWaktuBerkasAkhir).HasColumnName("Kurun_Waktu_Berkas_Akhir");

                entity.Property(e => e.KurunWaktuBerkasMulai).HasColumnName("Kurun_Waktu_Berkas_Mulai");

                entity.Property(e => e.Mm).HasColumnName("MM");

                entity.Property(e => e.NamaBerkas)
                    .HasMaxLength(200)
                    .HasColumnName("Nama_Berkas");

                entity.Property(e => e.RequestNumber)
                    .HasMaxLength(13)
                    .HasColumnName("Request_Number");

                entity.Property(e => e.RetensiAktif).HasColumnName("Retensi_Aktif");

                entity.Property(e => e.RetensiInaktif).HasColumnName("Retensi_Inaktif");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(200)
                    .HasColumnName("Status_Name");

                entity.Property(e => e.StepCode)
                    .HasMaxLength(50)
                    .HasColumnName("Step_Code");

                entity.Property(e => e.SubmittedDate)
                    .HasColumnType("date")
                    .HasColumnName("Submitted_Date");

                entity.Property(e => e.Tanggal).HasColumnType("date");

                entity.Property(e => e.TingkatPerkembanganDocument)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Tingkat_Perkembangan_Document");

                entity.Property(e => e.UraianInformasi).HasColumnName("Uraian_Informasi");

                entity.Property(e => e.Yyyy).HasColumnName("YYYY");
            });

            modelBuilder.Entity<VwFactInactiveDocument>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Fact_Inactive_Document");

                entity.Property(e => e.BentukItem)
                    .HasMaxLength(100)
                    .HasColumnName("Bentuk_item");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(50)
                    .HasColumnName("Company_Code");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasColumnName("Create_Date");

                entity.Property(e => e.Direktorat).HasMaxLength(200);

                entity.Property(e => e.DirektoratId)
                    .HasMaxLength(50)
                    .HasColumnName("Direktorat_Id");

                entity.Property(e => e.FileNameUser)
                    .HasMaxLength(200)
                    .HasColumnName("File_Name_User");

                entity.Property(e => e.Fungsi).HasMaxLength(200);

                entity.Property(e => e.FungsiId)
                    .HasMaxLength(50)
                    .HasColumnName("Fungsi_Id");

                entity.Property(e => e.InactiveFileId).HasColumnName("Inactive_File_Id");

                entity.Property(e => e.InactiveHeaderId).HasColumnName("inactive_Header_Id");

                entity.Property(e => e.InactiveItemId).HasColumnName("Inactive_Item_Id");

                entity.Property(e => e.JenisSeriesArsip)
                    .HasMaxLength(200)
                    .HasColumnName("Jenis_Series_Arsip");

                entity.Property(e => e.KategoriArsip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Kategori_Arsip");

                entity.Property(e => e.Kbo)
                    .HasMaxLength(200)
                    .HasColumnName("KBO");

                entity.Property(e => e.Keterangan).HasMaxLength(200);

                entity.Property(e => e.KodeSubPemberkasan)
                    .HasMaxLength(50)
                    .HasColumnName("Kode_Sub_Pemberkasan");

                entity.Property(e => e.KurunWaktuBerkasAkhir).HasColumnName("Kurun_Waktu_Berkas_Akhir");

                entity.Property(e => e.KurunWaktuBerkasMulai).HasColumnName("Kurun_Waktu_Berkas_Mulai");

                entity.Property(e => e.Mm).HasColumnName("MM");

                entity.Property(e => e.NamaBerkas)
                    .HasMaxLength(200)
                    .HasColumnName("Nama_Berkas");

                entity.Property(e => e.NamaSubPemberkasan)
                    .HasMaxLength(1000)
                    .HasColumnName("Nama_Sub_Pemberkasan");

                entity.Property(e => e.RequestNumber)
                    .HasMaxLength(13)
                    .HasColumnName("Request_Number");

                entity.Property(e => e.RetensiAktif).HasColumnName("Retensi_Aktif");

                entity.Property(e => e.RetensiInaktif).HasColumnName("Retensi_Inaktif");

                entity.Property(e => e.StatusAlihMedia).HasColumnName("Status_Alih_Media");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(200)
                    .HasColumnName("Status_Name");

                entity.Property(e => e.StepCode)
                    .HasMaxLength(50)
                    .HasColumnName("Step_Code");

                entity.Property(e => e.Tanggal).HasColumnType("date");

                entity.Property(e => e.TingkatPerkembanganDokumen)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Tingkat_Perkembangan_Dokumen");

                entity.Property(e => e.UraianInformasi).HasColumnName("Uraian_Informasi");

                entity.Property(e => e.Yyyy).HasColumnName("YYYY");
            });
        }
    }
}
