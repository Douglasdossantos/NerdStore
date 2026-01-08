using NerdStore.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace NerdStore.Catalago.Domain.tests
{
    public class ProdutoTests
    {
        [Fact(DisplayName = "Testeproduto")]
        public void Produto_ValidacoesDevemRetornarExceptions()
        {
            // Arrange

            var ex = Assert.Throws<DomainException>(() => 
            new Produto(string.Empty,"Descricao",true, 1, Guid.NewGuid(), DateTime.Today,"sfsafsfs",new Dimensoes(2,2,2)));

            Assert.Equal("O campo nome do produto não pode estar vazio", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
                 new Produto("Nome",string.Empty, true, 1, Guid.NewGuid(), DateTime.Today, "sfsafsfs", new Dimensoes(2, 2, 2)));

            Assert.Equal("O campo descrição do produto não pode estar vazio", ex.Message);

        }
    }
}
