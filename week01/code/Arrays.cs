public static class Arrays
{
    //plan:
    //1. Create a new array with a size equal to the number of multiples requested
    //2.Use a loop to go through each position in the array
    //3. For each position, calculate the multiple by multiplying the starting number by the current position plus one.
    //4.Store each calculated multiple into the memory into the array.
    //5.Return the completed array.
    public static double[] MultiplesOf(double number, int length)
    {
        // Plan:
        // 1. Create a new array with a size equal to the number of multiples requested.
        // 2. Use a loop to calculate each multiple.
        // 3. Store each multiple in the correct index.
        // 4. Return the completed array.

        double[] multiples = new double[length];
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }
        return multiples;
    }

   // Plan:
   // 1. Find the index where the list should split.
   // 2. The split point is the total list size minus the rotation amount.
   // 3. Create a new list containing the values from the split point to the end.
   // 4. Create another list containing the values from the beginning up to the split point.
   // 5. Combine both lists together so the rotated values are first.
   // 6. Return the new rotated list.
    public static void RotateListRight(List<int> data, int amount)
    {
          // Plan:
    // 1. Find where the list should be divided.
    // 2. Get the last section of the list.
    // 3. Get the first section of the list.
    // 4. Combine them in the new order.
    // 5. Return the rotated list.

         int splitIndex = data.Count - amount;

    List<int> rotatedList = new List<int>();

    List<int> endPart = data.GetRange(splitIndex, amount);

    List<int> startPart = data.GetRange(0, splitIndex);

    rotatedList.AddRange(endPart);
    rotatedList.AddRange(startPart);

    return;
}
}
    