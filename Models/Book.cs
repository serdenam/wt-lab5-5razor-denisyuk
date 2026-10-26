 using System.ComponentModel.DataAnnotations;

namespace wt_lab5_5razor_denisyuk.Models;

public class Book
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Введите название")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Введите автора")]
    public string Author { get; set; } = string.Empty;

    [Range(1000, 2100, ErrorMessage = "Год должен быть от 1000 до 2100")]
    public int Year { get; set; }

    public bool IsAvailable { get; set; }
}