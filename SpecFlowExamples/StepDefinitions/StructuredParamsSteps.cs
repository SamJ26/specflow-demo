﻿using SpecFlowExamples.Models;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowExamples.StepDefinitions
{
    [Binding]
    [Scope(Feature = "StructuredParams")]
    public class StructuredParamsSteps
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

        [When("I add a new book to store with following details:")]
        public void AddTwoBooksToStore(Table bookTable)
        {
            var bookObject = bookTable.CreateInstance<Book>();
            store.AddBook(bookObject);
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
}
