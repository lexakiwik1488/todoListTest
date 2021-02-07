using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
using ToDoList.Helpers;
using ToDoList.Models;

namespace ToDoList.ViewModels
{
    public class ViewModels
    {
        public class TodoListViewModel
        {
            public TodoListViewModel()
            {
                using (var db = DbHelper.GetConnection())
                {
                    this.EditableItem = new Item();
                    this.TodoItems = db.Query<Item>("SELECT * FROM ToDoListContext-1 ORDER BY Title DESC").ToList();
                }
            }

            public List<Item> TodoItems { get; set; }

            public Item EditableItem { get; set; }
        }
    }
}
