﻿using System;

namespace BlogTemplate.Models
{
    /// <summary>
    /// Type represent category entity
    /// </summary>
    public class Category : Entity
    {
        /// <summary>
        /// Name of the category
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Image for the category
        /// </summary>
        public string Image { get; set; }
    }
}
