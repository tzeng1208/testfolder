using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Sql;
using SDMS_MVC_WEB.HelperClass;
using SDMS_MVC_WEB.Data;

namespace SDMS_MVC_WEB.Models
{
    public class BIPCodesModel
    {

        //NBI and NPS tab
        public bool? rdoNbisLengthYes;
        public IEnumerable<SelectListItem> cboUpdateType;
        public IEnumerable<SelectListItem> cboStrahnetHwyDesig;
        public IEnumerable<SelectListItem> cboTrafficDir;
        public IEnumerable<SelectListItem> cboFedLandsHwys;
        public bool? rdoBaseHwyNetYes;
        public string txtLRSInvRoute;
        public string txtSubrouteNo;
        public short? txtCostEstyear;
        public string txtBorderBRStateCode;
        public string txtBorderBRPercentResp;
        public string txtBorderBRStructNo;
        public bool? rdoTmpStrDesigYes;
        public bool? rdoNhsInvRouteYes;
        public short? txtAdttTruck;
        public bool? rdoNatlNetTrucksYes;
        public float? txtLiftBRVertClearFt;
        public float? txtLiftBRVertClearM;

        // BIP A

        public IEnumerable<SelectListItem> cboObservedScour;
        public bool? rdo314_Yes;
        public string txt328;
        public IEnumerable<SelectListItem> cbo336_1;
        public IEnumerable<SelectListItem> cbo336_2;
        public IEnumerable<SelectListItem> cboDesignedBy;
        public IEnumerable<SelectListItem> cboMainAbutMat;
        public IEnumerable<SelectListItem> cboSubstructureMat;
        public IEnumerable<SelectListItem> cboDeckMaterial;
        public IEnumerable<SelectListItem> cboJointAbutments;
        public IEnumerable<SelectListItem> cboIntegralAbutments;
        public IEnumerable<SelectListItem> cboPrimaryTunnel;
        public IEnumerable<SelectListItem> cboSecondaryTunnel;
        public IEnumerable<SelectListItem> cboBearingType;
        public IQueryable<SelectListItem> cboBearingMaterial;
        public IQueryable<SelectListItem> cboMainSpanMaterial;
        public IQueryable<SelectListItem> cboMainSpanType;
        public bool? rdoAppYes;
        public float? txtRIPMilepoint;
        public float? txtRIPKmPoint;
        public double? txtRIPLatitude;
        public double? txtRIPLongitude;
        public string txtSpeedLimitMph;
        public string txtSpeedLimitKph;
        public bool? rdoFracCritYes;
        public bool? rdoFracSuscYes;
        public bool? rdoYrConstYes;
        public bool? rdoYrReconstYes;
        public float? txtBridgeHeightFt;
        public float? txtBridgeHeightM;
        public float? txtWaterDepthFt;
        public float? txtWaterDepthM;
        public float? txtMainSpanBeams;
        public float? txtApproxBeamDepthFt;
        public float? txtApproxBeamDepthM;
        public int? txtFloorBeams;
        public int? txtStringers;
        public int? txtBeams;
        public int? txtSteelBeamAreaSqFt;
        public int? txtSteelBeamAreaSqM;
        public string txtDeckThicknessIn;
        public string txtDeckThicknessCm;
        public string txtCulvertLengthFt;
        public string txtCulvertLengthM;
        public string txtSeismicAccCo;
        public int? txtMaxColHeightFt;
        public int? txtMaxColHeightM;
        public int? txtMinAbutLengthIn;
        public int? txtMinAbutLengthCm;
        public int? txtMinPierLengthIn;
        public int? txtMinPierLengthCm;
        public IQueryable<SelectListItem> cboOpMethod2;
        public IQueryable<SelectListItem> cboInvMethod2;

        // BIP B

        public string txtPrimaryNeeds;
        public string txtProgrammedPrjNo;
        public string txtAddlData;
        public string txtInspHist;
        public IQueryable<SDMS_Special_Equipment> specialEquipmentCodeList;
        public bool? chkUbiv;
        public bool? chkBucket;
        public bool? chkBoat;
        public bool? chkRigging;
        public bool? chkLadder;
        public bool? chkOther, chkOther2, chkOther3, chkOther4, chkOther5;        
        public short? txtOtherFreq, txtOtherFreq2, txtOtherFreq3, txtOtherFreq4, txtOtherFreq5;
        public string txtOtherDesc, txtOtherDesc2, txtOtherDesc3, txtOtherDesc4, txtOtherDesc5;
        public short? txtUbivFreq, txtBucketFreq, txtBoatFreq, txtRiggingFreq, txtLadderFreq;
        public string txtUbiv, txtBucket, txtBoat, txtRigging, txtLadder;
        public string txtOther, txtOther2, txtOther3, txtOther4, txtOther5;

        public bool? chkNdeEquip, chkNdeEquip2, chkNdeEquip3, chkNdeEquip4, chkNdeEquip5;
        public short? txtNdeEquipFreq, txtNdeEquipFreq2, txtNdeEquipFreq3, txtNdeEquipFreq4, txtNdeEquipFreq5;
        public string txtNdeEquipDesc, txtNdeEquipDesc2, txtNdeEquipDesc3, txtNdeEquipDesc4, txtNdeEquipDesc5;
        public string txtNdeEquip, txtNdeEquip2, txtNdeEquip3, txtNdeEquip4, txtNdeEquip5;

        public bool? chk392Other, chk392Other2, chk392Other3, chk392Other4, chk392Other5;
        public short? txt392OtherFreq, txt392OtherFreq2, txt392OtherFreq3, txt392OtherFreq4, txt392OtherFreq5;
        public string txt392OtherDesc, txt392OtherDesc2, txt392OtherDesc3, txt392OtherDesc4, txt392OtherDesc5;
        public string txt392Other, txt392Other2, txt392Other3, txt392Other4, txt392Other5;

        // constructor
        public BIPCodesModel(string SIA_KEY_CODE = "0630-001")
        {

            //NBI and NPS tab
            rdoNbisLengthYes = SDMSEntity.INSTANCE.SDMS_SIA_NBI.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C112_NBI_Length;
            cboUpdateType = SDMSEntity.INSTANCE.SDMS_SIA_NPS.Select(a => new SelectListItem { Text = a.C200_Update_Type_Code, Value = a.C200_Update_Type_Code }).Distinct();
            cboStrahnetHwyDesig = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Select(a => new SelectListItem { Text = a.C100_STRAHNET_Code, Value = a.C100_STRAHNET_Code }).Distinct();
            cboTrafficDir = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Select(a => new SelectListItem { Text = a.C102_Dir_Traf_Code, Value = a.C102_Dir_Traf_Code }).Distinct();
            cboFedLandsHwys = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Select(a => new SelectListItem { Text = a.C105_Fed_Lands_Code, Value = a.C105_Fed_Lands_Code }).Distinct();
            rdoBaseHwyNetYes = SDMSEntity.INSTANCE.SDMS_SIA_NBI.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C12_Base_Hwy_Network;
            txtLRSInvRoute = SDMSEntity.INSTANCE.SDMS_SIA_NBI.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C13A_LRS_Inv_Route;
            txtSubrouteNo = SDMSEntity.INSTANCE.SDMS_SIA_NBI.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C13B_LRS_Subroute;
            txtCostEstyear = SDMSEntity.INSTANCE.SDMS_SIA_NBI.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C97_YearImp_Cost;
            txtBorderBRStateCode = SDMSEntity.INSTANCE.SDMS_SIA_NBI.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C98A_Border_Brg_State_Code;
            txtBorderBRPercentResp = SDMSEntity.INSTANCE.SDMS_SIA_NBI.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C98B_Border_Brg_Pct_Resp;
            txtBorderBRStructNo = SDMSEntity.INSTANCE.SDMS_SIA_NBI.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C99_Border_Brg_Str_Number;
            rdoTmpStrDesigYes = SDMSEntity.INSTANCE.SDMS_SIA_NBI.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C103_Temp_Str;
            rdoNhsInvRouteYes = SDMSEntity.INSTANCE.SDMS_SIA_NBI.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C104_NHS_Hwy;
            txtAdttTruck = SDMSEntity.INSTANCE.SDMS_SIA_NBI.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C109_ADT_Truck;
            rdoNatlNetTrucksYes = SDMSEntity.INSTANCE.SDMS_SIA_NBI.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C110_National_Trk_Network;
            txtLiftBRVertClearFt = SDMSEntity.INSTANCE.SDMS_SIA_NBI.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C116_Eng_Vert_Lift_Brg;
            txtLiftBRVertClearM = SDMSEntity.INSTANCE.SDMS_SIA_NBI.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C116_Vert_Lift_Brg;

            // BIP A

            cboObservedScour = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Select(a => new SelectListItem { Text = a.C313_Observed_Scour_Code, Value = a.C313_Observed_Scour_Code }).Distinct();
            rdo314_Yes = SDMSEntity.INSTANCE.SDMS_SIA_BIP.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C314_Plans;
            txt328 = SDMSEntity.INSTANCE.SDMS_Recm_Work_Remarks.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).PROGRAMMED_PROJECT_NUMBER;
            cbo336_1 = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Select(a => new SelectListItem { Text = a.C336A_Crash_Test_Code, Value = a.C336A_Crash_Test_Code, Selected = a.SIA_Key_Code == SIA_KEY_CODE }).Distinct();
            cbo336_2 = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Select(a => new SelectListItem { Text = a.C336B_Crash_Test_Level, Value = a.C336B_Crash_Test_Level, Selected = a.SIA_Key_Code == SIA_KEY_CODE }).Distinct();
            cboDesignedBy = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Select(a => new SelectListItem { Text = a.C366_Designed_By, Value = a.C366_Designed_By, Selected = a.SIA_Key_Code == SIA_KEY_CODE }).Distinct();
            cboMainAbutMat = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Select(a => new SelectListItem { Text = a.C304_Main_Abut_Mat_Code, Value = a.C304_Main_Abut_Mat_Code, Selected = a.SIA_Key_Code == SIA_KEY_CODE }).Distinct();
            cboSubstructureMat = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Select(a => new SelectListItem { Text = a.C305_Main_Pier_Mat_Code, Value = a.C305_Main_Pier_Mat_Code, Selected = a.SIA_Key_Code == SIA_KEY_CODE }).Distinct();
            cboDeckMaterial = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Select(a => new SelectListItem { Text = a.C307_Deck_Material_Code, Value = a.C307_Deck_Material_Code, Selected = a.SIA_Key_Code == SIA_KEY_CODE }).Distinct();
            cboJointAbutments = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Select(a => new SelectListItem { Text = a.C315_Jointless, Value = a.C315_Jointless, Selected = a.SIA_Key_Code == SIA_KEY_CODE }).Distinct();
            cboIntegralAbutments = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Select(a => new SelectListItem { Text = a.C316_Integral_Abutments, Value = a.C316_Integral_Abutments, Selected = a.SIA_Key_Code == SIA_KEY_CODE }).Distinct();
            cboPrimaryTunnel = SDMSEntity.INSTANCE.L_341A_B_Tunnel_Lining.Select(a => new SelectListItem { Text = a.Tunnel_Lining_Desc, Value = a.C341_Tunnel_Lining_Code }).Distinct();
            cboSecondaryTunnel = SDMSEntity.INSTANCE.L_341A_B_Tunnel_Lining.Select(a => new SelectListItem { Text = a.Tunnel_Lining_Desc, Value = a.C341_Tunnel_Lining_Code }).Distinct();
            cboBearingType = SDMSEntity.INSTANCE.L_342A_B_Bearing_Type.Select(a => new SelectListItem { Text = a.Bearing_Type_Description, Value = a.C342_Bearing_Type_Code }).Distinct();
            cboBearingMaterial = SDMSEntity.INSTANCE.L_342A_B_Bearing_Type.Select(a => new SelectListItem { Text = a.Bearing_Type_Description, Value = a.C342_Bearing_Type_Code }).Distinct();
            cboMainSpanMaterial = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Select(a => new SelectListItem { Text = a.C343A_Str_Mat_Code, Value = a.C343A_Str_Mat_Code, Selected = a.SIA_Key_Code == SIA_KEY_CODE }).Distinct();
            cboMainSpanType = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Select(a => new SelectListItem { Text = a.C343B_Str_Type_Code, Value = a.C343B_Str_Type_Code, Selected = a.SIA_Key_Code == SIA_KEY_CODE }).Distinct();
            rdoAppYes = SDMSEntity.INSTANCE.SDMS_SIA_BIP.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C393_Approach_Slabs.getBool("Y");

            txtRIPMilepoint = SDMSEntity.INSTANCE.SDMS_SIA_BIP.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C354_RIP_Milepoint;
            txtRIPKmPoint = SDMSEntity.INSTANCE.SDMS_SIA_BIP.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C354_RIP_KmPoint;
            txtRIPLatitude = SDMSEntity.INSTANCE.SDMS_SIA_BIP.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C355_RIP_Latitude;
            txtRIPLongitude = SDMSEntity.INSTANCE.SDMS_SIA_BIP.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C356_RIP_Longitude;
            txtSpeedLimitMph = SDMSEntity.INSTANCE.SDMS_SIA_BIP.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C303_Eng_Speed_Limit;
            txtSpeedLimitKph = SDMSEntity.INSTANCE.SDMS_SIA_BIP.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C303_Speed_Limit;
            rdoFracCritYes = SDMSEntity.INSTANCE.SDMS_SIA_BIP.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C317A_Bridge_Fracture_Crit.getBool("1");
            rdoFracSuscYes = SDMSEntity.INSTANCE.SDMS_SIA_BIP.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C317B_Bridge_Fracture_Susc.getBool("2");
            rdoYrConstYes = SDMSEntity.INSTANCE.SDMS_SIA_BIP.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C318_Year_Const_Est;
            rdoYrReconstYes = SDMSEntity.INSTANCE.SDMS_SIA_BIP.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C319_Year_Reconst_Est;
            txtBridgeHeightFt = SDMSEntity.INSTANCE.SDMS_SIA_BIP.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C301_Eng_Bridge_Height.getFormat("f2");
            txtBridgeHeightM = SDMSEntity.INSTANCE.SDMS_SIA_BIP.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C301_Bridge_Height.getFormat("f2");
            txtWaterDepthFt = SDMSEntity.INSTANCE.SDMS_SIA_BIP.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C302_Eng_Water_Depth.getNumFormat("f2");
            txtWaterDepthM = SDMSEntity.INSTANCE.SDMS_SIA_BIP.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C302_Water_Depth.getNumFormat("f2");
            txtMainSpanBeams = SDMSEntity.INSTANCE.SDMS_SIA_BIP.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C308_Number_Beams.getNumFormat("f2");
            txtApproxBeamDepthFt = SDMSEntity.INSTANCE.SDMS_SIA_BIP.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C302_Eng_Water_Depth.getNumFormat("f2");
            txtApproxBeamDepthM = SDMSEntity.INSTANCE.SDMS_SIA_BIP.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C302_Water_Depth.getNumFormat("f2");
            txtFloorBeams = SDMSEntity.INSTANCE.SDMS_SIA_BIP.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C344_Floor_Beams.getInt0ifnullFormat("D");
            txtStringers = SDMSEntity.INSTANCE.SDMS_SIA_BIP.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C345_Stringers.getInt0ifnullFormat("D");
            txtSteelBeamAreaSqFt = SDMSEntity.INSTANCE.SDMS_SIA_BIP.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C347_Eng_Steel_Beam_Area.getIntFormat("D");
            txtSteelBeamAreaSqM = SDMSEntity.INSTANCE.SDMS_SIA_BIP.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C347_Steel_Beam_Area.getIntFormat("D");
            txtDeckThicknessIn = SDMSEntity.INSTANCE.SDMS_SIA_BIP.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C348_Eng_Deck_Thickness.getStringFormat("N");
            txtDeckThicknessCm = SDMSEntity.INSTANCE.SDMS_SIA_BIP.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C348_Deck_Thickness.getStringFormat("N");
            txtCulvertLengthFt = SDMSEntity.INSTANCE.SDMS_SIA_BIP.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C349_Eng_Culvert_Length.getStringFormat("N");
            txtCulvertLengthM = SDMSEntity.INSTANCE.SDMS_SIA_BIP.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C349_Culvert_Length.getStringFormat("N");
            txtSeismicAccCo = SDMSEntity.INSTANCE.SDMS_SIA_BIP.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C371_Seismic_Acc_Co.getStringFormat("N");
            txtMaxColHeightFt = SDMSEntity.INSTANCE.SDMS_SIA_BIP.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C374_Eng_Max_Col_Height.getIntFormat("D");
            txtMaxColHeightM = SDMSEntity.INSTANCE.SDMS_SIA_BIP.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C374_Max_Col_Height.getIntFormat("D");
            txtMinAbutLengthIn = SDMSEntity.INSTANCE.SDMS_SIA_BIP.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C375_Eng_Min_Abut_Beam_Length.getIntFormat("D");
            txtMinAbutLengthCm = SDMSEntity.INSTANCE.SDMS_SIA_BIP.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C375_Min_Abut_Beam_Length.getIntFormat("D");
            txtMinPierLengthIn = SDMSEntity.INSTANCE.SDMS_SIA_BIP.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C376_Eng_Min_Pier_Beam_Length.getIntFormat("D");
            txtMinPierLengthCm = SDMSEntity.INSTANCE.SDMS_SIA_BIP.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C376_Min_Pier_Beam_Length.getIntFormat("D");
            cboOpMethod2 = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Select(a => new SelectListItem { Text = a.C363_Opr_Rate_Method_Code, Value = a.C363_Opr_Rate_Method_Code, Selected = a.SIA_Key_Code == SIA_KEY_CODE }).Distinct();
            cboInvMethod2 = SDMSEntity.INSTANCE.SDMS_SIA_BIP.Select(a => new SelectListItem { Text = a.C365_Inv_Rate_Method_Code, Value = a.C365_Inv_Rate_Method_Code, Selected = a.SIA_Key_Code == SIA_KEY_CODE }).Distinct();

            // BIP B Tab

            txtPrimaryNeeds = SDMSEntity.INSTANCE.SDMS_Recm_Work_Remarks.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).PRIMARY_NEEDS;
            txtProgrammedPrjNo = SDMSEntity.INSTANCE.SDMS_Recm_Work_Remarks.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).PROGRAMMED_PROJECT_NUMBER;
            txtAddlData = SDMSEntity.INSTANCE.SDMS_SIA_BIP.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C330_Additional_Data;
            txtInspHist = SDMSEntity.INSTANCE.SDMS_SIA_BIP.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C333_Inspection_History;
            specialEquipmentCodeList = SDMSEntity.INSTANCE.SDMS_Special_Equipment.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).AsQueryable();

            foreach (SDMS_Special_Equipment row in specialEquipmentCodeList)
            {

                switch (row.SP_Equip_Code)
                {
                    case "01":

                        chkUbiv = true;
                        txtUbivFreq = row.SP_Equip_Rec_Freq.getFormat("f2");
                        txtUbiv = row.SP_Equip_Date_Used.getFormat("M/yy").ToString();

                        break;

                    case "02":

                        chkBucket = true;
                        txtBucketFreq = row.SP_Equip_Rec_Freq.getFormat("f2");
                        txtBucket = row.SP_Equip_Date_Used.getFormat("M/yy").ToString();
                        break;

                    case "03":

                        chkBoat = true;
                        txtBoatFreq = row.SP_Equip_Rec_Freq.getFormat("f2");
                        txtBoat = row.SP_Equip_Date_Used.getFormat("M/yy").ToString();
                        break;

                    case "04":

                        chkRigging = true;
                        txtRiggingFreq = row.SP_Equip_Rec_Freq.getFormat("f2");
                        txtRigging = row.SP_Equip_Date_Used.getFormat("M/yy").ToString();
                        break;

                    case "05":

                        chkLadder = true;
                        txtLadderFreq = row.SP_Equip_Rec_Freq.getFormat("f2");
                        txtLadder = row.SP_Equip_Date_Used.getFormat("M/yy").ToString();
                        break;

                    case "06":

                        if (chkOther.HasValue && !(bool)chkOther)
                        {
                            chkOther = true;
                            txtOtherFreq = row.SP_Equip_Rec_Freq.getFormat("f2");
                            txtOther = row.SP_Equip_Date_Used.getFormat("M/yy").ToString();
                            txtOtherDesc = row.SP_Equip_Desc;
                        }
                        else if (chkOther2.HasValue && !(bool)chkOther2)
                        {
                                chkOther2 = true;
                                txtOtherFreq2 = row.SP_Equip_Rec_Freq.getFormat("f2");
                                txtOther2 = row.SP_Equip_Date_Used.getFormat("M/yy").ToString();
                                txtOtherDesc2 = row.SP_Equip_Desc;
                        }
                        else if (chkOther3.HasValue && !(bool)chkOther3)
                        {
                            chkOther3 = true;
                            txtOtherFreq3 = row.SP_Equip_Rec_Freq.getFormat("f2");
                            txtOther3 = row.SP_Equip_Date_Used.getFormat("M/yy").ToString();
                            txtOtherDesc3 = row.SP_Equip_Desc;
                        }
                        else if (chkOther4.HasValue && !(bool)chkOther4)
                        {
                            chkOther4 = true;
                            txtOtherFreq4 = row.SP_Equip_Rec_Freq.getFormat("f2");
                            txtOther4 = row.SP_Equip_Date_Used.getFormat("M/yy").ToString();
                            txtOtherDesc4 = row.SP_Equip_Desc;
                        }
                        else if (chkOther5.HasValue && !(bool)chkOther5)
                        {
                            chkOther5 = true;
                            txtOtherFreq5 = row.SP_Equip_Rec_Freq.getFormat("f2");
                            txtOther5 = row.SP_Equip_Date_Used.getFormat("M/yy").ToString();
                            txtOtherDesc5 = row.SP_Equip_Desc;
                        }

                        break;

                        case "07":

                        if (chkNdeEquip.HasValue && !(bool)chkNdeEquip)
                        {
                            chkNdeEquip = true;
                            txtNdeEquipFreq = row.SP_Equip_Rec_Freq.getFormat("f2");
                            txtNdeEquip = row.SP_Equip_Date_Used.getFormat("M/yy").ToString();
                            txtNdeEquipDesc = row.SP_Equip_Desc;
                        }
                        else if (chkNdeEquip2.HasValue && !(bool)chkNdeEquip2)
                        {

                            chkNdeEquip2 = true;
                            txtNdeEquipFreq2 = row.SP_Equip_Rec_Freq.getFormat("f2");
                            txtNdeEquip2 = row.SP_Equip_Date_Used.getFormat("M/yy").ToString();
                            txtNdeEquipDesc2 = row.SP_Equip_Desc;

                        }
                        else if (chkNdeEquip3.HasValue && !(bool)chkNdeEquip3)
                        {

                            chkNdeEquip3 = true;
                            txtNdeEquipFreq3 = row.SP_Equip_Rec_Freq.getFormat("f2");
                            txtNdeEquip3 = row.SP_Equip_Date_Used.getFormat("M/yy").ToString();
                            txtNdeEquipDesc3 = row.SP_Equip_Desc;

                        }
                        else if (chkNdeEquip4.HasValue && !(bool)chkNdeEquip4)
                        {

                            chkNdeEquip4 = true;
                            txtNdeEquipFreq4 = row.SP_Equip_Rec_Freq.getFormat("f2");
                            txtNdeEquip4 = row.SP_Equip_Date_Used.getFormat("M/yy").ToString();
                            txtNdeEquipDesc4 = row.SP_Equip_Desc;

                        }
                        else if (chkNdeEquip5.HasValue && !(bool)chkNdeEquip5)
                        {

                            chkNdeEquip5 = true;
                            txtNdeEquipFreq5 = row.SP_Equip_Rec_Freq.getFormat("f2");
                            txtNdeEquip5 = row.SP_Equip_Date_Used.getFormat("M/yy").ToString();
                            txtNdeEquipDesc5 = row.SP_Equip_Desc;

                        }

                        break;

                    case "08":

                        if (chk392Other.HasValue && !(bool)chk392Other)
                        {
                            chk392Other = true;
                            txt392OtherFreq = row.SP_Equip_Rec_Freq.getFormat("f2");
                            txt392Other = row.SP_Equip_Date_Used.getFormat("M/yy").ToString();
                            txt392OtherDesc = row.SP_Equip_Desc;
                        }
                        else if (chk392Other2.HasValue && !(bool)chk392Other2)
                        {

                            chk392Other2 = true;
                            txt392OtherFreq2 = row.SP_Equip_Rec_Freq.getFormat("f2");
                            txt392Other2 = row.SP_Equip_Date_Used.getFormat("M/yy").ToString();
                            txt392OtherDesc2 = row.SP_Equip_Desc;

                        }
                        else if (chk392Other3.HasValue && !(bool)chk392Other3)
                        {

                            chk392Other3 = true;
                            txt392OtherFreq3 = row.SP_Equip_Rec_Freq.getFormat("f2");
                            txt392Other3 = row.SP_Equip_Date_Used.getFormat("M/yy").ToString();
                            txt392OtherDesc3 = row.SP_Equip_Desc;

                        }
                        else if (chk392Other4.HasValue && !(bool)chk392Other4)
                        {

                            chk392Other4 = true;
                            txt392OtherFreq4 = row.SP_Equip_Rec_Freq.getFormat("f2");
                            txt392Other4 = row.SP_Equip_Date_Used.getFormat("M/yy").ToString();
                            txt392OtherDesc4 = row.SP_Equip_Desc;

                        }
                        else if (chk392Other5.HasValue && !(bool)chk392Other5)
                        {

                            chk392Other5 = true;
                            txt392OtherFreq5 = row.SP_Equip_Rec_Freq.getFormat("f2");
                            txt392Other5 = row.SP_Equip_Date_Used.getFormat("M/yy").ToString();
                            txt392OtherDesc5 = row.SP_Equip_Desc;

                        }
                        break;
                }
            }

        }
    }
}