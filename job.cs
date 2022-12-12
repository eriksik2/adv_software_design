class Job
{
    private int minResponders;
    private int maxResponders;
    private User requester;
    private string description;
    private Location location;
    private string name;
    private Preferences preferences;
    private Preferences requirements;

    private DateTime time;

    public Job(int minResponders, int maxResponders, string description, Location location, string name, Preferences preferences, Preferences requirements, User requester, DateTime time)
    {
        this.minResponders = minResponders;
        this.maxResponders = maxResponders;
        this.description = description;
        this.location = location;
        this.name = name;
        this.preferences = preferences;
        this.requirements = requirements;
        this.requester = requester;
        this.time = time;
    }

    public User getRequester()
    {
        return requester;
    }

    public string getName()
    {
        return name;
    }

    public Preferences getRequirements()
    {
        return requirements;
    }

    public Preferences getPreferences()
    {
        return preferences;
    }

    public int getMaxResponders()
    {
        return maxResponders;
    }

    public int getMinResponders()
    {
        return minResponders;
    }
}