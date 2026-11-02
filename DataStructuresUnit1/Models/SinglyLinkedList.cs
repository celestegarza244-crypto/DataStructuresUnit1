using System.Text;

namespace DataStructuresUnit1.Models;

/// <summary>
/// A single node of the linked list. Each node is a separate object on the Heap
/// and is connected to the next one through a reference.
/// </summary>
public class LinkedNode
{
    public LinkedNode(int value)
    {
        Value = value;
    }

    public int Value { get; }

    public LinkedNode? Next { get; set; }
}

/// <summary>
/// Minimal singly linked list. It grows and shrinks one node at a time, which is the
/// classic example of a dynamic data structure (memory is requested only when needed).
/// </summary>
public class SinglyLinkedList
{
    private LinkedNode? _head;
    private LinkedNode? _tail;

    public int Count { get; private set; }

    /// <summary>Inserts a new node at the end of the list. Time: O(1) thanks to the tail reference.</summary>
    public void AddLast(int value)
    {
        var node = new LinkedNode(value); // dynamic allocation on the Heap

        if (_head is null)
        {
            _head = node;
            _tail = node;
        }
        else
        {
            _tail!.Next = node;
            _tail = node;
        }

        Count++;
    }

    /// <summary>Removes the first node. Time: O(1). Returns false when the list is empty.</summary>
    public bool RemoveFirst(out int removedValue)
    {
        removedValue = 0;

        if (_head is null)
        {
            return false;
        }

        removedValue = _head.Value;
        _head = _head.Next; // the old head becomes unreachable and will be collected by the GC

        if (_head is null)
        {
            _tail = null;
        }

        Count--;
        return true;
    }

    /// <summary>Builds a readable representation such as "10 → 20 → 30 → null".</summary>
    public override string ToString()
    {
        if (_head is null)
        {
            return "(lista vacía)";
        }

        var builder = new StringBuilder();
        for (LinkedNode? current = _head; current is not null; current = current.Next)
        {
            builder.Append(current.Value).Append(" → ");
        }

        builder.Append("null");
        return builder.ToString();
    }
}
