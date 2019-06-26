using System;
using System.ComponentModel.DataAnnotations;

namespace PokeTCGWebAPI.Models
{
    public class Set
    {
        [Key]
        public int SetID { get; set; }

        public string SetCode { get; set; }
        public string SetName { get; set; }
        public string SetSeries { get; set; }
        public bool SetStandard { get; set; }
        public bool SetExpanded { get; set; }
        public string SetSymbolURL { get; set; }
        public string SetLogoURL { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime SetReleaseDate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime LastUpdateDate { get; set; }

    }
}
