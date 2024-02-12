// RemoveDuplicates takes in an array of integers and returns an array with all of the duplicate values removed

Random random = new Random();

int[] RemoveDuplicates(int[] initialArray)
{
  List<int> collector = new List<int>();

  foreach (int item in initialArray)
    if (!collector.Contains(item))
      collector.Add(item);

  return collector.ToArray();
}

void TestTenTimes()
{
  for (int i = 0; i < 10; i++)
  {
    int[] testArray = new int[10];

    for (int j = 0; j < 10; j++)
      testArray[j] = random.Next(10);

    Console.WriteLine($"Initial Array: [{string.Join(",", testArray)}]\nNo Duplicates: [{string.Join(",", RemoveDuplicates(testArray))}]\n");
  }
}

TestTenTimes();
