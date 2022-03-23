Feature: SimpleParams

	This feature shows how to:
	- Pass simple numeric paramters to step definitions
	- Share data between bindings via fake store in step definitions class
	- Use scoped step definitions

	Rule: Adding a book does not affect magazines

		Scenario: Add books to store
	
			Testing the addition of a book to the store
			Related C# class: SimpleParamsSteps.cs

			Given I have 2 books in store
			And I have 1 magazine in store
			When I add 3 more books to store
			Then There should be 5 books in store
			And There should be 1 magazines
