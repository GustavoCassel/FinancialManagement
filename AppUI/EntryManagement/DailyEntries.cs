﻿namespace AppUI.EntryManagement;

public sealed class DailyEntries
{
    public DateTime Date { get; init; }

    public List<Entry> Entries { get; } = new();

    public DailyEntries(DateTime date)
    {
        Date = date;
    }

    public void AddEntry(Entry entry)
    {
        Entries.Add(entry);
    }

    public decimal GetTotalByPayment(Payment payment)
    {
        return Entries.Sum(entry =>
        {
            if (entry.Payment == payment)
                return entry.Value;

            return 0;
        });
    }

    public override string ToString()
    {
        return $"""
            Date: {Date.ToShortDateString()}
            Count: {Entries.Count}
            """;
    }
}