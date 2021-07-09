# ASP.NET_MVC_Assignments
For this assignment, you are to create an MVC Web Application from scratch. Use the ASP.NET Core Web Application project type, and the “Web Application (Model-View-Controller)” template to start with. This will give you the basic structure to build your project from.

Required Features:

 General file structure of a MVC project.

 A Layout file for your views to use. It should contain:
 
 A header element, containing a page logo and a navigation menu.
 
A container to be filled with each view.
 
 A footer, containing the current date as an object, and your name.
 
 
 A controller with at least three views:
 
 About – Containing information about yourself (CV).
 
 Contact – Containing your contact information.
 
 Projects – Containing the assignments and projects you have finished
 
 
 *Forms and Inputs*
 
Add a view to the existing page that takes a temperature in number form, checks how high it is, and tells you whether you have a fever or not. Define a custom route to reach it – “/FeverCheck” should redirect to this new page, rather than having to specify a controller and action.

Required Features:

• A form that takes a single numeric value (float or integer) and sends it on to a controller action.

• The value should be interpreted as a temperature and checked against the thresholds for fever.

• A message should appear on the page, showing whether you have a fever or not.


*Guessing Game*

Add a new view containing a number-guessing game. The page should include a form that allows you to input a number. When the page is loaded for the first time, the page should generate a random number between 1 and 100, that it will save when the page is refreshed. When you submit a number into the form, it should compare your number to the one the app generated. If it is the correct one, you should get a message congratulating you on your success, and a new number should be generated. Otherwise, it should tell you whether your guess is either too high or too low, and let you take another guess.

Required Features:

• A randomly generated number, hidden from the user of the page.

• The ability to guess, through a form, which number was generated.

• A message displaying how well you did.


*View Models*
Add a view to the existing page that displays a list of people. These people should have names, phone numbers and cities. Store this data inside of a model class and send it out to the view as a list. Additionally, there should be two forms attached to this view – one that can filter the list, and one that can add new people to the list.

Required Features:

• A table of people, generated from a list.

• Two forms:
• One form should filter the table – if you enter a string into the form and submit it, the page should be refreshed and only show the people whose names or cities contain the string you entered.

• The other form should let you add people to the list.

• Each row in the table should show the person, and a link that when clicked, removes the person.


*Partial Views*
In this assignment, you will continue developing the list of people that you added to in the last assignment, changing the general layout and structure of how the names are displayed.

Required Features:

• Rework the display of the person list to be based on partial views displayed in a list instead of using a table.

Code Requirements

• Instead of being rows in a table, each item in the list should be defined as fragment of HTML code (basically a page inside the page)

• This fragment should be defined inside its own partial view, instead of in the view itself.

• The partial view should take one instance of the person as its model.



