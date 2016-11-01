using MicroServiceApplication.Bean;
using MicroServiceApplication.factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MicroServiceApplication.Common
{
    class CommonManager
    {
        public static List<Client> selectClient()
        {
            SelectClientForm selectClientForm = new SelectClientForm();
            selectClientForm.ShowDialog();

            if (selectClientForm.DialogResult == DialogResult.OK)
            {
                return selectClientForm.CurrClient;
            }else
            {
                return null;
            }
        }

        public static List<Accountcycle> selectAccountcycle()
        {
            SelectAccountcycleForm selectAccountcycleForm = new SelectAccountcycleForm();
            selectAccountcycleForm.ShowDialog();

            if (selectAccountcycleForm.DialogResult == DialogResult.OK)
            {
                return selectAccountcycleForm.CurrAccountcycle;
            }
            else
            {
                return null;
            }
        }

        public static Sd3000Accset selectAccset(List<Sd3000Accset> accsetList)
        {
            SelectAccsetForm saf = new SelectAccsetForm();
            saf.Sd3000AccsetList = accsetList;
            saf.ShowDialog();

            if (saf.DialogResult == DialogResult.OK)
            {
                return saf.Accset;
            }
            else
            {
                return null;
            }
        }
        //引用用友弹出账套选择界面的方法start
        public static YYT3accset selectAccset(List<YYT3accset> accsetList)
        {
            SelectT3AccsetForm staf = new SelectT3AccsetForm();
            staf.YYT3AccsetList = accsetList;
            staf.ShowDialog();

            if (staf.DialogResult == DialogResult.OK)
            {
                return staf.Accset;
            }
            else
            {
                return null;
            }
        }
        //引用用友弹出账套选择界面的方法end
    }
}
