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
    public class TB012_Unidade_Produto_CompraService:ITB012_Unidade_Produto_CompraService
    {
        private readonly ITB012_Unidade_Produto_CompraRepository _unidade_Produto_CompraRepository;
        private readonly IMapper _mapper;

        public TB012_Unidade_Produto_CompraService(ITB012_Unidade_Produto_CompraRepository unidade_Produto_CompraRepository, IMapper mapper)
        {
            _unidade_Produto_CompraRepository = unidade_Produto_CompraRepository;
            _mapper = mapper;
        }

        public async Task<TB012_Unidade_Produto_CompraResponseDto> Create(TB012_Unidade_Produto_CompraResquesDto unidadeProdutoCompra)
        {
            var unidadeProdutoCompras = _mapper.Map<TB012_Unidade_Produto_Compra>(unidadeProdutoCompra);
            await _unidade_Produto_CompraRepository.AddAsync(unidadeProdutoCompras);
            return _mapper.Map<TB012_Unidade_Produto_CompraResponseDto>(unidadeProdutoCompras);
        }

        public async Task<TB012_Unidade_Produto_CompraResponseDto> Delete(int id)
        {
            var unidadeProdutoCompras = await _unidade_Produto_CompraRepository.GetByIdAsync(id);

            if (unidadeProdutoCompras == null)
            {
                return null;
            }
            await _unidade_Produto_CompraRepository.DeleteAsync(unidadeProdutoCompras);

            return _mapper.Map<TB012_Unidade_Produto_CompraResponseDto>(unidadeProdutoCompras);
        }

        public async Task<List<TB012_Unidade_Produto_CompraResponseDto>> GetAll()
        {
            var unidadeProdutoCompras = await _unidade_Produto_CompraRepository.GetAllAsync();
            return _mapper.Map<List<TB012_Unidade_Produto_CompraResponseDto>>(unidadeProdutoCompras);
        }

        public async Task<TB012_Unidade_Produto_CompraResponseDto> GetById(int id)
        {
            var unidadeProdutoCompras = await _unidade_Produto_CompraRepository.GetByIdAsync(id);
            if (unidadeProdutoCompras == null)
            {
                return null;
            }
            return _mapper.Map<TB012_Unidade_Produto_CompraResponseDto>(unidadeProdutoCompras);
        }

        public async Task<TB012_Unidade_Produto_CompraResponseDto> Update(int id, TB012_Unidade_Produto_CompraResquesDto unidadeProdutoCompra)
        {
            var unidadeProdutoCompras = await _unidade_Produto_CompraRepository.GetByIdAsync(id);
            if (unidadeProdutoCompras == null)
            {
                return null;
            }

            _mapper.Map(unidadeProdutoCompra, unidadeProdutoCompras);

            await _unidade_Produto_CompraRepository.UpdateAsync(unidadeProdutoCompras);

            return _mapper.Map<TB012_Unidade_Produto_CompraResponseDto>(unidadeProdutoCompras);
        }
    }
}
