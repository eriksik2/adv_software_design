
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
