using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SDMS_MVC_WEB.Data;

namespace SDMS_MVC_WEB.Models
{
    public class SDMSEntity
    {
        private static sdmsEntities1 _instance;

        public static sdmsEntities1 INSTANCE
        {

            get
            {

                if (_instance == null)
                {
                    _instance = new sdmsEntities1();
                }

                return _instance;
            }
        }
    }
}