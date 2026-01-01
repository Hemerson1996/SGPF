using FluentValidation;
using FluentValidation.Validators;
using SGFP.Application.DTOs.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Application.Validators
{
    public class TB003_Categoria_ReceitaRequestValidator : AbstractValidator<TB003_Categoria_ReceitaRequestDtos>
    {
        public TB003_Categoria_ReceitaRequestValidator()
        {
            RuleFor(x => x.categoriaReceita_Nome)
                .NotEmpty().WithMessage("Nome da Categoria Obrigatorio");
                
        }
    }
}
