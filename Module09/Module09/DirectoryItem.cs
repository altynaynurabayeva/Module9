using System;
using System.Collections.Generic;

public class DirectoryItem : FileSystemComponent
{
    private List<FileSystemComponent> _children = new List<FileSystemComponent>();
    public DirectoryItem(string name) : base(name) { }

    public override void Add(FileSystemComponent component) => _children.Add(component);
    public override void Remove(FileSystemComponent component) => _children.Remove(component);
    public override FileSystemComponent GetChild(int index) => _children[index];

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + " Directory: " + _name);
        foreach (var component in _children)
            component.Display(depth + 2);
    }
}
