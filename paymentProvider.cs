
abstract class PaymentProvider
{
    public abstract void widthdrawal(float amount);
    public abstract void deposit(float amount);
}

class CreditCard : PaymentProvider
{
    private string bankName;
    private string cardNumber;
    private string cvc;
    private string expiryDate;
    private string cardholderName;

    public CreditCard(string bankName, string cardNumber, string cvc, string expiryDate, string cardholderName)
    {
        this.bankName = bankName;
        this.cardNumber = cardNumber;
        this.cvc = cvc;
        this.expiryDate = expiryDate;
        this.cardholderName = cardholderName;
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

class Swish : PaymentProvider
{
    private string phoneNumber;

    public Swish(string phoneNumber)
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

class PayPal : PaymentProvider
{
    private string email;

    public PayPal(string email)
    {
        this.email = email;
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