using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quipu_BE
{
    public class UsuarioBE
    {
        private int id_usuario;
        private String nom_usuario;
        private String contrasena;
        private String correo_usuario;
        private DateTime fecha_registro;
        private DateTime fecha_ult_con;
        private String rol;
        private Boolean est_usuario;
        

        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Nom_usuario { get => nom_usuario; set => nom_usuario = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string Correo_usuario { get => correo_usuario; set => correo_usuario = value; }
        public DateTime Fecha_registro { get => fecha_registro; set => fecha_registro = value; }
        public string Rol { get => rol; set => rol = value; }
        public bool Est_usuario { get => est_usuario; set => est_usuario = value; }
        public DateTime Fecha_ult_con { get => fecha_ult_con; set => fecha_ult_con = value; }
    }
}
