using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommunityApp.Models;

public class City
{
    [Key]
    public int CityId { get; set; }

    [Display(Name = "City")]
    public string? CityName { get; set; }
    public int? Population { get; set; }

    [Display(Name = "Province")]
    public string? ProvinceCode { get; set; }

    [Display(Name = "Province")]
    [ForeignKey("ProvinceCode")]
    public Province? Province { get; set; }
}
