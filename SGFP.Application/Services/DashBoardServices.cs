using AutoMapper;
using SGFP.Application.DTOs.Request;
using SGFP.Application.DTOs.Response;
using SGFP.Application.Interfaces;
using SGFP.Domain.Entities;
using SGFP.Domain.Enums;
using SGFP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SGFP.Application.DTOs.Response.DashBoardResponseDtos;

namespace SGFP.Application.Services
{
    public class DashBoardServices : IDashBoardServices
    {
        private readonly ITB007_ReceitaRepository _receitaRepository;
        private readonly ITB010_DespesaRepository _despesaRepository;
        private readonly IMapper _mapper;

        public DashBoardServices(ITB007_ReceitaRepository receitaRepository, ITB010_DespesaRepository despesaRepository, IMapper mapper)
        {
            _receitaRepository = receitaRepository;
            _despesaRepository = despesaRepository;
            _mapper = mapper;
        }




        public async Task<DashBoardResponseDtos> Valores()
        {
            var receita = await _receitaRepository.GetAllAsync();           
            var despesa = await _despesaRepository.GetAllAsync();           

            var hoje = DateTime.Today;

            var inicioMes = new DateTime(hoje.Year, hoje.Month, 1);
            var fimMes = new DateTime(
                hoje.Year,
                hoje.Month,
                DateTime.DaysInMonth(hoje.Year, hoje.Month));

            decimal totalReceita = 0;
            decimal totalDespesa = 0;

            foreach (var r in receita.Where(x => x.ativo == true))
            {

                if (!EstaAtivaNoMesReceita(r, inicioMes, fimMes))
                    continue;

                totalReceita += r.frequencia_Id switch
                {
                    (int)FrequenciaTipo.Unica => UnicaReceita(r, inicioMes, fimMes),
                    (int)FrequenciaTipo.Diaria => DiariaReceita(r, inicioMes, fimMes),
                    (int)FrequenciaTipo.Quinzenal => QuinzenalReceita(r, inicioMes, fimMes),
                    (int)FrequenciaTipo.Mensal =>(decimal) r.receita_Valor,
                };

              
            }

            foreach (var d in despesa.Where(x => x.ativo == true))
            {

                if (!EstaAtivaNoMesDespesa(d, inicioMes, fimMes))
                    continue;

                totalDespesa += d.frequencia_Id switch
                {
                    (int)FrequenciaTipo.Unica => UnicaDespesa(d, inicioMes, fimMes),
                    (int)FrequenciaTipo.Diaria => DiariaDespesa(d, inicioMes, fimMes),
                    (int)FrequenciaTipo.Quinzenal => QuinzenalDespesa(d, inicioMes, fimMes),
                    (int)FrequenciaTipo.Mensal => (decimal)d.despesa_Valor,
                };


            }

            return new DashBoardResponseDtos
            {
                Total = new TotalDto
                {
                    TotalReceita = totalReceita,
                    TotalDebito = totalDespesa
                }
            };

        }

        private bool EstaAtivaNoMesReceita(TB007_Receita r, DateTime inicioMes, DateTime fimMes)
        {
            var fim = r.data_Fim ?? fimMes;
            return r.data_Inicio <= fimMes && fim >= inicioMes;
        }

        private decimal UnicaReceita(TB007_Receita r, DateTime inicioMes, DateTime fimMes)
           => r.data_Inicio >= inicioMes && r.data_Inicio <= fimMes
               ? r.receita_Valor : 0;

        private decimal DiariaReceita(TB007_Receita r, DateTime inicioMes, DateTime fimMes)
        {
            var inicio = r.data_Inicio < inicioMes ? inicioMes : r.data_Inicio;
            var fim = r.data_Fim ?? fimMes;
            if (fim > fimMes) fim = fimMes;

            var dias = (fim - inicio).Days + 1;
            return dias * r.receita_Valor;
        }

        private decimal QuinzenalReceita(TB007_Receita r, DateTime inicioMes, DateTime fimMes)
        {
            var inicio = r.data_Inicio < inicioMes ? inicioMes : r.data_Inicio;
            var fim = r.data_Fim ?? fimMes;
            if (fim > fimMes) fim = fimMes;

            var dias = (fim - inicio).Days + 1;
            var ocorrencias = dias / 15;

            return ocorrencias * r.receita_Valor;
        }

        private bool EstaAtivaNoMesDespesa(TB010_Despesa r, DateTime inicioMes, DateTime fimMes)
        {
            var fim = r.data_Fim ?? fimMes;
            return r.data_Inicio <= fimMes && fim >= inicioMes;
        }

        private decimal UnicaDespesa(TB010_Despesa r, DateTime inicioMes, DateTime fimMes)
           => r.data_Inicio >= inicioMes && r.data_Inicio <= fimMes
               ? r.despesa_Valor : 0;

        private decimal DiariaDespesa(TB010_Despesa r, DateTime inicioMes, DateTime fimMes)
        {
            var inicio = r.data_Inicio < inicioMes ? inicioMes : r.data_Inicio;
            var fim = r.data_Fim ?? fimMes;
            if (fim > fimMes) fim = fimMes;

            var dias = (fim - inicio).Days + 1;
            return dias * r.despesa_Valor;
        }

        private decimal QuinzenalDespesa(TB010_Despesa r, DateTime inicioMes, DateTime fimMes)
        {
            var inicio = r.data_Inicio < inicioMes ? inicioMes : r.data_Inicio;
            var fim = r.data_Fim ?? fimMes;
            if (fim > fimMes) fim = fimMes;

            var dias = (fim - inicio).Days + 1;
            var ocorrencias = dias / 15;

            return ocorrencias * r.despesa_Valor;
        }

    }
}
