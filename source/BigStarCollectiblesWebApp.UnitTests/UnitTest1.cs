using BigStarCollectiblesWebApp.Pages;

namespace BigStarCollectiblesWebApp.UnitTests;

public class UnitTest1
{
    // Generate a test method for the Index.cshtml.cs OnGet method
    [Fact]
    public void Test1()
    {
        // Arrange
        IndexModel indexModel = new();

        // Act
        indexModel.OnGet();

        // Assert
        Assert.NotNull(indexModel.MonsterCards);
        Assert.Equal(12, indexModel.MonsterCards.Count);
    }
}