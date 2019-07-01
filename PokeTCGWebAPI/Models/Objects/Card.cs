﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PokeTCGWebAPI.Models
{
    public class Card
    {
        public int CardID { get; set; }
        public string CardName { get; set; }
        public string CardImageURL { get; set; }
        public string CardImageHiURL { get; set; }

        //Foreign Key for Card Category - Pokemon, Trainer, Energy
        public int CardCatID { get; set; }
        public CardCat CardCat { get; set; }

        //Foreign Key for Card Type - Basic, Stage 1, Stage 2, etc
        public int CardTypeID { get; set; }
        public CardType CardType { get; set; }

        //Foreign Key for Set
        public int SetID { get; set; }
        public Set Set { get; set; }

        public string CardNum { get; set; }
        public string Artist { get; set; }
        public string CardRarity { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime SetReleaseDate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime LastUpdateDate { get; set; }
    }
}