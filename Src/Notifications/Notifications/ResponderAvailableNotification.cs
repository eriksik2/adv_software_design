class ResponderAvailableNotification : Notification
{
    private Job job;
    private ResponderProfile responder;

    public ResponderAvailableNotification(Job job, ResponderProfile responder) : base(null)
    {
        this.job = job;
        this.responder = responder;
    }

    public override string getTitle(Localization loc)
    {
        return loc.translate("ResponderAvailableNotificationTitle");
    }

    public override string getBody(Localization loc)
    {
        return loc.translate("ResponderAvailableNotificationBody");
    }
}