﻿using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator <Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog başlığını boş geçemezsiniz");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog içeriğini boş geçemezsiniz");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog görselini boş geçemezsiniz");
            RuleFor(x => x.BlogThumbnailImage).NotEmpty().WithMessage("Blog küçük görselini boş geçemezsiniz");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Lütfen 150 karakterden daha az veri girişi yapınız");
            RuleFor(x => x.BlogContent).MaximumLength(150).WithMessage("Lütfen 150 karakterden daha az veri girişi yapınız");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Lütfen 5 karakterden daha fazla (5-150 karakter arası) veri girişi yapınız");
            RuleFor(x => x.BlogContent).MinimumLength(5).WithMessage("Lütfen 5 karakterden daha fazla (5-150 karakter arası) veri girişi yapınız");
        }
    }
}
