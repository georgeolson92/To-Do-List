using Nancy;
using ToDoList.Objects;

namespace ToDoList
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["add_new_task.cshtml"];
      Get["/view_all_tasks"] = _ => {
        Task newTask = new Task(Request.Query["new-task"]);
        return View["view_all_tasks.cshtml", newTask];
      };
    }
  }
}
