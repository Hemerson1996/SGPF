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
    public class TB003_Categoria_ReceitaServices : ITB003_Categoria_ReceitaServices
    {
        private readonly ITB003_Categoria_ReceitaRepository _categoria_ReceitaRepository;
        private readonly IMapper _mapper;

        public TB003_Categoria_ReceitaServices(ITB003_Categoria_ReceitaRepository categoria_ReceitaRepository, IMapper mapper)
        {
            _categoria_ReceitaRepository = categoria_ReceitaRepository;
            _mapper = mapper;
        }


        public async Task<TB003_Categoria_ReceitaResponseDtos> Create(TB003_Categoria_ReceitaRequestDtos categoria)
        {
            var dado = _mapper.Map<TB003_Categoria_Receita>(categoria);
            await _categoria_ReceitaRepository.AddAsync(dado);
            return _mapper.Map<TB003_Categoria_ReceitaResponseDtos>(dado);
        }

        public async Task<TB003_Categoria_ReceitaResponseDtos> Delete(int id)
        {
            var categoriaReceita = await _categoria_ReceitaRepository.GetByIdAsync(id);

            if (categoriaReceita == null)
            {
                return null;
            }
            await _categoria_ReceitaRepository.DeleteAsync(categoriaReceita);

            return _mapper.Map<TB003_Categoria_ReceitaResponseDtos>(categoriaReceita);
        }

        public async Task<List<TB003_Categoria_ReceitaResponseDtos>> GetAll()
        {
            var categoriaReceita = await _categoria_ReceitaRepository.GetAllAsync();
            return _mapper.Map<List<TB003_Categoria_ReceitaResponseDtos>>(categoriaReceita);
        }

        public async Task<TB003_Categoria_ReceitaResponseDtos> GetById(int id)
        {
            var categoriaReceita = await _categoria_ReceitaRepository.GetByIdAsync(id);
            if(categoriaReceita == null)
            {
                return null;
            }
            return _mapper.Map<TB003_Categoria_ReceitaResponseDtos>(categoriaReceita);

        }

        public async Task<TB003_Categoria_ReceitaResponseDtos> Update(int id,TB003_Categoria_ReceitaRequestDtos categoria)
        {
            var categoriaReceita = await _categoria_ReceitaRepository.GetByIdAsync(id);
            if (categoriaReceita == null)
            {
                return null;
            }

            _mapper.Map(categoria,categoriaReceita);

            await _categoria_ReceitaRepository.UpdateAsync(categoriaReceita);

            return _mapper.Map<TB003_Categoria_ReceitaResponseDtos>(categoriaReceita);
        }
    }
}
