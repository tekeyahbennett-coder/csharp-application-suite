# C# Application Suite

A collection of C# console applications built to demonstrate core programming concepts including OOP, inheritance, data structures, LINQ, and input validation.

## Projects Included

### 1. Student Polymorphism System (`Exam 3/`)
- Abstract `Student` base class with full inheritance hierarchy
- Subclasses: `ElementarySchoolStudent`, `MiddleSchoolStudent`, `HighSchoolStudent`, `CollegeStudent`
- `IMathClass` interface implementation demonstrating polymorphic behavior

### 2. Loan Interest Calculator (`Loan Program/`)
- Calculates total interest based on principal, rate, and term
- Input validation for positive amounts and rates between 0-1
- Interface-based design for extensibility

### 3. Receipt Generator (`Receipt_V3/`)
- Multi-item receipt system with quantity, price, and subtotal calculations
- 2D array storage for up to 100 items
- Formatted currency output with running totals

### 4. Regex Input Validation (`Regular Expression for Validation/`)
- Name validation (first/last, 2-15 characters, letters only)
- Credit card number validation (12-19 digits)
- Loop-based retry logic with user-friendly error messages

### 5. LINQ List Processing (`List with Linq/`)
- LINQ `Select()` transformations on collections
- Custom string capitalization (title case)
- Address data collection and formatted output

### 6. Queue & Stack Operations (`Queue/`)
- Queue and stack implementations using .NET collections
- Enqueue/dequeue and push/pop operations
- Array reversal and null-safe display with coalescing operators

### 7. Course Management Dictionary (`Final Exam/`)
- Dictionary-based course lookup by course ID
- Key-value pair iteration and display
- Demonstrates efficient collection usage

## Additional Practice Exercises

A few smaller, earlier exercises are also included for completeness:

- **`Exam 2/`** - A `Person` class exercise covering basic object properties and a runner program.
- **`Student/`** - An earlier, simpler `Student`/`Program` exercise that predates the polymorphism system in `Exam 3/`.
- **`Inheritance/`** - A `Campus`/`DSC` inheritance exercise exploring base and derived class relationships.

## Tech Stack

- **Language:** C# / .NET 8
- **Tools:** Visual Studio 2022, VS Code
- **Concepts:** OOP, inheritance, interfaces, LINQ, regex, data structures

## How to Run

Each folder is a standalone project. Open the relevant `.csproj` (or the `Inheritance.sln` for the Inheritance exercise) in Visual Studio 2022, or run it from the command line with:

```
dotnet run --project "<folder name>"
```
