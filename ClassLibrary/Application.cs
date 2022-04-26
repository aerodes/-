using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Application
    {
        /// <summary>
        /// Ссылка на единственный экземпляр класса приложения
        /// </summary>
        private Application application;
        /// <summary>
        /// Список со списком задач
        /// </summary>
        private List<TaskList> taskLists;
        private Application()
        {
            TaskList taskList = new TaskList("Входящие");
            taskLists.Add(taskList);
        }
        /// <summary>
        /// Возвращает ссылку на экземпляр приложения, а в его отсутствие создает экземпляр
        /// </summary>
        /// <returns></returns>
        public Application GetApplication()
        {
            if (application != null) return application;
            else return application = new Application();
        }
        /// <summary>
        /// Создает список задач с указанным именем и добавляет его в taskLists
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public TaskList CreateTaskList(string name)
        {
            TaskList taskList = new TaskList(name);
            taskLists.Add(taskList);
            return taskList;
        }
        /// <summary>
        /// Возвращает имена списков задач
        /// </summary>
        /// <returns></returns>
        public List<string> GetTaskListNames()
        {
            List<string> list = new List<string>();
            foreach (TaskList task in taskLists)
            {
                list.Add(task.GetName());
            }
            return list;
        }
        /// <summary>
        /// Возвращает список задач по имени списка
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public TaskList GetTaskListByName(string name)
        {
            return taskLists.FirstOrDefault(x => x.GetName() == name);
        }
        /// <summary>
        /// Получает задачи запланированные на сегодня в хронологическом порядке
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTasksByToday()
        {
            List<Task> list = new List<Task>();
            foreach (TaskList task in taskLists)
            {
                list.AddRange(task.GetTasksByToday());
            }
            return list;
        }
        /// <summary>
        /// Получает задачи запланированные завтра и позже в хронологическом порядке
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTasksByFuture()
        {
            List<Task> list = new List<Task>();
            foreach (TaskList task in taskLists)
            {
                list.AddRange(task.GetTasksByFuture());
            }
            return list;
        }
    }
}
