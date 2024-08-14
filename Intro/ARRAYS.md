# Arrays in C#

### Overview

- **Fixed-Size Collection:** An array is a fixed-size collection of elements, meaning the number of elements in an array is defined at the time of its creation and cannot be changed.
- **Multiple Values:** Arrays are used to store multiple values in a single variable, allowing for more organized and manageable code.
- **Homogeneous Data Types:** All elements in an array must be of the same data type.

### Defining and Initializing Arrays

1. **Defining an Array:**

   - **Example:**
     ```csharp
     // Defining an array with 5 elements
     string[] country = new string[5];
     ```

2. **Defining and Initializing an Array:**

   - **Example:**
     ```csharp
     string[] country = { "Sri Lanka", "Singapore", "Italy", "Poland", "Canada" };
     ```

3. **Initializing Elements in an Array:**

   - **Example:**
     ```csharp
     double[] height = { 87.1, 65.7, 12.7, 91.6 };
     int[] age = { 50, 27, 32, 49, 61 };
     ```

### One-Dimensional vs. Two-Dimensional Arrays

#### **One-Dimensional Array**

- **Description:** A simple data structure that stores a collection of similar type data in a contiguous block of memory.
- **Other Names:** Called a single-dimensional array.
- **Storage:** Data will be stored as a list.

  **Example:**
  ```csharp
  int age[] = new int[5];
  ```

#### **Two-Dimensional Array**

- **Description:** A type of array that stores multiple data elements of the same type in a matrix or table-like format with a number of rows and columns.
- **Other Names:** Called a multidimensional array.
- **Storage:** Data will be stored in a row-column format.

  **Example:**
  ```csharp
  string name[][] = new string[5][8];
  ```

### Array Methods

Here are some commonly used methods from the `Array` class:

1. **`Clone()`**
   - **Description:** Used to create a shallow copy of the array.
   - **Example:**
     ```csharp
     int[] numbers = { 1, 2, 3 };
     int[] numbersClone = (int[])numbers.Clone();
     ```

2. **`Copy()`**
   - **Description:** Used to copy array elements into another array by specifying the starting index.
   - **Example:**
     ```csharp
     int[] sourceArray = { 1, 2, 3 };
     int[] destinationArray = new int[3];
     Array.Copy(sourceArray, destinationArray, 3);
     ```

3. **`Empty<T>()`**
   - **Description:** Used to return an empty array.
   - **Example:**
     ```csharp
     string[] emptyArray = Array.Empty<string>();
     ```

4. **`Finalize()`**
   - **Description:** Used to free resources and perform platform cleanup operations. (Not commonly used in typical array operations.)

5. **`Sort(Array)`**
   - **Description:** Used to sort all the elements of a one-dimensional array.
   - **Example:**
     ```csharp
     int[] numbers = { 3, 1, 2 };
     Array.Sort(numbers);
     // numbers is now {1, 2, 3}
     ```

6. **`Reverse(Array)`**
   - **Description:** Used to reverse the sequence of elements in an array.
   - **Example:**
     ```csharp
     int[] numbers = { 1, 2, 3 };
     Array.Reverse(numbers);
     // numbers is now {3, 2, 1}
     ```

7. **`IndexOf(Array, Object)`**
   - **Description:** Used to search for the specified object and return its first occurrence in a one-dimensional array.
   - **Example:**
     ```csharp
     int[] numbers = { 1, 2, 3 };
     int index = Array.IndexOf(numbers, 2); // index will be 1
     ```

### Array Class vs. ArrayList Class

#### **Array Class:**
- **Description:** A base class for language implementation that supports array operations. It provides methods for creating, manipulating, searching, and sorting array elements.

#### **ArrayList Class:**
- **Description:** Represents a resizable collection of elements that can contain elements of any data type. Unlike arrays, `ArrayList` can grow in size dynamically as elements are added.
