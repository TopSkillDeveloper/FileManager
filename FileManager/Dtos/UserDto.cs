
namespace FileManager.Dtos
{
    public class UserDto
    {
        // Данные, которые нужно вносить пользователю (кроме userId). Для метода httppost использовать данные поля
        public int userId { get; set; }
        public string name { get; set; }
        public string secondName { get; set; }
        public string login { get; set; }
        public string password { get; set; }
    }
}
