class JobCategory {

    static public JobCategory physicalLabor = new JobCategory("physicalLabor");
    static public JobCategory localDelivery = new JobCategory("localDelivery");
    static public JobCategory longDelivery = new JobCategory("longDelivery");
    static public JobCategory personalDriver = new JobCategory("personalDriver");
    static public JobCategory personalCare = new JobCategory("personalCare");
    static public JobCategory guarding = new JobCategory("guarding");

    private String name;

    public JobCategory(String name) {
        this.name = name;
    }
}