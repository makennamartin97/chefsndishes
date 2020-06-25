
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace chefsndishes.Models
{

    public class Chef
    {
        [Key]
        public int ChefID {get; set;}

        [Required(ErrorMessage="REQUIRED")]
        [Display(Name = "First Name")]
        public string FirstName {get; set;}

        [Required(ErrorMessage="REQUIRED")]
        [Display(Name = "Last Name")]
        public string LastName {get; set;}

        [Required(ErrorMessage="REQUIRED")]
        [CheckAge]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime Birthday {get; set;}

    
        public List<Dish> dishes {get; set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }


    
    
}