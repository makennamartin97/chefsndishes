
using System;
using System.ComponentModel.DataAnnotations;

namespace chefsndishes.Models
{
    public class CheckAgeAttribute : ValidationAttribute
    {
      protected override ValidationResult IsValid(object value, ValidationContext validationContext)
      {
          if ((DateTime) value > DateTime.Now.AddYears(-18))
              return new ValidationResult("Chefs must be 18 years or older");
          return ValidationResult.Success;
      }
    }
   
            //if ((DateTime) value > DateTime.Now)
        
               // return new ValidationResult("Please enter a future date.");
           // return ValidationResult.Success;
           //public static Bool CheckAge(DateTime Birthday, int age)
           //{
               //if(Birthday.AddYears(age)) > DateTime.Now)
              // {
                  // return false;
               //}
               //return true;
           //}
        
            
      //}
    
   //public class MinAgeAttribute : ValidationAttribute
    //{
        //public int age {get; set;}
        //protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        //    //if(DateTime.Now.Years -(DateTime)value.Years > 18)
            //{

            //}
            //DateTime Test = DateTime.Now.AddYears((DateTime)value, 18);
            

        //}
       
    //}
}
