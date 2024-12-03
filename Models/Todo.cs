using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TodoApplikasjonenAPI3.Models
{
    public class Todo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tittel er påkrevd")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Tittelen må være mellom 3 og 100 tegn")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Beskrivelse er påkrevd")]
        [StringLength(int.MaxValue, MinimumLength = 10, ErrorMessage = "Beskrivelsen må være minst 10 tegn hvis den er oppgitt.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "IsCompleted er påkrevd.")]
        public bool IsCompleted { get; set; }
    }
}
