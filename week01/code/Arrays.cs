public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.
    /// Example: MultiplesOf(7, 5) -> {7, 14, 21, 28, 35}
    /// </summary>
    public static double[] MultiplesOf(double number, int length)
    {
        // PLAN:
        // 1. Create a new array of doubles with the given length.
        // 2. Loop from index 0 to length - 1.
        // 3. For each index i, calculate the multiple as number * (i + 1).
        //    (i + 1 is used because the first multiple should be number itself.)
        // 4. Store the calculated value in the array.
        // 5. Return the filled array.

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result;
    }

    /// <summary>
    /// Rotate the 'data' list to the right by 'amount'.
    /// Example:
    /// {1,2,3,4,5,6,7,8,9} rotated right by 3 ->
    /// {7,8,9,1,2,3,4,5,6}
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // PLAN:
        // 1. Determine how many elements will move from the end to the front.
        // 2. Copy the last 'amount' elements into a temporary list.
        // 3. Remove those elements from the end of the original list.
        // 4. Insert the saved elements at the beginning of the list.
        // 5. Since lists are mutable, modify the original list directly.

        int count = data.Count;

        // Step 2: Get the last 'amount' elements
        List<int> tail = data.GetRange(count - amount, amount);

        // Step 3: Remove the last 'amount' elements
        data.RemoveRange(count - amount, amount);

        // Step 4: Insert them at the beginning
        data.InsertRange(0, tail);
    }
}
