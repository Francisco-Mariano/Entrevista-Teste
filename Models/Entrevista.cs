using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace entrevista.Models
{
    public class Entrevista
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Codigo { get; set; }
        public String NomeDaEmpresa { get; set; }
        public String Assunto { get; set; }
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }
    }
}
