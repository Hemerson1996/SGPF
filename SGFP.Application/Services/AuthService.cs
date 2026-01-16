using Org.BouncyCastle.Crypto.Generators;
using SGFP.Application.DTOs.Request;
using SGFP.Application.DTOs.Response;
using SGFP.Application.Interfaces;
using SGFP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFP.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly ITB001_UsuarioRepository _usuarioRepository;
        private readonly ITokenService _tokenService;

        public AuthService(ITB001_UsuarioRepository usuarioRepository, ITokenService tokenService)
        {
            _usuarioRepository = usuarioRepository;
            _tokenService = tokenService;
        }

        public async Task<LoginResponseDto> LoginAsync(LoginRequestDto dto)
        {
            var usuario = await _usuarioRepository.ObterPorEmail(dto.Email);

            if (usuario == null)
                throw new UnauthorizedAccessException();

            if (!BCrypt.Net.BCrypt.Verify(dto.Senha, usuario.SenhaHash))
                throw new UnauthorizedAccessException();

            var token = _tokenService.GerarToken(usuario);

            return new LoginResponseDto
            {
                Token = token,
                ExpiraEm = DateTime.UtcNow.AddHours(2),
                Role = usuario.Role
            };
        }
    }
}
