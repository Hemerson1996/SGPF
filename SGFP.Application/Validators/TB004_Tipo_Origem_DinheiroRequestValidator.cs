using FluentValidation;
using SGFP.Application.DTOs.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Application.Validators
{
    public class TB004_Tipo_Origem_DinheiroRequestValidator : AbstractValidator<TB004_Tipo_Origem_DinheiroRequestDto>
    {
        public TB004_Tipo_Origem_DinheiroRequestValidator()
        {
            RuleFor(x => x.tipo_Nome)
                .NotEmpty().WithMessage("Campo Nome Obrigatório");

            RuleFor(x => x.categoriaReceita_Id)
                .NotEmpty().WithMessage("Selecione o Tipo de Receita");
        }
    }
}
