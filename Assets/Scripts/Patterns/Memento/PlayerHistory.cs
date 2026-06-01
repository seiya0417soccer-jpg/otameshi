using System.Collections.Generic;

public class PlayerHistory
{
    private Stack<PlayerMemento> _history = new Stack<PlayerMemento>();

    public void Save(PlayerMemento memento)
    {
        _history.Push(memento);
    }

    public PlayerMemento Undo()
    {
        if (_history.Count == 0) return null;
        return _history.Pop();
    }
}