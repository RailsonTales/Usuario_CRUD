using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class UsuarioModel
    {
        public int id { get; set; }
        [DisplayName("Nome")]
        [StringLength(50, ErrorMessage = "O campo Nome permite no máximo 50 caracteres!")]
        public string nome { get; set; }
        [Required]
        [DisplayName("Sobre Nome")]
        public string sobrenome { get; set; }
        [DisplayName("Endereço")]
        public string endereco { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Informe o Email")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email inválido.")]
        public string email { get; set; }
        [DataType(DataType.Date)]
        public DateTime nascimento { get; set; }

        public virtual ICollection<UsuarioModel> UsuariosModelos { get; set; }
    }
}