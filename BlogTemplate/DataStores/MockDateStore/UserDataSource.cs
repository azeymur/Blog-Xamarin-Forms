using System.Collections.Generic;
using BlogTemplate.Models;

namespace BlogTemplate.DataStores.MockDataStore
{
    /// <summary>
    /// Mock data store with fake entities to test.
    /// </summary>
    public class UserDataSource : BaseDataStore<User>, IUserDataStore
    {
        protected override IList<User> items { get; }

        public UserDataSource()
        {
            items = new List<User>
            {
                new User { Id = "u001", FullName = "Jane Doe", Email = "janedoe@gmail.com", Image = "jane_doe",
                        About = "Etiam vel purus ac ligula efficitur bibendum et eget nulla. Integer maximus aliquam ex, id accumsan erat tempor at. Quisque cursus bibendum nisi id imperdiet." },

                new User { Id = "u002", FullName = "John Doe", Email = "johndoe@gmail.com", Image = "john_doe",
                        About = "Pellentesque vehicula libero in nisi porttitor consequat. Vestibulum condimentum sit amet sem at euismod. Sed nec mauris quam." }
            };
        }

    }
}
