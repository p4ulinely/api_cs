namespace api.Domain.Entities;

public class Text : BaseEntity
{
    public string Text1 { get; set; }
    public string Text2 { get; set; }

    public Text()
    {
        Validations();
    }

    public override void Validations()
    {
        if (string.IsNullOrWhiteSpace(Text1) || string.IsNullOrWhiteSpace(Text2))
            AddError("As string precisam ser preenchidas.");

        if (Text1.Length < 2 || Text2.Length < 2 )
            AddError("As string precisam ser maior que 2.");
    }
}