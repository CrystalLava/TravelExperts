# TravelExperts
Travel Experts WinForms Workshop

Topic:
Application development with C#.NET
Description:
In order that employees of Travel Experts can administer the data stored on their database, they need an application that will provide a graphical interface for viewing and modifying the data.  At this point, they have identified the tables that are most important, and request that access to these be developed as a prototype.

You have already received the TravelExperts SQL Server database.  You can build your application using the existing database structure. However, there may be minor improvements that would make your programming easier, so you are free to make improvements to the database.

There are no restrictions on the interface you choose to build. You are free to design the GUI as your team decides. Ensure that the navigation is user-friendly. Your application will need functionality that will allow the user to maintain the data in the tables listed below.

The agents need to add/edit travel packages.  This function must allow the user to enter data for the package and select from a product list to add products to the package.
 
The application will also require a simple add/edit access for maintaining the product, suppliers, and product_suppliers data.

The tables that will be used by this part of the project are:
1.	Packages
2.	Products
3.	Products_suppliers
4.	Suppliers
5.	Packages_products_suppliers

Make sure that you validate the data before creating the package:
a)	the Agency Commission cannot be greater than the Base Price
b)	the Package End Date must be later than Package Start Date
c)	Package Name and Package Description cannot be null


_____________________________________________________________________________________________________________________________________________________________________________

Here we go Team! Our Workshop 4 project and Tasks. We will check them off once we know we have completed them. 
Please put your name beside the stuff you do, on this file and in the code. 
Thanks!

Crystal -Travel Experts Admin Page (if there is time, we can add a users/login page)

??Manage Packages 
-	Edit 
-	Add 
- Delete
-	(Package ID/Package Name/ Info/ Commission/etc)
-	(Package Id/ ProductSupplierID)

Crystal Manage Products DONE!!!!  
- Add products (Product ID/ProdName)
- Edit products
- Delete

??Manage Supplier  
-	Add supplier 
-	Edit supplier
- Delete
-	(SupplierContactID/Name/Company/Address/etc)
-	(SupplierID/SupplierName)

??Validations
-	Agency Commission cannot be greater than the Base Price
-	Package End Date must be later than the Package Start Date
-	Package Name and package Description cannot be null
-	If time, add validations for numbers/letters/zipcode etc


***OTHER TABLES USED IN PROJECT IGNORE FOR NOW***

Products/Suppliers
-	(ProductSupplier ID/ProductID/SupplierID)

Packages/Products/Suppliers
-	(PackageID/ProductSupplierID)


