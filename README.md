# TextbookFinderV2
 
## Concept
## This project consist of an E-commerce Web Application design to be hosted on a server and makes use of simple database designed to hold descriptive data about textbooks. It includes an ERD diagram, class diagram, several wire-frame sketches that illustrate the basic concept and useability of the application. In the simplest form, the application will retrieve a list of textbooks to be displayed to the user with descriptive information and direct link to the publisher/retailer. 

*** 
# <a name="tcontent"></a>
# Table of Content 

- [Basic Connectivity](#bconnect)
- [Database Diagrams](#dbdia)
- [SQL Database Script](Database)
- [Wire-Frames](#wf)
- [UML Diagram](#umldia)
- [User Stories](#userstory)
- [Use Cases](#usecase)
- [Requirements](#reqlist)
- [Requirement Traceability Matrix](#RTM)
- [Prototype](Prototype/README.prototype.md)



***

# <a name="bconnect"></a>
## Basic Connectivity <h2>
[table of content](#tcontent)

![Process](https://user-images.githubusercontent.com/20195657/89743180-62a0c480-da55-11ea-964e-86f0f3a718f7.png)

***

<a name="dbdia"></a>
## Database Diagrams <h2>
[table of content](#tcontent)

![ERDDiagram](https://user-images.githubusercontent.com/20195657/89742739-74806880-da51-11ea-91dc-3aaa54e16cf8.png)

---

![BooksDB pdf (1)](https://user-images.githubusercontent.com/20195657/89743017-fffaf900-da53-11ea-9fb1-be9eec73c353.png)

![DatabaseDiagram](https://user-images.githubusercontent.com/20195657/93658619-118bd500-f9f2-11ea-84ed-86408270809c.png)

*** 

<a name="wf"></a>
## Wire-Frames: DRAFT <h2> 
[table of content](#tcontent)

## 1) 
![Sketch2](https://user-images.githubusercontent.com/20195657/89742744-7c400d00-da51-11ea-8c4c-fd2be526c949.png)

## 2) 
![Sketch3](https://user-images.githubusercontent.com/20195657/89742747-819d5780-da51-11ea-89aa-7379ab14118b.png)

## 3)
![Sketch4](https://user-images.githubusercontent.com/20195657/89742751-85c97500-da51-11ea-8482-b5930437c8e5.png)

***

<a name="umldia"></a>
## UML Diagram <h2>
[table of content](#tcontent)

![UML Diagram(1)](https://user-images.githubusercontent.com/20195657/90574316-79d66500-e16d-11ea-8fa4-e4e169a4a160.png)

***

                Actors: College student, Professor, Staff and Other users (non-students or faculty or Staff)
<a name="userstory"></a>
## User-Stories <h2>
[table of content](#tcontent)
  
1)	As a college student, I want to be able to search for books by Name or ISBN number so that I can get a list of relevant results and links with option to click and visit the publisher’s/retailer’s website.
2)	As a professor, I need to be able to enter the name or ISBN number of a textbook into a search mechanism so that I can see a list of books to choose from to aid in future assignments.
3)	As an everyday user, I need to be able to search for any kind of book or publication with links to other resources such as ReadMyBook (Richard Lee’s project) for the visually impaired and/or store locator (using google maps).

***

<a name="usecase"></a>
## Use Cases <h2>
  
### Use Case – Actor: College Student – Search for assigned textbook
-	Given I have a textbook to search for and I have the name and/or ISBN number, when I attempt to search for the name or number of the textbook, a list of results should be displayed with descriptive information, external links for purchasing options and a map to locate nearby retailers.

### Use Case – Actor: College professor – Search for reference material 
-	As a professor, given I have a list of required textbooks passed down by the department chair, when I attempt to search for reference material through the use category filters, a list of relevant textbooks is displayed with descriptive information based on the category selected. (this should be a list of results of free material to use as reference) 

### Use Case – Actor:  Everyday user (staff) – Searching for a book to share
-	Given I have a book in mind to search for, and I search for the title by a specific name or ISBN number, I get a list of results that I can scroll through so that I can select a title and share it with social media such as Facebook, Tweeter or Instagram. 

### Use Case – Actor:  Everyday user (non-student) – Search for a book to read
-	Given I have a book in mind that I want to find for purchase, and I attempt to search for the book by name or ISBN number, a list of relevant results is displayed in which I can make a selection to display the location of a retailer, or use links to other applications such as: application that read text outloud. 

***

<a name="reqlist"></a>
## Requirements <h2>
[table of content](#tcontent)

| ID |  Requirement List - System shall..                                            |Test Method|Test ID|
|----|-------------------------------------------------------------------------------|-----------|-------|
|1.0 |	Allow user to view pages of textbooks available                               |Inspection |T1     |
|1.1 |	Allow user to traverse through inventory pages                                |Unit Test  |T2     |
|1.2 |	Allow user to select individual textbook items                                |Demo       |T3     |
|1.3 |	Show color difference when catgory is selected                                |inspection |T4     |
|2.0 |	Display a relevant list of results when a category is selected                |Inspection |T5     |
|2.1 |	Display a maximum of 5 results per page                                       |Demo       |T6     |
|2.2 |	Allow user to add textbook items to the Cart                                  |Unit Test  |T7     |
|2.3 |	Allow user to see quantity of items in Cart and the current total             |Unit Test  |T8     |
|2.4 |	Allow user to remove items from Cart                                          |Demo       |T9     |
|3.0 |	Do not allow user to checkout with empty Cart                                 |Inspection |T10    |
|3.1 |	Let user submit valid shipping details and go through checkout                |Demo       |T11    |
|3.2 |	Display that order was successfully summit it along with order number         |Inspection |T12    |
|3.3 | Display an introduction page at the start of the application                  |Inspection |T13    |


***

<a name="RTM"></a>
## RTM <h2>
[table of content](#tcontent)
| ID |  Requirement Traceability Matrix  - Project: TextbookFinder                   |Implemented?| Initial |      Status       | Test Method |
|----|-------------------------------------------------------------------------------|------------|---------|-------------------|-------------|
|T1  |	Verify controller can use textbook repository file                            |     Yes    | Tested  | passed (10/12/20) |Inspection   |
|T2  |	Inspect list of textbooks displayed                                           |     Yes    | Tested  | passed (10/12/20) |Unit Test    |
|T3  |	Check that each product page is displayed                                     |     Yes    | Tested  | passed (10/15/20) | Unit Test   |
|T4  |	Verify category boxes are selectable                                          |     Yes    | Tested  | passed (10/15/20) |Inspection   |
|T5  |	Verify list of textbooks are filterd by the category selected                 |     Yes    | Tested  | passed (10/17/20) |Inspection   |
|T6  |	Check the filtered result shows the precribed number of results (5)           |     Yes    | Tested  | passed (10/20/20) |Inspection   |
|T7  |	Check that the Cart can add/load new items (textbooks)                        |     Yes    | Tested  | passed (10/20/20) | Unit Test   |
|T8  |	Verify the Cart sums the quantity of items in it                              |     Yes    | Tested  | passed (10/23/20) |Inspection   |
|T9  |	Verify items can be removed from Cart and Cart can be cleared                 |     Yes    | retest  | failing           |Inspection   |
|T10 |	Verify that system does not allow Checkout with empty Cart                    |     Yes    | Tested  | passed (10/24/20) |   Demo      |
|T11 |	Check valid shipping details for checkout and verify it Checks out an order   |     Yes    | Tested  | passed (10/27/20) | Tes/Demo    |
|T12 |	Check the order is saved to the database in the Orders table                  |     No     | Not Yet | failing           |Inspection   |
|T13 | Verify the intro page is displayed first                                      |     No     | Tested  | failing           |   Demo      |



***

| ?  |  Test Readiness Review                                                        |     %         |Test IDs                            |
|----|-------------------------------------------------------------------------------|---------------|------------------------------------|
| 1  |	What percent of requirements are (currently) covered by test cases?           |   80%         |T1 - T11                            |
| 2  |	What percent of test cases are currently passing?                             |   84.6%       |T1-T8, T10, T11                     |
| 3  |	What level of Validation could be expected after Verification?                |System Testing |Need to evaluate system’s compliance|



## Functional Requirements: The application must…
-	Search for books using web resources such as an external API
-	Allow user to enter query into a search mechanism
-	Allow user to select filters against the query to limit the number of results
-	Display a list of results in a scroll-down or scroll-up fashion
-	Allow to select a book to see description and retailer link
-	Display the location of a retailer nearby (map)
## Non-functional Requirements: The application should be…
-	Simple to use with few filtering options
-	Accessed through a web-browser
-	Able to search thru any category, name or ISBN number
-	Available 24/7 
-	Working in cohesion with an external API to render data to user.
-	A one- or two-page application, one: to display results, two: to display a bigger view of the selected result with product description, links and map.

***


