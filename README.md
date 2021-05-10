# Shopping Cart

- Requirement analysis

    This project will involve concepts from all core training modules; more specifically, this will involve:

    - Project Management
    - C# & ASP.NET
    - Unit Testing
    - Git
    - Basic Linux
    - Continuous Integration
    - Cloud Fundamentals
    - Databases
    - Angular Web Development (Stretch Goal)

    To create a CRUD (Create, Read, Update, Delete) application with the utilization of supporting tools, methodologies and technologies that encapsulate all core modules covered during training.

    Storage

    - information
    - files
    - cookies

    The requirements of the project are as follows:

    - A Trello board (or equivalent Kanban board tech) with full expansion on user stories, use cases and tasks needed to complete the project. It could also provide a record of any issues or risks that you faced creating your project.
    - A relational database use to store data persistently for the project, this database needs to have at least 2 tables in it, to demonstrate your understanding.
    - Clear Documentation from a design phase describing the architecture you will use for your project as well as a detailed Risk Assessment.
    - A functional CRUD application created in C#, following best practices and design principles, that meets the requirements set on your Kanban Board
    - Fully designed test suites for the application you are creating, as well as automated tests for validation of the application. You must provide high test coverage in your backend and provide consistently reports and evidence to support a TDD approach.
    - A functioning front-end website and integrated API's, using ASP.NET. As a stretch goal, you can add an Angular based front-end.
    - Code fully integrated into a Version Control System using the Feature-Branch model which will subsequently be built through a CI server and deployed to a cloud-based virtual machine.

    The documentation must be provided as a **[README.md](http://readme.md)** at the root of your folder structure. This will require a fully functional application based on the domain that you have chosen.

- Planning and Defining Requirements

    In this project I have chosen to make an online shopping system, where a user is able to shop for products and create and account to be able to go forward and process and order.

    - Kanban Board: Trello or an equivalent Kanban Board

            I will be using Jira. Below is an example of my planning on Jira that keeps track of what I need to do what I am currently working on and what I have finished.

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled.png)

    Here I have created an Epic which shows the User Story. The user would like to be able to create an account with their details, such as their title, name, address and email. They would like to update their details or delete them. The user would like to view all products and also create one and add it to their cart ready to purchase for an order. In their cart they would like to update and delete any products they have in there

    [https://team-1619354938675.atlassian.net/jira/software/projects/SHOP/boards/1/roadmap?selectedIssue=SHOP-8&shared=&atlOrigin=eyJpIjoiOGVhZjMzYjY1NzgyNDU3YmE4YTRiODliMjgzYTUxMDIiLCJwIjoiaiJ9](https://team-1619354938675.atlassian.net/jira/software/projects/SHOP/boards/1/roadmap?selectedIssue=SHOP-8&shared=&atlOrigin=eyJpIjoiOGVhZjMzYjY1NzgyNDU3YmE4YTRiODliMjgzYTUxMDIiLCJwIjoiaiJ9)

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%201.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%201.png)

    - Database: Azure Virtual Machine

        My database will be called OnlineShoppingDb, using Azure Virtual Machine, it will hold two tables. One for customer records and the other will be products.

        Using LucidChart I have created an ERD which contains my two tables and an orders table.

        ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%202.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%202.png)

        Using [portal.azure.com](https://portal.azure.com/) I will create an Azure Databse for my SQL.

    C - Create new data for file storage

    This could be either creating a user account or creating an order and adding it to the basket

    R - Get that file of bunch of file data (get my orders)

    Reading the users account details or viewing the users cart to see what they have added.

    U - Modify data that exists (add to cart)

    Updating their existing details such as Title, Name, Address or Email. Updating their cart and adding products into their Cart

    D - Remove file data 

    Deleting their information from the records or removing a product from their cart.

    [Risk Assessment Table](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Risk%20Assessment%20Table%20674b4b9ed7bd4b009cc0380613dcad6a.csv)

- Software Design and Development

    > Azure Database for my SQL

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%203.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%203.png)

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%204.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%204.png)

    Using a single server, and naming the resource group as wamdahhassan, and servername as wamdahhassandb, the version is 5.7.

    Configured the computer storage to basic, set vCore and one and set the storage as 5GB. Putting no on the storage growth.

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%205.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%205.png)

    Creating a tag and have named it myProject and setting the value as true since this will be needed to stay for my project.

    > Creating an [ASP.NET](http://asp.NET) Core Web App

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%206.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%206.png)

    > Creating a project name and solution

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%207.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%207.png)

    > Adding three new action controllers

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%208.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%208.png)

    > Adding, html pages for Account, Cart and Products

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%209.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%209.png)

    > Adding to the navigation bar in an ordered list for the pages, Products, Account and Cart

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2010.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2010.png)

    After these steps were taken, I ran into some errors such as not being able to put the details I wanted into the views I had created. I went back and did some research and realized that a different approach was to be taken. 

    Following the structure of the MVC application:

    1. Model - Contains the data being rendered.
    2. View - Renders my pages and data.
    3. Controller - maps and controls request services. 

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2011.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2011.png)

    For my code to interact with my database I have created a DbContext class. This class will manage my database connection and will be used to retrieve and save data in my database.

    I am creating the project following these steps.

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2012.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2012.png)

    Models - I have created a new class in my models folder, and named it people, which is the customers details, that will be in my people table. And have also created a seperate class below for products.

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2013.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2013.png)

    **Binding Model - to inject information**

    To be able to add or create data to people and products, binding models are needed. This are to inject the data that is input into the products or people class:

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2014.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2014.png)

    For Title, I have created a separate class since it has a number of different constants assigned to it. These constants are as shown below:

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2015.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2015.png)

    View - I have now created two folders in my Views folder and named one people and the other products, as this folder will be called when the program looks for people and products.

    Inside the people folder I have added a view for each action:

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2016.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2016.png)

    Inside the Create view I have created a form, in which the user can input their details/product details:

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2017.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2017.png)

    Controller - I have also now created a people controller in my controllers folder and created IActionResult for each of the CRUD procedures for a customer to be able to create, read, update and delete their details and linked these to each pairing view file: 

    Create:

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2018.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2018.png)

    Read :

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2019.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2019.png)

    Update:

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2020.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2020.png)

    Delete:

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2021.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2021.png)

    - Database: Azure Virtual Machine

        My database will be called TheWamdahShopDb, using Azure Virtual Machine, it will hold two tables. One for customer records and the other will be products.

        ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2022.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2022.png)

    Then using the connection string from my server I have pasted it into my json file. Using the package manager console on Visual Studio, I have added a Migration and updated the database.  

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2023.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2023.png)

    I can now see my 'thewamdahshopdb' database appear in my resource group on Azure VM. 

    I can now also open my sql workbench and type in the following commands to view my database and the tables inside my database:

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2024.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2024.png)

    Start debugging to view how my app is now working:

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2025.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2025.png)

    From this the page allows the user to enter their details into the form, also view update and delete their details. All the CRUD action buttons worked as required, and also able to navigate from their details back and forth:

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2026.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2026.png)

    Another issue I had faced was when I tried to change the startup folder to Products so that as soon as you start the program the products would list on the first page so that the user can view them, view their details and then add them to their cart. When I did attempt to do this, the page was not found, so it seemed to be a routing issue:

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2027.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2027.png)

    I was unable to add a product with their details this also was a routing issue as when you click on the action button:

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2028.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2028.png)

     It would not take me to the add product as the route specified page:

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2029.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2029.png)

    Instead it would go to the create product view page:

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2030.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2030.png)

    In the future I would like to get the navigation bar at the top of the page to work so that the user can navigate through the app easily, instead of when the home opens and having to type in the URL for their account details page.

    By going into the _Layout.cshtml file, it was possible to change the route of the action links on the navigation bar:

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2031.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2031.png)

    By changing the asp-controller so that it goes to the correct controller, as before it was set to home.

    I would have liked to add a third table for orders, so that its possible for a user to actually put through an order using the product id and the person ID. Also instead of the user creating a product, I would like to in future have a set list of products and allow the user to add more than one item to their cart and view the number of products they have in their cart and the total sum of money that the products add up to. To then be able to edit this to increase or decrease the amount they would like.

    Also to be able to add a sign in feature where a username and password can be entered to access the users details and their products privately. 

    If I had more time, I would have liked to put more detail and time into the planning, to have a clear idea of how design the web app and maybe add some colour. And to be able to have go back to debug and finish the testing. 

- Testing

    Unit Testing with C#

    - Coverage Report
    - Testing CRUD functionality

    To be able to test my code, I need to create mocks of my code. Before mocking my code, I need to create interfaces that will implement my database, this process is called repository pattern. 

    So I have created an interface folder, and to it I have added a public generic interface and called it IRepository:

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2032.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2032.png)

     And have also created interfaces for my model which are IPerson, IProduct and for the functions add and update.

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2033.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2033.png)

    IRepository Wrapper, enables me to update my tables and also save them, it contains the data tables for products and people.

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2034.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2034.png)

    Also creating a Repository folder and created a repository class, which inherits IRepository into it, and implemented the interface inside of this class. 

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2035.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2035.png)

    Going back to my controllers I can now remove, dbContext and replace it with repository. However when I save and run this, my details page no longer works.

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2036.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2036.png)

    To solve this I have added FirstOrDefault

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2037.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2037.png)

    Another issue I had noticed was that, my update details for the user would no longer update. No Error occurred for this however I am unsure of the reason. 

    Creating a new test project and named it TheWamdahShopControllerTests and added a class called ControllerTests

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2038.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2038.png)

    I have added a reference to this test project from thewamdahshop as I will be references to the files in this project. 

    In the controller tests class I have created all the mock tests I will be using to test my controller functions. 

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2039.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2039.png)

    Which are get all products, add products, delete products and get people.

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2040.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2040.png)

    In my get people function, it should also return the products they have, the error that was showing was that there is no product in the person model, however when I add product to the product model I get another error:

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2041.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2041.png)

    I was unable to fix this issue however I carried out tests on those that were working and that I was able to test, Which were AddProduct test DeleteProduct and GetAllProducts test:

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2042.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2042.png)

    To obtain my test coverage report, in the powershell developer I have entered the following command 

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2043.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2043.png)

    This is to install globally the reportgenerator tool

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2044.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2044.png)

    And then the command above to generate my test coverage report:

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2045.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2045.png)

    C:\Users\wamdah.hassan\source\TheWamdahShop\TheWamdahShopControllerTests\TestResults\54b2d542-0f27-412e-bbc9-e268dd06f074\coverage.cobertura.xml

- Deployment

    Using GitHub Actions I will deploy my web app to Azure. First I will create my azure app service

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2046.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2046.png)

    Naming it TheWamdahShopApp

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2047.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2047.png)

    And using .Net5

    I have named my app service plan 'wamdah-shop-appservice'

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2048.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2048.png)

    I have changed the service plan to Dev/Test and chosen plan B1

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2049.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2049.png)

    Now going back to Microsoft Visual Studio, and publishing my project.

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2050.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2050.png)

    Choosing Azure

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2051.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2051.png)

    And then using Azure App Service (Linux)

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2052.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2052.png)

    Using GitHub Actions

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2053.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2053.png)

    Which now produces my yml file.

    Copying the WebApp connection string from connection settings, and going to configuration and creating a new connection string

    On GitHub it shows that all checks have been passed

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2054.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2054.png)

    I can now open my webapp using the link from my app service.

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2055.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2055.png)

    ![Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2056.png](Shopping%20Cart%20a5d9359f7abe4cd783ed439a17fc236c/Untitled%2056.png)