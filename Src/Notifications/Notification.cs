
abstract class Notification
{
    private long timestamp;

    public Notification(long? timestamp)
    {
        this.timestamp = timestamp ?? new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds();
    }

    public virtual string getTitle(Localization loc)
    {
        return loc.translate("DefaultNotificationTitle");
    }

    public virtual string getBody(Localization loc)
    {
        return loc.translate("DefaultNotificationBody");
    }
}




