namespace RequestsChallenge.Model
{
    // RequestInfo - класс, описывающий информацию о http-запросе
    public class RequestInfo
    {
        public string Method { get; set; } = string.Empty;
        public string Path { get; set; } = string.Empty;
        public DateTime ReceivedAt { get; set; }
        public int StatusCode { get; set; }

        public RequestInfo() { }
    }
}
