namespace SpecFlowExamples.StepDefinitions
{
    public abstract class BaseSteps
    {
        protected readonly Store store = new Store();

        [Given("I have (.*) book in store")]
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
    }

    #region Scenario: Add books to store

    [Binding]
    [Scope(Scenario = "Add books to store")]
    public class AddBookSteps : BaseSteps
    {
        [When("I add (.*) more book to store")]
        public void AddTwoBooksToStore(int booksCount)
        {
            store.AddBooks(booksCount);
        }

        [Then("There should be (.*) books in store")]
        public void CheckNumberOfBooks(int booksCount)
        {
            Assert.True(store.Books.Count == booksCount);
        }

        [Then("There should be (.*) magazine")]
        public void CheckNumberOfMagazines(int magazinesCount)
        {
            Assert.True(store.Magazines.Count == magazinesCount);
        }
    }

    #endregion

    #region Scenario: Remove books from store

    [Binding]
    [Scope(Scenario = "Remove books from store")]
    public class RemoveBookSteps : BaseSteps
    {
        [When("I remove one book from store")]
        public void RemoveOneBookFromStore()
        {
            store.RemoveBook();
        }

        [Then("There should be (.*) books in store")]
        public void CheckNumberOfBooks(int booksCount)
        {
            Assert.True(store.Books.Count == booksCount);
        }

        [Then("There should be (.*) magazine")]
        public void CheckNumberOfMagazines(int magazinesCount)
        {
            Assert.True(store.Magazines.Count == magazinesCount);
        }
    }

    #endregion
}
