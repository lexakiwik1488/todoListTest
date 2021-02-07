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

        [Required( ErrorMessage = "Это поле объязательное")]
        [MinLength(3,ErrorMessage ="Название должно содержать как минимум 3 символа")]
        [MaxLength(30, ErrorMessage ="Название не должно превышать 30 символов")]
        public string Title { get; set; }  //Название

        [Required(ErrorMessage = "Пожалуйста, введите дату")]
        [DataType(DataType.Date)]
        public DateTime ExecutionDate { get; set; } //Дата и время

        [MaxLength(200, ErrorMessage = "Название не должно превышать 200 символов")]
        public string Description { get; set; } //Что нужно сделать
        public bool IsDone { get; set; } 
    }
}
