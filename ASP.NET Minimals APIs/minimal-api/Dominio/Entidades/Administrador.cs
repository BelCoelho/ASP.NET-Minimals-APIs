using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MinimalAPI.Dominio.Entidades
{
    public class Administrador
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//definido como Identity
        public int Id { get; set; }

        [Required]//Obrigatório
        [StringLength(255)]//255 caracteres
        public string Email { get; set; }

        [StringLength(50)]
        public string Senha { get; set; }

        [StringLength(10)]
        public string Perfil { get; set; }
    }
}