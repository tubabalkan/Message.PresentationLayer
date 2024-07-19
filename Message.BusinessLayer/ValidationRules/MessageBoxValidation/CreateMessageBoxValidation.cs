using FluentValidation;
using Message.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message.BusinessLayer.ValidationRules.MessageBoxValidation
{
    public class CreateMessageBoxValidation:AbstractValidator<MessageBox>
    {
        public CreateMessageBoxValidation()
        {
           RuleFor(x => x.Name).NotEmpty().WithMessage("Lütfen boş geçmeyin");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Lütfen boş geçmeyin");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Lütfen boş geçmeyin");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu Adını Boş Geçemezsiniz");
            RuleFor(x => x.Alıcı).NotEmpty().WithMessage("Alıcı Adını Boş Geçemezsiniz");
            RuleFor(x => x.Gonderen).NotEmpty().WithMessage("Gönderen Adını Boş Geçemezsiniz");
            RuleFor(x => x.MessageDetail).NotEmpty().WithMessage("Mesajı Boş Geçemezsiniz");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapın");
            RuleFor(x => x.MessageDetail).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapın");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter girişi yapın");
        }
    }
}
