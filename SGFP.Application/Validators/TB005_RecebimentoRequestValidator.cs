using FluentValidation;
using SGFP.Application.DTOs.Request;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Application.Validators
{
    public class TB005_RecebimentoRequestValidator : AbstractValidator<TB005_RecebimentoRequestDto>
    {
        public TB005_RecebimentoRequestValidator()
        {
            RuleFor(x => x.recebimento_Nome)
            .NotEmpty().WithMessage("Nome da Categoria Obrigatorio");
        }
    }
}
