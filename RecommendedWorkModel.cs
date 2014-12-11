using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SDMS_MVC_WEB.HelperExtension;

namespace SDMS_MVC_WEB.Models
{
    public class Maintenance
    {

        public string btnWorkCode;
        public string txtWorkCode;

        public string txtItem;
        public string txtDescription;
        public string txtTotal;
        public string txtQty;
        public string Unit;
        public string txtUnitCost;
        public string txtAddlCost;
        public Boolean Selected;
        public bool bUpdated;
        public bool bCCUpdated;


    }

    public class REHAB
    {
        public string txtItem;
        public string txtWorkCode;
        public string txtDescription;
        public string txtTotal;
        public string txtRehab;
        public string txtConstr;
        public bool rdoRehab;
        public bool rdoConstr;
        public string txtQty;
        public string txtUnit;
        public IEnumerable<SelectListItem> cboUnit;
        public string txtUnitCost;
        public string txtAddlCost;
        public bool selected;
        public bool bUpdated;
        public bool bCCUpdated;

    }
    public class RecommendedWorkModel
    {

        public IEnumerable<SelectListItem> cboPurposeOfImpr;
        public IEnumerable<SelectListItem> cboPriorityOfImpr;
        public IEnumerable<Maintenance> maintanenceRecord;
        public IEnumerable<REHAB> REHABRecord;

        public string txtBridgeImpCost;
        public string txtRoadwayImpCost;
        public string txtTotalProjectCost;
        public string txtMaintenanceCost;
        public string txtRehabCost;
        public string txtConstructionCost;
        public string txtTotalContractMaint;
        public string txtRI_Mult;
        public string txtTPC_Mult;
        public string txtTotEstStrImpCost;
        public string txtTotEstProjConCost;
        public string txtPrelim_Est_Total_Mult;
        public string txtRemarks;
        public IEnumerable<SelectListItem> cboStdRem;
        public string txtPrimaryNeeds;
        public string txtProgrammedPrjNo;
        public string selectedcboStdRem;


        public RecommendedWorkModel(string SIA_KEY_CODE)
        {

            cboPurposeOfImpr = SDMSEntity.INSTANCE.L_226_Priority_Improvement.Select(a => new SelectListItem { Text = a.Prior_Improve_Desc, Value = a.C226_Prior_Imp_Code }).Distinct();
            cboPriorityOfImpr = cboPurposeOfImpr.ToList();
            cboStdRem = SDMSEntity.INSTANCE.L_Rec_Work_Remarks_Design.Select(a => new SelectListItem { Text = a.RecWork_Remarks, Value = a.RecWork_Code }).Distinct();

            maintanenceRecord = SDMSEntity.INSTANCE.SDMS_Recm_Work_Data.AsEnumerable().Where(a => a.SIA_Key_Code == SIA_KEY_CODE && (a.NEEDED == null || a.NEEDED == 0)).
                    Select(a => new Maintenance
                    {
                        txtItem = a.ITEM_NO,
                        txtWorkCode = a.WORK_CODE,
                        txtDescription = a.DESCRIPTION,
                        txtQty = a.QUANTITY.ToString(),
                        txtTotal = string.Format("{0:#,###0}", a.MAINT_TOTAL),
                        Unit = a.UNIT,
                        txtUnitCost = string.Format("{0:#,###0}", a.UNIT_COST),
                        txtAddlCost = string.Format("{0:#,###0}", a.ADDL_COST)
                        
                    });

            REHABRecord = SDMSEntity.INSTANCE.SDMS_Recm_Work_Data.AsEnumerable().Where(a => a.SIA_Key_Code == SIA_KEY_CODE && a.NEEDED == 5).Select(a => new REHAB
            {

                txtWorkCode = a.WORK_CODE,
                txtItem = a.ITEM_NO,
                txtDescription = a.DESCRIPTION,
                txtTotal = string.Format("{0:#,###0}",
                a.CONSTR_TOTAL),
                rdoConstr = a.CONSTR_TOTAL != 0 ? true : false,
                rdoRehab = a.CONSTR_TOTAL != 0 ? false : true,
                txtQty = string.Format("{0:#,###0}", a.QUANTITY),
                txtUnitCost = string.Format("{0:#,###0}", a.UNIT_COST),
                txtAddlCost = string.Format("{0:#,###0}", a.ADDL_COST)

            });

            txtBridgeImpCost = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C94_Brg_Imp_Cost.ToString();

            txtTotalProjectCost = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C96_Total_Project_Cost.ToString();
            txtMaintenanceCost = SDMSEntity.INSTANCE.SDMS_SIA_NPS.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C227_Maint_Cost.ToString();
            txtRehabCost = SDMSEntity.INSTANCE.SDMS_SIA_NPS.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C228_Est_Rehab_Cost.ToString();
            txtConstructionCost = SDMSEntity.INSTANCE.SDMS_SIA_NPS.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C229_Est_Const_Cost.ToString();
            txtRI_Mult = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C95_Rwy_Imp_Cost.ToString();
            txtTPC_Mult = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C96_Total_Project_Cost.ToString();
            txtTotEstStrImpCost = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C385_Total_Itemized_Costs.ToString();
            txtTotEstProjConCost = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C386_Prelim_Est_Total.ToString();
            txtPrelim_Est_Total_Mult = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C386_Prelim_Est_Total.ToString();
            txtRemarks = SDMSEntity.INSTANCE.SDMS_Recm_Work_Remarks.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().REC_WORK_REM;
        //public IEnumerable<SelectListItem> cboStdRem = 
            txtPrimaryNeeds = SDMSEntity.INSTANCE.SDMS_Recm_Work_Remarks.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().PRIMARY_NEEDS;
            txtProgrammedPrjNo = SDMSEntity.INSTANCE.SDMS_Recm_Work_Remarks.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().PROGRAMMED_PROJECT_NUMBER;
            txtTotalContractMaint = SDMSEntity.INSTANCE.SDMS_SIA_NPS.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C227_Maint_Cost.ToString();
        }
    }
}