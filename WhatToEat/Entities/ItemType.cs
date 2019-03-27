using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WhatToEat.Entities
{
    [Table("ItemType")] // Use this attribute so the class is not plurlised in the Database
    public class ItemType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(255)]
        [Required]// cannot be a null value must be a string
        public string Title { get; set; }
    }
}