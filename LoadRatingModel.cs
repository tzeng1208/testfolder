using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SDMS_MVC_WEB.Models
{
    public class LoadRatingModel
    {

        public float? txtMult;
        public float? HSFactor;

        public float? ThreeFactor;
        public float? ThreeSTwoFactor;
        public float? ThreeThreeFactor;

        public string txtInvHL93;
        public string txtOprHL93;

        public float? txtHInvTons;
        public float? txtHInvM;

        public float? txtHsInvM;
        public float? txtHsInvTons;

        public float? txtType3InvTons;
        public float? txtType3InvM;

        public float? txtType3S2InvTons;
        public float? txtType3S2InvM;

        public float? txtType3_3InvTons;
        public float? txtType3_3InvM;

        public float? txtHOpTons;
        public float? txtHOpM;

        public float? txtHsOpTons;
        public float? txtHsOpM;

        public float? txtType3OpTons;
        public float? txtType3OpM;

        public float? txtType3S2OpTons;
        public float? txtType3S2OpM;

        public float? txtType3_3OpTons;
        public float? txtType3_3OpM;

        public bool? rdoAutoCalc; // radio button
        public bool? rdoManualOverride;

        public float? txtMaxSpanLength;

        public IEnumerable<SelectListItem> cboSuperStructMat;

        public float? txtInvSugH;
        public float? txtOpSugH;

        public float? txtInvSugHs;
        public float? txtOpSugHs;

        public float? txtInvSug3;
        public float? txtOpSug3;

        public float? txtInvSug3S2;
        public float? txtOpSug3S2;

        public float? txtInvSug3_3;
        public float? txtOpSug3_3;

        public float? txtInvCooper;
        public float? txtOprCooper;

        public IEnumerable<SelectListItem> cboDgnLoad1;
        public IEnumerable<SelectListItem> cboDgnLoad;
        public IEnumerable<SelectListItem> cboDesignedBy;

        public bool? rdoDgnLoadMeets;
        public bool? rdoLdRatingApplicable;

        // other data tab 
        public string txtDateLdRating;
        public IEnumerable<SelectListItem> cboRatedBy;
        public IEnumerable<SelectListItem> cboControlledBy;
        public IEnumerable<SelectListItem> cboOpMethod;
        public IEnumerable<SelectListItem> cboInvMethod;
        public IEnumerable<SelectListItem> cboOpMethod2;
        public IEnumerable<SelectListItem> cboInvMethod2;

        public string txtRemarks;
        public IEnumerable<SelectListItem> cboRemarks;

        public float? txtMlt;

        public LoadRatingModel(string SIA_KEY_CODE)
        {

            //txtInvHL93 = SDMSEntity.INSTANCE.SDMS_Struct_Load_Rating.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).in;

            txtHInvTons = SDMSEntity.INSTANCE.SDMS_Struct_Load_Rating.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).INV_TON_H;
            txtHInvM = SDMSEntity.INSTANCE.SDMS_Struct_Load_Rating.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).INV_MTON_H;

            txtHsInvTons = SDMSEntity.INSTANCE.SDMS_Struct_Load_Rating.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).INV_TON_HS;


            txtHsInvM = SDMSEntity.INSTANCE.SDMS_Struct_Load_Rating.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).INV_MTON_HS;

            txtType3InvTons = SDMSEntity.INSTANCE.SDMS_Struct_Load_Rating.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).INV_TON_TYPE3;
            txtType3InvM = SDMSEntity.INSTANCE.SDMS_Struct_Load_Rating.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).INV_MTON_TYPE3;

            txtType3S2InvTons = SDMSEntity.INSTANCE.SDMS_Struct_Load_Rating.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).INV_TON_TYPE3S2;
            txtType3S2InvM = SDMSEntity.INSTANCE.SDMS_Struct_Load_Rating.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).INV_MTON_TYPE3S2;

            txtType3_3InvTons = SDMSEntity.INSTANCE.SDMS_Struct_Load_Rating.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).INV_TON_TYPE33;
            txtType3_3InvM = SDMSEntity.INSTANCE.SDMS_Struct_Load_Rating.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).INV_MTON_TYPE33;

            txtHOpTons = SDMSEntity.INSTANCE.SDMS_Struct_Load_Rating.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).OP_TON_H;
            txtHOpM = SDMSEntity.INSTANCE.SDMS_Struct_Load_Rating.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).OP_MTON_H;

            txtHsOpTons = SDMSEntity.INSTANCE.SDMS_Struct_Load_Rating.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).OP_TON_HS;
            txtHsOpM = SDMSEntity.INSTANCE.SDMS_Struct_Load_Rating.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).OP_MTON_HS;

            txtType3OpTons = SDMSEntity.INSTANCE.SDMS_Struct_Load_Rating.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).OP_TON_TYPE3;
            txtType3OpM = SDMSEntity.INSTANCE.SDMS_Struct_Load_Rating.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).OP_MTON_TYPE3;

            txtType3S2OpTons = SDMSEntity.INSTANCE.SDMS_Struct_Load_Rating.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).OP_TON_TYPE3S2;
            txtType3S2OpM = SDMSEntity.INSTANCE.SDMS_Struct_Load_Rating.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).OP_MTON_TYPE3S2;

            txtType3_3OpTons = SDMSEntity.INSTANCE.SDMS_Struct_Load_Rating.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).OP_TON_TYPE33;
            txtType3_3OpM = SDMSEntity.INSTANCE.SDMS_Struct_Load_Rating.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).OP_MTON_TYPE33;

            txtMaxSpanLength = SDMSEntity.INSTANCE.SDMS_SIA_NBI.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).C48_Eng_Max_Span_Length;
            cboSuperStructMat = SDMSEntity.INSTANCE.SDMS_SIA_NBI.Select(a=>new SelectListItem{Text = a.C43A_Str_Material_Code, Value=a.C43B_Str_Type_Code});

            
            txtInvSugH = SDMSEntity.INSTANCE.L_H_Factors.FirstOrDefault(a => a.Span_Length == (double)txtMaxSpanLength).Inv_H10;
           
            calculate_others();

            txtInvCooper = SDMSEntity.INSTANCE.SDMS_Struct_Load_Rating.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).INV_RATING_COOPER;

            txtOprCooper = SDMSEntity.INSTANCE.SDMS_Struct_Load_Rating.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).OP_RATING_COOPER;

            cboDgnLoad1 = SDMSEntity.INSTANCE.L_31_Design_Load.Select(a => new SelectListItem { Value = a.C31_Design_Load_Code, Text = a.C31_Design_Load_Code + "-" + a.Design_Load_Eng_Desc });

            cboDgnLoad = SDMSEntity.INSTANCE.L_Design_Load_Remarks.Select(a => new SelectListItem { Value = a.Design_Load_Rem_Code, Text = a.Design_Load_Rem_Code + "-" + a.Design_Load_Remarks });

            cboDesignedBy = SDMSEntity.INSTANCE.L_366_Designed_By.Select(a => new SelectListItem { Value = a.C366_Design_Code, Text = a.C366_Design_Code + "-" + a.Design_Desc });

            rdoDgnLoadMeets = SDMSEntity.INSTANCE.SDMS_Struct_Load_Rating.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).CAP_DESIGN_LOAD;

            rdoLdRatingApplicable = SDMSEntity.INSTANCE.SDMS_Struct_Load_Rating.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).LOAD_CALC_APP;

            // Other Data tab

            txtDateLdRating = SDMSEntity.INSTANCE.SDMS_Struct_Load_Rating.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).DATE_LOAD_RATE.ToString() ;
            
            txtDateLdRating = String.IsNullOrEmpty(txtDateLdRating) ? txtDateLdRating: DateTime.Parse(txtDateLdRating).ToString("M/yy");

            cboRatedBy = SDMSEntity.INSTANCE.SDMS_Struct_Load_Rating.Select(a => new SelectListItem { Text = a.RATER, Value = a.RATER });
            cboControlledBy = SDMSEntity.INSTANCE.SDMS_Struct_Load_Rating.Select(a => new SelectListItem { Text = a.LOAD_RATE_CONTROL, Value = a.LOAD_RATE_CONTROL });
            cboOpMethod = SDMSEntity.INSTANCE.L_63_65_Rating_Methods.Select(a => new SelectListItem { Value = a.C63_65_Rate_Method_Code, Text = a.C63_65_Rate_Method_Code + "-" + a.Rate_Method_Desc});
            cboInvMethod = SDMSEntity.INSTANCE.L_63_65_Rating_Methods.Select(a => new SelectListItem { Value = a.C63_65_Rate_Method_Code, Text = a.C63_65_Rate_Method_Code + "-" + a.Rate_Method_Desc });
            cboOpMethod2 = SDMSEntity.INSTANCE.L_363_Opr_Rating_Methods.Select(a => new SelectListItem { Value = a.C363_Opr_Rate_Method_Code, Text = a.C363_Opr_Rate_Method_Code + "-" + a.C363_Opr_Rate_Method_Desc });
            cboInvMethod2 = cboOpMethod2.ToList();

            txtRemarks = SDMSEntity.INSTANCE.SDMS_Struct_Load_Rating.FirstOrDefault(a => a.SIA_Key_Code == SIA_KEY_CODE).LOAD_REMARKS;
            cboRemarks = SDMSEntity.INSTANCE.L_Load_Rating_STD_Remarks.Select(a => new SelectListItem { Value = a.LR_STD_Remark_Code, Text = a.LR_STD_Remark_Code + "-" + a.LR_STD_Remark_Desc });
        }

        private void calculate_others()
        {

            txtOpSugH = txtInvSugH * txtMult;

            txtInvSugHs = txtInvSugH * HSFactor;
            txtOpSugHs = txtInvSugHs * txtMult;

            txtInvSug3 = txtInvSugH * ThreeFactor;
            txtOpSug3 = txtInvSug3 * txtMult;

            txtInvSug3S2 = txtInvSugH * ThreeSTwoFactor;
            txtOpSug3S2 = txtInvSug3S2 * txtMult;

            txtInvSug3_3 = txtInvSugH * ThreeThreeFactor;
            txtOpSug3_3 = txtInvSug3_3 * txtMult;
        }
        public void update_txtInvSugH(int index)
        {

            switch (index)
            {

                case 1:

                    txtInvSugH = SDMSEntity.INSTANCE.L_H_Factors.FirstOrDefault(a => a.Span_Length == (double)txtMaxSpanLength).Inv_H10;
                    break;

                case 2:

                    txtInvSugH = SDMSEntity.INSTANCE.L_H_Factors.FirstOrDefault(a => a.Span_Length == (double)txtMaxSpanLength).Inv_H15;
                    break;

                case 3:

                    txtInvSugH = SDMSEntity.INSTANCE.L_H_Factors.FirstOrDefault(a => a.Span_Length == (double)txtMaxSpanLength).Inv_H15;
                    break;

                case 4:

                    txtInvSugH = SDMSEntity.INSTANCE.L_H_Factors.FirstOrDefault(a => a.Span_Length == (double)txtMaxSpanLength).Inv_H20;
                    break;

                case 5:

                    txtInvSugH = SDMSEntity.INSTANCE.L_H_Factors.FirstOrDefault(a => a.Span_Length == (double)txtMaxSpanLength).Inv_H20;
                    break;

            }

            calculate_others();
        }
    }
}