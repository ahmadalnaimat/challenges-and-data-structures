public class RotateLinkedListTests
{
    [Fact]
    public void RotateByZero()
    {
        var list = new Program.LinkedList();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);

        list.RotateLeft(0);

        Assert.Equal("1 -> 2 -> 3 -> 4 -> 5 -> Null", GetListAsString(list));
    }

    [Fact]
    public void RotateByKGreaterThanListLength()
    {
        var list = new Program.LinkedList();
        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.Add(40);
        list.Add(50);

        list.RotateLeft(7);

        Assert.Equal("40 -> 50 -> 10 -> 20 -> 30 -> Null", GetListAsString(list));
    }

    private string GetListAsString(Program.LinkedList list)
    {
        var result = new System.Text.StringBuilder();
        var current = list.Head;
        while (current != null)
        {
            result.Append(current.Data + " -> ");
            current = current.Next;
        }
        result.Append("Null");
        return result.ToString();
    }
}
