using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SDMS_MVC_WEB.Models
{
    public class BMSModel
    {

        public string txtAssetNumber;
        public bool? rdoNbiYes;

        public IEnumerable<SelectListItem> cboScourCritical;
        public string txtBIPScourSubCode;
        public string txtFHWAScourSubCode;

        public string txtDeck;
        public string txtSuperstructureCond;
        public string txtTunnelCond;
        public string txtSubstructureCond;
        public string txtCulvertCond;
        public string txtStructureEvalApp;
        public string txt368AltStrEval;

        public string txtBMSCode;
        public string txt325StrEval;
        public string txtEnvCode;
        public string txtDurCode;
        public string txtDetRate;
        public string txtERLCalc;

        public string txtSqFeet;
        public string txtSqM;
        public string txtCostSqFt;
        public string txtCostSqM;
        public string txtAppReplCost;
        public string txtProjReplCost;
        public string txt329Mult;
        public string txtMaintenanceCost;
        public string txtRehabCost;
        public string txtConstructionCost;
        public string txtTotEstImpCost;
        public string txtTotEstProjConCost;
        public string txtPrelim_Est_Total_Mult;

        public string txtFacCondInd;
        public string txtAPICode;

        public string txtSufficiencyRating;
        public bool? rdo382Yes;
        public bool? rdo383Yes;
        public string txtFundingEligibility;

        public string selectedcboScourCritical;

        public BMSModel(string SIA_KEY_CODE = "0630-001")
        {


            txtAssetNumber = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C300_NPS_Asset_Number.ToString();
            rdoNbiYes = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C326_NBI_Structure;

            cboScourCritical = SDMSEntity.INSTANCE.L_113_Scour_Critical.Select(a => new SelectListItem { Text = a.C113_Scour_Crit_Code + " - " + a.Scour_Crit_Desc, Value = a.C113_Scour_Crit_Code });
            txtBIPScourSubCode = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C378_BIP_Scour_Subcode;
            txtFHWAScourSubCode = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C379_FHWA_Scour_Subcode;

            txtDeck = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C58_Deck_Cond;
            txtSuperstructureCond = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C59_Super_Str_Cond;
            txtTunnelCond = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C59T_Tunnel_Cond;
            txtSubstructureCond = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C60_Sub_Str_Cond;
            txtCulvertCond = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C62_Culvert_Cond;

            txtStructureEvalApp = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C367_Str_Condition;
            txt368AltStrEval = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C368_Alt_Struct_Eval;

            txtBMSCode = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C320_BCI_Code.ToString();
            txt325StrEval = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C325_Struct_Eval_Index.ToString();
            txtEnvCode = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C321_Env_Code.ToString();

            txtDurCode = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C322_Durability_Code.ToString();
            txtDetRate =  SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C323_Rate_Det_Code.ToString();
            txtERLCalc =  SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C324_ERL_Calculated.ToString();

            txtSqFeet = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C310_Eng_Deck_Area.ToString();
            txtSqM =  SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C310_Deck_Area.ToString();
            txtCostSqFt = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C311_Eng_Cost_Per_Unit_Deck_Area.ToString();
            txtCostSqM =  SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C311_Cost_Per_Unit_Deck_Area.ToString();
            txtAppReplCost =  SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C312_Appr_Repc_Cost.ToString();
            txtProjReplCost =  SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C329_Proj_Repl_Cost.ToString();
            txt329Mult = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C329_Proj_Repl_Cost_Mult.ToString(); 

            txtMaintenanceCost = SDMSEntity.INSTANCE.SDMS_SIA_NPS.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C227_Maint_Cost.ToString();
            txtRehabCost = SDMSEntity.INSTANCE.SDMS_SIA_NPS.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C228_Est_Rehab_Cost.ToString();  
            txtConstructionCost = SDMSEntity.INSTANCE.SDMS_SIA_NPS.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C229_Est_Const_Cost.ToString();
  
            txtTotEstImpCost = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C385_Total_Itemized_Costs.ToString();
            txtTotEstProjConCost =  SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C386_Prelim_Est_Total.ToString();
            txtPrelim_Est_Total_Mult = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C386_Prelim_Est_Total.ToString();

            txtFacCondInd = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C380_Fac_Cond_Ind.ToString();
            txtAPICode = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C391_API_Code.ToString();  

            txtSufficiencyRating =  SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C381_Sufficiency_Rating.ToString();
            rdo382Yes =  SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C382_Structurally_Deficient;
            rdo383Yes =  SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C383_Functionally_Obsolete;
            txtFundingEligibility = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C384_Funding_Eligibility;
        }
    }
}