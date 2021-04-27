# Problem Description:  
## create an address book application using WinForms.
## You are expected to implement database normalization, SOLID, exception handling and error logging to a file with nLog. Use SQLClient to connect your application to the database.
 
## Design Requirements:
* The application registers users in two roles. These are: Admin and User roles.
* A user may have more than one phone number but must have one main phone number registered on signup.
* Users can register only one address.
* Users can optionally register multiple social media handles.
* On signup, collect the following data only: first name, last name, email, main phone number, password.
* On signup, all user details should be added to the database while authentication details (email and password) only are written to a .txt file using StreamWriter simultaneously.
* On login, use StreamReader to read authentication details from the .txt data store, not the database.
* The user’s address should contain:
  **	Street
  ** City
  ** State
  ** Zip Code
  ** Country

## Input Validation Requirements:
* User’s names must begin with a capital letter and must not contain any digits or special characters.
* User’s email format must be validated.
* User’s phone number must contain country code and must be 14 characters long e.g. +2348038756984.
 
## Functionality Requirements: 
* User should be able to sign up, log in and log out.
*	User should be able to add more phone numbers, update a phone number, delete a phone number, add one address, update their address.
*	User should be unable to delete but be able to change their main number.
*	User should be able to view a page showing his details.
* Admin should be able to view details of all registered users.
  

