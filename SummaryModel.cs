using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


// don't know location
namespace SDMS_MVC_WEB.Models
{
    public class SummaryModel
    {

        public IEnumerable<SelectListItem> mainStructureMaterial;

        public IEnumerable<SelectListItem> mainStructureType;

        public IEnumerable<SelectListItem> apprSpanMaterial;

        public IEnumerable<SelectListItem> apprSpanType;

        public IEnumerable<SelectListItem> deckType;

        public IEnumerable<SelectListItem> wearingSurface;

        public IEnumerable<SelectListItem> abutment1Foundation;

        public IEnumerable<SelectListItem> abutment2Foundation;

        public IEnumerable<SelectListItem> primaryPierFoundation;

        public IEnumerable<SelectListItem> secondPierFoundation;

        public IEnumerable<SelectListItem> mainAbutMaterial;

        public IEnumerable<SelectListItem> mainPierMaterial;

        public IEnumerable<SelectListItem> NPSRoadClassification;

        public IEnumerable<string> structureHistory;

        public IEnumerable<SelectListItem> state;

        public IEnumerable<SelectListItem> cboPrimaryTunnel;

        public IEnumerable<SelectListItem> cboSecondaryTunnel;

        public IEnumerable<SelectListItem> cboFieldTeamLeader;

        public IEnumerable<SelectListItem> cboReportReview;

        public IEnumerable<SelectListItem> cboReportApproval;

        public IEnumerable<SelectListItem> cboInspectors;

        public string txtStrEvalSummary;

        public bool? chkAddSigs;

        public string txtApprovalDate;

        public string txtERL;

        public string txtInspectors;

        public string txtMainSpanBeamCount;

        public string facilityCarried;

        public string featureIntersected;

        public string milePoint;

        public string kiloPoint;

        public string location;

        public string numMainSpans;

        public string numApproachSpans;

        public string structureTotalLength;

        public string maximumSpanLength;

        public string deckWidth;

        public string curbWidth;

        public string yearBuilt;

        public string yearConstructed;

        public string skewAngle;

        public string projNo;

        public string DrawingNo;

        public bool? EstYearBuiltCheck;

        public bool? EstYearConstCheck;

        public bool? plans;

        public bool? fractureCritial;

        public bool? fractureSusceptible;

        public IEnumerable<SelectListItem> fieldTeamLeader;

        public IEnumerable<SelectListItem> reportReview;

        public IEnumerable<SelectListItem> reportApproval;

        public IEnumerable<SelectListItem> inspector;

        public string txtInspector;

        public string approvalDate;

        public string estimatedRemainingLife;

        public string ERLCalculated;

        public string evaluationSummary;

        public string summaryOverflow;

        public string remarks;

        public string selectedMainStructMaterial;

        public string selectedMainStructType;

        public string selectedSpanMaterial;

        public string selectedSpanType;

        public string selectedDeckType;

        public string selectedWearingSurface;

        public string selectedAbutment1Foundation;

        public string selectedAbutment2Foundation;

        public string selectedMainAbutMaterial;

        public string selectedMainPierMaterial;

        public string selectedNPSRoadClassification;

        public string txtMinVertClearFt;

        public string txtMinVertClearM;

        public string numApproachSpansCount;

        public string txtStrLengthFt;

        public string txtStrLengthM;

        public string txtMaxSpanLengthFt;

        public string txtMaxSpanLengthM;

        public string txtDeckWidthFt;

        public string txtDeckWidthM;

        public string txtCurbToCurbWidthFt;

        public string txtCurbToCurbWidthM;

        public string txtYearConstr;

        public bool? rdoEstBuiltYes;

        public bool? rdoEstReconYes;

        public string txtSkewAngle;

        public string txtProjectRefNo;

        public string txtPlanRefNo;

        public bool? rdoPlansYes;

        public bool? rdoFracCritYes;

        public bool? rdoFracSuscYes;

        public string txtCulvertLengthFt;

        public string txtCulvertLengthM;

        public string txtRemarks;

        public string txtLocation;

        public string txtERLCalc;

        public string txtStrEvalSummary2;

        public IEnumerable<SelectListItem> cboState;

        public IEnumerable<SelectListItem> cboStandardRemarks;

        public bool? Print_Mile_Point;

        public bool? Print_Kilo_Point;
        public SummaryModel(string SIA_KEY_CODE)
        {
            //SDMSEntity.INSTANCE.L_43_44A_Main_Struct_Material.Select(a => new SelectListItem { Text = a.C43_44A_StrMat_Code + " - " + a.Str_Mat_Desc, Value = a.C43_44A_StrMat_Code });
            
            mainStructureMaterial = SDMSEntity.INSTANCE.L_43_44A_Main_Struct_Material.Select(a => new SelectListItem { Text = a.C43_44A_StrMat_Code + " - " + a.Str_Mat_Desc, Value = a.C43_44A_StrMat_Code });

            mainStructureType = SDMSEntity.INSTANCE.L_43_44B_Main_Struct_Type.Select(a => new SelectListItem { Text = a.C43_44B_StrType_Code + " - " + a.StrType_Desc, Value = a.C43_44B_StrType_Code });

            txtMainSpanBeamCount = SDMSEntity.INSTANCE.SDMS_Summary_Comments.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().STRUC_EVAL_SUM;
            apprSpanMaterial = mainStructureMaterial.ToList(); // create two different instances of list with same values

            //apprSpanType = SDMSEntity.INSTANCE.L_43_44B_Main_Struct_Type.Select(a => new SelectListItem { Text = a.C43_44B_StrType_Code + " - " + a.StrType_Desc, Value = a.C43_44B_StrType_Code });

            apprSpanType = mainStructureType.ToList();
            
            deckType = SDMSEntity.INSTANCE.L_107_Deck_Type.Select(a => new SelectListItem { Text= a.C107_Deck_Type_Code + " - " + a.Deck_Type_Desc, Value = a.C107_Deck_Type_Code});

            wearingSurface = SDMSEntity.INSTANCE.L_108A_Wear_Surface_Type.Select(a => new SelectListItem { Text = a.C108A_WS_Type_Code + " - " + a.WS_Type_Desc, Value = a.C108A_WS_Type_Code });

            abutment1Foundation = SDMSEntity.INSTANCE.L_216_217_Foundations.Select(a => new SelectListItem { Text = a.C216_217_Foundation_Code + " - " + a.Foundation_Desc, Value = a.C216_217_Foundation_Code });

            abutment2Foundation = abutment1Foundation.ToList();

            primaryPierFoundation = abutment1Foundation.ToList();

            secondPierFoundation = abutment1Foundation.ToList();

            mainAbutMaterial = SDMSEntity.INSTANCE.L_304_Main_Abut_Material.Select(a => new SelectListItem { Text = a.C304_Main_Abut_Mat_Code + " - " + a.Main_Abut_Mat_Desc, Value = a.C304_Main_Abut_Mat_Code });

            mainPierMaterial = SDMSEntity.INSTANCE.L_305_Main_Pier_Material.Select(a => new SelectListItem { Text = a.C305_Main_Pier_Mat_Code + " - " + a.Main_Pier_Mat_Desc, Value = a.C305_Main_Pier_Mat_Code });

            state = SDMSEntity.INSTANCE.L_1_State_Code.Select(a => new SelectListItem { Text = a.C1_ST_Code + " - " + a.State_Name, Value = a.C1_ST_Code });

            facilityCarried = SDMSEntity.INSTANCE.X_SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C7_Facil_Carried;

            featureIntersected = SDMSEntity.INSTANCE.X_SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C6A_Features_Inter;

            milePoint = SDMSEntity.INSTANCE.X_SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C354_RIP_Milepoint.ToString();

            kiloPoint = SDMSEntity.INSTANCE.X_SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C354_RIP_KmPoint.ToString();

            numMainSpans = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C45_Num_Main_Spans.ToString();

            numApproachSpans = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C46_Num_Appr_Spans.ToString();

            structureTotalLength = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C49_Eng_Str_Length.ToString();

            maximumSpanLength = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C48_Eng_Max_Span_Length.ToString();

            deckWidth = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C52_Eng_Deck_Width_Out_Out.ToString();

            curbWidth = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C51_Eng_Deck_Width_Curb_Curb.ToString();

            yearBuilt = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C27_Year_Const.ToString();

            yearConstructed = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C106_Year_Recon.ToString();

            skewAngle = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C34_Skew.ToString();

            projNo = SDMSEntity.INSTANCE.SDMS_SIA_NPS.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C211_Proj_Number;

            DrawingNo = SDMSEntity.INSTANCE.SDMS_SIA_NPS.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C212_Drawing_Number;

            EstYearBuiltCheck = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C318_Year_Const_Est;

            EstYearConstCheck = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C319_Year_Reconst_Est;

            plans = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C314_Plans;

            var temp = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C317A_Bridge_Fracture_Crit;

            if (temp == null)
            {
                fractureCritial = null;
            }
            else
            {

                fractureCritial = temp.ToString() == "1" ? true : false;
            }

            temp = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C317B_Bridge_Fracture_Susc;

            if (temp == null)
            {
                fractureSusceptible = null;
            }
            else
            {

                fractureSusceptible = temp.ToString() == "1" ? true : false;
            }

            fieldTeamLeader = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Select(a => new SelectListItem { Text = a.C350_Fld_Team_Leader, Value = a.C350_Fld_Team_Leader }).Distinct();

            reportReview = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Select(a => new SelectListItem { Text = a.C352_Report_Reviewer, Value = a.C352_Report_Reviewer }).Distinct();

            reportApproval = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Select(a => new SelectListItem { Text = a.C353_Report_Approval, Value = a.C353_Report_Approval }).Distinct();

            inspector = SDMSEntity.INSTANCE.System_L_Inspectors.Select(a => new SelectListItem { Text = a.Inspector_Name, Value = a.Inspector_Name });

            txtInspector = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C351_Inspection_Team;

            chkAddSigs = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C332_Report_Approved;

            approvalDate = ((DateTime)SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C353_Report_Approval_Date).ToString("MM/dd/yyyy");

            ERLCalculated = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C324_ERL_Calculated.ToString();

            evaluationSummary = SDMSEntity.INSTANCE.SDMS_Summary_Comments.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().STRUC_EVAL_SUM;

            summaryOverflow = SDMSEntity.INSTANCE.SDMS_Summary_Comments.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().STRUC_EVAL_SUM_2;

            NPSRoadClassification = SDMSEntity.INSTANCE.SDMS_SIA_NPS.Select(a => new SelectListItem { Value = a.C208_Road_Class_Code, Text = a.C208_Road_Class_Code });
            //locaction = SDMSEntity.INSTANCE.X_SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().

            txtMinVertClearFt = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C53_Eng_Min_Vert_Clear_Over.ToString();

            txtMinVertClearM = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C53_Min_Vert_Clear_Over.ToString();

            numApproachSpansCount = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C46_Num_Appr_Spans.ToString();

            txtStrLengthFt = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C49_Eng_Str_Length.ToString();

            txtStrLengthM = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C49_Str_Length.ToString();

            txtMaxSpanLengthFt = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C48_Eng_Max_Span_Length.ToString();

            txtMaxSpanLengthM = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C48_Max_Span_Length.ToString();

            txtDeckWidthFt = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C52_Eng_Deck_Width_Out_Out.ToString();

            txtDeckWidthM = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C52_Deck_Width_Out_Out.ToString();

            txtCurbToCurbWidthFt = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C51_Eng_Deck_Width_Curb_Curb.ToString();

            txtCurbToCurbWidthM = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C51_Deck_Width_Curb_Curb.ToString();

            txtYearConstr = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C27_Year_Const.ToString();

            rdoEstBuiltYes = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C318_Year_Const_Est;

            rdoEstReconYes = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C319_Year_Reconst_Est;

            txtSkewAngle = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C34_Skew;

            txtProjectRefNo = SDMSEntity.INSTANCE.SDMS_SIA_NPS.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C211_Proj_Number;

            txtPlanRefNo = SDMSEntity.INSTANCE.SDMS_SIA_NPS.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C212_Drawing_Number;

            rdoPlansYes = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C314_Plans;

            rdoFracCritYes = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C317A_Bridge_Fracture_Crit=="1";

            rdoFracSuscYes = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C317B_Bridge_Fracture_Susc == "1";

            txtCulvertLengthFt = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C349_Eng_Culvert_Length;

            txtCulvertLengthM = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C349_Culvert_Length;

            txtRemarks = SDMSEntity.INSTANCE.SDMS_SIA_NPS.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C230_Remarks;

            cboState = SDMSEntity.INSTANCE.L_1_State_Code.Select(a => new SelectListItem { Text = a.State_Name, Value = a.C1_ST_Code });

            facilityCarried = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C7_Facil_Carried;

            featureIntersected = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C6A_Features_Inter;

            txtLocation = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C9_Location;

            Print_Mile_Point = SDMSEntity.INSTANCE.X_SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().Print_Mile_Point;

            Print_Kilo_Point = SDMSEntity.INSTANCE.X_SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().Print_Kilo_Point;

            cboSecondaryTunnel = SDMSEntity.INSTANCE.L_341A_B_Tunnel_Lining.Select(a => new SelectListItem { Text = a.C341_Tunnel_Lining_Code + "-" + a.Tunnel_Lining_Desc, Value = a.Tunnel_Lining_Desc });

            cboPrimaryTunnel = cboSecondaryTunnel.ToList();

            cboStandardRemarks = SDMSEntity.INSTANCE.L_Summary_Default_Remarks.Select(a => new SelectListItem { Text = a.Sum_Default_Remark, Value = a.Sum_Def_Remark_Code });

        }
    }
}