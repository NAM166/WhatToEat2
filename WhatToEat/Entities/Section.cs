using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WhatToEat.Entities
{
    [Table("Section")]//Gives a specified title to the table
    public class Section
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // automatically increases the Database ID
        public int Id { get; set; }
        [MaxLength(255)]
        [Required] //A value needs to be entered 
        public string Title { get; set; }
    }
}