﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace alura_backend_challenge_3.Data.ValueObjects
{
    public class VideoVO
    {
        public Guid Id { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public string URL { get; set; }

        public CategoriaVO CategoriaVO { get; set; }
    }
}
