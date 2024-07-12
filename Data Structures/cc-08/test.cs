using Xunit;

public class LinkedListTests
{
    [Fact]
    public void TestRemoveNodeFromEnd()
    {
        LinkedList list = new LinkedList();
        list.Add(5);
        list.Add(10);
        list.Add(20);
        list.Add(30);

        list.Remove(30);

        Assert.Equal("Head -> 5 -> 10 -> 20 -> Null", list.ToString());
    }

    [Fact]
    public void TestPrintList()
    {
        LinkedList list = new LinkedList();
        list.Add(5);
        list.Add(10);
        list.Add(20);
        list.Add(30);

        Assert.Equal("Head -> 5 -> 10 -> 20 -> 30 -> Null", list.ToString());
    }
}
