using Alura.ByteBank.Dados.Repositorio;
using Alura.ByteBank.Dominio.Entidades;
using System.Collections.Generic;
using Xunit;

namespace Alura.ByteBank.Infraestrutura.Testes
{
	public class ClienteRepositorioTestes
	{
		[Fact]
		public void TestaObterTodosClientes()
		{
			// Arrange
			var _repositorio = new ClienteRepositorio();

			// Act
			List<Cliente> lista = _repositorio.ObterTodos();

			// Assert
			Assert.NotNull(lista);
			Assert.Equal(3, lista.Count);
		}
	}
}
