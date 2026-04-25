using System;
class AdminDeletionException : Exception
{
    public AdminDeletionException() : base() { }
    public AdminDeletionException(string message) : base(message) { }
    public AdminDeletionException(string message, Exception inner) : base(message, inner) { }
}