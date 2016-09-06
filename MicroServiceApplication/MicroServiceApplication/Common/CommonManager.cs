using MicroServiceApplication.Bean;
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
    }
}
