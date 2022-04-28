namespace api.Domain.Entities;

public abstract class BaseEntity
{
    private readonly List<ValidationError> _erros;

    public bool Valid => _erros?.Count == 0;
    public bool Invalid => _erros?.Count > 0;
    public IEnumerable<ValidationError> Errors => _erros.AsEnumerable();

    protected BaseEntity()
    {
        _erros = new List<ValidationError>();
    }

    public abstract void Validations();

    public void AddError(string message) 
        => _erros.Add(new ValidationError(message));

    public void AddErrors(IEnumerable<ValidationError> erros) 
        => _erros.AddRange(erros);

    public string LastErrorMessage() 
        => _erros.FirstOrDefault()?.Message;
    
    public virtual string LastError()
        => $"({_erros.FirstOrDefault()?.Code}) {_erros.FirstOrDefault()?.Message}";

    public TEntity GetEntityWithError<TEntity>(string message) where TEntity : BaseEntity, new()
    {
        AddError(message);
        return (TEntity)this;
    }
}