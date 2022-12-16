
class JobReportedFinishedNotification : Notification
{
    private Job job;

    public JobReportedFinishedNotification(Job job) : base(null)
    {
        this.job = job;
    }

    public override string getTitle(Localization loc)
    {
        return loc.translate("JobReportedFinishedNotificationTitle");
    }

    public override string getBody(Localization loc)
    {
        return loc.translate("JobReportedFinishedNotificationBody");
    }
}

