using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    public class Todo
    {
        //name, startdate, end date, iscompleted => Properties

        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsCompleted { get; set; }

        private Todo[] _todos = new Todo[10];

        public void ViewTodos()
        {
            foreach (var singleTodo in _todos)
            {
                if (singleTodo != null)
                {
                    Console.WriteLine($"Name:{this.Name}) | " +
                $"Started On: {this.StartDate} | " +
                $"Ends On: {this.EndDate} |" +
                $"Is Completed: {this.IsCompleted}");
                }
            }
        }
        public void ViewTodos(string pName)
        {
            foreach (var singleTodo in _todos)
                {
                if(singleTodo.Name== pName)
                {
                    Console.WriteLine($"Name:{singleTodo.Name}) | " +
                $"Started On: {singleTodo.StartDate} | " +
                $"Ends On: {singleTodo.EndDate} |" +
                $"Is Completed: {singleTodo.IsCompleted}");
                    break;
                }
            }
        }
        //User should specify where position in _todo array) to add the new todo item
        public void Create(int pPosition)
        {
            if(pPosition > 9)
            {
                throw new Exception("Please enter a value between 0-9");

            }
            _todos[pPosition] = new Todo() { Name = this.Name,
                StartDate = this.StartDate,
                EndDate = this.EndDate, 
                IsCompleted = this.IsCompleted };
            Console.WriteLine("Todo created successfully ");
        }
        public void Edit()
        {

        }
        public void Delete()
        {

        }

    }
}
