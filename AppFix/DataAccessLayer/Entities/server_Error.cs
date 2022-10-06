namespace DataAccessLayer.Entities
{
    public struct Server_Error
    {
        public string? typeRequest { get; set; }
        public string? description { get; set; }

        public string? errorTime { get; set; }
    }
}
