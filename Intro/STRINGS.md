# Strings in C#

### Overview

- **Reference Data Type:** Strings are a reference data type in C#.
- **Storage:** They are used to store sequences of character objects, representing text.
- **Class:** A string in C# is an object of the `System.String` class.
- **Operations:** The `String` class provides a wide range of methods to perform various operations on strings.

### Declaration & Initialization

1. **Using `string` Keyword:**

   - **Declaration:**
     ```csharp
     string name; // String declaration
     ```

   - **Declaration and Initialization:**
     ```csharp
     string name = "Kamal"; // Declaration and initialization at once
     ```

2. **Creating an Object from `System.String` Class:**

   - **Declaration:**
     ```csharp
     String homeTown; // Declaration
     ```

   - **Declaration and Initialization:**
     ```csharp
     String homeTown = "Colombo"; // Declaration and initialization at once
     ```

### Common String Methods

Here are some commonly used methods from the `System.String` class:

1. **`Clone()`**

   - **Description:** Returns a reference to this instance of the string.
   - **Example:**
     ```csharp
     string original = "Hello";
     string copy = (string)original.Clone();
     ```

2. **`Compare(String, String)`**

   - **Description:** Compares two string objects.
   - **Example:**
     ```csharp
     int result = String.Compare("Apple", "Banana");
     // result will be less than 0 because "Apple" is less than "Banana"
     ```

3. **`Concat(String, String)`**

   - **Description:** Concatenates two specified strings.
   - **Example:**
     ```csharp
     string fullName = String.Concat("John", "Doe");
     // fullName will be "JohnDoe"
     ```

4. **`ToString()`**

   - **Description:** Returns an instance of the string.
   - **Example:**
     ```csharp
     int number = 123;
     string numberString = number.ToString();
     ```

5. **`Trim()`**

   - **Description:** Removes leading and trailing whitespace characters.
   - **Example:**
     ```csharp
     string text = "  Hello  ";
     string trimmedText = text.Trim(); // "Hello"
     ```

6. **`ToUpper()`**

   - **Description:** Converts a string into uppercase.
   - **Example:**
     ```csharp
     string text = "hello";
     string upperText = text.ToUpper(); // "HELLO"
     ```

7. **`IndexOf(char)`**

   - **Description:** Gets the index of the specified character in the string.
   - **Example:**
     ```csharp
     string text = "Hello";
     int index = text.IndexOf('e'); // index will be 1
     ```

8. **`Substring(Int32)`**

   - **Description:** Retrieves a substring from this instance starting at a specified index.
   - **Example:**
     ```csharp
     string text = "HelloWorld";
     string subText = text.Substring(5); // subText will be "World"
     ```

9. **`Join(String, String[])`**

   - **Description:** Concatenates all the elements of a string array, using the specified separator.
   - **Example:**
     ```csharp
     string[] words = { "Hello", "World" };
     string sentence = String.Join(" ", words); // sentence will be "Hello World"
     ```