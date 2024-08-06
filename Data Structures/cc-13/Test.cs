using System;
using Xunit;
using static Program;

public class StackWithDeleteMiddleTests
{
    [Fact]
    public void Odd_Size()
    {
        StackWithDeleteMiddle stack = new StackWithDeleteMiddle();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        stack.DeleteMiddle();
        Assert.Equal(2, stack.Count);
    }
    [Fact]
    public void Even_Size()
    {
        StackWithDeleteMiddle stack = new StackWithDeleteMiddle();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);

        stack.DeleteMiddle();
        Assert.Equal(3, stack.Count);

    }
}