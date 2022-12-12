

class Preferences 
{
    private List<Sex> sex;
    private List<JobCategory> categories;
    private int minAge;
    private int maxAge;

    public Preferences(List<Sex> sex, List<JobCategory> categories, int minAge, int maxAge)
    {
        this.sex = sex;
        this.categories = categories;
        this.minAge = minAge;
        this.maxAge = maxAge;
    }

    public List<Sex> getSex()
    {
        return sex;
    }

    public List<JobCategory> getCategories()
    {
        return categories;
    }

    public int getMinAge()
    {
        return minAge;
    }

    public int getMaxAge()
    {
        return maxAge;
    }
}