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
    public class TB005_RecebimentoService : ITB005_RecebimentoService
    {
        private readonly ITB005_RecebimentoRepository _recebimentoRepository;
        private readonly IMapper _mapper;

        public TB005_RecebimentoService(ITB005_RecebimentoRepository recebimentoRepository, IMapper mapper)
        {
            _recebimentoRepository = recebimentoRepository;
            _mapper = mapper;
        }

        public async Task<TB005_RecebimentoResponseDto> create(TB005_RecebimentoRequestDto request)
        {
            var recebimento =  _mapper.Map<TB005_Recebimento>(request);
            await _recebimentoRepository.AddAsync(recebimento);
            return _mapper.Map<TB005_RecebimentoResponseDto>(recebimento);
        }

        public async Task<TB005_RecebimentoResponseDto> delete(int id)
        {
            var recebimento = await _recebimentoRepository.GetByIdAsync(id);
            if (recebimento == null)
                return null;
            await _recebimentoRepository.DeleteAsync(recebimento);
            return _mapper.Map<TB005_RecebimentoResponseDto>(recebimento);

        }

        public async Task<List<TB005_RecebimentoResponseDto>> GetAll()
        {
            var recebimento = await _recebimentoRepository.GetAllAsync();
            return _mapper.Map<List<TB005_RecebimentoResponseDto>>(recebimento);
        }

        public async Task<TB005_RecebimentoResponseDto> GetById(int id)
        {
            var recebimento = await _recebimentoRepository.GetByIdAsync(id);
            return _mapper.Map<TB005_RecebimentoResponseDto>(recebimento);
        }

        public async Task<TB005_RecebimentoResponseDto> update(int id, TB005_RecebimentoRequestDto request)
        {
            var recebimento = await _recebimentoRepository.GetByIdAsync(id);
            if (recebimento == null)
                return null;

            _mapper.Map(request, recebimento);
            await _recebimentoRepository.UpdateAsync(recebimento);
            return _mapper.Map<TB005_RecebimentoResponseDto>(recebimento);
        }
    }
}
