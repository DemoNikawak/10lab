
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;


namespace lab9_WebDriver;


public class MyTest : TestsClass
{
    protected override string? Url => "https://5element.by";

    private string product = "Samsung Galaxy M32";

    [Test]
    public void Element5Test()
    {

        Thread.Sleep(1000);
        var searchInput = findElement("//input[@class='inp inp--lg']");
        searchInput.Click();
        searchInput.SendKeys(product);
        searchInput.SendKeys(Keys.Enter);

        Thread.Sleep(1000);
        string text = "";
        try
        {
             

            var elements = driver.FindElements(By.ClassName("title"));
                foreach (var eleme in elements)
                    if (eleme.Text == product)
                    {
                        text = eleme.Text;
                        Assert.True(text != "");

                    return;
                    }

        }
        catch
        {
            Assert.Fail(); 
        }


    }

}