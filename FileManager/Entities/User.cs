﻿
namespace FileManager.Entities
{
    public class User
    {
        // данные, которые будут вноситься в БД
        public int userId { get; set; }
        public string name { get; set; }
        public string secondName { get; set; }
        public string login { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
