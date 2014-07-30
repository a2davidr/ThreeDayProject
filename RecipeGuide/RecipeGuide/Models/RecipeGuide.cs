//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RecipeGuide.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RecipeGuide
    {
        public RecipeGuide()
        {
            this.RecipeTypes = new HashSet<RecipeType>();
        }
    
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public Nullable<System.DateTime> Copyright { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> Price { get; set; }
    
        public virtual ICollection<RecipeType> RecipeTypes { get; set; }
    }
}