using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Entities.Models
{
    public partial class EIA_DEVContext : DbContext
    {
        public virtual DbSet<AccInvoice> AccInvoice { get; set; }
        public virtual DbSet<AccInvoiceDtl> AccInvoiceDtl { get; set; }
        public virtual DbSet<AccReceipt> AccReceipt { get; set; }
        public virtual DbSet<AccReceiptChrg> AccReceiptChrg { get; set; }
        public virtual DbSet<AccReceiptDtl> AccReceiptDtl { get; set; }
        public virtual DbSet<AucAuctionList> AucAuctionList { get; set; }
        public virtual DbSet<AucAuctionListDtl> AucAuctionListDtl { get; set; }
        public virtual DbSet<AucAuctionSaleLot> AucAuctionSaleLot { get; set; }
        public virtual DbSet<AucBoe> AucBoe { get; set; }
        public virtual DbSet<AucBoegroup> AucBoegroup { get; set; }
        public virtual DbSet<AucSaleList> AucSaleList { get; set; }
        public virtual DbSet<ExpCsb1> ExpCsb1 { get; set; }
        public virtual DbSet<ExpCsb1dtl> ExpCsb1dtl { get; set; }
        public virtual DbSet<ExpCsb1weightAcceptance> ExpCsb1weightAcceptance { get; set; }
        public virtual DbSet<ExpCsb1weightAcceptanceDtl> ExpCsb1weightAcceptanceDtl { get; set; }
        public virtual DbSet<ExpEntryGatePass> ExpEntryGatePass { get; set; }
        public virtual DbSet<ExpOflgatePass> ExpOflgatePass { get; set; }
        public virtual DbSet<ExpReleasePass> ExpReleasePass { get; set; }
        public virtual DbSet<GenLov> GenLov { get; set; }
        public virtual DbSet<ImpForm1> ImpForm1 { get; set; }
        public virtual DbSet<ImpForm1Dtl> ImpForm1Dtl { get; set; }
        public virtual DbSet<ImpForm2> ImpForm2 { get; set; }
        public virtual DbSet<ImpForm2Dtl> ImpForm2Dtl { get; set; }
        public virtual DbSet<ImpGatePass> ImpGatePass { get; set; }
        public virtual DbSet<ImpGatePassDtl> ImpGatePassDtl { get; set; }
        public virtual DbSet<ImpOhforwarding> ImpOhforwarding { get; set; }
        public virtual DbSet<ImpOhgpgatePass> ImpOhgpgatePass { get; set; }
        public virtual DbSet<ImpOnHoldMemo> ImpOnHoldMemo { get; set; }
        public virtual DbSet<MAirlineDtl> MAirlineDtl { get; set; }
        public virtual DbSet<MAirlineMst> MAirlineMst { get; set; }
        public virtual DbSet<MAirportMst> MAirportMst { get; set; }
        public virtual DbSet<MCheckListMst> MCheckListMst { get; set; }
        public virtual DbSet<MCommonMasterMst> MCommonMasterMst { get; set; }
        public virtual DbSet<MCountryMst> MCountryMst { get; set; }
        public virtual DbSet<MCourierEmpMst> MCourierEmpMst { get; set; }
        public virtual DbSet<MCourierMst> MCourierMst { get; set; }
        public virtual DbSet<MCurrencyMst> MCurrencyMst { get; set; }
        public virtual DbSet<MDelayedChrgMst> MDelayedChrgMst { get; set; }
        public virtual DbSet<MFlightmasterMst> MFlightmasterMst { get; set; }
        public virtual DbSet<MGlobalMappingMst> MGlobalMappingMst { get; set; }
        public virtual DbSet<MModeofpaymentMst> MModeofpaymentMst { get; set; }
        public virtual DbSet<MsbmTbl> MsbmTbl { get; set; }
        public virtual DbSet<MTerminalMst> MTerminalMst { get; set; }
        public virtual DbSet<MUomcategoryMst> MUomcategoryMst { get; set; }
        public virtual DbSet<MUomMst> MUomMst { get; set; }
        public virtual DbSet<MUploadFileMst> MUploadFileMst { get; set; }
        public virtual DbSet<MUserTypeMst> MUserTypeMst { get; set; }
        public virtual DbSet<MWarehouseMst> MWarehouseMst { get; set; }
        public virtual DbSet<VmsgAlertM> VmsgAlertM { get; set; }
        public virtual DbSet<VmsgRelation> VmsgRelation { get; set; }
        public virtual DbSet<VmsgTemplateM> VmsgTemplateM { get; set; }
        public virtual DbSet<VrcfColumnDtl> VrcfColumnDtl { get; set; }
        public virtual DbSet<VrcfDebugDtl> VrcfDebugDtl { get; set; }
        public virtual DbSet<VrcfTableDtl> VrcfTableDtl { get; set; }
        public virtual DbSet<VrcfXlsxStyle> VrcfXlsxStyle { get; set; }
        public virtual DbSet<VsecApplicationAuditTrail> VsecApplicationAuditTrail { get; set; }
        public virtual DbSet<VsecApplications> VsecApplications { get; set; }
        public virtual DbSet<VsecFunctionAccess> VsecFunctionAccess { get; set; }
        public virtual DbSet<VsecFunctionMst> VsecFunctionMst { get; set; }
        public virtual DbSet<VsecLoginMst> VsecLoginMst { get; set; }
        public virtual DbSet<VsecProfileMst> VsecProfileMst { get; set; }
        public virtual DbSet<VsecQuestionMst> VsecQuestionMst { get; set; }
        public virtual DbSet<VsecRoleMst> VsecRoleMst { get; set; }
        public virtual DbSet<VsecUserActionHst> VsecUserActionHst { get; set; }
        public virtual DbSet<VsecUserMst> VsecUserMst { get; set; }
        public virtual DbSet<VsecUserRoleMap> VsecUserRoleMap { get; set; }

        // Unable to generate entity type for table 'dbo.M_Terminal_HST'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.IMP_GatePass_Hst'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.IMP_GatePassChkLst_Hst'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ACC_Receipt_Hst'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.M_UOMCategory_HST'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ACC_ReceiptDtl_Hst'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VSEC_PROFILE_HST'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VSEC_ROLE_HST'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DelhiFlight'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VSEC_USER_HST'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.M_UOM_HST'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VSEC_LOGIN_HST'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ACC_ReceiptDtlGP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AUC_AuctionListDtl_Hst'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AUC_BOEGroupDtl'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AUC_AuctionSaleLot_Hst'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AUC_BOE_Hst'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.IMP_OnHoldCRNDtl'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AUC_BOEDtl_Hst'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AUC_BOEGroup_Hst'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AUC_BOEGroupDtl_Hst'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.IMP_OnHoldConsgManuf'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EXP_CSB1_Hst'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.M_Flightmaster_HST'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EXP_CSB1Dtl_Hst'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EXP_CSB1WeightAcceptance_Hst'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EXP_CSB1WeightAcceptanceDtl_Hst'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.IMP_OnHoldItemDtl'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EXP_EntryGatePass_Hst'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EXP_ReleasePass_Hst'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EXP_ReleasePassULD_HST'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.M_Airline_HST'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.IMP_Form2_HST'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.IMP_OHTGPGatePass'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.IMP_Form2Dtl_Hst'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Migration_Mum_31_Mar_15_OH'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.IMP_OHGatePassChkLst_Hst'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Migration_Mum_31_Mar_15_F2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.IMP_OHGPGatePass_HST'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Migration_Del_08_Apr_15_OH'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.IMP_OnHoldCRNDtl_Hst'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Migration_Del_08_Apr_15_F2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.IMP_OnHoldMemo_Hst'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.IMP_OnHoldWHLocaction_Hst'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VMSG_ALERT_DETAILS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.M_CourierEmp_HST'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VMSG_ALERT_DETAILS_HST'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.IMP_Form1_Hst'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.IMP_GatePassChkLst'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.M_CommonMaster_HST'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.M_Modeofpayment_HST'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EXP_ReleasePassULD'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.IMP_Form1Dtl_Hst'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VSEC_FUNCTION_MST_LABEL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tempColumnDtl7'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AUC_BOEDtl'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.M_Courier_HST'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.APP_LOGGER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.GEN_APP_PARAM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VRCF_PARAM'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ACC_Receipt_Hist'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.M_UserType_HST'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AUC_AuctionList_HST'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.IMP_OHGatePassChkLst'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ACC_ReceiptDtl_Hist'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VRCF_COMBO_DTL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VMSG_HISTORY_LOGS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VRCF_JSCRIPT_DTL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VMSG_GENERATOR_TEMP'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VMSG_GENERATOR'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Migration21Mar2014'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VMSG_ErrorLog'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VMSG_DISCLAIMER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EXP_OFLGatePass_HST'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Migration20Mar2014'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Migration21-Mar-2014'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VMSG_TIME_WINDOW_M'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VRCF_PARAM_LABEL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MigrationCourier_Mst'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VRCF_TABLE_DTL_LABEL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VRCF_COLUMN_DTL_LABEL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ACC_Invoice_Hst'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.M_Global_Mapping_Hst'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.IMP_OnHoldWHLocaction'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MstPackage'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.M_DelayedChrg_MST_bak'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MSBM_HST'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.M_Airport_HST'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.M_DelayedChrg_HST'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.M_Airline_11Dec2014'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.M_Country_HST'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.M_Currency_HST'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.m_Flight_Mst_15122014'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.m_Flight_Mst_17122014'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Reasons_Master'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.m_Flight_Mst_26122014'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Pending_Detain01-Mar-2014'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.M_Warehouse_HST'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SEQ_EMPMASTER'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.IMP_GatePassDtl_Hst'. Please see the warning messages.

        public EIA_DEVContext(DbContextOptions<EIA_DEVContext> options) : base(options)
        {

        }
     
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccInvoice>(entity =>
            {
                entity.HasKey(e => e.InvoiceId);

                entity.ToTable("ACC_Invoice");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CustomCostRcvrAmt).HasColumnType("money");

                entity.Property(e => e.CustomCostRcvrChrgs).HasColumnType("money");

                entity.Property(e => e.CustomSixtyPayAmt).HasColumnType("money");

                entity.Property(e => e.CustomSixtyPayChrgs).HasColumnType("money");

                entity.Property(e => e.EntranceFees).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.ExportChargesAmt).HasColumnType("money");

                entity.Property(e => e.ExportChargesChrgs).HasColumnType("money");

                entity.Property(e => e.ExportChargesName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FacilitationAmt).HasColumnType("money");

                entity.Property(e => e.FacilitationChrgs).HasColumnType("money");

                entity.Property(e => e.ImportChargesAmt).HasColumnType("money");

                entity.Property(e => e.ImportChargesChrgs).HasColumnType("money");

                entity.Property(e => e.ImportChargesName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.McStatus)
                    .HasColumnName("MC_Status")
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.MemberShipFees).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.OutstandingStatus).HasColumnType("char(1)");

                entity.Property(e => e.PeriodFrom).HasColumnType("datetime");

                entity.Property(e => e.PeriodTo).HasColumnType("datetime");

                entity.Property(e => e.PrimaryCessAmt).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.PrimaryCessChrgs).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.ReceivedAmount).HasColumnType("money");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ScreenAirlineAmt).HasColumnType("money");

                entity.Property(e => e.ScreenAirlineChrgs).HasColumnType("money");

                entity.Property(e => e.ScreenEiciamt)
                    .HasColumnName("ScreenEICIAmt")
                    .HasColumnType("money");

                entity.Property(e => e.ScreenEicichrgs)
                    .HasColumnName("ScreenEICIChrgs")
                    .HasColumnType("money");

                entity.Property(e => e.SecondaryCessAmt).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.SecondaryCessChrgs).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.ServiceTaxAmt).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.ServiceTaxChrgs).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Status)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.SwachhBharatCessAmt).HasColumnType("money");

                entity.Property(e => e.SwachhBharatCessChrgs).HasColumnType("money");

                entity.Property(e => e.TerminalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.UserAccessAmt).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.UserAccessArea).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.UserAccessChrgs).HasColumnType("numeric(10, 2)");
            });

            modelBuilder.Entity<AccInvoiceDtl>(entity =>
            {
                entity.HasKey(e => e.InvoiceDtlId);

                entity.ToTable("ACC_InvoiceDtl");

                entity.Property(e => e.ActualDateofArrival).HasColumnType("datetime");

                entity.Property(e => e.AirlineWeight).HasColumnType("money");

                entity.Property(e => e.Eiciweight)
                    .HasColumnName("EICIWeight")
                    .HasColumnType("money");

                entity.Property(e => e.FlightNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GrossWeight).HasColumnType("money");

                entity.Property(e => e.IgmreferenceNo)
                    .HasColumnName("IGMReferenceNo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Mawbno)
                    .HasColumnName("MAWBNo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumberofShps).HasColumnType("nchar(10)");
            });

            modelBuilder.Entity<AccReceipt>(entity =>
            {
                entity.HasKey(e => e.ReceiptId);

                entity.ToTable("ACC_Receipt");

                entity.Property(e => e.ReceiptId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ExportedtoTally)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.FlightDate).HasColumnType("datetime");

                entity.Property(e => e.FlightNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GatePassId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.ReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiptNo)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceTaxAmount).HasColumnType("money");

                entity.Property(e => e.Status)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.TerminalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VersionNo).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<AccReceiptChrg>(entity =>
            {
                entity.HasKey(e => e.ReceiptId);

                entity.ToTable("ACC_ReceiptChrg");

                entity.Property(e => e.ReceiptId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CustomCostRcvrAmt).HasColumnType("money");

                entity.Property(e => e.CustomCostRcvrChrgs).HasColumnType("money");

                entity.Property(e => e.CustomSixtyPayAmt).HasColumnType("money");

                entity.Property(e => e.CustomSixtyPayChrgs).HasColumnType("money");

                entity.Property(e => e.FacilitationAmt).HasColumnType("money");

                entity.Property(e => e.FacilitationChrgs).HasColumnType("money");

                entity.Property(e => e.Igmnumber)
                    .HasColumnName("IGMNumber")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryCessAmt).HasColumnType("money");

                entity.Property(e => e.PrimaryCessChrgs).HasColumnType("money");

                entity.Property(e => e.ScreenAirlineAmt).HasColumnType("money");

                entity.Property(e => e.ScreenAirlineChrgs).HasColumnType("money");

                entity.Property(e => e.ScreenEiciamt)
                    .HasColumnName("ScreenEICIAmt")
                    .HasColumnType("money");

                entity.Property(e => e.ScreenEicichrgs)
                    .HasColumnName("ScreenEICIChrgs")
                    .HasColumnType("money");

                entity.Property(e => e.SecondaryCessAmt).HasColumnType("money");

                entity.Property(e => e.SecondaryCessChrgs).HasColumnType("money");

                entity.Property(e => e.ServiceTaxAmt).HasColumnType("money");

                entity.Property(e => e.ServiceTaxChrgs).HasColumnType("money");

                entity.Property(e => e.Weight).HasColumnType("money");
            });

            modelBuilder.Entity<AccReceiptDtl>(entity =>
            {
                entity.HasKey(e => e.ReceiptDtlId);

                entity.ToTable("ACC_ReceiptDtl");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.BalAmount).HasColumnType("money");

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChequeDate).HasColumnType("date");

                entity.Property(e => e.ChequeNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Mopcode)
                    .HasColumnName("MOPCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Tdsamount)
                    .HasColumnName("TDSAmount")
                    .HasColumnType("money");

                entity.Property(e => e.VersionNo).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<AucAuctionList>(entity =>
            {
                entity.HasKey(e => e.AucListId);

                entity.ToTable("AUC_AuctionList");

                entity.Property(e => e.AucListId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AucListDate).HasColumnType("datetime");

                entity.Property(e => e.AucListNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChequeDate).HasColumnType("datetime");

                entity.Property(e => e.ChequeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DutyAmount).HasColumnType("money");

                entity.Property(e => e.FinancialYear)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.McStatus)
                    .HasColumnName("MC_Status")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Mopcode).HasColumnName("MOPCode");

                entity.Property(e => e.Status)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TerminalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Tr6challanDate)
                    .HasColumnName("TR6ChallanDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tr6challanNo)
                    .HasColumnName("TR6ChallanNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VersionNo).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<AucAuctionListDtl>(entity =>
            {
                entity.HasKey(e => e.AucListDtlId);

                entity.ToTable("AUC_AuctionListDtl");

                entity.Property(e => e.AucListDtlId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AucListId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AucRemarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AucStatus).HasColumnType("char(2)");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.McStatus)
                    .HasColumnName("MC_Status")
                    .HasColumnType("char(1)");

                entity.Property(e => e.MemoNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OnHoldId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Status)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.VersionNo).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<AucAuctionSaleLot>(entity =>
            {
                entity.HasKey(e => e.AucSaleLotId);

                entity.ToTable("AUC_AuctionSaleLot");

                entity.Property(e => e.AucSaleLotId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AucListDtlId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AucSaleLotNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FinancialYear)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.TerminalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VersionNo).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<AucBoe>(entity =>
            {
                entity.ToTable("AUC_BOE");

                entity.Property(e => e.AucBoeid)
                    .HasColumnName("AucBOEId")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.AucBoedate)
                    .HasColumnName("AucBOEDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.AucBoeno)
                    .HasColumnName("AucBOENo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AucListId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AuctionDate).HasColumnType("datetime");

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BidderName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BidderVattinNo)
                    .HasColumnName("BidderVATTinNo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ChequeDate).HasColumnType("datetime");

                entity.Property(e => e.ChequeNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DutyAmount).HasColumnType("money");

                entity.Property(e => e.FinancialYear)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.Mopcode).HasColumnName("MOPCode");

                entity.Property(e => e.OtherCharges).HasColumnType("money");

                entity.Property(e => e.Status).HasColumnType("char(1)");

                entity.Property(e => e.TerminalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Tr6challanDate)
                    .HasColumnName("TR6ChallanDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tr6challanNo)
                    .HasColumnName("TR6ChallanNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT")
                    .HasColumnType("money");

                entity.Property(e => e.Vatperc)
                    .HasColumnName("VATPerc")
                    .HasColumnType("money");

                entity.Property(e => e.VersionNo).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<AucBoegroup>(entity =>
            {
                entity.HasKey(e => e.AucGroupId);

                entity.ToTable("AUC_BOEGroup");

                entity.Property(e => e.AucGroupId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AdditiaonlCdamount)
                    .HasColumnName("AdditiaonlCDAmount")
                    .HasColumnType("money");

                entity.Property(e => e.AdditionalInfo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AdditonalCdrate)
                    .HasColumnName("AdditonalCDRate")
                    .HasColumnType("money");

                entity.Property(e => e.AucBoeid)
                    .HasColumnName("AucBOEId")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AucGroupName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AucSaleLotNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bcd)
                    .HasColumnName("BCD")
                    .HasColumnType("money");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Custom).HasColumnType("money");

                entity.Property(e => e.Cvd)
                    .HasColumnName("CVD")
                    .HasColumnType("money");

                entity.Property(e => e.FairPrice).HasColumnType("money");

                entity.Property(e => e.FinancialYear)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.RateSd)
                    .HasColumnName("RateSD")
                    .HasColumnType("money");

                entity.Property(e => e.SalePrice).HasColumnType("money");

                entity.Property(e => e.Status).HasColumnType("char(1)");

                entity.Property(e => e.TerminalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TotalDuty).HasColumnType("money");

                entity.Property(e => e.TotalDutyRate).HasColumnType("money");

                entity.Property(e => e.VersionNo).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<AucSaleList>(entity =>
            {
                entity.ToTable("AUC_SaleList");

                entity.Property(e => e.AucListId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.AucSaleListDate).HasColumnType("datetime");

                entity.Property(e => e.BidderAddr1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BidderAddr2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BidderIdNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BidderName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BidderPhoneNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FinancialYear)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.McStatus)
                    .HasColumnName("MC_Status")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Status)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.TerminalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VattinNo)
                    .HasColumnName("VATTinNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExpCsb1>(entity =>
            {
                entity.HasKey(e => e.Csb1id);

                entity.ToTable("EXP_CSB1");

                entity.Property(e => e.Csb1id)
                    .HasColumnName("CSB1Id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CourierCoId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Csb1date)
                    .HasColumnName("CSB1Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Csb1no)
                    .HasColumnName("CSB1No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Csb1time).HasColumnName("CSB1Time");

                entity.Property(e => e.DateofDeparture).HasColumnType("datetime");

                entity.Property(e => e.EcmreferenceDocDate)
                    .HasColumnName("ECMReferenceDocDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EcmreferenceDocManifestWt)
                    .HasColumnName("ECMReferenceDocManifestWt")
                    .HasColumnType("money");

                entity.Property(e => e.EcmreferenceDocNo)
                    .HasColumnName("ECMReferenceDocNo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EcmreferenceNonDocDate)
                    .HasColumnName("ECMReferenceNonDocDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EcmreferenceNonDocManifestWt)
                    .HasColumnName("ECMReferenceNonDocManifestWt")
                    .HasColumnType("money");

                entity.Property(e => e.EcmreferenceNonDocNo)
                    .HasColumnName("ECMReferenceNonDocNo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectedDateofLanding).HasColumnType("datetime");

                entity.Property(e => e.FinYear)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FlightNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceId)
                    .HasColumnName("InvoiceID")
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.Mawbno)
                    .HasColumnName("MAWBNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RelGpClosour)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ReleaseGatePassId)
                    .HasColumnName("ReleaseGatePassID")
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).HasColumnType("char(1)");

                entity.Property(e => e.TerminalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ThokaNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VersionNo).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ExpCsb1dtl>(entity =>
            {
                entity.HasKey(e => e.Csb1dtlId);

                entity.ToTable("EXP_CSB1Dtl");

                entity.Property(e => e.Csb1dtlId)
                    .HasColumnName("CSB1DtlId")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Csb1id)
                    .HasColumnName("CSB1ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Csbtype).HasColumnName("CSBType");

                entity.Property(e => e.Csbvalue)
                    .HasColumnName("CSBValue")
                    .HasColumnType("money");

                entity.Property(e => e.Csbweight)
                    .HasColumnName("CSBWeight")
                    .HasColumnType("money");

                entity.Property(e => e.ThokaNo)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.VersionNo).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ExpCsb1weightAcceptance>(entity =>
            {
                entity.HasKey(e => e.Csb1waid);

                entity.ToTable("EXP_CSB1WeightAcceptance");

                entity.Property(e => e.Csb1waid)
                    .HasColumnName("CSB1WAId")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AirlineEmpId)
                    .HasColumnName("AirlineEmpID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CourierRepresentativeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Csb1id)
                    .HasColumnName("CSB1Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.FinYear)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.LeoissuedBy)
                    .HasColumnName("LEOIssuedBy")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Obcname)
                    .HasColumnName("OBCName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnType("char(1)");

                entity.Property(e => e.TerminalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Uomcode)
                    .HasColumnName("UOMCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VersionNo).HasDefaultValueSql("((1))");

                entity.Property(e => e.WeightRecordedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExpCsb1weightAcceptanceDtl>(entity =>
            {
                entity.HasKey(e => e.Csb1wadtlId);

                entity.ToTable("EXP_CSB1WeightAcceptanceDtl");

                entity.Property(e => e.Csb1wadtlId)
                    .HasColumnName("CSB1WADtlId")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Csb1waid)
                    .HasColumnName("CSB1WAId")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TagNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Uomcode)
                    .HasColumnName("UOMCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VersionNo).HasDefaultValueSql("((1))");

                entity.Property(e => e.Waweight)
                    .HasColumnName("WAWeight")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<ExpEntryGatePass>(entity =>
            {
                entity.HasKey(e => e.EntryGatePassId);

                entity.ToTable("EXP_EntryGatePass");

                entity.Property(e => e.EntryGatePassId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CourierCoId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Csb3).HasColumnName("CSB3");

                entity.Property(e => e.Csb4).HasColumnName("CSB4");

                entity.Property(e => e.EntryGatePassDate).HasColumnType("datetime");

                entity.Property(e => e.EntryGatePassNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntryPersonStaff)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EntryWeight).HasColumnType("money");

                entity.Property(e => e.FinYear)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FlightDate).HasColumnType("datetime");

                entity.Property(e => e.FlightNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.RtogatePassDate)
                    .HasColumnName("RTOGatePassDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.RtogatePassNo)
                    .HasColumnName("RTOGatePassNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rtoreason)
                    .HasColumnName("RTOReason")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rtoremarks)
                    .HasColumnName("RTORemarks")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnType("char(1)");

                entity.Property(e => e.TerminalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VersionNo).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ExpOflgatePass>(entity =>
            {
                entity.HasKey(e => e.Oflgpid);

                entity.ToTable("EXP_OFLGatePass");

                entity.Property(e => e.Oflgpid).HasColumnName("OFLGPID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.Csb3).HasColumnName("CSB3");

                entity.Property(e => e.Csb4).HasColumnName("CSB4");

                entity.Property(e => e.FinYear)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.OfficerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OffloadingPersonStaff)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Oflweight)
                    .HasColumnName("OFLWeight")
                    .HasColumnType("money");

                entity.Property(e => e.Reason)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnType("char(1)");

                entity.Property(e => e.TerminalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VersionNo).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ExpReleasePass>(entity =>
            {
                entity.HasKey(e => e.ReleasePassId);

                entity.ToTable("EXP_ReleasePass");

                entity.Property(e => e.ReleasePassId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AirlineStaff)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CourierCoStaff)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Csb1id)
                    .HasColumnName("CSB1Id")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Eicirepresentative)
                    .HasColumnName("EICIRepresentative")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FinYear)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.HandlingStaff)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.ReleasePassDate).HasColumnType("datetime");

                entity.Property(e => e.ReleasePassNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnType("char(1)");

                entity.Property(e => e.TerminalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VersionNo).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<GenLov>(entity =>
            {
                entity.HasKey(e => e.LovId);

                entity.ToTable("GEN_LOV");

                entity.Property(e => e.LovId)
                    .HasColumnName("LOV_ID")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.Culture)
                    .HasColumnName("CULTURE")
                    .HasMaxLength(10);

                entity.Property(e => e.LovmoduleId)
                    .HasColumnName("LOVModuleID")
                    .HasMaxLength(2);

                entity.Property(e => e.SqlStatement)
                    .HasColumnName("SQL_STATEMENT")
                    .HasMaxLength(2000);

                entity.Property(e => e.XmlHeader)
                    .HasColumnName("XML_HEADER")
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<ImpForm1>(entity =>
            {
                entity.HasKey(e => e.Form1Id);

                entity.ToTable("IMP_Form1");

                entity.Property(e => e.AirlineEmpName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AirportOfShipment)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CourierRepresentative)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CustomOfficer)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfArrival).HasColumnType("datetime");

                entity.Property(e => e.DutyOfficer)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FinYear)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FlightNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Form1No)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IgmDate).HasColumnType("datetime");

                entity.Property(e => e.IgmNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.ProvisionalIgmno).HasColumnName("ProvisionalIGMNo");

                entity.Property(e => e.SecurityOfficer)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnType("char(1)");

                entity.Property(e => e.SupervisorName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TerminalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VersionNo).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ImpForm1Dtl>(entity =>
            {
                entity.HasKey(e => e.Form1DtlId);

                entity.ToTable("IMP_Form1Dtl");

                entity.Property(e => e.ActualNoofBags).HasDefaultValueSql("((0))");

                entity.Property(e => e.ActualNoofPackages).HasDefaultValueSql("((0))");

                entity.Property(e => e.ActualNoofShps).HasDefaultValueSql("((0))");

                entity.Property(e => e.ActualWeight)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Coloader)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Mawbno)
                    .HasColumnName("MAWBNo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NoofBags).HasDefaultValueSql("((0))");

                entity.Property(e => e.NoofPackages).HasDefaultValueSql("((0))");

                entity.Property(e => e.NoofShps).HasDefaultValueSql("((0))");

                entity.Property(e => e.UldNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VersionNo).HasDefaultValueSql("((1))");

                entity.Property(e => e.Weight)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ImpForm2>(entity =>
            {
                entity.HasKey(e => e.Form2Id);

                entity.ToTable("IMP_Form2");

                entity.Property(e => e.Form2Id)
                    .HasColumnName("Form2ID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ActualDateofArrival).HasColumnType("datetime");

                entity.Property(e => e.AirportofArrival)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AirportofShipment)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CountryofExportation)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EcmreferenceDocDate)
                    .HasColumnName("ECMReferenceDocDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EcmreferenceDocManifestWt)
                    .HasColumnName("ECMReferenceDocManifestWt")
                    .HasColumnType("money");

                entity.Property(e => e.EcmreferenceDocNo)
                    .HasColumnName("ECMReferenceDocNo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EcmreferenceNonDocDate)
                    .HasColumnName("ECMReferenceNonDocDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EcmreferenceNonDocManifestWt)
                    .HasColumnName("ECMReferenceNonDocManifestWt")
                    .HasColumnType("money");

                entity.Property(e => e.EcmreferenceNonDocNo)
                    .HasColumnName("ECMReferenceNonDocNo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FinYear)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.FlightNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Form2No)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IgmreferenceDate)
                    .HasColumnName("IGMReferenceDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IgmreferenceNo)
                    .HasColumnName("IGMReferenceNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceId)
                    .HasColumnType("numeric(18, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.Mawbno)
                    .HasColumnName("MAWBNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnType("char(1)");

                entity.Property(e => e.TerminalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ThokaNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VersionNo).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ImpForm2Dtl>(entity =>
            {
                entity.HasKey(e => e.Form2DtlId);

                entity.ToTable("IMP_Form2Dtl");

                entity.Property(e => e.Form2DtlId)
                    .HasColumnName("Form2DtlID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Form2Id)
                    .HasColumnName("Form2ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ThokaNo)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.VersionNo).HasDefaultValueSql("((1))");

                entity.Property(e => e.WeightofShps).HasColumnType("money");

                entity.Property(e => e.WeightofTrans).HasColumnType("money");
            });

            modelBuilder.Entity<ImpGatePass>(entity =>
            {
                entity.HasKey(e => e.GatePassId);

                entity.ToTable("IMP_GatePass");

                entity.Property(e => e.GatePassId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AssessedValue).HasColumnType("money");

                entity.Property(e => e.Chaname)
                    .HasColumnName("CHAName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChargesApplicable)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ChargesApplicableRemarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClearedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CourierEmpId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Ddramount)
                    .HasColumnName("DDRAmount")
                    .HasColumnType("money");

                entity.Property(e => e.Ddrdate)
                    .HasColumnName("DDRDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ddrno)
                    .HasColumnName("DDRNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DelayedCharges).HasColumnType("money");

                entity.Property(e => e.DutyFeeAmount).HasColumnType("money");

                entity.Property(e => e.EcmreferenceNo)
                    .HasColumnName("ECMReferenceNo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FinYear)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Form2Id)
                    .HasColumnName("Form2ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.GatePassDate).HasColumnType("datetime");

                entity.Property(e => e.GatePassNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gptype)
                    .HasColumnName("GPType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idfnumber)
                    .HasColumnName("IDFNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IgmreferenceNo)
                    .HasColumnName("IGMReferenceNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IssueDateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.MemoNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OnHoldId)
                    .HasColumnName("OnHoldID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Personalpenalty).HasColumnType("money");

                entity.Property(e => e.PreventiveOfficer)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RedemptionFine).HasColumnType("money");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceTax).HasColumnType("money");

                entity.Property(e => e.ServiceTaxPerc)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Status).HasColumnType("char(1)");

                entity.Property(e => e.SwachhBharatCessAmt).HasColumnType("money");

                entity.Property(e => e.SwachhBharatCessPerc).HasColumnType("money");

                entity.Property(e => e.Tdsamount)
                    .HasColumnName("TDSAmount")
                    .HasColumnType("money");

                entity.Property(e => e.Tdsprc)
                    .HasColumnName("TDSPrc")
                    .HasColumnType("money");

                entity.Property(e => e.TerminalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Tpctm).HasColumnName("TPCTM");

                entity.Property(e => e.VersionNo).HasDefaultValueSql("((1))");

                entity.Property(e => e.WaiveDelayCharges).HasColumnType("money");

                entity.Property(e => e.WaiveTdscharges)
                    .HasColumnName("WaiveTDSCharges")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<ImpGatePassDtl>(entity =>
            {
                entity.HasKey(e => e.GatePassDtlId);

                entity.ToTable("IMP_GatePassDtl");

                entity.Property(e => e.GatePassDtlId)
                    .HasColumnName("GatePassDtlID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.GatePassId)
                    .HasColumnName("GatePassID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ThokaNo)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.VersionNo).HasDefaultValueSql("((1))");

                entity.Property(e => e.Weight).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<ImpOhforwarding>(entity =>
            {
                entity.HasKey(e => e.ForwardingId);

                entity.ToTable("IMP_OHForwarding");

                entity.Property(e => e.ForwardingId)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Charepresentative)
                    .HasColumnName("CHARepresentative")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CourierRepresentative)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CustomRepresentative)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EcmreferenceNo)
                    .HasColumnName("ECMReferenceNo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Form2Id)
                    .HasColumnName("Form2ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ForwardingDate).HasColumnType("datetime");

                entity.Property(e => e.ForwardingNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IgmreferenceNo)
                    .HasColumnName("IGMReferenceNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImporterRepresentative)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InwardCourierRepresentativeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InwardRemarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InwardWeight).HasColumnType("money");

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.MemoNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OnHoldId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnType("char(1)");

                entity.Property(e => e.TerminalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Year)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ImpOhgpgatePass>(entity =>
            {
                entity.HasKey(e => e.OhgpgatePassId);

                entity.ToTable("IMP_OHGPGatePass");

                entity.Property(e => e.OhgpgatePassId)
                    .HasColumnName("OHGPGatePassId")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ChaName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OhgpassessedValue)
                    .HasColumnName("OHGPAssessedValue")
                    .HasColumnType("money");

                entity.Property(e => e.Ohgpchaname)
                    .HasColumnName("OHGPCHAName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OhgpclearedBy).HasColumnName("OHGPClearedBy");

                entity.Property(e => e.OhgpcourierEmpId)
                    .HasColumnName("OHGPCourierEmpId")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.OhgpcreatedBy)
                    .HasColumnName("OHGPCreatedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OhgpcreatedOn)
                    .HasColumnName("OHGPCreatedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ohgpddramount)
                    .HasColumnName("OHGPDDRAmount")
                    .HasColumnType("money");

                entity.Property(e => e.Ohgpddrdate)
                    .HasColumnName("OHGPDDRDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ohgpddrno)
                    .HasColumnName("OHGPDDRNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OhgpdelayedCharges)
                    .HasColumnName("OHGPDelayedCharges")
                    .HasColumnType("money");

                entity.Property(e => e.OhgpecmreferenceNo)
                    .HasColumnName("OHGPECMReferenceNo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OhgpfileNo)
                    .HasColumnName("OHGPFileNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ohgpform2Id)
                    .HasColumnName("OHGPForm2ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.OhgpgatePassDate)
                    .HasColumnName("OHGPGatePassDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.OhgpgatePassNo)
                    .HasColumnName("OHGPGatePassNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ohgpgptype)
                    .HasColumnName("OHGPGPType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ohgpidfnumber)
                    .HasColumnName("OHGPIDFNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OhgpigmreferenceNo)
                    .HasColumnName("OHGPIGMReferenceNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OhgpissueDateTime)
                    .HasColumnName("OHGPIssueDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.OhgplastUpDtBy)
                    .HasColumnName("OHGPLastUpDtBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OhgplastUpDtOn)
                    .HasColumnName("OHGPLastUpDtOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.OhgpmemoNo)
                    .HasColumnName("OHGPMemoNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OhgpnoOfPks).HasColumnName("OHGPNoOfPks");

                entity.Property(e => e.OhgponHoldId)
                    .HasColumnName("OHGPOnHoldID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.OhgppreventiveOfficer)
                    .HasColumnName("OHGPPreventiveOfficer")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ohgpremarks)
                    .HasColumnName("OHGPRemarks")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OhgpserviceTax)
                    .HasColumnName("OHGPServiceTax")
                    .HasColumnType("money");

                entity.Property(e => e.Ohgpstatus)
                    .HasColumnName("OHGPStatus")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Ohgptime).HasColumnName("OHGPTime");

                entity.Property(e => e.OhgpwaiveDelayCharges)
                    .HasColumnName("OHGPWaiveDelayCharges")
                    .HasColumnType("money");

                entity.Property(e => e.OhgpwaiveTdscharges)
                    .HasColumnName("OHGPWaiveTDSCharges")
                    .HasColumnType("money");

                entity.Property(e => e.Ohgpweight).HasColumnName("OHGPWeight");

                entity.Property(e => e.PersonalPenalty).HasColumnType("money");

                entity.Property(e => e.RedemptionFees).HasColumnType("money");

                entity.Property(e => e.ServiceTaxPerc).HasColumnType("money");

                entity.Property(e => e.SwachhBharatCessAmt).HasColumnType("money");

                entity.Property(e => e.SwachhBharatCessPerc).HasColumnType("money");

                entity.Property(e => e.Tdsamount)
                    .HasColumnName("TDSAmount")
                    .HasColumnType("money");

                entity.Property(e => e.Tdsprc)
                    .HasColumnName("TDSPrc")
                    .HasColumnType("money");

                entity.Property(e => e.TerminalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ThokaNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VersionNo).HasDefaultValueSql("((1))");

                entity.Property(e => e.Year)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ImpOnHoldMemo>(entity =>
            {
                entity.HasKey(e => e.OnHoldId);

                entity.ToTable("IMP_OnHoldMemo");

                entity.Property(e => e.OnHoldId)
                    .HasColumnName("OnHoldID")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AssessedValue1).HasColumnType("money");

                entity.Property(e => e.AssessedValue1Type)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AssessedValue2).HasColumnType("money");

                entity.Property(e => e.AssessedValue2Type)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AucDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AucListId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ConsigneeAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ConsigneeContactNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ConsigneeEmailId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConsigneeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ConsigneePin)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CourierStaffName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CourierStaffRemarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Drgroup)
                    .HasColumnName("DRGroup")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EcmreferenceNo)
                    .HasColumnName("ECMReferenceNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FinYear)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Form2Id)
                    .HasColumnName("Form2ID")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.GrossWeight).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Hawbno)
                    .HasColumnName("HAWBNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IecsourceCode)
                    .HasColumnName("IECSourceCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IgmreferenceNo)
                    .HasColumnName("IGMReferenceNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImportExportCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ItemDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.MemoNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MemoUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MemoUpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.NetWeight).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Notification1SentOn).HasColumnType("datetime");

                entity.Property(e => e.Notification1SentRemarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Notification2SentOn).HasColumnType("datetime");

                entity.Property(e => e.Notification2SentRemarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OnHoldDate).HasColumnType("datetime");

                entity.Property(e => e.OnHoldTypeId).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReasonDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialRequest).HasColumnType("char(1)");

                entity.Property(e => e.Status).HasColumnType("char(1)");

                entity.Property(e => e.TerminalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ThokaNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value).HasColumnType("money");

                entity.Property(e => e.VersionNo).HasDefaultValueSql("((1))");

                entity.Property(e => e.WarehouseIdentification)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseRemarks)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MAirlineDtl>(entity =>
            {
                entity.HasKey(e => e.AirlineDtlId);

                entity.ToTable("M_Airline_Dtl");

                entity.Property(e => e.AirlineAddress1)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AirlineAddress2)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AirlineCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AirlineName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ContactEmail)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.McStatus)
                    .HasColumnName("MC_Status")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Status)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TerminalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.XrayApplicable)
                    .HasColumnName("XRayApplicable")
                    .HasColumnType("char(1)");
            });

            modelBuilder.Entity<MAirlineMst>(entity =>
            {
                entity.HasKey(e => e.AirlineId);

                entity.ToTable("M_Airline_MST");

                entity.Property(e => e.AirlineAccountingPrefix)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AirlineAddress1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AirlineAddress2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AirlineCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AirlineName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AirlinePrefix)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ContactEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.McStatus)
                    .HasColumnName("MC_Status")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Status)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TerminalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.XrayApplicable)
                    .HasColumnName("XRayApplicable")
                    .HasColumnType("char(1)");
            });

            modelBuilder.Entity<MAirportMst>(entity =>
            {
                entity.HasKey(e => e.AirportCode);

                entity.ToTable("M_Airport_MST");

                entity.Property(e => e.AirportCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AirportDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.McStatus)
                    .HasColumnName("MC_Status")
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.Status)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("('A')");
            });

            modelBuilder.Entity<MCheckListMst>(entity =>
            {
                entity.HasKey(e => e.CheckListId);

                entity.ToTable("M_CheckList_MST");

                entity.Property(e => e.CheckListId).ValueGeneratedNever();

                entity.Property(e => e.CheckListDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CheckListType)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CheckListValue1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CheckListValue2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.McStatus)
                    .HasColumnName("MC_Status")
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.Module)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Required).HasColumnType("char(1)");

                entity.Property(e => e.Status).HasColumnType("char(1)");
            });

            modelBuilder.Entity<MCommonMasterMst>(entity =>
            {
                entity.HasKey(e => e.MasterId);

                entity.ToTable("M_CommonMaster_MST");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.MasterDesc)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.MasterType)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MasterValue1)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.MasterValue2)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.MasterValue3)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.MasterValue4)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.MasterValue5)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.McStatus)
                    .HasColumnName("MC_Status")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Status).HasColumnType("char(1)");
            });

            modelBuilder.Entity<MCountryMst>(entity =>
            {
                entity.HasKey(e => e.CountryCode);

                entity.ToTable("M_Country_MST");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CountryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.McStatus)
                    .HasColumnName("MC_Status")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Status)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MCourierEmpMst>(entity =>
            {
                entity.HasKey(e => e.CourierEmpId);

                entity.ToTable("M_CourierEmp_MST");

                entity.Property(e => e.CourierEmpId).HasColumnName("CourierEmpID");

                entity.Property(e => e.AuthoriseforBoe)
                    .HasColumnName("AuthoriseforBOE")
                    .HasColumnType("char(1)");

                entity.Property(e => e.AuthoriseforGp)
                    .HasColumnName("AuthoriseforGP")
                    .HasColumnType("char(1)");

                entity.Property(e => e.AuthoriseforSecurity).HasColumnType("char(1)");

                entity.Property(e => e.CourierEmpCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CourierEmpName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Idnos)
                    .HasColumnName("IDNos")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IssuedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.McStatus)
                    .HasColumnName("MC_Status")
                    .HasColumnType("char(1)");

                entity.Property(e => e.PassNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StaffAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TerminalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TypeofId)
                    .HasColumnName("TypeofID")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MCourierMst>(entity =>
            {
                entity.HasKey(e => e.CourierCoId);

                entity.ToTable("M_Courier_MST");

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CourierCoAddr1)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CourierCoAddr2)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CourierCoCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CourierCoCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CourierCoMigratedName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CourierCoName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CourierCoRegistrationExpiryDt).HasColumnType("date");

                entity.Property(e => e.CourierCoRegistrationNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CourierCoState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CourierCoTallyName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CourierContact)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CourierEmail)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.McStatus)
                    .HasColumnName("MC_Status")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Status)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TerminalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MCurrencyMst>(entity =>
            {
                entity.HasKey(e => e.CurrencyCode);

                entity.ToTable("M_Currency_MST");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CurrencyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.McStatus)
                    .HasColumnName("MC_Status")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Status)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MDelayedChrgMst>(entity =>
            {
                entity.HasKey(e => e.ChargesId);

                entity.ToTable("M_DelayedChrg_MST");

                entity.Property(e => e.ChargesId).HasColumnName("ChargesID");

                entity.Property(e => e.ChargeType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DaysFrom).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.DaysTo).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.McStatus)
                    .HasColumnName("MC_Status")
                    .HasColumnType("char(1)");

                entity.Property(e => e.MinCap).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Module)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Per)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrevSlabAmt).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Rate).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Status)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TerminalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Uom)
                    .HasColumnName("UOM")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MFlightmasterMst>(entity =>
            {
                entity.HasKey(e => e.FlightNumber);

                entity.ToTable("M_Flightmaster_MST");

                entity.Property(e => e.FlightNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AirlineCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AirportofDeparture)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AirportofDestination)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Eta).HasColumnName("ETA");

                entity.Property(e => e.Etd).HasColumnName("ETD");

                entity.Property(e => e.FlightType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.McStatus)
                    .HasColumnName("MC_Status")
                    .HasColumnType("char(1)");

                entity.Property(e => e.MigratedFlightNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnType("char(1)");

                entity.Property(e => e.TerminalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MGlobalMappingMst>(entity =>
            {
                entity.HasKey(e => e.LoginId);

                entity.ToTable("M_Global_Mapping_Mst");

                entity.Property(e => e.LoginId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedDt).HasColumnType("datetime");

                entity.Property(e => e.McStatus)
                    .HasColumnName("MC_Status")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("char(1)");

                entity.Property(e => e.TerminalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MModeofpaymentMst>(entity =>
            {
                entity.HasKey(e => e.Mopcode);

                entity.ToTable("M_Modeofpayment_MST");

                entity.Property(e => e.Mopcode)
                    .HasColumnName("MOPCode")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.LastUpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Mopdesc)
                    .HasColumnName("MOPDesc")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MsbmTbl>(entity =>
            {
                entity.HasKey(e => e.MsbmId);

                entity.ToTable("MSBM_TBL");

                entity.Property(e => e.MsbmId).HasColumnName("MSBM_ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.McStatus)
                    .HasColumnName("MC_Status")
                    .HasColumnType("char(1)");

                entity.Property(e => e.MsbmNumber)
                    .HasColumnName("MSBM_NUMBER")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NameOfCurrier)
                    .HasColumnName("NAME_OF_CURRIER")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PkgId).HasColumnName("Pkg_Id");

                entity.Property(e => e.Pkgs).HasColumnName("PKGS");

                entity.Property(e => e.Status).HasColumnType("char(1)");

                entity.Property(e => e.UbNo).HasColumnName("UB_NO");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Weight)
                    .HasColumnName("WEIGHT")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<MTerminalMst>(entity =>
            {
                entity.HasKey(e => e.TerminalCode);

                entity.ToTable("M_Terminal_MST");

                entity.Property(e => e.TerminalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DetentionBankCreditAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DetentionCashAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DetentionFeesAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DetentionServiceTaxAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DetentionTdsaccount)
                    .HasColumnName("DetentionTDSAccount")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExpCustomCostAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExpCustomCostChrg).HasColumnType("money");

                entity.Property(e => e.ExpCustomSixtyPayAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExpCustomSixtyPayChrg).HasColumnType("money");

                entity.Property(e => e.ExpFacilitationAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExpFacilitationFee).HasColumnType("money");

                entity.Property(e => e.ExpXrayChrgAccount)
                    .HasColumnName("ExpXRayChrgAccount")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExpXrayChrgAirline)
                    .HasColumnName("ExpXRayChrgAirline")
                    .HasColumnType("money");

                entity.Property(e => e.ExpXrayChrgEici)
                    .HasColumnName("ExpXRayChrgEICI")
                    .HasColumnType("money");

                entity.Property(e => e.ExportCashAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExportChargesAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExportChargesName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExportChargesPerc).HasColumnType("money");

                entity.Property(e => e.ExportTdsaccount)
                    .HasColumnName("ExportTDSAccount")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FacilitationBankCreditAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImpCustomCostAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImpCustomCostChrg).HasColumnType("money");

                entity.Property(e => e.ImpCustomSixtyPayAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImpCustomSixtyPayChrg).HasColumnType("money");

                entity.Property(e => e.ImpFacilatationAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImpFacilitationFee).HasColumnType("money");

                entity.Property(e => e.ImportCashAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImportChargesAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImportChargesName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImportChargesPerc).HasColumnType("money");

                entity.Property(e => e.ImportTdsaccount)
                    .HasColumnName("ImportTDSAccount")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNote)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.McStatus)
                    .HasColumnName("MC_Status")
                    .HasColumnType("char(1)");

                entity.Property(e => e.MemberShipFeesAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OperationalManager)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Optional1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Optional2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Optional3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PanNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryEduCessPerc).HasColumnType("money");

                entity.Property(e => e.ReportPreview).HasColumnType("char(1)");

                entity.Property(e => e.Roaddress1)
                    .HasColumnName("ROAddress1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Roaddress2)
                    .HasColumnName("ROAddress2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Roaddress3)
                    .HasColumnName("ROAddress3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Roaddress4)
                    .HasColumnName("ROAddress4")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SaleLotAutoMode).HasColumnType("char(1)");

                entity.Property(e => e.SecondaryEduCessPerc).HasColumnType("money");

                entity.Property(e => e.ServiceTaxAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceTaxPerc).HasColumnType("money");

                entity.Property(e => e.ServiceTaxRegnNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnType("char(1)");

                entity.Property(e => e.SwachhBharatCess).HasColumnType("money");

                entity.Property(e => e.TermAddress1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TermAddress2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TermAddress3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TermAddress4)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TerminalMode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TerminalName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserAccessFeesAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WebSiteName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MUomcategoryMst>(entity =>
            {
                entity.HasKey(e => e.UomcategorId);

                entity.ToTable("M_UOMCategory_MST");

                entity.Property(e => e.UomcategorId)
                    .HasColumnName("UOMCategorId")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.McStatus)
                    .HasColumnName("MC_Status")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Status).HasColumnType("char(10)");

                entity.Property(e => e.UomcategoryName)
                    .HasColumnName("UOMCategoryName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MUomMst>(entity =>
            {
                entity.HasKey(e => e.Uomcode);

                entity.ToTable("M_UOM_MST");

                entity.Property(e => e.Uomcode)
                    .HasColumnName("UOMCode")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.McStatus)
                    .HasColumnName("MC_Status")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Status)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UomcategorId).HasColumnName("UOMCategorId");

                entity.Property(e => e.Uomname)
                    .HasColumnName("UOMName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MUploadFileMst>(entity =>
            {
                entity.HasKey(e => e.FileId);

                entity.ToTable("M_UploadFile_MST");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FilePath)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FinantcialYear)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.Module)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TerminalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MUserTypeMst>(entity =>
            {
                entity.HasKey(e => e.UserTypeId);

                entity.ToTable("M_UserType_MST");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.McStatus)
                    .HasColumnName("MC_Status")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Status)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UserTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserTypeDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MWarehouseMst>(entity =>
            {
                entity.HasKey(e => e.WarehouseCode);

                entity.ToTable("M_Warehouse_MST");

                entity.Property(e => e.WarehouseCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.McStatus)
                    .HasColumnName("MC_Status")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnType("char(1)");

                entity.Property(e => e.WarehouseLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VmsgAlertM>(entity =>
            {
                entity.HasKey(e => e.AlertId);

                entity.ToTable("VMSG_ALERT_M");

                entity.Property(e => e.AlertId)
                    .HasColumnName("ALERT_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AlertDesc)
                    .IsRequired()
                    .HasColumnName("ALERT_DESC")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AlertPriority).HasColumnName("ALERT_PRIORITY");

                entity.Property(e => e.Attachment)
                    .HasColumnName("ATTACHMENT")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AttachmentBaseFolder)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AttachmentName)
                    .HasColumnName("ATTACHMENT_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bcc)
                    .HasColumnName("BCC")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.BccGroup)
                    .HasColumnName("BCC_GROUP")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.BodyAsAttachment)
                    .HasColumnName("BODY_AS_ATTACHMENT")
                    .HasColumnType("char(1)");

                entity.Property(e => e.BodyMessageText)
                    .HasColumnName("BODY_MESSAGE_TEXT")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Cc)
                    .HasColumnName("CC")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.CcGroup)
                    .HasColumnName("CC_GROUP")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("CREATED_ON")
                    .HasColumnType("datetime");

                entity.Property(e => e.DisclaimerId).HasColumnName("DISCLAIMER_ID");

                entity.Property(e => e.DisplaySenderName)
                    .HasColumnName("DISPLAY_SENDER_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DoNotSendDay)
                    .HasColumnName("DO_NOT_SEND_DAY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MessageSubject)
                    .HasColumnName("MESSAGE_SUBJECT")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SendPickDay).HasColumnName("SEND_PICK_DAY");

                entity.Property(e => e.SendPickHour).HasColumnName("SEND_PICK_HOUR");

                entity.Property(e => e.SendType)
                    .HasColumnName("Send_Type")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Sensitivity)
                    .HasColumnName("SENSITIVITY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sourceemail)
                    .HasColumnName("SOURCEEMAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToGroup)
                    .HasColumnName("TO_GROUP")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ToId)
                    .HasColumnName("TO_ID")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("UPDATED_BY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn)
                    .HasColumnName("UPDATED_ON")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<VmsgRelation>(entity =>
            {
                entity.HasKey(e => e.RelationId);

                entity.ToTable("VMSG_RELATION");

                entity.Property(e => e.RelationId)
                    .HasColumnName("Relation_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AlertId).HasColumnName("Alert_Id");

                entity.Property(e => e.TemplateId).HasColumnName("Template_Id");

                entity.HasOne(d => d.Alert)
                    .WithMany(p => p.VmsgRelation)
                    .HasForeignKey(d => d.AlertId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VMSG_RELATION_VMSG_ALERT_M");

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.VmsgRelation)
                    .HasForeignKey(d => d.TemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VMSG_RELATION_VMSG_TEMPLATE_M");
            });

            modelBuilder.Entity<VmsgTemplateM>(entity =>
            {
                entity.HasKey(e => e.TemplateId);

                entity.ToTable("VMSG_TEMPLATE_M");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("Template_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContentType)
                    .IsRequired()
                    .HasColumnName("Content_Type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.ImagePath)
                    .HasColumnName("Image_Path")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MailType)
                    .HasColumnName("Mail_Type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateData)
                    .IsRequired()
                    .HasColumnName("Template_Data")
                    .HasColumnType("text");

                entity.Property(e => e.TemplateDesc)
                    .IsRequired()
                    .HasColumnName("Template_Desc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateSubject)
                    .IsRequired()
                    .HasColumnName("Template_Subject")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdatedOn)
                    .HasColumnName("updatedOn")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<VrcfColumnDtl>(entity =>
            {
                entity.HasKey(e => new { e.Tableid, e.ColId });

                entity.ToTable("VRCF_COLUMN_DTL");

                entity.Property(e => e.Tableid).HasColumnName("TABLEID");

                entity.Property(e => e.ColId).HasColumnName("COL_ID");

                entity.Property(e => e.AddDisplayProperty)
                    .HasColumnName("ADD_DISPLAY_PROPERTY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddRequiredFlag)
                    .HasColumnName("ADD_REQUIRED_FLAG")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddShowHdr)
                    .HasColumnName("ADD_SHOW_HDR")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddShowHdrColSpan)
                    .HasColumnName("ADD_SHOW_HDR_COL_SPAN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddShowHdrColumnseq)
                    .HasColumnName("ADD_SHOW_HDR_COLUMNSEQ")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AddShowHdrRowSpan)
                    .HasColumnName("ADD_SHOW_HDR_ROW_SPAN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddShowHdrRowno)
                    .HasColumnName("ADD_SHOW_HDR_ROWNO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ColumnColumname)
                    .HasColumnName("COLUMN_COLUMNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ColumnCopy)
                    .HasColumnName("COLUMN_COPY")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ColumnPersesion).HasColumnName("COLUMN_PERSESION");

                entity.Property(e => e.ColumnUrl)
                    .HasColumnName("COLUMN_URL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ColumnValueSql)
                    .HasColumnName("COLUMN_VALUE_SQL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ComputedColumn)
                    .HasColumnName("COMPUTED_COLUMN")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ControlAdditionalInformation)
                    .HasColumnName("CONTROL_ADDITIONAL_INFORMATION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ControlAdditionalMessage)
                    .HasColumnName("CONTROL_ADDITIONAL_Message")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ControlType)
                    .HasColumnName("CONTROL_TYPE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomSearchFlag)
                    .HasColumnName("CUSTOM_SEARCH_FLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Datalength).HasColumnName("DATALENGTH");

                entity.Property(e => e.Datatype)
                    .HasColumnName("DATATYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DbColFlag)
                    .HasColumnName("DB_COL_FLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.DbRefcolFlg)
                    .HasColumnName("DB_REFCOL_FLG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DbRefcolSql)
                    .HasColumnName("DB_REFCOL_SQL")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DbcolName)
                    .HasColumnName("DBCOL_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultVal)
                    .HasColumnName("DEFAULT_VAL")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayProperty)
                    .HasColumnName("DISPLAY_PROPERTY")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EncryptionFlag)
                    .HasColumnName("ENCRYPTION_FLAG")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ExportColLabel)
                    .HasColumnName("EXPORT_COL_LABEL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExportColSeq).HasColumnName("EXPORT_COL_SEQ");

                entity.Property(e => e.ExportFlag)
                    .HasColumnName("EXPORT_FLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InsertFlag)
                    .HasColumnName("INSERT_FLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.JsFunction)
                    .HasColumnName("JS_FUNCTION")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.PkFlag)
                    .HasColumnName("PK_FLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PopupWindowProperty)
                    .HasColumnName("POPUP_WINDOW_PROPERTY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PopupWindowValues)
                    .HasColumnName("POPUP_WINDOW_VALUES")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RangeFlag)
                    .HasColumnName("RANGE_FLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RangeValColId).HasColumnName("RANGE_VAL_COL_ID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RequiredFlag)
                    .HasColumnName("REQUIRED_FLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SearchFlg)
                    .HasColumnName("SEARCH_FLG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SendParameter)
                    .HasColumnName("SEND_PARAMETER")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SeqFlag)
                    .HasColumnName("SEQ_FLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SeqName)
                    .HasColumnName("SEQ_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SessionParameter)
                    .HasColumnName("SESSION_PARAMETER")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SessionValue)
                    .HasColumnName("SESSION_VALUE")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ShowHdr)
                    .HasColumnName("SHOW_HDR")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ShowHdrColNo)
                    .HasColumnName("SHOW_HDR_COL_NO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShowHdrColSpan)
                    .HasColumnName("SHOW_HDR_COL_SPAN")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShowHdrColumnseq)
                    .HasColumnName("SHOW_HDR_COLUMNSEQ")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShowHdrControlWidth)
                    .HasColumnName("SHOW_HDR_CONTROL_WIDTH")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShowHdrLabel)
                    .HasColumnName("SHOW_HDR_LABEL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShowHdrLabelWidth)
                    .HasColumnName("SHOW_HDR_LABEL_WIDTH")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShowHdrRowSpan)
                    .HasColumnName("SHOW_HDR_ROW_SPAN")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShowHdrRowno)
                    .HasColumnName("SHOW_HDR_ROWNO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShowList)
                    .HasColumnName("SHOW_LIST")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ShowListColAlign)
                    .HasColumnName("SHOW_LIST_COL_ALIGN")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShowListColWidth).HasColumnName("SHOW_LIST_COL_WIDTH");

                entity.Property(e => e.ShowListHeadAlign)
                    .HasColumnName("SHOW_LIST_HEAD_ALIGN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShowListLabel)
                    .HasColumnName("SHOW_LIST_LABEL")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShowListSeq).HasColumnName("SHOW_LIST_SEQ");

                entity.Property(e => e.SortExpression)
                    .HasColumnName("SORT_EXPRESSION")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SortFlag)
                    .HasColumnName("SORT_FLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SqlDataType)
                    .HasColumnName("SQL_DATA_TYPE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SqlId).HasColumnName("SQL_ID");

                entity.Property(e => e.SqlStatement)
                    .HasColumnName("SQL_STATEMENT")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Sumflag)
                    .HasColumnName("SUMFLAG")
                    .HasColumnType("char(1)");

                entity.Property(e => e.TUpper)
                    .HasColumnName("T_UPPER")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueFlag)
                    .HasColumnName("UNIQUE_FLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateFlg)
                    .HasColumnName("UPDATE_FLG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.XlsxColFlag)
                    .HasColumnName("XLSX_COL_FLAG")
                    .HasColumnType("char(1)");

                entity.Property(e => e.XlsxColumnSeq).HasColumnName("XLSX_COLUMN_SEQ");

                entity.Property(e => e.XlsxDataStyleName)
                    .HasColumnName("XLSX_DATA_STYLE_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.XlsxHeaderStyleName)
                    .HasColumnName("XLSX_HEADER_STYLE_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.XlsxHeaderText)
                    .HasColumnName("XLSX_HEADER_TEXT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.XlsxNumFormat)
                    .HasColumnName("XLSX_NUM_FORMAT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.XlsxProtectionFlag)
                    .HasColumnName("XLSX_PROTECTION_FLAG")
                    .HasColumnType("char(1)");

                entity.Property(e => e.XmlParamFlag)
                    .HasColumnName("XML_PARAM_FLAG")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.XmlParamSend)
                    .HasColumnName("XML_PARAM_SEND")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VrcfDebugDtl>(entity =>
            {
                entity.HasKey(e => e.Sequence);

                entity.ToTable("VRCF_DEBUG_DTL");

                entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");

                entity.Property(e => e.DebugDate)
                    .HasColumnName("DEBUG_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPADDRESS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LogSeq).HasColumnName("LOG_SEQ");

                entity.Property(e => e.ProcName)
                    .HasColumnName("PROC_NAME")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Sessionid)
                    .HasColumnName("SESSIONID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SqlStr)
                    .HasColumnName("SQL_STR")
                    .IsUnicode(false);

                entity.Property(e => e.StepStr)
                    .HasColumnName("STEP_STR")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.TableId).HasColumnName("TABLE_ID");

                entity.Property(e => e.Userid)
                    .HasColumnName("USERID")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VrcfTableDtl>(entity =>
            {
                entity.HasKey(e => e.TableId);

                entity.ToTable("VRCF_TABLE_DTL");

                entity.Property(e => e.TableId)
                    .HasColumnName("TableID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddtabFlag)
                    .HasColumnName("ADDTAB_FLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AuthbyColnm)
                    .HasColumnName("AUTHBY_COLNM")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AuthdtColnm)
                    .HasColumnName("AUTHDT_COLNM")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorAfterSave)
                    .HasColumnName("AUTHOR_AFTER_SAVE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorBeforeSave)
                    .HasColumnName("AUTHOR_BEFORE_SAVE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Autoauthorflag)
                    .HasColumnName("AUTOAUTHORFLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.BulkUpdateCol)
                    .HasColumnName("BULK_UPDATE_COL")
                    .HasColumnType("nchar(10)");

                entity.Property(e => e.ButtonAction)
                    .HasColumnName("BUTTON_ACTION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ButtonLabel)
                    .HasColumnName("BUTTON_LABEL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ComboControlFlag)
                    .HasColumnName("COMBO_CONTROL_FLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId)
                    .HasColumnName("COUNTRY_ID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedbyColnm)
                    .HasColumnName("CREATEDBY_COLNM")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateddtColnm)
                    .HasColumnName("CREATEDDT_COLNM")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomSaveMsg)
                    .HasColumnName("CUSTOM_SAVE_MSG")
                    .IsUnicode(false);

                entity.Property(e => e.DateLastUpdated)
                    .HasColumnName("DATE_LAST_UPDATED")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DebugFlag)
                    .HasColumnName("DEBUG_FLAG")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultSearch)
                    .HasColumnName("DEFAULT_SEARCH")
                    .HasColumnType("char(1)");

                entity.Property(e => e.DeleteFlag)
                    .HasColumnName("DELETE_FLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DllMethodName)
                    .HasColumnName("DLL_METHOD_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DllName)
                    .HasColumnName("DLL_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EditFlag)
                    .HasColumnName("EDIT_FLAG")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ExcelWorksheetGenby)
                    .HasColumnName("EXCEL_WORKSHEET_GENBY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExportOption)
                    .HasColumnName("EXPORT_OPTION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Functionid).HasColumnName("FUNCTIONID");

                entity.Property(e => e.HeaderColWidth)
                    .HasColumnName("HEADER_COL_WIDTH")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JsFileName)
                    .HasColumnName("JS_FILE_NAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedBy)
                    .HasColumnName("LAST_UPDATED_BY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ListHstHeader)
                    .HasColumnName("LIST_HST_HEADER")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ListMstHeader)
                    .HasColumnName("LIST_MST_HEADER")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ListTempHeader)
                    .HasColumnName("LIST_TEMP_HEADER")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MakerBeforeSave)
                    .HasColumnName("MAKER_BEFORE_SAVE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MakerCustomSave)
                    .HasColumnName("MAKER_CUSTOM_SAVE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MasterPageName)
                    .HasColumnName("MASTER_PAGE_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MaxColsSummary)
                    .HasColumnName("MAX_COLS_SUMMARY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MaxNoColsHeader)
                    .HasColumnName("MAX_NO_COLS_HEADER")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.McStatusColnm)
                    .HasColumnName("MC_STATUS_COLNM")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Moduleid)
                    .HasColumnName("MODULEID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NamespaceClassName)
                    .HasColumnName("NAMESPACE_CLASS_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PageHeader)
                    .HasColumnName("PAGE_HEADER")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PageLinkLable)
                    .HasColumnName("PAGE_LINK_LABLE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PageSize)
                    .HasColumnName("PAGE_SIZE")
                    .HasDefaultValueSql("((50))");

                entity.Property(e => e.PageUrl)
                    .HasColumnName("PAGE_URL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PageUrlAction)
                    .HasColumnName("PAGE_URL_ACTION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PageUrlLabel)
                    .HasColumnName("PAGE_URL_LABEL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PageUrlWindowFlag)
                    .HasColumnName("PAGE_URL_WINDOW_FLAG")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.PaginationFlag)
                    .HasColumnName("PAGINATION_FLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.PerDeleteFlag)
                    .HasColumnName("PER_DELETE_FLAG")
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.PgSizeDropdown)
                    .HasColumnName("PG_SIZE_DROPDOWN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PopupWindowProperty)
                    .HasColumnName("POPUP_WINDOW_PROPERTY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PopupWindowValues)
                    .HasColumnName("POPUP_WINDOW_VALUES")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PrintExportFlag)
                    .HasColumnName("PRINT_EXPORT_FLAG")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SaveProcName)
                    .HasColumnName("SAVE_PROC_NAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SaveSubmitflag)
                    .HasColumnName("SAVE_SUBMITFLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.SaveType)
                    .HasColumnName("SAVE_TYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SaveUrl)
                    .HasColumnName("SAVE_URL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SaveWindowflag)
                    .HasColumnName("SAVE_WINDOWFLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Schema)
                    .HasColumnName("SCHEMA")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Screentype)
                    .HasColumnName("SCREENTYPE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SelectAll)
                    .HasColumnName("SELECT_ALL")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.ShowCopy)
                    .HasColumnName("SHOW_COPY")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SortcolDefault)
                    .HasColumnName("SORTCOL_DEFAULT")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialChar)
                    .HasColumnName("SPECIAL_CHAR")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusColnm)
                    .HasColumnName("STATUS_COLNM")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SummaryColWidth)
                    .HasColumnName("SUMMARY_COL_WIDTH")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SummaryFlag)
                    .HasColumnName("SUMMARY_FLAG")
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.TableHeight).HasColumnName("TABLE_HEIGHT");

                entity.Property(e => e.TableNameHst)
                    .HasColumnName("TABLE_NAME_HST")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TableNameMst)
                    .HasColumnName("TABLE_NAME_MST")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TableNameTmp)
                    .HasColumnName("TABLE_NAME_TMP")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionFlag)
                    .HasColumnName("TRANSACTION_FLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.WhereClause)
                    .HasColumnName("WHERE_CLAUSE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.WindowsExitOption)
                    .HasColumnName("WINDOWS_EXIT_OPTION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.XlsxChecksumFlag)
                    .HasColumnName("XLSX_CHECKSUM_FLAG")
                    .HasColumnType("char(1)");

                entity.Property(e => e.XlsxExportFlag)
                    .HasColumnName("XLSX_EXPORT_FLAG")
                    .HasColumnType("char(1)");

                entity.Property(e => e.XlsxProtectionFlag)
                    .HasColumnName("XLSX_PROTECTION_FLAG")
                    .HasColumnType("char(1)");
            });

            modelBuilder.Entity<VrcfXlsxStyle>(entity =>
            {
                entity.HasKey(e => e.Stylename);

                entity.ToTable("VRCF_XLSX_STYLE");

                entity.Property(e => e.Stylename)
                    .HasColumnName("STYLENAME")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Fillcolor)
                    .IsRequired()
                    .HasColumnName("FILLCOLOR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fontcolor)
                    .IsRequired()
                    .HasColumnName("FONTCOLOR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fontname)
                    .IsRequired()
                    .HasColumnName("FONTNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fontsize).HasColumnName("FONTSIZE");

                entity.Property(e => e.Isbold)
                    .IsRequired()
                    .HasColumnName("ISBOLD")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VsecApplicationAuditTrail>(entity =>
            {
                entity.ToTable("VSEC_APPLICATION_AUDIT_TRAIL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccessedBy)
                    .IsRequired()
                    .HasColumnName("ACCESSED_BY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccessedMenu)
                    .IsRequired()
                    .HasColumnName("ACCESSED_MENU")
                    .IsUnicode(false);

                entity.Property(e => e.AccessedMenuId).HasColumnName("ACCESSED_MENU_ID");

                entity.Property(e => e.AccessedOn)
                    .HasColumnName("ACCESSED_ON")
                    .HasColumnType("datetime");

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasColumnName("IP_ADDRESS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsSuccessful)
                    .IsRequired()
                    .HasColumnName("IS_SUCCESSFUL")
                    .HasColumnType("char(1)");

                entity.Property(e => e.SessionId)
                    .IsRequired()
                    .HasColumnName("SESSION_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VsecApplications>(entity =>
            {
                entity.HasKey(e => e.ApplicationId);

                entity.ToTable("VSEC_APPLICATIONS");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationPath)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<VsecFunctionAccess>(entity =>
            {
                entity.HasKey(e => e.Faid);

                entity.ToTable("VSEC_FUNCTION_ACCESS");

                entity.Property(e => e.Faid).HasColumnName("FAID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FnId).HasColumnName("FnID");

                entity.Property(e => e.ParentFnId).HasColumnName("ParentFnID");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.VsecFunctionAccess)
                    .HasForeignKey(d => d.ApplicationId)
                    .HasConstraintName("FK_VSEC_FUNCTION_ACCESS_VSEC_APPLICATIONS");

                entity.HasOne(d => d.Fn)
                    .WithMany(p => p.VsecFunctionAccess)
                    .HasForeignKey(d => d.FnId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VSEC_FUNCTION_ACCESS_VSEC_FUNCTION_MST");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.VsecFunctionAccess)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VSEC_FUNCTION_ACCESS_VSEC_ROLE_MST");
            });

            modelBuilder.Entity<VsecFunctionMst>(entity =>
            {
                entity.HasKey(e => e.FnId);

                entity.ToTable("VSEC_FUNCTION_MST");

                entity.Property(e => e.FnId)
                    .HasColumnName("FnID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppearsInMenu).HasColumnType("char(1)");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FnDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FnDisplay)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FnUrl)
                    .HasColumnName("FnURL")
                    .HasMaxLength(260)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnType("char(1)");

                entity.Property(e => e.ShowToAll).HasColumnType("char(1)");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.VsecFunctionMst)
                    .HasForeignKey(d => d.ApplicationId)
                    .HasConstraintName("FK_VSEC_FUNCTION_MST_VSEC_APPLICATIONS");
            });

            modelBuilder.Entity<VsecLoginMst>(entity =>
            {
                entity.HasKey(e => e.LoginMid);

                entity.ToTable("VSEC_LOGIN_MST");

                entity.HasIndex(e => e.LoginId)
                    .HasName("IX_VSEC_LOGIN_M")
                    .IsUnique();

                entity.Property(e => e.LoginMid).HasColumnName("LoginMId");

                entity.Property(e => e.ActiveStatus)
                    .IsRequired()
                    .HasColumnType("char(1)");

                entity.Property(e => e.Answer1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Answer2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Answer3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDateTime).HasColumnType("datetime");

                entity.Property(e => e.LastPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastPasswordChangeDate).HasColumnType("datetime");

                entity.Property(e => e.LoginId)
                    .IsRequired()
                    .HasColumnName("LoginID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProfileId).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.UserMstId).HasColumnName("UserMstID");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.VsecLoginMst)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VSEC_LOGIN_MST_VSEC_PROFILE_MST");

                entity.HasOne(d => d.QuestionId1Navigation)
                    .WithMany(p => p.VsecLoginMstQuestionId1Navigation)
                    .HasForeignKey(d => d.QuestionId1)
                    .HasConstraintName("FK_VSEC_LOGIN_MST_VSEC_QUESTION_MST");

                entity.HasOne(d => d.QuestionId2Navigation)
                    .WithMany(p => p.VsecLoginMstQuestionId2Navigation)
                    .HasForeignKey(d => d.QuestionId2)
                    .HasConstraintName("FK_VSEC_LOGIN_MST_VSEC_QUESTION_MST1");

                entity.HasOne(d => d.QuestionId3Navigation)
                    .WithMany(p => p.VsecLoginMstQuestionId3Navigation)
                    .HasForeignKey(d => d.QuestionId3)
                    .HasConstraintName("FK_VSEC_LOGIN_MST_VSEC_QUESTION_MST2");

                entity.HasOne(d => d.UserMst)
                    .WithMany(p => p.VsecLoginMst)
                    .HasForeignKey(d => d.UserMstId)
                    .HasConstraintName("FK_VSEC_LOGIN_MST_VSEC_USER_MST");
            });

            modelBuilder.Entity<VsecProfileMst>(entity =>
            {
                entity.HasKey(e => e.ProfileId);

                entity.ToTable("VSEC_PROFILE_MST");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.McStatus)
                    .HasColumnName("MC_Status")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ProfileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnType("char(1)");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<VsecQuestionMst>(entity =>
            {
                entity.HasKey(e => e.QuestionId);

                entity.ToTable("VSEC_QUESTION_MST");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<VsecRoleMst>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("VSEC_ROLE_MST");

                entity.HasIndex(e => e.DisplayName)
                    .HasName("IX_VSEC_ROLE_MST_1")
                    .IsUnique();

                entity.HasIndex(e => e.RoleSname)
                    .HasName("IX_VSEC_ROLE_MST")
                    .IsUnique();

                entity.Property(e => e.ActiveFlag).HasColumnType("char(1)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.McStatus)
                    .HasColumnName("MC_Status")
                    .HasColumnType("char(1)");

                entity.Property(e => e.RoleSname)
                    .IsRequired()
                    .HasColumnName("RoleSName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnType("char(1)");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<VsecUserActionHst>(entity =>
            {
                entity.ToTable("VSEC_USER_ACTION_HST");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoginId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PreviousValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VsecUserMst>(entity =>
            {
                entity.HasKey(e => e.UserMstId);

                entity.ToTable("VSEC_USER_MST");

                entity.Property(e => e.UserMstId)
                    .HasColumnName("UserMstID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Area)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.EmpCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FatherName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnType("char(1)");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpDtOn).HasColumnType("datetime");

                entity.Property(e => e.McStatus)
                    .HasColumnName("MC_Status")
                    .HasColumnType("char(1)");

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.P1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.P10)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.P2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.P3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.P4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.P5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.P6)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.P7)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.P8)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.P9)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNo2)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnType("char(1)");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<VsecUserRoleMap>(entity =>
            {
                entity.HasKey(e => e.MapId);

                entity.ToTable("VSEC_USER_ROLE_MAP");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LoginMid).HasColumnName("LoginMId");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("char(1)");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.LoginM)
                    .WithMany(p => p.VsecUserRoleMap)
                    .HasForeignKey(d => d.LoginMid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VSEC_USER_ROLE_MAP_VSEC_LOGIN_MST");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.VsecUserRoleMap)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_VSEC_USER_ROLE_MAP_VSEC_ROLE_MST");
            });
        }
    }
}
