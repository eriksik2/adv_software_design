class OfferedJobNotification : Notification
{
    private Job job;

    public OfferedJobNotification(Job job) : base(null)
    {
        this.job = job;
    }

    public override string getTitle(Localization loc)
    {
        return loc.translate("OfferedJobNotificationTitle");
    }

    public override string getBody(Localization loc)
    {
        return loc.translate("OfferedJobNotificationBody");
    }
}