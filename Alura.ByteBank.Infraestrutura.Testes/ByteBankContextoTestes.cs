using Alura.ByteBank.Dados.Contexto;
using System;
using Xunit;

namespace Alura.ByteBank.Infraestrutura.Testes
{
	public class ByteBankContextoTestes
	{
		[Fact]
		public void TestaConexaoContextoComBDMySql()
		{
			// Arrange
			var contexto = new ByteBankContexto();
			bool conectado;

			// Act
			try
			{
				conectado = contexto.Database.CanConnect();
			}
			catch (Exception ex)
			{
				throw new Exception($"Não foi possível conectar a base de dados. Exceção: {ex.Message}");
			}

			// Assert
			Assert.True(conectado);
		}
	}
}
