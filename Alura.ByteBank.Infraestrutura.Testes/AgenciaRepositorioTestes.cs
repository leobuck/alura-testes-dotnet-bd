using Alura.ByteBank.Dados.Repositorio;
using Alura.ByteBank.Dominio.Interfaces.Repositorios;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Alura.ByteBank.Infraestrutura.Testes
{
	public class AgenciaRepositorioTestes
	{
		private readonly IAgenciaRepositorio _repositorio;

        public AgenciaRepositorioTestes()
        {
			var servico = new ServiceCollection();
			servico.AddTransient<IAgenciaRepositorio, AgenciaRepositorio>();
			var provedor = servico.BuildServiceProvider();
			_repositorio = provedor.GetService<IAgenciaRepositorio>();
		}

		[Fact]
		public void TestaExcecaoConsultaAgenciaPorId()
		{
			// Act
			// Assert
			Assert.Throws<FormatException>(
				() => _repositorio.ObterPorId(33)
			);
		}
    }
}
