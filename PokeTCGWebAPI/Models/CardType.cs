using System;
using System.ComponentModel.DataAnnotations;

namespace PokeTCGWebAPI.Models
{
    public class CardType
    {
        [Key]
        public int CardTypeID { get; set; }

        public string CardTypeName { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime LastUpdateDate { get; set; }
    }
}
