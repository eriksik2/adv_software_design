class JobFullNotification : Notification
{
    private Job job;

    public JobFullNotification(Job job) : base(null)
    {
        this.job = job;
    }

    public override string getTitle(Localization loc)
    {
        return loc.translate("JobFullNotificationTitle");
    }

    public override string getBody(Localization loc)
    {
        return loc.translate("JobFullNotificationBody");
    }
}