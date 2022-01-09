Report: Advanced Object Oriented Programming Problem
Yunong Liu and Adrien Lefevre


I.	Introduction:
For this advanced object-oriented programming problem we had to implement a complete and automated ordering, production, delivery system for a pizzeria.

II.	Specification
1.	Modules
Our implementation consists of four modules: 
Module1: Display, add, delete, modify customers, clerks, deliverers
Module2: Add, modify, display an order (its price or its details). 
Module3 : Display the number of orders managed by clerk, the number of deliveries made by delivery person, the orders according to a period of time, the average of the prices of the orders, the average of the customer accounts.
Module 4: Register everything, use a promotion code on an order, check if a promotion code is usable, display all used codes of a customer

Our program contains 8 classes: Drink, Customer, Order, Clerk, Staff, Deliveryman, Pizza and Pizzeria, and two interfaces IMoyenne and IPrix. As well as 5 WPF pages : MainWindow, Module1, Module2, Module3, Module4.

2.	Classes:

● Customer is composed of a name, a first name, an address, a city, a phone number, a date of first order, a total purchase amount, a list of orders assigned to him, and a list of used orders.

● Order is defined by a time, date, customer number, clerk name, order number, delivery number, whether it is a 
When adding a new order, the customer is asked to enter the name of the customer and the name of the clerk.
When adding a new order we have to create an instance of this order with the different attributes but without the pizza and drink lists. We then call the AddPizza() and AddDrink() function in the order instance as many times as the user deems necessary.

● Actual has a last name, first name, address, number and state. It is never instantiated so it is defined as abstract.

● Clerk inherits from staff, it also has a date of hire and a number of orders managed.

● Deliveryman inherits staff, it also has a means of transport and a number of deliveries made.

● Pizza has a size, a type, and a quantity, here the Pizza class does not represent a single pizza but several pizzas of the same type and size.

● Drink has a type, a volume and a quantity. As in the Pizza class, here the Drink class does not represent a single drink but several pizzas of the same type and size.

● Pizzeria is the main program class. It has an order list, a clerk list, a customer list, a delivery list, a promotion code list and a cash register.
When building it, the program reads the excel documents provided in "debug" to build the different lists from the data present in the csv.
We have used 
When main is executed, it will create a new MainWindow and display it.
It is in this class that we wrote all the methods of display, modification, addition, deletion, reading, writing, calculation of averages, checks... Because in addition to being functional with a WPF display, our program works only with a display and reading in the console.
To perform the sorting, of clients for example, we used .Sort with delegates, as well as .Foreach to review them.
 
For the creation of the promotion code system we gave the pizzeria a list of valid promotion codes in the form of a SortedList<string, float> containing in each box a promotion code (string) and an associated amount (float).
We had to create many methods to search for items within lists based on numbers and names.

3.	Interfaces:
● IMoyenne defined by the calculation of an average returning a float (used in the Pizzeria, Client classes)
● IPrix defined by the calculation of a price and returning a float (used in the Pizza, Customer, Order, Drink classes)


4.	WPF pages:
● MainWindow: The main window creates a pizza instance, it presents the different module choices and opens them.
● Module 1: Presents the choices for displaying customers, clerks and liveurs, additions, deletions and modifications.
● Module 2: Presents the choices for adding, displaying certain items and modifying orders.
● Module 3: Presents the display choices of the different statistics related to the pizzeria.
● Module 4: Presents the choices of using promotion codes and saving all the elements in the excels.

For the reading of the elements we read six files: customers, orders, clerk, detailsOrders and deliveryman.

For the saving of elements we use other files than those used during the reading to keep valid models.
	
Functioning of the WPF pages :
Each time we click on one of the displayed buttons, we close the ListBox containing all the buttons by setting its visibility to "Hidden" and we open the corresponding StackPanel by setting its visibility to "Visible". We play with these visibilities to display or not the necessary elements
Text input by the user is done by using TextBoxes and display by using TextBlocks. Validation of entries in TextBoxes is done by clicking on validation buttons.
Each method opens when the corresponding button is clicked (e.g. Add Clerk), and the necessary TextBoxes and blocks are displayed. The user can enter the text as he wishes and then press a "validate" button. When this button is clicked, the data entered is retrieved and the changes are made in the program.

DETAILS OF THE DIFFICULT PARTS : 
We first implemented everything in a console application project thinking that we could modify the WPF window elements from this code, which was not possible afterwards. So we had to adapt all the methods already coded in WPF to be able to display and retrieve the data.we had difficulties to do WPF because we didn't really know it except what we saw in CMo and TDo, so we had to train ourselves by watching tutorials on websites and in video in order to have what we want to present.
Especially for module number 2 which is complex. Adapting the code of the console project to WPF was also not a good idea because it was very long to do.
We had some problems when writing in an excel file which could not be done because of the position of this file. 

POSSIBLE EXTENSIONS & IMPROVEMENTS : 
More criteria for average calculation functions
More information types for the search functions
Improve the interface
Improve data storage: replace files with databases

Conclusion:
This project has allowed us to demonstrate our knowledge of C# and to improve our programming skills. Moreover, this project allowed us to organize ourselves, to divide the work and at the same time to work in autonomy. Unfortunately the current situation means that we have to work remotely and therefore it is more difficult to communicate. In summary, this project is a very good training for further learning and is beneficial in every way.