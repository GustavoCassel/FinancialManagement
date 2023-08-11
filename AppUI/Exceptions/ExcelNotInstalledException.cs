namespace AppUI.Exceptions;

public sealed class ExcelNotInstalledException : Exception
{
    public ExcelNotInstalledException()
        : base("O Excel não está instalado devidamente!")
    { }
}