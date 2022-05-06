﻿using FilmesAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesApi.Data.Dtos
{
    public class ReadGerenteDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Nome { get; set; }

        public Object Cinemas { get; set; }

    }
}
