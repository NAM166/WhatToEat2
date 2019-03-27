using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WhatToEat.Entities
{
    [Table("Item")] // Use this attribute so the class is not plurlised in the Database
    public class Item
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(255)]
        [Required]
        public string Title { get; set; }
        [MaxLength(2048)]
        public string Description { get; set; }
        [MaxLength(1024)]
        public string Url { get; set; }
        [MaxLength(1024)]
        [DisplayName("Image Url")]
        public string ImageUrl { get; set; }
        [AllowHtml]// saves the HTML
        public string HTML { get; set; }
        [DefaultValue(0)]
        public string HTMLShort
        {
            get
            {
                return HTML == null || HTML.Length < 50 ?
                  HTML : HTML.Substring(0, 50);
            }
        }
        public int OutlettId { get; set; }
        public int ItemTypeId { get; set; }
        public int SectionId { get; set; }
        public bool IsFree { get; set; }
        [DisplayName("Item Types")]
        public ICollection<ItemType> ItemTypes { get; set; }
        [DisplayName("Sections")]
        public ICollection<Section> Sections { get; set; }
        }
}