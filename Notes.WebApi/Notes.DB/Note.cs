using System.ComponentModel.DataAnnotations;

namespace Notes.DB
{
    public class Note
    {
        // Инициализируем поля БД
        [Key]
        public int Id { get; set; }
        public string Value { get; set; }
    }
}
