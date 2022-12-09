class jobProcessHandler
{
    private Job job;
    private JobProcessState state;

    public getJob()
    {
        return job;
    }

    public getState()
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