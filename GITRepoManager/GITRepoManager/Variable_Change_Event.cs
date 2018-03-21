using System;
using System.ComponentModel;

public class Variable_Change_Event
{
    private bool _Selection_Changed;
    private object _lock;

    /// <summary>
    /// Constructor for the variable change class. Here a boolean is used to trigger
    /// an event everytime the boolean changes. This could be any data type but would
    /// require appropriate modifications.
    /// </summary>
    /// <param name="defaultState">The default state to set the object to on creation.</param>
    /// 
    public Variable_Change_Event(bool defaultState)
    {
        _Selection_Changed = defaultState;
        _lock = new object();
    }

    /// <summary>
    /// The publicly avaialable boolean used to access the internal boolean used by the event.
    /// </summary>
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

    /// <summary>
    /// Constructing an event handler for the class
    /// </summary>
    /// <param name="e"></param>
    protected virtual void OnSelectionChanged(EventArgs e)
    {
        EventHandler handler = Selection_Changed_EventHandler;
        handler(this, e);
    }

    /// <summary>
    /// The event handler that can be implemented to perform upon the boolean changing values.
    /// </summary>
    public event EventHandler Selection_Changed_EventHandler;
}