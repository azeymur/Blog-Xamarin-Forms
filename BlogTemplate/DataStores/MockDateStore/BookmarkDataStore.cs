using System.Collections.Generic;
using BlogTemplate.Models;
using EcommerceTemplate.DataStores.MockDataStore;

namespace BlogTemplate.DataStores.MockDateStore
{
    /// <summary>
    /// Mock data store with fake entities to test.
    /// </summary>
    public class BookmarkDataStore : BaseDataStore<Bookmark>, IBookmarkDataStore
    {
        protected override IList<Bookmark> items { get; }

        public BookmarkDataStore()
        {
            items = new List<Bookmark>
            {
                new Bookmark { Id = "b001", UserId = "u001", PostId = "p010" },

                new Bookmark { Id = "b002", UserId = "u001", PostId = "p023" },

                new Bookmark { Id = "b003", UserId = "u001", PostId = "p028" },

                new Bookmark { Id = "b004", UserId = "u001", PostId = "p014" },

                new Bookmark { Id = "b005", UserId = "u001", PostId = "p016" },

                new Bookmark { Id = "b006", UserId = "u001", PostId = "p020" },

                new Bookmark { Id = "b007", UserId = "u001", PostId = "p027" },

                new Bookmark { Id = "b008", UserId = "u002", PostId = "p010" },

                new Bookmark { Id = "b009", UserId = "u002", PostId = "p023" },

                new Bookmark { Id = "b010", UserId = "u002", PostId = "p028" },

                new Bookmark { Id = "b011", UserId = "u002", PostId = "p004" },

                new Bookmark { Id = "b012", UserId = "u002", PostId = "p018" },

                new Bookmark { Id = "b013", UserId = "u002", PostId = "p021" },

                new Bookmark { Id = "b014", UserId = "u002", PostId = "p012" },
            };
        }
    }
}
