using Amazon.Lambda.SQSEvents;
using Amazon.Lambda.TestUtilities;
using ECommerceLambda.Domain.Models;
using System.Text.Json;

namespace AprovarPedidoLambda.Testes
{
    public class FunctionTest
    {
        [Fact]
        public async void Deve_salvar_um_pedido_com_sucesso()
        {

            var pedido = new Pedido
            {
                Cliente = new Cliente
                {
                    Nome = "Carlos",
                    Documento = "12145478799",
                    Email = "carlos@hotmail.com",
                    Endereco = new Endereco
                    {
                        Cidade = "São paulo",
                        Estado = "SP",
                        Logradouro = "Rua Palmeiras",
                        Numero = 123,
                        Complemento = "apt 123"
                    }
                },
                PedidoId = new Guid(),
                StatusPedido = StatusPedidoEnum.AGUARDANDO_PAGAMENTO,
                ItensPedido = new List<ItemPedido>
                {
                    new ItemPedido
                    {
                        ProdutoId = 1,
                        Quantidade = 2,
                        ValorUnitario = 50
                    }
                }
            };

            var input = new SQSEvent
            {
                Records = new List<SQSEvent.SQSMessage>
                {
                    new SQSEvent.SQSMessage
                    {
                        Body = JsonSerializer.Serialize(pedido)
                    }
                }
            };

            var context = new TestLambdaContext
            {
                Logger = new TestLambdaLogger()
            };



            var function = new Function();
            await function.FunctionHandler(input, context);

            //assert
        }
    }
}