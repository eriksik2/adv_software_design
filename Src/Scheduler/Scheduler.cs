
// TODO : add private constructor
class Scheduler
{
    static private Scheduler? scheduler;

    public static Scheduler getScheduler()
    {
        if (scheduler == null)
        {
            scheduler = new Scheduler();
        }
        return scheduler;
    }

    private List<Task> tasks = new List<Task>();

    public void schedule(Task task)
    {
        tasks.Add(task);
    }

    public void runScheduled()
    {
        var runningTasks = new List<Task>(tasks);
        tasks.Clear();
        foreach (Task task in runningTasks)
        {
            task.run();
        }
    }
}


