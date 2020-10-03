using System.ComponentModel.DataAnnotations; // 加required 才不會噴505error server v.s clients errors

namespace Commander.Dtos
{
    public class CommandCreateDto
    {

        // public int Id { get; set; } 自動生成 不用放
        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }
        [Required]
        public string Line { get; set; }
        [Required]
        public string Platform { get; set; }
    }
}