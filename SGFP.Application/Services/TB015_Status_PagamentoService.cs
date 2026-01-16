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
    public class TB015_Status_PagamentoService : ITB015_Status_PagamentoService
    {
        private readonly ITB015_Status_PagamentoRepository _status_PagamentoRepository;
        private readonly IMapper _mapper;

        public TB015_Status_PagamentoService(ITB015_Status_PagamentoRepository status_PagamentoRepository, IMapper mapper)
        {
            _status_PagamentoRepository = status_PagamentoRepository;
            _mapper = mapper;
        }

        public async Task<TB015_Status_PagamentoResponseDto> Create(TB015_Status_PagamentoRequestDto statusPagamento)
        {
            var statusPagamentos = _mapper.Map<TB015_Status_Pagamentos>(statusPagamento);
            await _status_PagamentoRepository.AddAsync(statusPagamentos);
            return _mapper.Map<TB015_Status_PagamentoResponseDto>(statusPagamentos);
        }

        public async Task<TB015_Status_PagamentoResponseDto> Delete(int id)
        {
            var statusPagamentos = await _status_PagamentoRepository.GetByIdAsync(id);

            if (statusPagamentos == null)
            {
                return null;
            }
            await _status_PagamentoRepository.DeleteAsync(statusPagamentos);

            return _mapper.Map<TB015_Status_PagamentoResponseDto>(statusPagamentos);
        }

        public async Task<List<TB015_Status_PagamentoResponseDto>> GetAll()
        {
            var statusPagamentos = await _status_PagamentoRepository.GetAllAsync();
            return _mapper.Map<List<TB015_Status_PagamentoResponseDto>>(statusPagamentos);
        }

        public async Task<TB015_Status_PagamentoResponseDto> GetById(int id)
        {
            var statusPagamentos = await _status_PagamentoRepository.GetByIdAsync(id);
            if (statusPagamentos == null)
            {
                return null;
            }
            return _mapper.Map<TB015_Status_PagamentoResponseDto>(statusPagamentos);
        }

        public async Task<TB015_Status_PagamentoResponseDto> Update(int id, TB015_Status_PagamentoRequestDto statusPagamento)
        {
            var statusPagamentos = await _status_PagamentoRepository.GetByIdAsync(id);
            if (statusPagamentos == null)
            {
                return null;
            }

            _mapper.Map(statusPagamento, statusPagamentos);

            await _status_PagamentoRepository.UpdateAsync(statusPagamentos);

            return _mapper.Map<TB015_Status_PagamentoResponseDto>(statusPagamentos);
        }
    }
}
