namespace FeedbackFlow.Api.Logic;

/// <summary>
/// Служба обработки контролера управления приложениями
/// </summary>
public interface IFeedbackApplicationHandler
{
    /// <summary>
    /// Возвращает приложение по идентификатору
    /// </summary>
    /// <param name="id">идентификатор id приложения</param>
    /// <param name="token">токен отмены запроса</param>
    Task<FeedbackApplicationResponseItem> GetById(Guid id, CancellationToken token);
}
