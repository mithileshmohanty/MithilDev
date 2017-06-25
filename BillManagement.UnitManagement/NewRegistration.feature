Feature: Registration of New User
As a new unregistered user
I want to Register my self
So that i can use the software

Scenario: User Notification on successful registration
Given User "Test" is a new user
When click on "Register" after the data entry
Then message box shows "User Registered Successfully" and user is redirected to "LogOn" page.

Scenario: Resetting the input fields on Reset 
Given User "Test1" is a new user and already entered all the details
When click on "Reset"
Then all the entered fields are cleared and user is not redirected to any other page.

Scenario: User Notification on previously used user id 
Given User "Test1" is a new user and "Test" is a registered userid
When user enters "Test" in "UserId" field
Then error message is shown "UserId already registered" in red color And "Register" button is disabled.

Scenario: User Notification on previously used email id 
Given User "Test1" is a new user and "Test@ge.com" is a registered userid
When user enters "Test@ge.com" in "Email Id" field
Then error message is shown "Email already registered" in red color 
And "Register" button is disabled.