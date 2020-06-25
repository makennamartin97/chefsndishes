
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace chefsndishes.Models
{

    public class Dish
    {
        [Key]
        public int DishID {get; set;}

        [Required(ErrorMessage="REQUIRED")]
        [Display(Name = "Dish Name")]
        public string DishName {get;set;}

        [Required(ErrorMessage="REQUIRED")]
        [Range(0, 3000)]
        public int Calories {get;set;}

        [Required(ErrorMessage="REQUIRED")]
        [Display(Name = "Tastiness Rating:")]
        [Range(0, 5)]
        public int Tastiness { get; set; }
        
        [Required(ErrorMessage="REQUIRED")]
        [Display(Name = "Description:")]
        public string Description { get; set; }

        public int ChefId {get;set;}

        public Chef Maker{get; set;}


        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    

       

    }
}