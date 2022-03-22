Feature: Intro

	This feature shows how to:
	- Bind steps on step definitions
	- Pass data from feature files to step definitions
	- Use scoped step definitions
	- Share data between bindings using fields in class with step definitions

	Rule: Adding a book does not affect magazines

		Scenario: Add books to store
	
			Testing the addition of a book to the store
			Related C# class: AddBookWithoutParamsSteps.cs

			Given I have one book in store
			And I have one magazine in store
			When I add two more books to store
			Then There should be three books in store
			And There should be one magazine

		Scenario: Add books to store using steps with parameters
	
			Testing the addition of a book to the store using parameters
			Related C# class: AddBookWithParamsSteps.cs

			Given I have 2 books in store
			And I have 1 magazine in store
			When I add 3 more books to store
			Then There should be 5 books in store
			And There should be 1 magazines
