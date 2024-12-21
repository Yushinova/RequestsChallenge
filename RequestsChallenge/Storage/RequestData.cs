﻿namespace RequestsChallenge.Storage
{
    // RequestData - класс, описывающий таблицу с данными о запросе
    public class RequestData
    {
        public int Id { get; set; }
        public string Method { get; set; } = string.Empty;
        public string Path { get; set; } = string.Empty;
        public DateTime ReceivedAt { get; set; }
        public int StatusCode { get; set; }

        public RequestData() { }
    }
}