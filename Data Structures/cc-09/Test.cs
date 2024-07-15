using Xunit;

public class RemoveDuplicatesTests
{
    [Fact]
    public void Test_RemoveDuplicates_NoDuplicates()
    {
        LinkedList list = new LinkedList();
        list.Head = new Node(1);
        list.Head.Next = new Node(2);
        list.Head.Next.Next = new Node(3);

        list.RemoveDuplicate();
        Assert.Equal("1 -> 2 -> 3 -> Null", CaptureConsoleOutput(list.Display));
    }

    [Fact]
    public void Test_RemoveDuplicates_WithDuplicates()
    {
        LinkedList list = new LinkedList();
        list.Head = new Node(5);
        list.Head.Next = new Node(20);
        list.Head.Next.Next = new Node(20);
        list.Head.Next.Next.Next = new Node(10);
        list.Head.Next.Next.Next.Next = new Node(5);
        list.Head.Next.Next.Next.Next.Next = new Node(10);

        list.RemoveDuplicate();
        Assert.Equal("5 -> 20 -> 10 -> Null", CaptureConsoleOutput(list.Display));
    }

    [Fact]
    public void Test_RemoveDuplicates_AllDuplicates()
    {
        LinkedList list = new LinkedList();
        list.Head = new Node(7);
        list.Head.Next = new Node(7);
        list.Head.Next.Next = new Node(7);
        list.Head.Next.Next.Next = new Node(7);

        list.RemoveDuplicate();
        Assert.Equal("7 -> Null", CaptureConsoleOutput(list.Display));
    }

    // Helper method to capture console output for verification
    private string CaptureConsoleOutput(Action action)
    {
        var consoleOutput = new StringWriter();
        Console.SetOut(consoleOutput);
        action.Invoke();
        Console.SetOut(new StreamWriter(Console.OpenStandardOutput())); // Reset Console output
        return consoleOutput.ToString().Trim();
    }
}
