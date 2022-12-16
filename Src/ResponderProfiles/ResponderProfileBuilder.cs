
class ResponderProfileBuilder
{
    private User? user;
    private Location? location;

    private List<JobCategory> jobCategories = new List<JobCategory>();

    private Sex? sex;

    private int? age;

    public void setUser(User user)
    {
        this.user = user;
    }

    public void setInitialCategories(List<JobCategory> categories)
    {
        this.jobCategories = categories;
    }

    public void setSex(Sex sex)
    {
        this.sex = sex;
    }

    public void setAge(int age)
    {
        this.age = age;
    }

    public ResponderProfile build()
    {
        throw new NotImplementedException();
    }
}