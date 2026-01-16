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
    public class TB014_Item_CompraServices : ITB014_Item_CompraServices
    {
        private readonly ITB014_Item_CompraRepository _item_CompraRepository;
        private readonly IMapper _mapper;

        public TB014_Item_CompraServices(ITB014_Item_CompraRepository item_CompraRepository, IMapper mapper)
        {
            _item_CompraRepository = item_CompraRepository;
            _mapper = mapper;
        }

        public async Task<TB014_Item_CompraResponseDto> Create(TB014_Item_CompraRequestDto itemCompra)
        {
            var itemCompras = _mapper.Map<TB014_Item_Compra>(itemCompra);
            await _item_CompraRepository.AddAsync(itemCompras);
            return _mapper.Map<TB014_Item_CompraResponseDto>(itemCompras);
        }

        public async Task<TB014_Item_CompraResponseDto> Delete(int id)
        {
            var itemCompras = await _item_CompraRepository.GetByIdAsync(id);

            if (itemCompras == null)
            {
                return null;
            }
            await _item_CompraRepository.DeleteAsync(itemCompras);

            return _mapper.Map<TB014_Item_CompraResponseDto>(itemCompras);
        }

        public async Task<List<TB014_Item_CompraResponseDto>> GetAll()
        {
            var itemCompras = await _item_CompraRepository.GetAllFull();
            return _mapper.Map<List<TB014_Item_CompraResponseDto>>(itemCompras);
        }

        public async Task<TB014_Item_CompraResponseDto> GetById(int id)
        {
            var itemCompras = await _item_CompraRepository.GetByIdAsync(id);
            if (itemCompras == null)
            {
                return null;
            }
            return _mapper.Map<TB014_Item_CompraResponseDto>(itemCompras);
        }

        public async Task<TB014_Item_CompraResponseDto> Update(int id, TB014_Item_CompraRequestDto itemCompra)
        {
            var itemCompras = await _item_CompraRepository.GetByIdAsync(id);
            if (itemCompras == null)
            {
                return null;
            }

            _mapper.Map(itemCompra, itemCompras);

            await _item_CompraRepository.UpdateAsync(itemCompras);

            return _mapper.Map<TB014_Item_CompraResponseDto>(itemCompras);
        }
    }
}
