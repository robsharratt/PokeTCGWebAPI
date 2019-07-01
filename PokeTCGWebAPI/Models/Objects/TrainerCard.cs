using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PokeTCGWebAPI.Models
{
    public class TrainerCard : Card
    {
        [StringLength(1024)]
        public string TrainerCardText;

    }
}
