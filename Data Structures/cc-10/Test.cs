using System;
using Xunit;

public class MergeSortedLinkedListsTests
{
    [Fact]
    public void TestMergingWhenOneListIsEmpty()
    {
        LinkedList list1 = new LinkedList();
        LinkedList list2 = new LinkedList();
        list2.AddLast(1);
        list2.AddLast(3);
        list2.AddLast(5);

        LinkedList mergedList = LinkedList.MergeSortedLists(list1, list2);

        Assert.Equal("Head -> 1 -> 3 -> 5 -> Null", mergedList.ToString());
    }

    [Fact]
    public void TestMergingWhenBothListsAreEmpty()
    {
        LinkedList list1 = new LinkedList();
        LinkedList list2 = new LinkedList();

        LinkedList mergedList = LinkedList.MergeSortedLists(list1, list2);

        Assert.Equal("Head -> Null", mergedList.ToString());
    }

    [Fact]
    public void TestMergingExampleCase()
    {
        LinkedList list1 = new LinkedList();
        list1.AddLast(5);
        list1.AddLast(10);
        list1.AddLast(15);

        LinkedList list2 = new LinkedList();
        list2.AddLast(2);
        list2.AddLast(3);
        list2.AddLast(20);

        LinkedList mergedList = LinkedList.MergeSortedLists(list1, list2);

        Assert.Equal("Head -> 2 -> 3 -> 5 -> 10 -> 15 -> 20 -> Null", mergedList.ToString());
    }
}
