using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace MVC_qrPerAPI.Models
{
    public class IndexView
    {
        [Required(ErrorMessage = "x")]
        public string Url { get; set; }
        [Required(ErrorMessage = "y")]
        public int Breite { get; set; }
        [Required(ErrorMessage = "z")]
        public int Hoehe { get; set; }
        [Required(ErrorMessage = "a")]
        public Color VF { get; set; }
        [Required(ErrorMessage = "s")]
        public Color HF { get; set; }
    }
}
