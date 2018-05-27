Feature: SortAllCatsByGender
	In order to dispaly the cat details
	As a consumer
	I want to display the cat details in alphabetical order by gender

@catDetails
Scenario: Sort all cat details by gender in alphabetical order
	Given Controller "AGLWebService" resource "PeopleSearch"
	Then Send request to controller
	And I output all the "Male" Cats in alphabetical order
	And I output all the "Female" Cats in alphabetical order

