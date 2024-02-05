using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckService.Config
{
    // Classe para fornecer métodos para habilitar e desabilitar controles dentro dos forms
    public static class Controle
    {
        // Método para habilitar o controle conforme o Tipo
        public static void habilitarControles<T>(Control.ControlCollection controles)
        {
            foreach (Control control in controles)
            {
                if (control is T)
                {
                    control.Enabled = true;
                }
            }
        }

        // Método para desabilitar o controle conforme o Tipo
        public static void desabilitarControles<T>(Control.ControlCollection controles)
        {
            foreach (Control control in controles)
            {
                if (control is T)
                {
                    control.Enabled = false;
                }
            }
        }
    }
}
