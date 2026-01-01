using AutoMapper;
using SGFP.Application.DTOs.Request;
using SGFP.Application.DTOs.Response;
using SGFP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Application.Mappings
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            // Entity → DTO
            //CreateMap<>();
            CreateMap<TB003_Categoria_Receita, TB003_Categoria_ReceitaResponseDtos>();
            CreateMap<TB004_Tipo_Origem_Dinheiro, TB004_Tipo_Origem_DinheiroResponseDto>();
            CreateMap<TB005_Recebimento, TB005_RecebimentoResponseDto>();
            CreateMap<TB006_Frequencia, TB006_FrequenciaResponseDto>();
            CreateMap<TB007_Receita, TB007_ReceitaResponseDto>();


            // DTO → Entity
            //CreateMap<>();
            CreateMap<TB003_Categoria_ReceitaRequestDtos, TB003_Categoria_Receita>();
            CreateMap<TB004_Tipo_Origem_DinheiroRequestDto, TB004_Tipo_Origem_Dinheiro>();
            CreateMap<TB005_RecebimentoRequestDto, TB005_Recebimento>();
            CreateMap<TB007_ReceitaRequestDto, TB007_Receita>();


        }
    }
}
