using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SDMS_MVC_WEB.Models;
using SDMS_MVC_WEB.Data;

namespace SDMS_MVC_WEB.Models
{
    public class MenuTree
    {
        public List<MenuTreeItem> menuList;

        public static MenuTree _treeinstance;

        public List<MenuTreeItem> getTree()
        {
            return menuList;
        }

        public MenuTree()
        {

            sdmsEntities1 myentity = new sdmsEntities1();

            menuList = new List<MenuTreeItem>();

            var p1 = myentity.X_SDMS_SIA_NPS.Select(a => a.C201_Park_Code).Distinct();
            var p2 = myentity.SDMS_SIA_NPS.Select(a => a.C201_Park_Code).Distinct();

            IEnumerable<L_201_Park_Code> list = myentity.L_201_Park_Code.Where(a => (p1.Contains(a.C201_Park_Code) || p2.Contains(a.C201_Park_Code)));

            int id = 0;
            foreach (L_201_Park_Code item in list)
            {

                MenuTreeItem k = new MenuTreeItem();
                k.menuName = String.Format("{0} {1}", item.C201_Park_Code, item.Park_Abbrev);
                k.parentID = 0;
                id++;
                k.menuID = id;
                k.tag = item.C201_Park_Code;

                menuList.Add(k);

                var components = from a in myentity.SDMS_SIA_NPS
                                 join b in myentity.SDMS_SIA_BIP
                                 on a.SIA_Key_Code equals b.SIA_Key_Code
                                 where a.C201_Park_Code == item.C201_Park_Code
                                 select new { a.SIA_Key_Code, a.C204b_Str_Number_Suffix, a.C200_Update_Type_Code, a.C202_Str_Name, b.C390_Insp_Date };

                //var components = myentity.SDMS_SIA_NPS.Where(a => a.C201_Park_Code == item.C201_Park_Code).Select(a => new { a.SIA_Key_Code, a.C204b_Str_Number_Suffix, a.C200_Update_Type_Code });

                if (components != null)
                {

                    int parentid = id;

                    foreach (var component in components)
                    {

                        MenuTreeItem child = new MenuTreeItem();
                        if (component.C200_Update_Type_Code == "D")
                        {
                            child.menuName = string.Format("{0}{1} D", component.SIA_Key_Code, component.C204b_Str_Number_Suffix);
                        }
                        else
                        {
                            child.menuName = string.Format("{0}{1}", component.SIA_Key_Code, component.C204b_Str_Number_Suffix);
                        }

                        child.parentID = parentid;
                        id++;
                        child.menuID = id;
                        child.navURL = component.SIA_Key_Code;
                        child.tag = component.SIA_Key_Code;
                        child.strName = component.C202_Str_Name;
                        child.inspectionDate = component.C390_Insp_Date.HasValue ? ((DateTime)component.C390_Insp_Date).ToString("MM/dd/yyyy") : string.Empty;

                        menuList.Add(child);
                    }
                }
            }

        }

        public int count()
        {
            return menuList.Count;
        }

        public void addItem(MenuTreeItem temp)
        {

            menuList.Add(temp);

        }

        public static MenuTree instance
        {

            get
            {

                if (_treeinstance == null)
                {

                    _treeinstance = new MenuTree();
                    
                }

                return _treeinstance;

            }

        }
    }
}