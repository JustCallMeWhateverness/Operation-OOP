# Individual Assignment – OOP, Inheritance/Composition & Basic Algorithms
**Overview:**
You will be provided with a pre-existing API project that includes three endpoints for managing bonsai trees. Your task is to create a class library and integrate it with the API by:
•	Expanding the logic (adding multiple classes, using inheritance or composition from the existing Bonsai class, or creating entirely new classes and interfaces such as IEntity).
•	Implementing a simple algorithmic function (search, sorting, filtering, or a basic calculation).
•	Adding new endpoints to the API that use your logic.
This assignment aims to assess your skills in:
•	Algorithmic thinking and logical approaches to designing algorithms.
•	Analysis and structuring of applications.
•	Object-oriented programming techniques (inheritance, composition, encapsulation, etc.).

**Course Objectives Covered**
1.	Algorithmic thinking and logical approaches to designing algorithms.
2.	Analysis and structuring of applications.
3.	Structured and object-oriented programming techniques.
________________________________________
## Step-by-Step Instructions
1. Retrieve the Existing API Project
Start with the provided code and verify that the three Bonsai endpoints function correctly:
•	GET /api/bonsai - Retrieves all bonsai trees.
•	GET /api/bonsai/{id} - Retrieves a specific bonsai tree.
•	POST /api/bonsai - Creates a new bonsai tree.
Familiarize yourself with the project structure (Program.cs, Bonsai.cs, endpoints, etc.).
________________________________________
2. **Create/Extend the Class Library**
•	Base your work on the existing Bonsai class in OperationOOP.Core/Models/Bonsai.cs.
•	Add at least two new classes to the class library to enhance Bonsai management.
•	Use inheritance or composition from the Bonsai class or create a common interface (e.g., IEntity).
•	Ensure your classes:
o	Use encapsulation (public/private/protected).
o	Follow design principles (e.g., "Single Responsibility", "Composition over inheritance" when appropriate).
________________________________________
3. **Implement an Algorithmic Method**
Add at least one method with simple algorithmic logic. Example implementations:
•	Filter a list of products to find those with low stock.
•	Search for an animal in a zoo by name or species.
•	Calculate a total sum or sort objects by price, quantity, or name.
This method should be accessible via an API endpoint.
________________________________________
4. **Add New API Endpoints**
Ensure you add at least 2–3 new endpoints, such as:
•	GET for listing or filtering objects.
•	POST for adding a new object to your in-memory collection.
Your endpoint logic should interact with your class library. Using Dependency Injection (DI) is optional but encouraged.
________________________________________
5. **Test and Demonstrate**
•	You don’t need to write unit tests (unless required), but test your endpoints using a web browser, Postman, or built-in Swagger pages.
•	Verify that your algorithmic methods work correctly (e.g., checking if filtering or sorting returns the correct results).
________________________________________
## Example Ideas
Here are some example domains for inspiration:
**Recipe Management**
•	Classes: Recipe (base), Ingredient, CookingStep
•	Algorithms:
o	Filter recipes based on cooking time or difficulty.
o	Search for recipes that contain specific ingredients.
o	Scale ingredient amounts for different portions.
•	Endpoints:
o	GET /recipes
o	GET /recipes/search
o	POST /recipes
________________________________________
**Workout System**
•	Classes: Workout (base), CardioWorkout, StrengthWorkout, Exercise
•	Algorithms:
o	Calculate total workout duration and calorie burn.
o	Filter exercises by muscle group.
o	Sort workouts by intensity level.
•	Endpoints:
o	GET /workouts
o	GET /workouts/muscle-group/{group}
o	POST /workouts
________________________________________
**Game Character Management**
•	Classes: Character (base), Warrior, Mage, Equipment, Skill
•	Algorithms:
o	Calculate total damage or defense.
o	Filter characters by class or level.
o	Sort equipment by value or rarity.
•	Endpoints:
o	GET /characters
o	GET /characters/class/{class}
o	POST /characters
________________________________________
**Plant Management**
•	Classes: Plant (base), IndoorPlant, OutdoorPlant, WateringSchedule
•	Algorithms:
o	Calculate the next watering date.
o	Filter plants by care difficulty.
o	Sort by health status or water requirements.
•	Endpoints:
o	GET /plants
o	GET /plants/care-level/{level}
o	POST /plants
________________________________________
**Movie Library**
•	Classes: Movie (base), Review, Director, Genre
•	Algorithms:
o	Calculate the average rating.
o	Filter movies by genre or release year.
o	Sort by rating or release date.
•	Endpoints:
o	GET /movies
o	GET /movies/genre/{genre}
o	POST /movies
________________________________________
Key Concepts Demonstrated
Each of these examples allows you to showcase:
•	Inheritance and/or Composition
•	Encapsulation of Data
•	Algorithmic Data Processing (searching, filtering, sorting)
•	REST API Design
•	(Optional) Dependency Injection
________________________________________
Final Submission
1. **Code Submission**
Submit your solution via a GitHub repository link.
•	Comment your code to explain your thought process.
2. **Short Video Presentation** (5–10 min)
Create a short video explaining your solution.
•	Describe your classes and whether you used inheritance/composition (and why).
•	Demonstrate your algorithm (e.g., "Here's how the filtering works").
•	Discuss design principles you applied (e.g., "I chose composition over inheritance because...").
________________________________________
## Higher-Level Criteria (For VG-Grade)
According to course objectives, you should:
1.	Independently analyze and combine OOP concepts
2.	Evaluate alternative solutions when selecting programming techniques
3.	Utilize pre-existing solutions in frameworks and class libraries
4.	Discuss OOP concepts such as polymorphism, inheritance, interfaces, abstract classes, etc.
5.	Evaluate different design choices
o	Why use inheritance instead of composition (or vice versa)?
o	What other design patterns/principles might be relevant?
6.	Pre-Built Solutions in .NET
o	Evaluate how .NET features (e.g., Minimal API, DI, Collections, LINQ) helped your implementation.
o	Could you use design patterns like Repository or Strategy?
________________________________________
## Going Beyond
If you want to challenge yourself, you can:
•	Expand your class library with additional classes or extra functionality (e.g., categories, related objects).
•	Implement design principles more rigorously (SOLID, DIP/IoC, etc.).
•	Add more complex algorithms (e.g., advanced calculations, data validation).
•	Introduce additional endpoints or integrate an external file/database (if time and knowledge allow).
________________________________________
**Good Luck!**
This assignment is a great opportunity to practice:
•	Object-oriented design in a real-world scenario.
•	Separating class libraries from API logic.
•	Implementing basic algorithms for filtering/searching/calculations.
