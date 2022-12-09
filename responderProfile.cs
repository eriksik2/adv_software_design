
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
        throw new NotImplementedException();
    }

    public void removeCategory(JobCategory category)
    {
        throw new NotImplementedException();
    }

    public Sex getSex()
    {
        throw new NotImplementedException();
    }

    public int getAge()
    {
        throw new NotImplementedException();
    }

    public Location getLocation()
    {
        throw new NotImplementedException();
    }
}