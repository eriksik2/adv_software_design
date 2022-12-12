
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