
class PayPal : PaymentProvider
{
    private string email;

    public PayPal(string email)
    {
        this.email = email;
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