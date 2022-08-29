namespace Builder
{
    /// <summary>
    /// Посада співробітника в комнанії
    /// </summary>
    public enum CompanyPosition { Director, TeamLead, Developer };

    /// <summary>
    /// Інтерфейс співробітник
    /// </summary>
    public interface IEmployee
    {
        /// <summary>
        /// Посада
        /// </summary>
        CompanyPosition Position { get; set; }
    }
}

