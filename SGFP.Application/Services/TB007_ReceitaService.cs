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
    public class TB007_ReceitaService:ITB007_ReceitaService
    {
        private readonly ITB007_ReceitaRepository _receitaRepository;
        private IMapper _mapper;

        public TB007_ReceitaService(ITB007_ReceitaRepository receitaRepository, IMapper mapper)
        {
            _receitaRepository = receitaRepository;
            _mapper = mapper;
        }

        public async Task<TB007_ReceitaResponseDto> Create(TB007_ReceitaRequestDto receita)
        {
            var dado = _mapper.Map<TB007_Receita>(receita);
            await _receitaRepository.AddAsync(dado);
            return _mapper.Map<TB007_ReceitaResponseDto>(dado);
        }

        public async Task<TB007_ReceitaResponseDto> Delete(int id)
        {
            var receita = await _receitaRepository.GetByIdAsync(id);

            if (receita == null)
            {
                return null;
            }
            await _receitaRepository.DeleteAsync(receita);

            return _mapper.Map<TB007_ReceitaResponseDto>(receita);
        }

        public async Task<List<TB007_ReceitaResponseDto>> GetAll()
        {
            var receita = await _receitaRepository.GetAllAsync();
            return _mapper.Map<List<TB007_ReceitaResponseDto>>(receita);
  
        }

        public async Task<TB007_ReceitaResponseDto> GetById(int id)
        {
            var receita = await _receitaRepository.GetByIdAsync(id);
            if (receita == null)
            {
                return null;
            }
            return _mapper.Map<TB007_ReceitaResponseDto>(receita);
        }

        public async Task<TB007_ReceitaResponseDto> Update(int id, TB007_ReceitaRequestDto receita)
        {
            var receitas = await _receitaRepository.GetByIdAsync(id);
            if (receitas == null)
            {
                return null;
            }

            _mapper.Map(receita, receitas);

            await _receitaRepository.UpdateAsync(receitas);

            return _mapper.Map<TB007_ReceitaResponseDto>(receitas);
        }
    }
}
