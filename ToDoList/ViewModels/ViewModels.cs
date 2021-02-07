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
                    this.EditableItem = new Items();
                    this.TodoItems = db.Query<Items>("SELECT * FROM ToDoListContext-1 ORDER BY Title DESC").ToList();
                }
            }

            public List<Items> TodoItems { get; set; }

            public Items EditableItem { get; set; }
        }
    }
}
