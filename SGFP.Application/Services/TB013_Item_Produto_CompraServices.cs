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
    public class TB013_Item_Produto_CompraServices:ITB013_Item_Produto_CompraServices
    {
        private readonly ITB013_Item_Produto_CompraRepository _item_Produto_CompraRepository;
        private readonly IMapper _mapper;

        public TB013_Item_Produto_CompraServices(ITB013_Item_Produto_CompraRepository item_Produto_CompraRepository, IMapper mapper)
        {
            _item_Produto_CompraRepository = item_Produto_CompraRepository;
            _mapper = mapper;
        }

        public async Task<TB013_Item_Produto_CompraResponseDto> Create(TB013_Item_Produto_CompraRequestDto itemProdutoCompra)
        {
            var itemProdutoCompras = _mapper.Map<TB013_Item_Produto_Compra>(itemProdutoCompra);
            await _item_Produto_CompraRepository.AddAsync(itemProdutoCompras);
            return _mapper.Map<TB013_Item_Produto_CompraResponseDto>(itemProdutoCompras);
        }

        public async Task<TB013_Item_Produto_CompraResponseDto> Delete(int id)
        {
            var itemProdutoCompras = await _item_Produto_CompraRepository.GetByIdAsync(id);

            if (itemProdutoCompras == null)
            {
                return null;
            }
            await _item_Produto_CompraRepository.DeleteAsync(itemProdutoCompras);

            return _mapper.Map<TB013_Item_Produto_CompraResponseDto>(itemProdutoCompras);
        }

        public async Task<List<TB013_Item_Produto_CompraResponseDto>> GetAll()
        {
            var itemProdutoCompras = await _item_Produto_CompraRepository.GetAllFull();
            return _mapper.Map<List<TB013_Item_Produto_CompraResponseDto>>(itemProdutoCompras);
        }

        public async Task<TB013_Item_Produto_CompraResponseDto> GetById(int id)
        {
            var itemProdutoCompras = await _item_Produto_CompraRepository.GetByIdAsync(id);
            if (itemProdutoCompras == null)
            {
                return null;
            }
            return _mapper.Map<TB013_Item_Produto_CompraResponseDto>(itemProdutoCompras);
        }

        public async Task<TB013_Item_Produto_CompraResponseDto> Update(int id, TB013_Item_Produto_CompraRequestDto itemProdutoCompra)
        {
            var itemProdutoCompras = await _item_Produto_CompraRepository.GetByIdAsync(id);
            if (itemProdutoCompras == null)
            {
                return null;
            }

            _mapper.Map(itemProdutoCompra, itemProdutoCompras);

            await _item_Produto_CompraRepository.UpdateAsync(itemProdutoCompras);

            return _mapper.Map<TB013_Item_Produto_CompraResponseDto>(itemProdutoCompras);
        }
    }
}
