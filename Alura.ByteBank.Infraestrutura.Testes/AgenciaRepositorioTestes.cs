using Alura.ByteBank.Dados.Repositorio;
using Alura.ByteBank.Dominio.Entidades;
using Alura.ByteBank.Dominio.Interfaces.Repositorios;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
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
		public void TestaObterTodasAgencias()
		{
			// Arrange
			// Act
			List<Agencia> lista = _repositorio.ObterTodos();

			// Assert
			Assert.NotNull(lista);
		}

		[Fact]
		public void TestaObterAgenciaPorId()
		{
			// Arrange
			// Act
			var agencia = _repositorio.ObterPorId(1);

			// Assert
			Assert.NotNull(agencia);
		}

		[Theory]
		[InlineData(1)]
		[InlineData(2)]
		public void TestaObterAgenciasPorVariosId(int id)
		{
			// Arrange
			// Act
			var agencia = _repositorio.ObterPorId(id);

			// Assert
			Assert.NotNull(agencia);
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

		[Fact]
		public void TestaInsereUmaNovaAgenciaNoBancoDeDados()
		{
			// Arrange
			var agencia = new Agencia()
			{
				Numero = 568,
				Nome = "Agencia Paulista",
				Endereco = "Avenida Paulista, 123",
				Identificador = Guid.NewGuid(),
			};

			// Act
			var retorno = _repositorio.Adicionar(agencia);

			// Assert
			Assert.True(retorno);
		}

		[Fact]
		public void TestaRemoverDeterminadaAgencia()
		{
			// Arrange
			// Act
			var removido = _repositorio.Excluir(3);

			// Assert
			Assert.True(removido);
		}
	}
}
