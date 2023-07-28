using Quipu_ADO;
using Quipu_BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quipu_BL
{
    public class UsuarioBL
    {
        UsuarioADO usuarioADO = new UsuarioADO();
        public UsuarioBE ConsultaUsuario(string email)
        {
            return usuarioADO.LoginUsuario(email);
        }

        public void ActualizarConexion(string email)
        {
            usuarioADO.ActualizarConexion(email);
        }
    }
}
