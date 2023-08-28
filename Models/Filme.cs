﻿using System.ComponentModel.DataAnnotations;

namespace FilmeApi.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get;  set; }
        [Required(ErrorMessage ="O titulo do filme é obrigatório!")]
        public string Titulo { get; set; }
        [Required(ErrorMessage ="O genero do filme é obrigatório!")]
        [MaxLength(50,ErrorMessage ="o tamanho do genero não pode exceder 50 caracteres!")]
        public string Genero { get; set; }
        [Required]
        [Range(70,600,ErrorMessage ="A duração deve ter entre 70 e 600 minutos!")]
        public int Duracao { get; set; }
       
    }
}
