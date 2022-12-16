
class Klarna : PaymentProvider
{
    private string phoneNumber;

    public Klarna(string phoneNumber)
    {
        this.phoneNumber = phoneNumber;
    }

    public override void widthdrawal(float amount)
    {
        throw new NotImplementedException();
    }

    public override void deposit(float amount)
    {
        throw new NotImplementedException();
    }
}