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
    public class TB004_Tipo_Origem_DinheiroService : ITB004_Tipo_Origem_DinheiroService
    {
        private readonly ITB004_Tipo_Origem_DinheiroRepository _Tipo_Origem_DinheiroRepository;
        private readonly IMapper _mapper;

        public TB004_Tipo_Origem_DinheiroService(ITB004_Tipo_Origem_DinheiroRepository tipo_Origem_DinheiroRepository, IMapper mapper)
        {
            _Tipo_Origem_DinheiroRepository = tipo_Origem_DinheiroRepository;
            _mapper = mapper;
        }

        public async Task<TB004_Tipo_Origem_DinheiroResponseDto> Create(TB004_Tipo_Origem_DinheiroRequestDto request)
        {
            var tipo = _mapper.Map<TB004_Tipo_Origem_Dinheiro>(request);
            await _Tipo_Origem_DinheiroRepository.AddAsync(tipo);
            return _mapper.Map<TB004_Tipo_Origem_DinheiroResponseDto>(tipo);
        }

        public async Task<TB004_Tipo_Origem_DinheiroResponseDto> Delete(int id)
        {
            var tipo = await _Tipo_Origem_DinheiroRepository.GetByIdAsync(id);
            if (tipo == null)
                return null;

            await _Tipo_Origem_DinheiroRepository.DeleteAsync(tipo);

            return _mapper.Map<TB004_Tipo_Origem_DinheiroResponseDto>(tipo);
        }

        public async Task<List<TB004_Tipo_Origem_DinheiroResponseDto>> GetAll()
        {
            var tipo = await _Tipo_Origem_DinheiroRepository.GetAllAsync();
            return _mapper.Map<List<TB004_Tipo_Origem_DinheiroResponseDto>>(tipo);

        }

        public async Task<TB004_Tipo_Origem_DinheiroResponseDto> GetById(int id)
        {
            var tipo = await _Tipo_Origem_DinheiroRepository.GetByIdAsync(id);
            return _mapper.Map<TB004_Tipo_Origem_DinheiroResponseDto>(tipo);
        }

        public async Task<TB004_Tipo_Origem_DinheiroResponseDto> Update(int id, TB004_Tipo_Origem_DinheiroRequestDto request)
        {
            var tipo = await _Tipo_Origem_DinheiroRepository.GetByIdAsync(id);
            if (tipo == null)
                return null;
            _mapper.Map(request, tipo);

            await _Tipo_Origem_DinheiroRepository.UpdateAsync(tipo);

            return _mapper.Map<TB004_Tipo_Origem_DinheiroResponseDto>(tipo);
        }
    }
}
