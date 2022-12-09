
abstract class Notification
{
    private long timestamp;

    public Notification(long? timestamp)
    {
        this.timestamp = timestamp ?? new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds();
    }

    public string getTitle(Localization loc) {
        return "Notification";
    }

    public string getBody(Localization loc) {
        return "You have a notification";
    }
}

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