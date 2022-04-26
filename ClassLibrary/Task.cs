using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Task
    {
        /// <summary>
        /// Название задачи
        /// </summary>
        public string Title;
        /// <summary>
        /// Дата и время завершения задачи
        /// </summary>
        public DateTime Due;
        /// <summary>
        /// Отметка о выполнении задачи
        /// </summary>
        public bool Done;
    }
}
