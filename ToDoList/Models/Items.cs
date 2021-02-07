using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class Items
    {
        public int Id { get; set; }
        public string Title { get; set; }  //Название

        [DataType(DataType.Date)]
        public DateTime ExecutionDate { get; set; } //Дата и время когда нужно сделать
        public string Description { get; set; } //Что нужно сделать
        //public bool IsDone { get; set; } 
    }
}
