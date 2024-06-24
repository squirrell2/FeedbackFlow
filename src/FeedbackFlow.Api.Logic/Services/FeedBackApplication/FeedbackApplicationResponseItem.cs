namespace FeedbackFlow.Api.Logic;

/// <summary>
/// Модель ответа на запрос получения приложения по идентификатору
/// </summary>
public record FeedbackApplicationResponseItem
{
    /// <summary>
    /// Индитификатор приложения
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Наименование приложения 
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Время редактирования записи
    /// </summary>
    public DateTimeOffset DateEdit { get; set; }
}
