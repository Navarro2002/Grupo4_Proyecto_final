using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo4_Proyecto_final.Models
{
    [Table("ctl_rol")]
    public class RolModel
    {
        public int id { get; set; }
        public string nombre { get; set; }

    }
}
