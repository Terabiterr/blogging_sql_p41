using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Blog
{
    // Первинний ключ BlogId
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int BlogId { get; set; }

    // Ім'я блогу, обов'язкове поле, максимальна довжина 100 символів
    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    // Навігаційна властивість для зв'язку одним з багатьох з Posts
    public ICollection<Post>? Posts { get; set; }
}
