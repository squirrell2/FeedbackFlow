namespace FeedbackFlow.Api.Logic
{
    public record FeedbackApplicationCreateItem
    {
        /// <summary>
        /// Наименование приложения 
        /// </summary>
        public string Name { get; set; } = null!;
    }
}
