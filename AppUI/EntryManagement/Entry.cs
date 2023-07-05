namespace AppUI.EntryManagement;

public enum Payment
{
    None,
    Credit,
    Debit
}

public sealed class Entry
{
    public string InvoiceCode { get; init; }
    public DateTime Date { get; init; }
    public string Description { get; init; }
    public Payment Payment { get; init; }

    public decimal Value
    {
        get => _value;
        set
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(nameof(value), "Valor não pode ser negativo ou zero!");

            _value = value;
        }
    }

    private decimal _value;

    public Entry(string? invoiceCode, DateTime date, string description, Payment payment, decimal value)
    {
        InvoiceCode = invoiceCode ?? "Não Encontrado";
        Date = date;
        Description = description;
        Payment = payment;
        Value = value;
    }

    /*public Entry GetOneForTest()
    {
        
    }*/

    public override string ToString()
    {
        return $"""
            InvoiceCode: {InvoiceCode}
            Date: {Date.ToShortDateString()}
            Description: {Description}
            Payment: {Payment}
            Value: {Value:C2}
            """;
    }
}