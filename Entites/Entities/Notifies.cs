using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Entities
{
    public class Notifies
    {
        public Notifies() { Notitycoes = new List<Notifies>(); }


        [NotMapped]
        public string NameProperty { get; set; }
        [NotMapped]
        public string Mensage { get; set; }
        [NotMapped]
        public List<Notifies> Notitycoes { get; set; }

        public bool ValidPropertyString(string value, string NamePropertys)
        {
            if(string.IsNullOrWhiteSpace(value)|| string.IsNullOrWhiteSpace(NamePropertys))
            {
                Notitycoes.Add(new Notifies()
                {
                    Mensage = "Campo Obrigatorio",
                    NameProperty = NamePropertys
                }); 
                return false;
            }
            return true;
        }

        public bool ValidPropertyInt(int value, string NamePropertys)
        {
            if (value < 1 || string.IsNullOrWhiteSpace(NamePropertys))
            {
                Notitycoes.Add(new Notifies()
                {
                    Mensage = "Campo Obrigatorio",
                    NameProperty = NamePropertys
                });
                return false;
            }
            return true;
        }
    }
}
