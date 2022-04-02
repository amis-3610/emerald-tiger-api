using Emerald.Tiger.Domain.Catalog;

namespace Emerald.Tiger.Domain.Tests
{
    [TestClass]
    public class ItemTests
    {
        [TestMethod]
        public void Can_Create_New_Item()
        {
            // Arrange
            var item = new Item("Shirt", "A nice shirt", "Nike", 100.00m);

            // Assert
            Assert.AreEqual("Shirt", item.Name);
            Assert.AreEqual("A nice shirt", item.Description);
            Assert.AreEqual("Nike", item.Brand);
            Assert.AreEqual(100.00m, item.Price);
            Assert.AreEqual(0, item.Ratings.Count);
        }

        [TestMethod]
        public void Can_Add_Rating_To_Item()
        {
            // Arrange
            var item = new Item("Shirt", "A nice shirt", "Nike", 100.00m);
            var rating = new Rating(5, "Mike", "Good");

            // Act
            item.AddRating(rating);

            // Assert
            Assert.AreEqual(1, item.Ratings.Count);
            Assert.AreEqual(5, item.Ratings[0].Stars);
            Assert.AreEqual("Good", item.Ratings[0].Review);
        }
    }

}