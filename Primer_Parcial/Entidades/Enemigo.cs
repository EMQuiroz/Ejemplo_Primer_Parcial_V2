﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Enemigo: Personaje
    {
        private string objetivo;


        public Enemigo(string nombre, List<EHabilidades> habilidades,string objetivo)
                      :base(nombre,habilidades)
        {
            this.objetivo = objetivo;
        }


        protected override string Nombre
        {
            get
            { 
                return $"Soy {base.nombre} y  los voy a hacer puré.";
            }
        }

        /// <summary>
        /// Muestra la informacion del enemigo
        /// </summary>
        /// <returns>un string</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Nombre}");
            sb.Append(base.ToString());
            sb.AppendLine($"Su objetivo es {this.objetivo}");

            return sb.ToString();
        }
    }



}
