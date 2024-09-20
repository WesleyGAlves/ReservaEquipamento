using System.ComponentModel.DataAnnotations;

namespace ReservaEquipamento.Models
{
    public class ReservaModel
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Digite o nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o equipamento!")]
        public string Equipamento { get; set; }

        [Required(ErrorMessage = "Digite a sala!")]
        public string Sala { get; set; }

        [Required(ErrorMessage = "Digite o Horário!")]
        public int Horario { get; set; }
    }
}
