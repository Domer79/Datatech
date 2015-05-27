namespace Test.Web.Models
{
    public struct ErrorInfo
    {
        public string Type { get; set; }
        
        public string Message { get; set; }

        public string Stack { get; set; }
    }
}
