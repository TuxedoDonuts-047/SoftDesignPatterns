using DatabaseConnect;

namespace DatabaseSYS.Tests;

[TestClass]
public class HobbyValidationTests
{
    [TestMethod]
    public void ValidateHobbyInput_ValidInput_ReturnsParsedValues()
    {
        bool result = HobbyValidation.ValidateHobbyInput(
            "  Board Games  ", "4", "12.50",
            out string errorMessage,
            out int playerCount,
            out decimal price);

        Assert.IsTrue(result);
        Assert.AreEqual(string.Empty, errorMessage);
        Assert.AreEqual(4, playerCount);
        Assert.AreEqual(12.50m, price);
    }

    [DataTestMethod]
    [DataRow(null, "4", "12.50", "Description must be entered.")]
    [DataRow("   ", "4", "12.50", "Description must be entered.")]
    [DataRow("12345", "4", "12.50", "Description must not be completely numeric.")]
    public void ValidateHobbyInput_InvalidDescription_ReturnsExpectedError(
        string? description, string playerCount, string price, string expectedError)
    {
        bool result = HobbyValidation.ValidateHobbyInput(
            description!, playerCount, price,
            out string errorMessage,
            out _,
            out _);

        Assert.IsFalse(result);
        Assert.AreEqual(expectedError, errorMessage);
    }

    [DataTestMethod]
    [DataRow(null)]
    [DataRow("")]
    [DataRow("0")]
    [DataRow("-2")]
    [DataRow("two")]
    public void ValidateHobbyInput_InvalidPlayerCount_ReturnsExpectedError(string? playerCount)
    {
        bool result = HobbyValidation.ValidateHobbyInput(
            "Board Games", playerCount!, "12.50",
            out string errorMessage,
            out int parsedPlayerCount,
            out _);

        Assert.IsFalse(result);
        Assert.AreEqual("Number of players must be a valid whole number greater than zero.", errorMessage);
        Assert.AreEqual(playerCount is "-2" ? -2 : 0, parsedPlayerCount);
    }

    [DataTestMethod]
    [DataRow(null)]
    [DataRow("")]
    [DataRow("0")]
    [DataRow("-10.00")]
    [DataRow("free")]
    public void ValidateHobbyInput_InvalidPrice_ReturnsExpectedError(string? price)
    {
        bool result = HobbyValidation.ValidateHobbyInput(
            "Board Games", "4", price!,
            out string errorMessage,
            out _,
            out decimal parsedPrice);

        Assert.IsFalse(result);
        Assert.AreEqual("Price must be a numeric value greater than zero.", errorMessage);
        Assert.AreEqual(price is "-10.00" ? -10.00m : 0m, parsedPrice);
    }
}
