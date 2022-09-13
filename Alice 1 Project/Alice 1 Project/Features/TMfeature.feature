Feature: TMfeature

A short summary of the feature

@tag1
Scenario: Create time and material record with valid details
	Given I logged into turnup portal successfully
	When I navigate to time and material page
	And  I create a new time and material record
	Then The record should be created successfully


Scenario Outline: Edit time and material record
    Given I logged into turnup portal successfully
	When I navigate to time and material page
	And I update '<Description>','<Code>' and '<Price>' on an exiting time and material record
	Then The time and material record should have updated '<Description>','<Code>' and '<Price>'

Examples: 
| Description | Code     | Price   |
| Edit1       | Monitotr | $50.00  |
| Edit2       | Keyboard | $100.00 |
| Edit3       | Mouse    | $160.00 |