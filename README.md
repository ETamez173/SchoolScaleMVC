# SchoolScale

SchoolScale is an Asp.Net MVC web app with full CRUD functionality that allows users to research degrees and higher education programs, search for schools based on user degree selections.  It offers a simple, user-friendly design and increases the efficiency of school evaluation for better decision making.

On the degrees and programs tab, the user is presented with a simple list of available degrees and programs. Users have the ability to review the degrees and programs listed along with the average yearly earnings, high earning, and low earnings for the given degree. The user can then select a degree they like search for schools offering the degree or program.
While on the degrees and programs tab users can add a new degree to the list.  Users can edit a degree and increase or decrease earnings and update the name if needed.

Once the user clicks on the Find Schools link they are taken to the School Match page and presented with a comprehensive list of Schools offering the selected degree or program.  Users can review the schools in the listing along with the yearly cost and total cost of attending the schools.

While on the School Match page users can add a new school to the list. 

Once the user clicks on the Begin Analysis link they are taken to the Financial Workbench where they are able to enter information about paying for school.  They are able to enter their intended personal contributions, grants, and scholarships.  If they need a loan the workbench allows the user to enter the loan period in years and the loan interest rate and the user can then press the “Crunch Numbers” button and this takes them to the “Benefit Cost Analysis” page.

On the “Benefit Cost Analysis” page the user is presented with a list of the degrees they are considering.  Each degree and school combination they are considering is shown with details about related earnings and the related costs.  The user is presented with Estimated Career Earnings over 20 years and the breakdown of the total costs of the degree and a calculated Benefit Cost Ratio is shown that represents how much they can expect to get back from the chosen degree over time for each dollar spent.  For example, a ratio of 24 means that the user would get back $24 for each $1.00 they put into the degree.  The higher the ratio the better financial benefit to the user.

While on the “Benefit Cost Analysis” page the use can compare multiple degree choices. The user can add a note to the listing and they are able to Delete a listing.

# Image of the app here

Installation
In your terminal run git clone SSH KEY HERE
Open Visual Studio
Under the tools tab, open the NuGet Package Manager console and run Update-Database to run migrations
Build and run the application after migrations are complete

# Usage

1.	Register as a new user and login
2.	Navigate to the Degree link on the navbar
3.	Review degrees and programs and find one that you want to do some research on
4.	Click on degree details in the page to view degree details edit the degree item
5.	Click on the "Find Schools" link of an item to search for matching schools
6.	On the School Match page review the degree annual cost and total cost for each degree 
7.	Click on school details to view details 
8.	To begin the analysis, click the Begin Analysis link  
9.	On the Financial Workbench page. You can enter your personal contributions, grants, and scholarships. Next enter loan period in years and the loan interest rate and press the “Crunch Numbers” button and you will be taken to the Benefit Cost Analysis page
10.	On the Benefit Cost Analysis page review the Estimated Earnings and the costs for each degree and school combination as well as the calculated Benefit Cost Ratio 
11.	Add a note to an item
12.	Delete an item 
13.	Navigate back to My Pantry and view the purchased grocery item has been added to the pantry list


