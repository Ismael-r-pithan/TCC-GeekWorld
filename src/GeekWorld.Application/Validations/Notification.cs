﻿namespace GeekWorld.Application.Validations
{
    public class Notification
    {
        public Notification(string message) => Message = message;

        public string Message { get; }
    }
}
