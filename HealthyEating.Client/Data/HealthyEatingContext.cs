﻿using HealthyEating.Client.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyEating.Client.Data
{
    public class HealthyEatingContext : DbContext, IDatabase
    {
        public HealthyEatingContext()
            : base("HealthyEating")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

          

        }

        public virtual IDbSet<Recipe> Recipes { get; set; }

        public virtual IDbSet<Ingredient> Ingredients { get; set; }

        public virtual IDbSet<User> Users { get; set; }

        public virtual IDbSet<Meal> Meals { get; set; }

        public virtual IDbSet<Quantity> Quantities { get; set; }
    }
}
