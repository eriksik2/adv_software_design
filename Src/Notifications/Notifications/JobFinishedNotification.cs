
class JobFinishedNotification : Notification
{
    private Job job;

    public JobFinishedNotification(Job job) : base(null)
    {
        this.job = job;
    }

    public override string getTitle(Localization loc)
    {
        return loc.translate("JobFinishedNotificationTitle");
    }

    public override string getBody(Localization loc)
    {
        return loc.translate("JobFinishedNotificationBody");
    }
}
