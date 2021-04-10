using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HotelListing.Shared;
using AutoMapper;
using HotelListing.Shared.Models;
using Microsoft.AspNetCore.Identity;
using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Configurations.Entities
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Sandals Resort and Spa",
                    Address = "Negril",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Grand Palldium",
                    Address = "Nassua",
                    CountryId = 2,
                    Rating = 3
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Comfort Suits",
                    Address = "George Town",
                    CountryId = 3,
                    Rating = 4.3
                }
            );
        }
    }
}