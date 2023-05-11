namespace AppLib;

public sealed class MergedEntry
{
    public string InvoiceCode { get; init; }
    public string Description { get; init; }
    public decimal TotalCredit { get; private set; }
    public decimal TotalDebit { get; private set; }
    public decimal Difference => Math.Abs(TotalCredit - TotalDebit);

    public MergedEntry(Entry entry)
    {
        InvoiceCode = entry.InvoiceCode;
        Description = entry.Description;
    }

    public void AddPayment(Payment payment, decimal value)
    {
        switch (payment)
        {
            case Payment.Debit:
                TotalDebit += value;
                break;

            case Payment.Credit:
                TotalCredit += value;
                break;

            case Payment.None:
            default:
                break;
        }
    }

    public override string ToString()
    {
        return $"""
            InvoiceCode: {InvoiceCode}
            TotalCredit: {TotalCredit:C2}
            TotalDebit: {TotalDebit:C2}
            """;
    }
}