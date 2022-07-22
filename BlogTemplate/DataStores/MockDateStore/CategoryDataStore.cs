using System.Collections.Generic;
using BlogTemplate.MaterialDesign;
using BlogTemplate.Models;
using BlogTemplate.Resources;
using EcommerceTemplate.DataStores.MockDataStore;

namespace BlogTemplate.DataStores.MockDateStore
{
    /// <summary>
    /// Mock data store with fake entities to test.
    /// </summary>
    public class CategoryDataStore : BaseDataStore<Category>, ICategoryDataStore
    {
        protected override IList<Category> items { get; }

        public CategoryDataStore()
        {
            items = new List<Category>
            {
                new Category { Id = "c001", Image = Icons.Surfing, Name = "Surfing" },

                new Category { Id = "c002", Image = Icons.Sailing, Name = "Sailing" },

                new Category { Id = "c003", Image = Icons.SportsBasketball, Name = "Basketball" },

                new Category { Id = "c004", Image = Icons.SportsTennis, Name = "Tennis" },

                new Category { Id = "c005", Image = Icons.Kayaking, Name = "Kayaking" },

                new Category { Id = "c006", Image = Icons.DownhillSkiing, Name = "Skiing" },

                new Category { Id = "c007", Image = Icons.SportsHandball, Name = "Handball" },
            };
        }
    }
}
