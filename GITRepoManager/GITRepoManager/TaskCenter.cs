using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 
 * Function Template When Usint TaskCenter
 * 
 * <Return Type> Function Name (OrderedDictionary Parameters)
 * {
 *      Dictionary should contain the parameter object as the key and the parameter type as the value
 *      Should already know what type each parameter is when writing the function. May just use list of objects and convert in function
 *      
 *      <Return Type>
 * }
 * 
*/
namespace GITRepoManager
{
    public class TaskCenter
    {
        private static List<TaskFunction> TaskList_Function { get; set; }
        private static List<TaskAction> TaskList_Action { get; set; }
        public static List<object> Responses { get; set; }

        public TaskCenter()
        {
            TaskList_Function = new List<TaskFunction>();
            TaskList_Action = new List<TaskAction>();
            Responses = new List<object>();
        }

        public void Add_Function(Func<OrderedDictionary, object> function, OrderedDictionary Parameters)
        {
            TaskFunction temp = new TaskFunction(function, Parameters);
            TaskList_Function.Add(temp);
        }

        public void Add_Action(Action<OrderedDictionary> action, OrderedDictionary Parameters)
        {
            TaskAction temp = new TaskAction(action, Parameters);

            TaskList_Action.Add(temp);
        }

        public void Run_Functions()
        {
            foreach(TaskFunction TaskFunc in TaskList_Function)
            {

                try
                {
                    TaskFunc.func.Invoke(TaskFunc.Parameters);
                }

                catch
                {

                }
            }
        }

        public void Run_Actions()
        {
            foreach(TaskAction TaskAct in TaskList_Action)
            {
                try
                {
                    TaskAct.action.Invoke(TaskAct.Parameters);
                }

                catch
                {

                }
            }
        }

        public void Clear_Lists()
        {
            TaskList_Action.Clear();
            TaskList_Function.Clear();
            Responses.Clear();
        }
    }

    public class TaskFunction
    {
        public Func<OrderedDictionary, object> func { get; set; }
        public OrderedDictionary Parameters { get; set; }

        public TaskFunction(Func<OrderedDictionary, object> _Function = null, OrderedDictionary _Parameters = null)
        {
            func = _Function;
            Parameters = _Parameters;
        }
    }

    public class TaskAction
    {
        public Action<OrderedDictionary> action { get; set; }
        public OrderedDictionary Parameters { get; set; }

        public TaskAction(Action<OrderedDictionary> _Action = null, OrderedDictionary _Parameters = null)
        {
            action = _Action;
            Parameters = _Parameters;
        }

    }

}
