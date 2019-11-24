using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    class AppManager:ApplicationContext
    {
        public AppManager()
        {
            if(Splash())
            {
                DialogResult EE = DialogResult.OK;

                do
                {
                    if (Login())
                    {
                        Principal frm = new Principal();
                        EE = frm.ShowDialog();
                    }
                    else
                    {
                        EE = DialogResult.OK;
                    }

                } while (EE == DialogResult.Ignore);

                Application.Exit();
            }
        }
        private Boolean Splash()
        {
            Boolean Comprobacion = true;
            Splash frm = new Splash();
            frm.ShowDialog();
            return Comprobacion;
        }
        private Boolean Login()
        {
            Login frm = new Login();
            frm.ShowDialog();

            return frm.Autorizado;
        }
    }
}
