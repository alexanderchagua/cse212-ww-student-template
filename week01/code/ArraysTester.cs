public static class ArraysTester {
    /// <summary>
    /// Entry point for the tests
    /// </summary>
    public static void Run() {
        // Sample Test Cases (may not be comprehensive)
        Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
        double[] multiples = MultiplesOf(7, 5);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{7, 14, 21, 28, 35}
        multiples = MultiplesOf(1.5, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{1.5, 3.0, 4.5, 6.0, 7.5, 9.0, 10.5, 12.0, 13.5, 15.0}
        multiples = MultiplesOf(-2, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{-2, -4, -6, -8, -10, -12, -14, -16, -18, -20}

        Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 1);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{9, 1, 2, 3, 4, 5, 6, 7, 8}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 5);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{5, 6, 7, 8, 9, 1, 2, 3, 4}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 3);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{7, 8, 9, 1, 2, 3, 4, 5, 6}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 9);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{1, 2, 3, 4, 5, 6, 7, 8, 9}
    }
    /// <summary>
    /// This function will produce a list of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>


/// The process for generating the list of multiples is as follows:
/// 1. Check if the specified 'length' is non-positive. If so, return an empty array.
/// 2. Create a List to store the multiples.
/// 3. Iterate through numbers from 1 to 'length'.
/// 4. In each iteration, calculate the multiple by multiplying 'number' by the current index.
/// 5. Add the calculated multiple to the list.
/// 6. After all multiples have been calculated and added to the list, convert the list to a double array.
/// 7. Return the array of multiples as the result.
    
private static double[] MultiplesOf(double number, int length)
{
    // Check if the 'length' is less than or equal to 0
    if (length <= 0)
    {
        // If 'length' is non-positive, return an empty double array
        return new double[0]; 
    }

    // Create a list to store the multiples of the given 'number'
    List<double> multiples = new List<double>();

    // Iterate through numbers from 1 to 'length'
    for (int i = 1; i <= length; i++)
    {
        // Calculate the multiple by multiplying 'number' with 'i'
        double multiple = number * i;
        
        // Add the calculated multiple to the list
        multiples.Add(multiple);
    }

    // Convert the list of multiples to a double array and return it
    return multiples.ToArray();
}
    
    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// <c>&lt;List&gt;{1, 2, 3, 4, 5, 6, 7, 8, 9}</c> and an amount is 3 then the list returned should be 
    /// <c>&lt;List&gt;{7, 8, 9, 1, 2, 3, 4, 5, 6}</c>.  The value of amount will be in the range of <c>1</c> and 
    /// <c>data.Count</c>.
    /// <br /><br />
    /// Because a list is dynamic, this function will modify the existing <c>data</c> list rather than returning a new list.
    /// </summary>
    /// 


    /// The process for rotating the list is as follows:
/// 1. Check if 'amount' is within a valid range (between 1 and the size of the list).
/// 2. Calculate the index at which the list will be split to form two parts.
/// 3. Get the first part of the list from the split index to the end.
/// 4. Get the second part of the list from the beginning to the split index.
/// 5. Concatenate the first and second parts to form the rotated list.
/// 6. Clear the original list.
/// 7. Add all elements from the rotated list back to the original list.
   private static void RotateListRight(List<int> data, int amount)
{
    if (amount >= 1 && amount <= data.Count)
    {
        // Calculate the index where the list will be split.
        int splitIndex = data.Count - amount;
        
        // Get the first part of the list.
        List<int> firstPart = data.GetRange(splitIndex, amount);

        // Get the second part of the list.
        List<int> secondPart = data.GetRange(0, splitIndex);

        // Concatenate the two parts to form the rotated list.
        firstPart.AddRange(secondPart);

        // Update the original list with the rotated list.
        data.Clear();
        data.AddRange(firstPart);
    }
    // If the value of 'amount' is not in the valid range, no rotation will be performed.
}
}
