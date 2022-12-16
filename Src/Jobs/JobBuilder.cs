class JobBuilder
{
    private int? minResponders;
    private int? maxResponders;
    private string? description;
    private Location? location;
    private string? name;
    private Preferences? preferences;
    private Preferences? requirements;
    private User? requester;

    private DateTime? time;

    public void setRequester(User requester)
    {
        this.requester = requester;
    }

    public void setMinResponders(int minResponders)
    {
        this.minResponders = minResponders;
    }

    public void setMaxResponders(int maxResponders)
    {
        this.maxResponders = maxResponders;
    }

    public void setDescription(string description)
    {
        this.description = description;
    }

    public void setLocation(Location location)
    {
        this.location = location;
    }

    public void setName(string name)
    {
        this.name = name;
    }
    
    public void setPreferences(Preferences preferences)
    {
        this.preferences = preferences;
    }

    public void setRequirements(Preferences requirements)
    {
        this.requirements = requirements;
    }

    public void setTime(DateTime time)
    {
        this.time = time;
    }

    public Job build()
    {
        if (minResponders == null)
        {
            throw new Exception("minResponders not set");
        }
        if (maxResponders == null)
        {
            throw new Exception("maxResponders not set");
        }
        if (description == null)
        {
            throw new Exception("description not set");
        }
        if (location == null)
        {
            throw new Exception("location not set");
        }
        if (name == null)
        {
            throw new Exception("name not set");
        }
        if (preferences == null)
        {
            throw new Exception("preferences not set");
        }
        if (requirements == null)
        {
            throw new Exception("requirements not set");
        }
        if (requester == null)
        {
            throw new Exception("requester not set");
        }
        if (time == null)
        {
            throw new Exception("time not set");
        }
        return new Job(
            minResponders: minResponders.Value,
            maxResponders: maxResponders.Value,
            description: description,
            location: location,
            name: name,
            preferences: preferences,
            requirements: requirements,
            requester: requester,
            time: time.Value
        );
    }
}