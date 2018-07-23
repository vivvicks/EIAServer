using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class VrcfTableDtl
    {
        public int TableId { get; set; }
        public int? Functionid { get; set; }
        public string Autoauthorflag { get; set; }
        public string TableNameTmp { get; set; }
        public string TableNameMst { get; set; }
        public string TableNameHst { get; set; }
        public string PageHeader { get; set; }
        public string ListTempHeader { get; set; }
        public string ListMstHeader { get; set; }
        public string ListHstHeader { get; set; }
        public string SortcolDefault { get; set; }
        public string PaginationFlag { get; set; }
        public int? PageSize { get; set; }
        public string PgSizeDropdown { get; set; }
        public string CreatedbyColnm { get; set; }
        public string CreateddtColnm { get; set; }
        public string AuthbyColnm { get; set; }
        public string AuthdtColnm { get; set; }
        public string StatusColnm { get; set; }
        public string McStatusColnm { get; set; }
        public string DateLastUpdated { get; set; }
        public string LastUpdatedBy { get; set; }
        public string Schema { get; set; }
        public string WhereClause { get; set; }
        public string MakerBeforeSave { get; set; }
        public string MakerCustomSave { get; set; }
        public string AuthorBeforeSave { get; set; }
        public string AuthorAfterSave { get; set; }
        public string HeaderColWidth { get; set; }
        public string ButtonLabel { get; set; }
        public string ButtonAction { get; set; }
        public string SaveUrl { get; set; }
        public string SaveWindowflag { get; set; }
        public string SaveSubmitflag { get; set; }
        public string PageUrl { get; set; }
        public string PageUrlLabel { get; set; }
        public string PageUrlAction { get; set; }
        public string PageUrlWindowFlag { get; set; }
        public string ExportOption { get; set; }
        public string SaveType { get; set; }
        public string SaveProcName { get; set; }
        public string NamespaceClassName { get; set; }
        public string DllMethodName { get; set; }
        public string DllName { get; set; }
        public string JsFileName { get; set; }
        public string SummaryFlag { get; set; }
        public string MaxColsSummary { get; set; }
        public string SummaryColWidth { get; set; }
        public int? TableHeight { get; set; }
        public string MasterPageName { get; set; }
        public string XlsxExportFlag { get; set; }
        public string XlsxChecksumFlag { get; set; }
        public string XlsxProtectionFlag { get; set; }
        public string PerDeleteFlag { get; set; }
        public string BulkUpdateCol { get; set; }
        public string EditFlag { get; set; }
        public string DeleteFlag { get; set; }
        public string AddtabFlag { get; set; }
        public string SelectAll { get; set; }
        public string ComboControlFlag { get; set; }
        public string TransactionFlag { get; set; }
        public string Screentype { get; set; }
        public string CustomSaveMsg { get; set; }
        public string DefaultSearch { get; set; }
        public string DebugFlag { get; set; }
        public string SpecialChar { get; set; }
        public string ExcelWorksheetGenby { get; set; }
        public string ShowCopy { get; set; }
        public string Moduleid { get; set; }
        public string CountryId { get; set; }
        public string MaxNoColsHeader { get; set; }
        public string PrintExportFlag { get; set; }
        public string PageLinkLable { get; set; }
        public string PopupWindowProperty { get; set; }
        public string PopupWindowValues { get; set; }
        public string WindowsExitOption { get; set; }
    }
}
