using System;

public abstract class FileSystemComponent
{
    protected string _name;
    public FileSystemComponent(string name) { _name = name; }
    public abstract void Display(int depth);
    public virtual void Add(FileSystemComponent component) => throw new NotImplementedException();
    public virtual void Remove(FileSystemComponent component) => throw new NotImplementedException();
    public virtual FileSystemComponent GetChild(int index) => throw new NotImplementedException();
}
