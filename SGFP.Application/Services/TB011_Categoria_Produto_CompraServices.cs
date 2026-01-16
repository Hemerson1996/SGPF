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
    public class TB011_Categoria_Produto_CompraServices : ITB011_Categoria_Produto_CompraServices
    {
        public readonly ITB011_Categoria_Produto_CompraRepository _categoria_Produto_CompraRepository;
        public readonly IMapper _mapper;

        public TB011_Categoria_Produto_CompraServices(ITB011_Categoria_Produto_CompraRepository categoria_Produto_CompraRepository, IMapper mapper)
        {
            _categoria_Produto_CompraRepository = categoria_Produto_CompraRepository;
            _mapper = mapper;
        }

        public async Task<TB011_Categoria_Produto_CompraResponseDto> Create(TB011_Categoria_Produto_CompraRequestDto categoiriaProdutoCompra)
        {
            var categoiriaProdutoCompras = _mapper.Map<TB011_Categoria_Produto_Compra>(categoiriaProdutoCompra);
            await _categoria_Produto_CompraRepository.AddAsync(categoiriaProdutoCompras);
            return _mapper.Map<TB011_Categoria_Produto_CompraResponseDto>(categoiriaProdutoCompras);
        }

        public async Task<TB011_Categoria_Produto_CompraResponseDto> Delete(int id)
        {
            var categoiriaProdutoCompras = await _categoria_Produto_CompraRepository.GetByIdAsync(id);

            if (categoiriaProdutoCompras == null)
            {
                return null;
            }
            await _categoria_Produto_CompraRepository.DeleteAsync(categoiriaProdutoCompras);

            return _mapper.Map<TB011_Categoria_Produto_CompraResponseDto>(categoiriaProdutoCompras);
        }

        public async Task<List<TB011_Categoria_Produto_CompraResponseDto>> GetAll()
        {
            var categoiriaProdutoCompras = await _categoria_Produto_CompraRepository.GetAllAsync();
            return _mapper.Map<List<TB011_Categoria_Produto_CompraResponseDto>>(categoiriaProdutoCompras);
        }

        public async Task<TB011_Categoria_Produto_CompraResponseDto> GetById(int id)
        {
            var categoiriaProdutoCompras = await _categoria_Produto_CompraRepository.GetByIdAsync(id);
            if (categoiriaProdutoCompras == null)
            {
                return null;
            }
            return _mapper.Map<TB011_Categoria_Produto_CompraResponseDto>(categoiriaProdutoCompras);
        }

        public async Task<TB011_Categoria_Produto_CompraResponseDto> Update(int id, TB011_Categoria_Produto_CompraRequestDto categoiriaProdutoCompra)
        {
            var categoiriaProdutoCompras = await _categoria_Produto_CompraRepository.GetByIdAsync(id);
            if (categoiriaProdutoCompras == null)
            {
                return null;
            }

            _mapper.Map(categoiriaProdutoCompra, categoiriaProdutoCompras);

            await _categoria_Produto_CompraRepository.UpdateAsync(categoiriaProdutoCompras);

            return _mapper.Map<TB011_Categoria_Produto_CompraResponseDto>(categoiriaProdutoCompras);
        }
    }
}
