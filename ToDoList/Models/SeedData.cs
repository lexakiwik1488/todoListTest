using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ToDoList.Data;

namespace ToDoList.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ToDoListContext(
               serviceProvider.GetRequiredService<
                   DbContextOptions<ToDoListContext>>()))
            {
                if(context.Items.Any())
                {
                    return;
                }

                context.Items.AddRange(
                    new Item
                    {
                        Title = "Доделать TODOList",
                        ExecutionDate = DateTime.Parse("2021-2-10"),
                        Description = "Наконецто сделать его и сдать.",
                        IsDone = false
                    },

                    new Item
                    {
                        Title = "Добавить новый пункт ",
                        ExecutionDate = DateTime.Parse("2021-2-10"),
                        Description = "Добавить в список новый пункт и выполнить его.",
                        IsDone = false
                    },

                    new Item
                    {
                        Title = "Покушать",
                        ExecutionDate = DateTime.Parse("2021-2-10"),
                        Description = "Круто пожрать",
                        IsDone = true
                    }
                    ) ;

                context.SaveChanges();
            }
        }
    }
}
