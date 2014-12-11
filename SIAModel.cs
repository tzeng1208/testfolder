using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SDMS_MVC_WEB.Models
{
    public class SIAModel
    {

        public IQueryable<SelectListItem> cbo201Park;
        public string txt202Name;
        public IQueryable<SelectListItem> cbo203Kind;
        public string txt204No;
        public IQueryable<SelectListItem> cboStrNumberSuffix;
        public IQueryable<SelectListItem> cbo205NpsRegion;
        public short? txt206RouteCodeNo;
        public string txt207RoadSectionNo;
        public IQueryable<SelectListItem> cbo208NPSRoadClass;
        public bool? rdoRural;
        public IQueryable<SelectListItem> cboFunctionClass;
        public bool? rdo209NPSYes;
        public string txt210OperatingUnit;
        public string txt211NpsProjectNo;
        public string txt212DrawingNo;
        public IQueryable<SelectListItem> cbo21MaintainedBy;
        public IQueryable<SelectListItem> cbo22Owner;
        public IQueryable<SelectListItem> cbo43MainStructType1;
        public IQueryable<SelectListItem> cbo43MainStructType2;
        public string txt45MainSpans;

        public SIAModel()
        {

        }

        public SIAModel(string SIA_KEY_CODE)
        {

            var selectObject = SDMSEntity.INSTANCE.SDMS_SIA_NPS.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE);
            cbo201Park = SDMSEntity.INSTANCE.L_201_Park_Code.Select(a => new SelectListItem { Text = a.C201_Park_Code + "-" + a.Full_Park_Name, Value = a.C201_Park_Code, Selected=(a.C201_Park_Code==selectObject.C201_Park_Code)}).Distinct();
            txt202Name = SDMSEntity.INSTANCE.SDMS_SIA_NPS.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C202_Str_Name;
            cbo203Kind = SDMSEntity.INSTANCE.L_203_Struct_Kind.Select(a=>new SelectListItem{Text = a.C203_Str_Kind_Code, Value = a.C203_Str_Kind_Code, Selected = (a.C203_Str_Kind_Code == selectObject.C203_Str_Kind_Code)}).Distinct();
            txt204No = SDMSEntity.INSTANCE.SDMS_SIA_NPS.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C204a_Str_Number;
            cboStrNumberSuffix = SDMSEntity.INSTANCE.SDMS_SIA_NPS.Select(a => new SelectListItem { Text = a.C204b_Str_Number_Suffix, Value = a.C204b_Str_Number_Suffix }).Distinct();

            cbo205NpsRegion = SDMSEntity.INSTANCE.L_205_NPS_Region.Select(a => new SelectListItem { Text = a.C205_Region_Code, Value = a.C205_Region_Code, Selected = (a.C205_Region_Code == selectObject.C205_Region_Code) }).Distinct();
            txt206RouteCodeNo = selectObject.C206_Route_Code;
            txt207RoadSectionNo = selectObject.SIA_Key_Code.Substring(5) + selectObject.C204b_Str_Number_Suffix;
            cbo208NPSRoadClass = SDMSEntity.INSTANCE.L_208_Road_Class.Select(a => new SelectListItem { Text = a.C208_Road_Class_Code + "-" + a.Road_Class_Desc, Value = a.C208_Road_Class_Code, Selected = (a.C208_Road_Class_Code == selectObject.C208_Road_Class_Code) }).Distinct();
            string funcClass = SDMSEntity.INSTANCE.SDMS_SIA_NBI.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C26_Func_Class_Code;
            cboFunctionClass = SDMSEntity.INSTANCE.L_26_Func_Class.OrderBy(a=>a.C26_Func_Class_Code).Select(a=>new SelectListItem{ Text = a.C26_Func_Class_Code, Value = a.C26_Func_Class_Code}).Distinct();

            int sFuncClass = Convert.ToInt16(funcClass);
            

            //if ( sFuncClass< 10 && sFuncClass>=0)
            //{
            //    rdoRural = true;
            //}
            //else if (sFuncClass < 19 && sFuncClass >= 11)
            //{
            //    rdoRural = false;
            //}

            switch (sFuncClass)
            {

                case 1:

                    rdoRural = true;
                    cboFunctionClass.First().Selected = true;
                    break;

                case 2:

                    rdoRural = true;
                    cboFunctionClass.Skip(1).First().Selected = true;
                    break;

                case 6:

                    rdoRural = true;
                    cboFunctionClass.Skip(2).First().Selected = true;
                    break;

                case 7:

                    rdoRural = true;
                    cboFunctionClass.Skip(3).First().Selected = true;
                    break;

                case 8:

                    rdoRural = true;
                    cboFunctionClass.Skip(4).First().Selected = true;
                    break;

                case 9:

                    rdoRural = true;
                    cboFunctionClass.Skip(5).First().Selected = true;
                    break;

                case 11:

                    rdoRural = false;
                    cboFunctionClass.First().Selected = true;
                    break;

                case 12:

                    rdoRural = true;
                    cboFunctionClass.Skip(1).First().Selected = true;
                    break;

                case 14:

                    rdoRural = true;
                    cboFunctionClass.Skip(2).First().Selected = true;
                    break;

                case 16:

                    rdoRural = true;
                    cboFunctionClass.Skip(3).First().Selected = true;
                    break;

                case 17:

                    rdoRural = true;
                    cboFunctionClass.Skip(4).First().Selected = true;
                    break;

                case 19:

                    rdoRural = true;
                    cboFunctionClass.Skip(5).First().Selected = true;
                    break;
            }

            rdo209NPSYes = SDMSEntity.INSTANCE.SDMS_SIA_NPS.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C209_Inside_Park;
            txt210OperatingUnit = SDMSEntity.INSTANCE.SDMS_SIA_NPS.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C210_Opr_Unit;
            txt211NpsProjectNo = SDMSEntity.INSTANCE.SDMS_SIA_NPS.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C211_Proj_Number;
            txt212DrawingNo = SDMSEntity.INSTANCE.SDMS_SIA_NPS.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C212_Drawing_Number;
            cbo21MaintainedBy = SDMSEntity.INSTANCE.L_21_Maintenance_By.Select(a => new SelectListItem { Text = a.C21_Maintain_Code + "-" + a.Maintain_Desc, Value = a.C21_Maintain_Code }).Distinct();
            cbo22Owner = SDMSEntity.INSTANCE.L_22_OwnerCode.Select(a => new SelectListItem { Text = a.C22_Owner_Code + "-" + a.Owner_Desc, Value = a.C22_Owner_Code }).Distinct();
            cbo43MainStructType1 = SDMSEntity.INSTANCE.L_43_44A_Main_Struct_Material.Select(a => new SelectListItem { Text = a.C43_44A_StrMat_Code + "-" + a.Str_Mat_Desc, Value = a.C43_44A_StrMat_Code }).Distinct();
            cbo43MainStructType2 = SDMSEntity.INSTANCE.L_43_44B_Main_Struct_Type.Select(a => new SelectListItem { Text = a.C43_44B_StrType_Code + "-" + a.StrType_Desc, Value = a.C43_44B_StrType_Code }).Distinct();
            

        }

    }
}