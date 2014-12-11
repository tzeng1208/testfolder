using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SDMS_MVC_WEB.Models
{
    public class DataChange {

        public string date {set; get;}
        public string user {set; get;}
        public string reason {set; get;}
    }
    public class CoverModel
    {
        public IEnumerable<SelectListItem> inspectionType { set; get; }

        public IEnumerable<SelectListItem> pAlldata { set; get; }

        public IEnumerable<SelectListItem> pReqdata { set; get; }
        public string parkName { set; get; }
        public string facilityCarried { set; get; }

        public string featureIntersected { set; get; }

        [Required]
        [Range(typeof(DateTime), "1/1/1950", "1/1/2039", ErrorMessage="Required date range from 1/1/1950 to 1/1/2039" )]
        public string dateExported { set; get; }

        public bool? C6B_Critical_Facil { set; get; }

        public bool? Print_Mile_Point { set; get; }

        public bool? Print_Kilo_Point { set; get; }

        public IEnumerable<DataChange> postAllData;

        public IEnumerable<DataChange> postRequiredData;

        // need to set to int and set and get for model binding in post back
        public int inspectionType_selected { set; get; }

        public string SIA_KEY_CODE { set; get; }

        public CoverModel()
        {

        }

        public CoverModel(string SIA_KEY_CODE="0630-001")
        {
            string parkcode = SDMSEntity.INSTANCE.SDMS_SIA_NPS.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C201_Park_Code;

            parkName = SDMSEntity.INSTANCE.L_201_Park_Code.Where(a => a.C201_Park_Code == parkcode).First().Full_Park_Name;

            facilityCarried = SDMSEntity.INSTANCE.X_SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C7_Facil_Carried;

            featureIntersected = SDMSEntity.INSTANCE.X_SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C6A_Features_Inter;

            C6B_Critical_Facil = SDMSEntity.INSTANCE.X_SDMS_SIA_NBI.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().C6B_Critical_Facil;

            Print_Mile_Point = SDMSEntity.INSTANCE.X_SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().Print_Mile_Point;

            Print_Kilo_Point = SDMSEntity.INSTANCE.X_SDMS_SIA_BIP.Where(a => a.SIA_Key_Code == SIA_KEY_CODE).First().Print_Kilo_Point;

            //postAllData = SDMSEntity.INSTANCE.sdms_posting_info.Where(a => a.SIA_Key_Code == SIA_KEY_CODE && a.post_type == "1").Select(a => new DataChange { date = a.post_date.ToString(), user = a.posted_by, reason = a.post_reason });

            //postRequiredData = SDMSEntity.INSTANCE.sdms_posting_info.Where(a => a.SIA_Key_Code == SIA_KEY_CODE && a.post_type == "2").Select(a => new DataChange { date = a.post_date.ToString(), user = a.posted_by, reason = a.post_reason });

            inspectionType = SDMSEntity.INSTANCE.L_331_Insp_Type.Select(a => new SelectListItem { Text = a.Insp_Type_Desc, Value = a.Insp_Type_Code });

            string s = "String goes here";
            string line1 = String.Format("{0,27}", s);
            string line2 = String.Format("{0,-27}", String.Format("{0," + ((27 + s.Length) / 2).ToString() + "}", s));
            string line3 = String.Format("{0,-27}", s);
            string line4 = string.Format("{0,-27}, {1, 27}", s, s);

            var temp = SDMSEntity.INSTANCE.sdms_posting_info.Where(a => a.SIA_Key_Code == SIA_KEY_CODE && a.post_type == "1");

            if (temp != null)
                pAlldata = temp.ToList().Select(a => new SelectListItem { Value = a.posting_info.ToString(), Text = string.Format("{0, -20} {1, -20} {2,-30}", a.post_date.GetValueOrDefault().ToString("MM/dd/yyyy"), a.posted_by, a.post_reason) });


            temp = SDMSEntity.INSTANCE.sdms_posting_info.Where(a => a.SIA_Key_Code == SIA_KEY_CODE && a.post_type == "2");

            if (temp != null)
                pReqdata = temp.ToList().Select(a => new SelectListItem { Value = a.posting_info.ToString(), Text = string.Format("{0, -20} {1, -20} {2,-30}", a.post_date.GetValueOrDefault().ToString("MM/dd/yyyy"), a.posted_by, a.post_reason) });

           
        }

    }
}