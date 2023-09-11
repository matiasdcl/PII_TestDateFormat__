using TestDateFormat;

namespace Library.Tests;

public class DataFormatterTests
{
    [Test]
    public void CorrectFormatTest()
    {
        string testDate = "10/11/1997";
        Assert.AreEqual(DateFormatter.ChangeFormat(testDate), "1997/11/10");
    }

    [Test]
    public void IncorrectFormatTest()
    {
        string testDate = "aaaaaaaaaa";
        Assert.AreNotEqual(testDate, "1997-11-10");
    }

    [Test]
    public void EmptyStringFormarTest()
    {
        string testDate = "";
        //Assert.IsEmpty(DateFormatter.ChangeFormat(testDate));
        Assert.IsEmpty(DateFormatter.ChangeFormat(testDate));
    }

    [Test]
    public void NullFormatTest()
    {
        string testDate = null;
        Assert.IsNull(DateFormatter.ChangeFormat(testDate));
    }
}