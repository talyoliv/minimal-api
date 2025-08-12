using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public class VeiculoTest
{
    [TestMethod]
    public void TestarGetSetPropriedadesVeiculo()
    {
        // Arrange
        var veiculo = new Veiculo();

        //Act
        veiculo.Id = 1;
        veiculo.Nome = "Vectra GLS";
        veiculo.Ano = 2001;

        // Assert
        Assert.AreEqual(1, veiculo.Id);
        Assert.AreEqual("Vectra GLS", veiculo.Nome);
        Assert.AreEqual(2001, veiculo.Ano);
    }
}



