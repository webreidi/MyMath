namespace PlaywrightTests
{
    [TestClass]
    public partial class FrontEndTests : PageTest
    {
        [TestMethod]
        public async Task HomepageHasPlaywrightInTitleAndGetStartedLinkLinkingtoTheIntroPage()
        {
            await Page.GotoAsync("https://playwright.dev");

            // Expect a title "to contain" a substring.
            await Expect(Page).ToHaveTitleAsync(PWRegex());

            // create a locator
            var getStarted = Page.Locator("text=Get Started");

            // Expect an attribute "to be strictly equal" to the value.
            await Expect(getStarted).ToHaveAttributeAsync("href", "/docs/intro");

            // Click the get started link.
            await getStarted.ClickAsync();

            // Expects the URL to contain intro.
            await Expect(Page).ToHaveURLAsync(IntroRegex());

            await Expect(Page).ToHaveTitleAsync("Installation | Playwright");
        }

        [TestMethod]
        public async Task WebPageHasLink()
        {
            await Page.GotoAsync("https://dotnet.microsoft.com/en-us/");

            await Expect(Page).ToHaveTitleAsync(DotNetRegex());

            var getStarted = Page.Locator("text=Get Started");

            await Expect(getStarted).ToHaveAttributeAsync("href", "/en-us/learn");
            await getStarted.ClickAsync();

        }

        [GeneratedRegex(".NET | Build. Test. Deploy.")]
        private static partial Regex DotNetRegex();

        [GeneratedRegex("Playwright")]
        private static partial Regex PWRegex();
        [GeneratedRegex(".*intro")]
        private static partial Regex IntroRegex();
    }
}