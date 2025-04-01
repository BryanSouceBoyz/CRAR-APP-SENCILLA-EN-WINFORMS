using Aplicacion_Sencilla.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Sencilla.Dato
{
    public class Usuario
    {
        List<UsuarioModel> lista = new List<UsuarioModel>();
       
        public void guardar(UsuarioModel modelo)
        {
            lista.Add(modelo);
        }
        public List<UsuarioModel> consultar()
        {
            return lista;
        }
    }
}
