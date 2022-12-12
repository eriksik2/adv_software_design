
class JobProcess
{
    private Job job;
    private JobProcessState state;
    private TransactionHandler transaction;

    private List<ResponderProfile> responders = new List<ResponderProfile>();

    public JobProcess(Job job, TransactionHandler transaction)
    {
        this.job = job;
        this.state = JobProcessState.Pending;
        this.transaction = transaction;
    }

    public Job getJob()
    {
        return job;
    }

    public JobProcessState getState()
    {
        return state;
    }

    public List<ResponderProfile> getResponders()
    {
        return responders;
    }
}

class JobProcessHandler
{
    static private JobProcessHandler? jobProcessHandler;

    static public JobProcessHandler getJobProcessHandler()
    {
        if (jobProcessHandler == null)
        {
            jobProcessHandler = new JobProcessHandler();
        }
        return jobProcessHandler;
    }

    private List<JobProcess> jobProcesses = new List<JobProcess>();


    public void addJobProcess(JobProcess jobProcess)
    {
        jobProcesses.Add(jobProcess);
    }

    public JobProcess? getProcess(Job job)
    {
        foreach (JobProcess jobProcess in jobProcesses)
        {
            if (jobProcess.getJob() == job)
            {
                return jobProcess;
            }
        }
        return null;
    }
    
}

enum JobProcessState
{
    Pending,
    Accepted,
    Cancelled,
    Completed
}