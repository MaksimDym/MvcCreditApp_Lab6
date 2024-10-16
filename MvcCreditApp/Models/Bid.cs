using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcCreditApp.Models
{
    public class Bid
    {
        
        public virtual int BidId { get; set; }
       
        [DisplayName("Имя заявителя")]
        public virtual string Name { get; set; }
        [Required(ErrorMessage = "Название кредита обязательно для заполнения.")]
        [DisplayName("Название кредита")]
        public virtual string CreditHead { get; set; }
        
        [DisplayName("Дата подачи заявки")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
        
        public virtual DateTime bidDate { get; set; }


    }
}
