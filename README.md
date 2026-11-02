# Product Management System

A simple, console-based **Product Management System** built in **C#** (.NET). This application allows users to manage a list of products interactively with robust input validation and formatted console output.

---

## Features

1. **Add Products**: Add products with a category, name, and price. Includes input validation:
   - Non-empty validation.
   - Character length restrictions (between 3 and 15 characters for categories and names).
   - Numeric check (categories and names cannot contain numbers).
   - Decimal validation for prices (prevents negative values and invalid formats).
2. **View Products**: Displays a cleanly formatted list of all registered products sorted by price in ascending order.
3. **Search Products**: Search for products by name or category (case-insensitive).
4. **Total Price**: Calculate and display the sum of the prices of all products in the system.
5. **Interactive Menu**: User-friendly navigation loop with color-coded console messages for success, warnings, and errors.

---

## Technologies Used

* **C#**
* **.NET** (Console Application)
* **LINQ** (for sorting, filtering, and aggregation)

---

## Getting Started

### Prerequisites

Make sure you have the [.NET SDK](https://dotnet.microsoft.com/) installed on your machine.

### Installation & Running

1. Clone the repository or download the source code:
   ```bash
   git clone <repository-url>
