namespace WebMvc.Models
{
    public class Pessoa
    {
        public int Id {get; set;}

        [System.ComponentModel.DataAnnotations.Required]
        public string Nome {get; set;}
    }
}