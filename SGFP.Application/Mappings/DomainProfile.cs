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

            CreateMap<TB004_Tipo_Origem_Dinheiro, TB004_Tipo_Origem_DinheiroResponseDto>()
                .ForMember(
                dest => dest.TB003_Categoria_ReceitaResponseDtos,
                opt => opt.MapFrom(src => src.TB003_Categoria_Receita));

            CreateMap<TB005_Recebimento, TB005_RecebimentoResponseDto>();
            CreateMap<TB006_Frequencia, TB006_FrequenciaResponseDto>();
            CreateMap<TB007_Receita, TB007_ReceitaResponseDto>()
                .ForMember(
                dest => dest.TB004_Tipo_Origem_DinheiroResponseDtos,
                opt => opt.MapFrom(src => src.TB004_Tipo_Origem_Dinheiros));
            CreateMap<TB008_Categoria_Despesa, TB008_Categoria_DespesaResponseDtos>();

            CreateMap<TB009_Tipo_Despesa, TB009_Tipo_DespesaResponseDto>()
                .ForMember(
                dest=>dest.TB008_Categoria_DespesaResponseDtos,
                opt=>opt.MapFrom(src=>src.TB008_Categoria_Despesas));

            CreateMap<TB010_Despesa, TB010_DespesaResponseDto>()
              .ForMember(
              dest => dest.TB008_Categoria_DespesaResponseDtos,
              opt => opt.MapFrom(src => src.TB008_Categoria_Despesas))
               .ForMember(
              dest => dest.TB006_FrequenciaResponseDtos,
              opt => opt.MapFrom(src => src.TB006_Frequencia))
                .ForMember(
              dest => dest.TB015_Status_PagamentoResponseDtos,
              opt => opt.MapFrom(src => src.TB015_Status_Pagamento));

            CreateMap<TB011_Categoria_Produto_Compra, TB011_Categoria_Produto_CompraResponseDto>();
            CreateMap<TB012_Unidade_Produto_Compra, TB012_Unidade_Produto_CompraResponseDto>();
            CreateMap<TB013_Item_Produto_Compra, TB013_Item_Produto_CompraResponseDto>()
               .ForMember(
               dest => dest.TB011_Categoria_Produto_CompraResponseDto,
               opt => opt.MapFrom(src => src.TB011_Categoria_Produto_Compras));

            CreateMap<TB014_Item_Compra, TB014_Item_CompraResponseDto>()
                .ForMember(
                dest => dest.TB011_Categoria_Produto_CompraResponseDto,
                opt => opt.MapFrom(src => src.TB011_Categoria_Produto_Compras))
                .ForMember(
                dest => dest.TB012_Unidade_Produto_CompraResponseDto,
                opt => opt.MapFrom(src => src.TB012_Unidade_Produto_Compras))
                .ForMember(
                dest => dest.TB013_Item_Produto_CompraResponseDto,
                opt => opt.MapFrom(src => src.TB013_Item_Produto_Compra));
            CreateMap<TB015_Status_Pagamentos,TB015_Status_PagamentoResponseDto>();


            // DTO → Entity
            //CreateMap<>();
            CreateMap<TB003_Categoria_ReceitaRequestDtos, TB003_Categoria_Receita>();
            CreateMap<TB004_Tipo_Origem_DinheiroRequestDto, TB004_Tipo_Origem_Dinheiro>();
            CreateMap<TB005_RecebimentoRequestDto, TB005_Recebimento>();
            CreateMap<TB006_FrequenciaRequestDto, TB006_Frequencia>();
            CreateMap<TB007_ReceitaRequestDto, TB007_Receita>();
            CreateMap<TB008_Categoria_DespesaRequestDtos, TB008_Categoria_Despesa>();
            CreateMap<TB009_Tipo_DespesaRequestDto, TB009_Tipo_Despesa>();
            CreateMap<TB010_DespesaRequestDto, TB010_Despesa>();
            CreateMap<TB011_Categoria_Produto_CompraRequestDto, TB011_Categoria_Produto_Compra>();
            CreateMap<TB012_Unidade_Produto_CompraResquesDto, TB012_Unidade_Produto_Compra>();
            CreateMap<TB013_Item_Produto_CompraRequestDto, TB013_Item_Produto_Compra>();
            CreateMap<TB014_Item_CompraRequestDto, TB014_Item_Compra>();
            CreateMap<TB015_Status_PagamentoRequestDto, TB015_Status_Pagamentos>();


        }
    }
}
