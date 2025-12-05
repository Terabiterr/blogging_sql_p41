using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Post
{
    // Первинний ключ PostId
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int PostId { get; set; }

    // Заголовок посту, обов'язкове поле, максимальна довжина 100 символів
    [Required]
    [StringLength(100)]
    public string? Title { get; set; }

    // Зміст посту, обов'язкове поле
    [Required]
    public string? Content { get; set; }

    // Зовнішній ключ для зв'язку з Blog
    public int BlogId { get; set; }

    // Навігаційна властивість для зв'язку з Blog
    public Blog? Blog { get; set; }
}
