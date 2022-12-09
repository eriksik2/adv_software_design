

class Preferences 
{
    private List<Sex> sex;
    private List<JobCategory> categories;
    private int minAge;
    private int maxAge;
    private DateTime datetime;

    public Preferences(List<Sex> sex, List<JobCategory> categories, int minAge, int maxAge, DateTime datetime)
    {
        this.sex = sex;
        this.categories = categories;
        this.minAge = minAge;
        this.maxAge = maxAge;
        this.datetime = datetime;
    }
}