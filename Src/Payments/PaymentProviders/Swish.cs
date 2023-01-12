
class Swish : PaymentProvider
{
    private string phoneNumber;

    public Swish(string phoneNumber)
    {
        this.phoneNumber = phoneNumber;
    }

    public override bool widthdrawal(float amount)
    {
        throw new NotImplementedException();
    }

    public override void deposit(float amount)
    {
        throw new NotImplementedException();
    }
}