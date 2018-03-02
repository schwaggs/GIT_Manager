using System;
using System.ComponentModel;

public class Variable_Change_Event
{
    private bool _Selection_Changed;
    private object _lock;

    public Variable_Change_Event(bool defaultState)
    {
        _Selection_Changed = defaultState;
        _lock = new object();
    }

    public bool Selection_Changed
    {
        get { return _Selection_Changed; }

        set
        {
            lock (_lock)
            {
                _Selection_Changed = value;
                OnSelectionChanged(EventArgs.Empty);
            }
        }
    }

    protected virtual void OnSelectionChanged(EventArgs e)
    {
        EventHandler handler = Selection_Changed_EventHandler;
        handler(this, e);
    }

    public event EventHandler Selection_Changed_EventHandler;
}