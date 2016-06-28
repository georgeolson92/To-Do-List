namespace ToDoList.Objects
{
  public class Task
  {
    private string _description;
    public Task (string description)
    {
      _description = description;
    }
    public string GetDescription()
    {
      return _description;
    }
    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }
  }
}
