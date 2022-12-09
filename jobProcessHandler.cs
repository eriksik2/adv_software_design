class jobProcessHandler
{
    private Job job;
    private JobProcessState state;

    public jobProcessHandler(Job job)
    {
        this.job = job;
        this.state = JobProcessState.Pending;
    }

    public Job getJob()
    {
        return job;
    }

    public JobProcessState getState()
    {
        return state;
    }
}

enum JobProcessState
{
    Pending,
    Accepted,
    Cancelled,
    Completed
}