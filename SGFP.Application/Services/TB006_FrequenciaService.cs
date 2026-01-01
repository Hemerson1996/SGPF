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
    public class TB006_FrequenciaService : ITB006_FrequenciaService
    {
        private readonly ITB006_FrequenciaRepository _frequenciaRepository;
        private readonly IMapper _mapper;

        public TB006_FrequenciaService(ITB006_FrequenciaRepository frequenciaRepository, IMapper mapper)
        {
            _frequenciaRepository = frequenciaRepository;
            _mapper = mapper;
        }

        public async Task<TB006_FrequenciaResponseDto> Create(TB006_FrequenciaRequestDto frequecia)
        {
            var dado = _mapper.Map<TB006_Frequencia>(frequecia);
            await _frequenciaRepository.AddAsync(dado);
            return _mapper.Map<TB006_FrequenciaResponseDto>(dado);
        }

        public async Task<TB006_FrequenciaResponseDto> Delete(int id)
        {
            var frequencia = await _frequenciaRepository.GetByIdAsync(id);

            if (frequencia == null)
            {
                return null;
            }
            await _frequenciaRepository.DeleteAsync(frequencia);

            return _mapper.Map<TB006_FrequenciaResponseDto>(frequencia);
        }

        public async Task<List<TB006_FrequenciaResponseDto>> GetAll()
        {
            var frequencias = await _frequenciaRepository.GetAllAsync();
            return _mapper.Map<List<TB006_FrequenciaResponseDto>>(frequencias);
        }

        public async Task<TB006_FrequenciaResponseDto> GetById(int id)
        {
            var frequencia = await _frequenciaRepository.GetByIdAsync(id);
            if (frequencia == null)
            {
                return null;
            }
            return _mapper.Map<TB006_FrequenciaResponseDto>(frequencia);
        }

        public async Task<TB006_FrequenciaResponseDto> Update(int id, TB006_FrequenciaRequestDto frequecia)
        {
            var frequencia = await _frequenciaRepository.GetByIdAsync(id);
            if (frequencia == null)
            {
                return null;
            }

            _mapper.Map(frequecia, frequencia);

            _frequenciaRepository.UpdateAsync(frequencia);

            return _mapper.Map<TB006_FrequenciaResponseDto>(frequencia);
        }
    }
}
