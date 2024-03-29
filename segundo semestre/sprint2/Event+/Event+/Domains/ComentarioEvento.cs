﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Event_.Domains
{
    [Table("ComentarioEvento")]
    public class ComentarioEvento
    {
        //atributos da classe
        [Key]
        public Guid IdComentarioEvento { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(200)")]
        [Required(ErrorMessage = "Descrição do comentário obrigatória!")]
        public string? Descricao{ get; set; }

        [Column(TypeName = "BIT")]
        [Required]
        public bool Exibe { get; set; }

        //atributos das dependencias = Usuario
        [Required(ErrorMessage = "Usuário obrigatório!")]
        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public Usuario? Usuario { get; set; }

        //atributos das dependencias = Evento
        [Required(ErrorMessage = "Evento obrigatório!")]
        public Guid IdEvento { get; set; }

        [ForeignKey(nameof(IdEvento))]
        public Evento? Evento { get; set; }
    }
}
