using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcCreditApp.Models
{
    public class Credit
    {
       
        public virtual int CreditId { get; set; }
        [Required(ErrorMessage = "Вид кредита обязателен для заполнения.")]
        [DisplayName("Вид кредита")]
        public virtual string Head { get; set; }
        [Required(ErrorMessage = "Срок кредита обязателен для заполнения.")]
        [DisplayName("Срок кредита")]
        public virtual int Period { get; set; }
        [Required(ErrorMessage = "Сумма кредита обязательна для заполнения.")]
        [DisplayName("Сумма кредита")]
        public virtual int Sum { get; set; }
        [Required(ErrorMessage = "Процентная ставка обязательна для заполнения.")]
        [Range(0, 100, ErrorMessage = "Процентная ставка должна быть в диапазоне от 0 до 100.")]
        [DisplayName("Процентная ставка")]
        public virtual int Procent { get; set; }


    }
}
