﻿using System;
using System.Collections.Generic;
using System.Web;
using LojaVirtual.Modelo;

namespace LojaVirtual.Fabrica
{
    public class FabricaDeUsuario
    {
        public static FabricaDeUsuario Instancia()
        {
            return Inicializadora.instancia;
        }

        private class Inicializadora
        {
            internal static readonly FabricaDeUsuario instancia = new FabricaDeUsuario();
        }

        public void ObterUsuario(Usuario usuario)
        {
            usuario.Id = Guid.NewGuid();
        }
    }
}