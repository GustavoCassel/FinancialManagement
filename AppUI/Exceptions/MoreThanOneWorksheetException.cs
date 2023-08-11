namespace AppUI.Exceptions;

public sealed class MoreThanOneWorksheetException : Exception
{
    public MoreThanOneWorksheetException()
        : base("A planilha possui mais que 1 (uma) página!")
    { }
}