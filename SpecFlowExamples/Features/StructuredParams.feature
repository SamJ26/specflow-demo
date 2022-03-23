﻿Feature: StructuredParams

	This feature shows how to:
	- Pass structured data to step definitions (pass one object as parameter)
	- Share data between bindings via fake store in step definitions class

	Rule: Adding a book does not affect magazines

		Scenario: Add book with details to store
	
			Testing the addition of a book to the store
			Related C# class: StructuredParamsSteps.cs

			Given I have 2 books in store
			And I have 1 magazine in store
			When I add a new book to store with following details:
				| Property | Value             |
				| Name     | Amazing book name |
				| Author   | E.L. James        |
			Then There should be 3 books in store
			And There should be 1 magazine