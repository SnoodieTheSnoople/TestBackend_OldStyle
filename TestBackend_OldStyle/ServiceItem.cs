namespace TestBackend_OldStyle;

public class ServiceItem
{
    private string _name;
    private string _description;
    private bool _status;

    public ServiceItem(string name, string description, bool status)
    {
        this._name = name ?? throw new ArgumentNullException(nameof(name));
        this._description = description ?? throw new ArgumentNullException(nameof(description));
        this._status = status;
    }
}