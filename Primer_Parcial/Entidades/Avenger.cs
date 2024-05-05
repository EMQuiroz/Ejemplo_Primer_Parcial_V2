using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Avenger: Personaje
    {
        EEquipamiento eEquipamento;

        public Avenger(string nombre, List<EHabilidades> habilidades, EEquipamiento eq)
                      :base(nombre,habilidades)
        {
            this.eEquipamento = eq;

        }

        


        
        protected override string Nombre 
        {
            get 
            { 
                return $"Mi nombre es {base.nombre}, y si no puedo proteger la tierra, la vengaré."; 
            }
        }


        /// <summary>
        /// Muestra la informacion del avenger
        /// </summary>
        /// <returns> retorna un string</returns>
        public override string ToString()
        {
            //Agregue la propiedad Nombre
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Nombre}");
            sb.Append(base.ToString());
            sb.AppendLine($"El equipamiento es {this.eEquipamento}");

            return sb.ToString();
        }

    }
}
