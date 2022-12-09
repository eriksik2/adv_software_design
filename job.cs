class Job
{
    private List<User> responders = new List<User>();
    private int minResponders;
    private int maxResponders;
    private User requester;
    private string description;
    private Location location;
    private string name;
    private Preferences preferences;
    private Preferences requirements;

    public Job(int minResponders, int maxResponders, string description, Location location, string name, Preferences preferences, Preferences requirements, User requester)
    {
        this.minResponders = minResponders;
        this.maxResponders = maxResponders;
        this.description = description;
        this.location = location;
        this.name = name;
        this.preferences = preferences;
        this.requirements = requirements;
        this.requester = requester;
    }

    public User getRequester()
    {
        return requester;
    }

    public List<User> getResponders()
    {
        return responders;
    }

    public string getName()
    {
        return name;
    }
}