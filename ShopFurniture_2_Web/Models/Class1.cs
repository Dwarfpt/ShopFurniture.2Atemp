using System.Collections.Generic;

namespace ShopFurniture_2_Web.Models
{
    public class UserData
    {
        public string UserName { get; set; }
        public List<Product> Products { get; set; }
    }

    public class Product
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
    public class TeamMember
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }


}
