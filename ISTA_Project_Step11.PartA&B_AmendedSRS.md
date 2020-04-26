# ISTA_Project_Step11
## *Denis Licona*
###### *29 Mar 2020* 

**Use Case Description:** To initiate an order, the user is prompted to either log into an existing account or create a new account.  

**Use Case Name:** Create a new user account

**Actors:**

- New Shopper (creates a new user account)
- Website (processes the account creation and stores it for future usage)

**Triggers:**

The user indicates that he/she wants to create an account.

**Preconditions:**

User wants to create a username and password to make purchases.

**Post-conditions:**

The user is able to authenticate to the website and place orders.

**Normal Flow:**

1. The user indicates that he/she wants to place an order.
1. The site will prompt the user to authenticate with an username and password, or create an account.
1. The user does not have an account and wants to create a username and password.
1. The user clicks on "Create an account".
1. The user is prompted to fill out a form that requests the user's Fname, Lname, street address, city, state, phone number and email address.
1. The user is to confirm that the imputed information is correct. 
1. The user is then requested to create a unique username and desired 12 character password. 
1. The user is prompted that a successful username and password has been created. 
1. The user is prompted to login using the username and password. 
1. The user is welcomed back by the site using his/her Fname and Lname.
1. The user my proceed to building the desired cake pops. 

**Amended Functional Requirements Specification**

| # | Functional Requirement | Objective |
| -------------| 
|1| The website's home page shall display an option for the user proceed and create an order | Threshold |
|2| The website shall redirect the user to an authentication page where he/she needs to provide an username and password or create an account | Threshold | 
|3| The user shall be able to click a __Create and Account__ link, redirecting the user to a form page request for the user's *fname, lname, street address, city, state, phone number, and email address* | Threshold|
|4| The user is to be able to click submit, and __no null data__ shall be allowed | Threshold|
|5| Upon validate of user's information, the user shall be requested to create an unique __username__ and __password__ | Threshold|
|6| If the username already exists, the site should prompt the user that the username is already being used and to try again with a different one | Threshold|
|7| Once a unique username is created, the user shall be prompted to create a 12-character password | Threshold|
|8| The user shall be able to click __submit__ and then prompted with a banner stating: "*Congratulations! Your account has been created*" | Threshold|
|9| Once the account is created, the user is redirected back to the authentication page in order to authenticate | Threshold|
|10| When the user successfully authenticates, he/she may begin the cake pop designing process | Threshold|