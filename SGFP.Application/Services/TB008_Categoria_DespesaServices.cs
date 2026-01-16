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
    public class TB008_Categoria_DespesaServices : ITB008_Categoria_DespesaServices
    {
        private readonly ITB008_Categoria_DespesaRespository _categoria_DespesaRespository;
        private readonly IMapper _mapper;

        public TB008_Categoria_DespesaServices(ITB008_Categoria_DespesaRespository categoria_DespesaRespository, IMapper mapper)
        {
            _categoria_DespesaRespository = categoria_DespesaRespository;
            _mapper = mapper;
        }

        public async Task<TB008_Categoria_DespesaResponseDtos> Create(TB008_Categoria_DespesaRequestDtos despesa)
        {
            var dado = _mapper.Map<TB008_Categoria_Despesa>(despesa);
            await _categoria_DespesaRespository.AddAsync(dado);
            return _mapper.Map<TB008_Categoria_DespesaResponseDtos>(dado);
        }

        public async Task<TB008_Categoria_DespesaResponseDtos> Delete(int id)
        {
            var despesas = await _categoria_DespesaRespository.GetByIdAsync(id);

            if (despesas == null)
            {
                return null;
            }
            await _categoria_DespesaRespository.DeleteAsync(despesas);

            return _mapper.Map<TB008_Categoria_DespesaResponseDtos>(despesas);
        }

        public async Task<List<TB008_Categoria_DespesaResponseDtos>> GetAll()
        {
            var despesas = await _categoria_DespesaRespository.GetAllAsync();
            return _mapper.Map<List<TB008_Categoria_DespesaResponseDtos>>(despesas);
        }

        public async Task<TB008_Categoria_DespesaResponseDtos> GetById(int id)
        {
            var despesa = await _categoria_DespesaRespository.GetByIdAsync(id);
            if (despesa == null)
            {
                return null;
            }
            return _mapper.Map<TB008_Categoria_DespesaResponseDtos>(despesa);
        }

        public async Task<TB008_Categoria_DespesaResponseDtos> Update(int id, TB008_Categoria_DespesaRequestDtos despesa)
        {
            var despesas = await _categoria_DespesaRespository.GetByIdAsync(id);
            if (despesas == null)
            {
                return null;
            }

            _mapper.Map(despesa, despesas);

            await _categoria_DespesaRespository.UpdateAsync(despesas);

            return _mapper.Map<TB008_Categoria_DespesaResponseDtos>(despesas);
        }
    }
}
