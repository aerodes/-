using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class TaskList
    {
        /// <summary>
        /// Имя списка с задачами
        /// </summary>
        private string name;
        /// <summary>
        /// Список задач, относящихся к списку
        /// </summary>
        private List<Task> tasks;
        public TaskList(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// Возвращает имя списка задач
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return name;
        }
        /// <summary>
        /// Добавляет задачу в список задач
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        public Task AddTask(Task task)
        {
            tasks.Add(task);
            return task;
        }
        /// <summary>
        /// Возвращает список всех задач
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTasks()
        {
            return tasks;
        }
        /// <summary>
        /// Удаляет задачу из списка задач
        /// </summary>
        /// <param name="task"></param>
        public void Remove(Task task)
        {
            tasks.Remove(task);
        }
        /// <summary>
        /// Возвращает задачи запланированные на сегодня в хронологическом порядке
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTasksByToday()
        {
            return tasks.Where(x => x.Due == DateTime.Now).ToList();
        }
        /// <summary>
        /// Возвращает задачи на завтра и позже в хронологическом порядке
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTasksByFuture()
        {
            return tasks.Where(x => x.Due > DateTime.Now).ToList();
        }
    }
}
