
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
