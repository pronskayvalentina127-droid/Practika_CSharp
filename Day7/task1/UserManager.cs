class UserManager
{
    public void DeleteUser(string role)
    {
        if (role == "Admin")
        {
            throw new AdminDeletionException("Запрещено удалять администратора");
        }
    }
}