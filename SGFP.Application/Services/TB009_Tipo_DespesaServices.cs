using AutoMapper;
using SGFP.Application.DTOs.Request;
using SGFP.Application.DTOs.Response;
using SGFP.Application.Interfaces;
using SGFP.Domain.Entities;
using SGFP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Application.Services
{
    public class TB009_Tipo_DespesaServices : ITB009_Tipo_DespesaServices
    {
        private readonly ITB009_Tipo_DespesaRespository _tipo_DespesaRespository;
        private readonly IMapper _mapper;

        public TB009_Tipo_DespesaServices(ITB009_Tipo_DespesaRespository tipo_DespesaRespository, IMapper mapper)
        {
            _tipo_DespesaRespository = tipo_DespesaRespository;
            _mapper = mapper;
        }

        public async Task<TB009_Tipo_DespesaResponseDto> Create(TB009_Tipo_DespesaRequestDto tipoDespesa)
        {
            var tipoDespesas = _mapper.Map<TB009_Tipo_Despesa>(tipoDespesa);
            await _tipo_DespesaRespository.AddAsync(tipoDespesas);
            return _mapper.Map<TB009_Tipo_DespesaResponseDto>(tipoDespesas);
        }

        public async Task<TB009_Tipo_DespesaResponseDto> Delete(int id)
        {
            var tipoDespesas = await _tipo_DespesaRespository.GetByIdAsync(id);

            if (tipoDespesas == null)
            {
                return null;
            }
            await _tipo_DespesaRespository.DeleteAsync(tipoDespesas);

            return _mapper.Map<TB009_Tipo_DespesaResponseDto>(tipoDespesas);
        }

        public async Task<List<TB009_Tipo_DespesaResponseDto>> GetAll()
        {
            var tipoDespesa = await _tipo_DespesaRespository.GetAllFull();
            return _mapper.Map<List<TB009_Tipo_DespesaResponseDto>>(tipoDespesa);
        }

        public async Task<TB009_Tipo_DespesaResponseDto> GetById(int id)
        {
            var tipoDespesa = await _tipo_DespesaRespository.GetByIdAsync(id);
            if (tipoDespesa == null)
            {
                return null;
            }
            return _mapper.Map<TB009_Tipo_DespesaResponseDto>(tipoDespesa);
        }

        public async Task<TB009_Tipo_DespesaResponseDto> Update(int id, TB009_Tipo_DespesaRequestDto tipoDespesa)
        {
            var tipoDespesas = await _tipo_DespesaRespository.GetByIdAsync(id);
            if (tipoDespesas == null)
            {
                return null;
            }

            _mapper.Map(tipoDespesa, tipoDespesas);

            await _tipo_DespesaRespository.UpdateAsync(tipoDespesas);

            return _mapper.Map<TB009_Tipo_DespesaResponseDto>(tipoDespesas);
        }
    }
}
