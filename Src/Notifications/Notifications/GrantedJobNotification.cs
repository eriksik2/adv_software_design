
class GrantedJobNotification : Notification
{
    private Job job;

    public GrantedJobNotification(Job job) : base(null)
    {
        this.job = job;
    }

    public override string getTitle(Localization loc)
    {
        return loc.translate("GrantedJobNotificationTitle");
    }

    public override string getBody(Localization loc)
    {
        return loc.translate("GrantedJobNotificationBody");
    }
}
