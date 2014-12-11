using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SDMS_MVC_WEB.Models
{

    public class TopNavModel
    {


        public string selected { set; get; }
        public string strname { set; get; }
        public string inspection { set; get; }

        public IEnumerable<SelectListItem> droplist { set; get; }

    }
}