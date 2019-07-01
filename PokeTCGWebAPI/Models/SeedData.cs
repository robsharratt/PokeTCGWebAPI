using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace PokeTCGWebAPI.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
            .GetRequiredService<ApplicationDbContext>();
            //TODO: Deletes the DB (this is not needed for final code)
            context.Database.EnsureDeleted();
            context.Database.Migrate();
            
            if (!context.CardCats.Any())
            {
                context.CardCats.AddRange(
                    new CardCat
                    {
                        CardCatName = "Pokemon",
                        LastUpdateDate = DateTime.Now
                    },
                    new CardCat
                    {
                        CardCatName = "Trainer",
                        LastUpdateDate = DateTime.Now
                    },
                    new CardCat
                    {
                        CardCatName = "Energy",
                        LastUpdateDate = DateTime.Now
                    }
                );
                if (!context.CardTypes.Any())
                {
                    var strings = new List<string>() {
                        "Basic", "Stage 1", "Stage 2", "Item", "Supporter",
                        "Stadium", "Pokémon Tool", "Technical Machine", "EX", "GX",
                        "TAG TEAM", "LEGEND", "BREAK", "MEGA", "Special",
                        "Level Up", "Rocket's Secret Machine", "Restored"
                    };

                    foreach (string value in strings) {
                        context.CardTypes.Add(
                            new CardType
                            {
                                CardTypeName = value,
                                LastUpdateDate = DateTime.Now
                            }
                        );
                    }
                //new CardType
                //    {
                //        CardTypeName = "Basic",
                //        LastUpdateDate = DateTime.Now
                //    },
                //    new CardType
                //    {
                //        CardTypeName = "Stage 1",
                //        LastUpdateDate = DateTime.Now
                //    },
                //    new CardType
                //    {
                //        CardTypeName = "Stage 2",
                //        LastUpdateDate = DateTime.Now
                //    },
                //    new CardType
                //    {
                //        CardTypeName = "Item",
                //        LastUpdateDate = DateTime.Now
                //    },
                //    new CardType
                //    {
                //        CardTypeName = "Supporter",
                //        LastUpdateDate = DateTime.Now
                //    },
                //    new CardType
                //    {
                //        CardTypeName = "Stadium",
                //        LastUpdateDate = DateTime.Now
                //    },
                //    new CardType
                //    {
                //        CardTypeName = "Pokémon Tool",
                //        LastUpdateDate = DateTime.Now
                //    },
                //    new CardType
                //    {
                //        CardTypeName = "Technical Machine",
                //        LastUpdateDate = DateTime.Now
                //    },
                //    new CardType
                //    {
                //        CardTypeName = "EX",
                //        LastUpdateDate = DateTime.Now
                //    },
                //    new CardType
                //    {
                //        CardTypeName = "GX",
                //        LastUpdateDate = DateTime.Now
                //    },
                //    new CardType
                //    {
                //        CardTypeName = "TAG TEAM",
                //        LastUpdateDate = DateTime.Now
                //    },
                //    new CardType
                //    {
                //        CardTypeName = "LEGEND",
                //        LastUpdateDate = DateTime.Now
                //    },
                //    new CardType
                //    {
                //        CardTypeName = "BREAK",
                //        LastUpdateDate = DateTime.Now
                //    },
                //    new CardType
                //    {
                //        CardTypeName = "MEGA",
                //        LastUpdateDate = DateTime.Now
                //    },
                //    new CardType
                //    {
                //        CardTypeName = "Special",
                //        LastUpdateDate = DateTime.Now
                //    },
                //    new CardType
                //    {
                //        CardTypeName = "Level Up",
                //        LastUpdateDate = DateTime.Now
                //    },
                //    new CardType
                //    {
                //        CardTypeName = "Rocket's Secret Machine",
                //        LastUpdateDate = DateTime.Now
                //    },
                //    new CardType
                //    {
                //        CardTypeName = "Restored",
                //        LastUpdateDate = DateTime.Now
                //    }
                //);
                    context.SaveChanges();
                }
                if (!context.SetSeries.Any())
                {
                    context.SetSeries.AddRange(
                    new SetSeries
                    {
                        SetSeriesName = "Sun & Moon"
                    }
                    );
                }
                context.SaveChanges();
                if (!context.Sets.Any())
                {
                    context.Sets.AddRange(
                    new Set
                    {
                        SetName = "Unbroken Bonds",
                        SetCode = "sm10",
                        SetPTCGOCode = "UNB",
                        SetSeries = context.SetSeries.FirstOrDefault(m => m.SetSeriesName.Equals("Sun & Moon")),
                        SetTotalCards = 214,
                        SetStandard = true,
                        SetExpanded = true,
                        SetSymbolURL = "https://images.pokemontcg.io/sm10/symbol.png",
                        SetLogoURL = "https://images.pokemontcg.io/sm10/logo.png",
                        SetReleaseDate = Convert.ToDateTime("04/05/2019")
                    },
                    new Set
                    {
                        SetName = "Team Up",
                        SetCode = "sm9",
                        SetPTCGOCode = "TEU",
                        SetSeries = context.SetSeries.FirstOrDefault(m => m.SetSeriesName.Equals("Sun & Moon")),
                        SetTotalCards = 181,
                        SetStandard = true,
                        SetExpanded = true,
                        SetSymbolURL = "https://images.pokemontcg.io/sm9/symbol.png",
                        SetLogoURL = "https://images.pokemontcg.io/sm9/logo.png",
                        SetReleaseDate = Convert.ToDateTime("02/01/2019")
                    },
                    new Set
                    {
                        SetName = "Lost Thunder",
                        SetCode = "sm8",
                        SetPTCGOCode = "LOT",
                        SetSeries = context.SetSeries.FirstOrDefault(m => m.SetSeriesName.Equals("Sun & Moon")),
                        SetTotalCards = 214,
                        SetStandard = true,
                        SetExpanded = true,
                        SetSymbolURL = "https://images.pokemontcg.io/sm8/symbol.png",
                        SetLogoURL = "https://images.pokemontcg.io/sm8/logo.png",
                        SetReleaseDate = Convert.ToDateTime("11/02/2018")
                    },
                    new Set
                    {
                        SetName = "Guardians Rising",
                        SetCode = "sm2",
                        SetPTCGOCode = "GRI",
                        SetSeries = context.SetSeries.FirstOrDefault(m => m.SetSeriesName.Equals("Sun & Moon")),
                        SetTotalCards = 145,
                        SetStandard = true,
                        SetExpanded = true,
                        SetSymbolURL = "https://images.pokemontcg.io/sm2/symbol.png",
                        SetLogoURL = "https://images.pokemontcg.io/sm2/logo.png",
                        SetReleaseDate = Convert.ToDateTime("05/05/2017")
                    }
                    );
                }
                context.SaveChanges();
                if (!context.Cards.Any())
                {
                    //context.Cards.AddRange(
                        //new Card
                        //{
                            //CardName = "Grass Energy",
                            //CardImageURL = "https://images.pokemontcg.io/sm2/167.png",
                            //CardImageHiURL = "https://images.pokemontcg.io/sm2/167_hires.png",

                            //CardCat = “Energy”??,
                            //CardType = “Basic”??,

                            //Set = context.Set.FirstOrDefault(m => m.SetName.Equals("Guardians Rising")),

                            //CardNum =167,
                            //Artist = "",
                            //CardRarity = "Rare Secret",
                            //LastUpdateDate = DateTime.Now
                        //});
                }
                context.SaveChanges();
            }
        }
    }
}
