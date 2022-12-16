
class JobMatchResultNotification : Notification
{
    private Job job;
    private List<ResponderProfile> candidates;

    public JobMatchResultNotification(Job job, List<ResponderProfile> candidates) : base(null)
    {
        this.job = job;
        this.candidates = candidates;
    }

    public override string getTitle(Localization loc)
    {
        return loc.translate("JobMatchResultNotificationTitle");
    }

    public override string getBody(Localization loc)
    {
        return loc.translate("JobMatchResultNotificationBody");
    }
}
