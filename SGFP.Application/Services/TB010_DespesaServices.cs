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
    public class TB010_DespesaServices : ITB010_DespesaServices
    {
        private readonly ITB010_DespesaRepository _despesaRepository;
        private readonly IMapper _mapper;

        public TB010_DespesaServices(ITB010_DespesaRepository despesaRepository, IMapper mapper)
        {
            _despesaRepository = despesaRepository;
            _mapper = mapper;
        }

        public async Task<TB010_DespesaResponseDto> Create(TB010_DespesaRequestDto dispesa)
        {
            var dispesas = _mapper.Map<TB010_Despesa>(dispesa);
            await _despesaRepository.AddAsync(dispesas);
            return _mapper.Map<TB010_DespesaResponseDto>(dispesas);
        }

        public async Task<TB010_DespesaResponseDto> Delete(int id)
        {
            var despesas = await _despesaRepository.GetByIdAsync(id);

            if (despesas == null)
            {
                return null;
            }
            await _despesaRepository.DeleteAsync(despesas);

            return _mapper.Map<TB010_DespesaResponseDto>(despesas);
        }

        public async Task<List<TB010_DespesaResponseDto>> GetAll()
        {
            var despesa = await _despesaRepository.GetAllFull();
            return _mapper.Map<List<TB010_DespesaResponseDto>>(despesa);
        }

        public async Task<TB010_DespesaResponseDto> GetById(int id)
        {
            var despesa = await _despesaRepository.GetByIdAsync(id);
            if (despesa == null)
            {
                return null;
            }
            return _mapper.Map<TB010_DespesaResponseDto>(despesa);
        }

        public async Task<TB010_DespesaResponseDto> Update(int id, TB010_DespesaRequestDto dispesa)
        {
            var despesas = await _despesaRepository.GetByIdAsync(id);
            if (despesas == null)
            {
                return null;
            }

            _mapper.Map(dispesa, despesas);

            await _despesaRepository.UpdateAsync(despesas);

            return _mapper.Map<TB010_DespesaResponseDto>(despesas);
        }
    }
}
