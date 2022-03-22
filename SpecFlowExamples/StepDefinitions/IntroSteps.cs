namespace SpecFlowExamples.StepDefinitions
{
    #region Scenario: Add books to store

    [Binding]
    [Scope(Scenario = "Add books to store")]
    public class AddBookWithoutParamsSteps
    {
        private readonly Store store = new Store();

        [Given("I have one book in store")]
        public void PrepareBooksInStore()
        {
            store.AddBooks(1);
            Assert.True(store.Books.Count == 1);
        }

        [Given("I have one magazine in store")]
        public void PrepareMagazinesInStore()
        {
            store.AddMagazines(1);
            Assert.True(store.Magazines.Count == 1);
        }

        [When("I add two more books to store")]
        public void AddTwoBooksToStore()
        {
            store.AddBooks(2);
        }

        [Then("There should be three books in store")]
        public void CheckNumberOfBooks()
        {
            Assert.True(store.Books.Count == 3);
        }

        [Then("There should be one magazine")]
        public void CheckNumberOfMagazines()
        {
            Assert.True(store.Magazines.Count == 1);
        }
    }

    #endregion

    #region Scenario: Add books to store using steps with parameters

    [Binding]
    [Scope(Scenario = "Add books to store using steps with parameters")]
    public class AddBookWithParamsSteps
    {
        private readonly Store store = new Store();

        [Given("I have (.*) books in store")]
        public void PrepareBooksInStore(int booksCount)
        {
            store.AddBooks(booksCount);
            Assert.True(store.Books.Count == booksCount);
        }

        [Given("I have (.*) magazine in store")]
        public void PrepareMagazinesInStore(int magazinesCount)
        {
            store.AddMagazines(magazinesCount);
            Assert.True(store.Magazines.Count == magazinesCount);
        }

        [When("I add (.*) more books to store")]
        public void AddTwoBooksToStore(int booksCount)
        {
            store.AddBooks(booksCount);
        }

        [Then("There should be (.*) books in store")]
        public void CheckNumberOfBooks(int booksCount)
        {
            Assert.True(store.Books.Count == booksCount);
        }

        [Then("There should be (.*) magazines")]
        public void CheckNumberOfMagazines(int magazinesCount)
        {
            Assert.True(store.Magazines.Count == magazinesCount);
        }
    }

    #endregion
}
