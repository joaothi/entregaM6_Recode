using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JTViagens.Models
{
	[Table("Pacote")]
	public class Pacote
	{
		[Key]
		public int PacoteId { get; set; }

		[Required(ErrorMessage = "Informe o preço do Pacote")]
		public double Preco { get; set; }

		[Required(ErrorMessage = "Informe o destino do Pacote")]
		[StringLength(20)]
		public string Destino { get; set; }


		[Display(Name = "Data_Viagem")]
		[Required]
		[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
		[DataType(DataType.DateTime, ErrorMessage = "Data em formato inválido")]
		public DateTime Data_Viagem { get; set; }

		[Display(Name = "Hora")]
		[Required]
		[DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
		[DataType(DataType.DateTime, ErrorMessage = "Hora em formato inválido")]
		public DateTime Hora { get; set; }


	}
}
