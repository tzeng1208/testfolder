using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SDMS_MVC_WEB.Models
{
    public class MenuTreeItem
    {
        public string menuName { get; set; }
        public string navURL { set; get; }

        public int menuID { set; get; }

        public int parentID { set; get; }

        public string tag { set; get; }

        public string strName { set; get; }

        public string inspectionDate { set; get; }
    }
}