using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
   
// Scenario: Add three items with different priorities.
// Expected Result: Highest priority item should be removed first.
// Defect(s) Found: Passed after fixing Dequeue.
public void TestPriorityQueue_1()
{
    var queue = new PriorityQueue();

    queue.Enqueue("Apple", 1);
    queue.Enqueue("Banana", 5);
    queue.Enqueue("Orange", 3);

    var result = queue.Dequeue();

    Assert.AreEqual("Banana", result);
}
    

   [TestMethod]
// Scenario: Add two items with the same priority.
// Expected Result: First item added should be removed first.
// Defect(s) Found: Passed after fixing FIFO priority handling.
public void TestPriorityQueue_2()
{
    var queue = new PriorityQueue();

    queue.Enqueue("John", 10);
    queue.Enqueue("Mary", 10);

    var result = queue.Dequeue();

    Assert.AreEqual("John", result);
}
}