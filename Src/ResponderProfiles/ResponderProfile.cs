
class ResponderProfile
{
    private User user;
    private Location location;

    private List<JobCategory> jobCategories;

    private Sex sex;

    private int age;

    public ResponderProfile(User user, Location location, List<JobCategory> jobCategories, Sex sex, int age)
    {
        this.user = user;
        this.location = location;
        this.jobCategories = jobCategories;
        this.sex = sex;
        this.age = age;
    }

    public void addCategory(JobCategory category)
    {
        jobCategories.Add(category);
    }

    public void removeCategory(JobCategory category)
    {
        jobCategories.Remove(category);
    }

    public Sex getSex()
    {
        return sex;
    }

    public int getAge()
    {
        return age;
    }

    public Location getLocation()
    {
        return location;
    }

    public User getUser()
    {
        return user;
    }
}