# Individual Assignment – OOP, Inheritance/Composition & Basic Algorithms
**Overview:**
You will be provided with a pre-existing API project that includes three endpoints for managing bonsai trees. Your task is to create a class library and integrate it with the API by:
-	Expanding the logic (adding multiple classes, using inheritance or composition from the existing Bonsai class, or creating entirely new classes and interfaces such as IEntity).
-	Implementing a simple algorithmic function (search, sorting, filtering, or a basic calculation).
-	Adding new endpoints to the API that use your logic.
This assignment aims to assess your skills in:
-	Algorithmic thinking and logical approaches to designing algorithms.
-	Analysis and structuring of applications.
-	Object-oriented programming techniques (inheritance, composition, encapsulation, etc.).

**Course Objectives Covered**
1.	Algorithmic thinking and logical approaches to designing algorithms.
2.	Analysis and structuring of applications.
3.	Structured and object-oriented programming techniques.
________________________________________
## Step-by-Step Instructions
1. **Retrieve the Existing API Project**
Start with the provided code and verify that the three Bonsai endpoints function correctly:
-	GET /api/bonsai - Retrieves all bonsai trees.
-	GET /api/bonsai/{id} - Retrieves a specific bonsai tree.
-	POST /api/bonsai - Creates a new bonsai tree.
Familiarize yourself with the project structure (Program.cs, Bonsai.cs, endpoints, etc.).
________________________________________
2. **Create/Extend the Class Library**
-	Base your work on the existing Bonsai class in OperationOOP.Core/Models/Bonsai.cs.
-	Add at least two new classes to the class library to enhance Bonsai management.
-	Use inheritance or composition from the Bonsai class or create a common interface (e.g., IEntity).
-	Ensure your classes:
-	Use encapsulation (public/private/protected).
-	Follow design principles (e.g., "Single Responsibility", "Composition over inheritance" when appropriate).
________________________________________
3. **Implement an Algorithmic Method**
Add at least one method with simple algorithmic logic. Example implementations:
-	Filter a list of products to find those with low stock.
-	Search for an animal in a zoo by name or species.
-	Calculate a total sum or sort objects by price, quantity, or name.
This method should be accessible via an API endpoint.
________________________________________
4. **Add New API Endpoints**
Ensure you add at least 2–3 new endpoints, such as:
-	GET for listing or filtering objects.
-	POST for adding a new object to your in-memory collection.
Your endpoint logic should interact with your class library. Using Dependency Injection (DI) is optional but encouraged.
________________________________________
5. **Test and Demonstrate**
-	You don’t need to write unit tests (unless required), but test your endpoints using a web browser, Postman, or built-in Swagger pages.
-	Verify that your algorithmic methods work correctly (e.g., checking if filtering or sorting returns the correct results).
________________________________________
## Example Idea

**Game Character Management**
-	Classes: Character (base), Warrior, Mage, Equipment, Skill
-	Algorithms:
-	Calculate total damage or defense.
-	Filter characters by class or level.
-	Sort equipment by value or rarity.
-	Endpoints:
-	GET /characters
-	GET /characters/class/{class}
-	POST /characters
________________________________________
**Key Concepts Demonstrated**

Each of these examples allows you to showcase:
-	Inheritance and/or Composition
-	Encapsulation of Data
-	Algorithmic Data Processing (searching, filtering, sorting)
-	REST API Design
-	(Optional) Dependency Injection
________________________________________
## Final Submission

1. **Code Submission**
Submit your solution via a GitHub repository link.
-	Comment your code to explain your thought process.
2. **Short Video Presentation** (5–10 min)
Create a short video explaining your solution.
-	Describe your classes and whether you used inheritance/composition (and why).
-	Demonstrate your algorithm (e.g., "Here's how the filtering works").
-	Discuss design principles you applied (e.g., "I chose composition over inheritance because...").
________________________________________
## Higher-Level Criteria (For VG-Grade)
According to course objectives, you should:
1.	Independently analyze and combine OOP concepts
2.	Evaluate alternative solutions when selecting programming techniques
3.	Utilize pre-existing solutions in frameworks and class libraries
4.	Discuss OOP concepts such as polymorphism, inheritance, interfaces, abstract classes, etc.
5.	Evaluate different design choices
-	Why use inheritance instead of composition (or vice versa)?
-	What other design patterns/principles might be relevant?
6.	Pre-Built Solutions in .NET
-	Evaluate how .NET features (e.g., Minimal API, DI, Collections, LINQ) helped your implementation.
-	Could you use design patterns like Repository or Strategy?
________________________________________
## Going Beyond
If you want to challenge yourself, you can:
-	Expand your class library with additional classes or extra functionality (e.g., categories, related objects).
-	Implement design principles more rigorously (SOLID, DIP/IoC, etc.).
-	Add more complex algorithms (e.g., advanced calculations, data validation).
-	Introduce additional endpoints or integrate an external file/database (if time and knowledge allow).
________________________________________
**Good Luck!**
This assignment is a great opportunity to practice:
-	Object-oriented design in a real-world scenario.
-	Separating class libraries from API logic.
-	Implementing basic algorithms for filtering/searching/calculations.
