namespace FeddbackFlow.Data.EfModels;

/// <summary>
/// Приложение (Модель базы данных)  
/// </summary>
public class FeedBackApplication
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
