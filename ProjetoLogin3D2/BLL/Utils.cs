using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoLogin3D2.BLL
{
    public class Utils
    {
        public Boolean UsuarioLogado()
        {
            // Verificar se usuário está logado
            if (HttpSessionStateBase["usuario"] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}