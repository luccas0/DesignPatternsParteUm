using CursoDesignPatterns.Modulo1;
using CursoDesignPatterns.Modulo1.Desafio1;
using CursoDesignPatterns.Modulo2;
using CursoDesignPatterns.Modulo3;
using CursoDesignPatterns.Modulo3.Desafio1;
using CursoDesignPatterns.Modulo4;
using CursoDesignPatterns.Modulo6;

namespace CursoDesignPatterns
{

    class Program
    {
        static void Main(string[] args)
        {

            Orcamento orcamento = new Orcamento(500.0);

            orcamento.AdicionaItem(new Item("CANETA", 250.0));
            orcamento.AdicionaItem(new Item("LAPIS", 250.0));

            Console.WriteLine("Valor do orçamento: " + orcamento.Valor);

            #region Desafios Strategy

            Orcamento reforma = new Orcamento(500.0);

            Imposto novoImposto = new ICCC();
            Console.WriteLine("Calculo do ICCC: " + novoImposto.Calcula(reforma));

            #endregion

            #region Desafios Responsability

            CalculadorDeDescontos calculador = new CalculadorDeDescontos();
            double desconto = calculador.Calcula(orcamento);

            Console.WriteLine("Calculo do desconto: " +desconto);
            #endregion

            #region Desafios Template

            TemplateDeImpostoCondicional icpp = new ICPP();
            TemplateDeImpostoCondicional ikcv = new IKCV();

            Console.WriteLine("Calculo do ICPP: " + icpp.Calcula(orcamento));
            Console.WriteLine("Calculo do IKCV: " + ikcv.Calcula(orcamento));

            #endregion

            #region Desafios Decorator

            Imposto impostos = new ImpostoMuitoAlto(new IHIT());

            Console.WriteLine("Calculo do imposto alto: " + impostos.Calcula(orcamento));

            #endregion

            #region Desafios State

            orcamento.AplicaDescontoExtra();
            Console.WriteLine(orcamento.Valor);
            orcamento.Aprova();

            orcamento.AplicaDescontoExtra();
            Console.WriteLine(orcamento.Valor);

            orcamento.Finaliza();

            #endregion

            #region Desafios Builder

            ItemDaNota inf1 = new ItemDaNotaBuilder()
                                    .ComValor(100.0)
                                    .ComNome("Item1")
                                    .Constroi();

            ItemDaNota inf2 = new ItemDaNotaBuilder()
                                    .ComValor(200.0)
                                    .ComNome("Item2")
                                    .Constroi();

            NotaFiscal nf = new NotaFiscalBuilder().ParaEmpresa("ExemploEmpresa")
                                      .ComCnpj("123.456.789/0000-00")
                                      .ComItem(inf1)
                                      .ComItem(inf2)
                                      .ComItem(new ItemDaNota("item 3", 300.0))
                                      .ComObservacoes("Exemplo de observação")
                                      .Constroi();

            Console.WriteLine(nf.Itens.Count);

            #endregion

            #region Desafios Observer

            //NotaFiscalBuilder builder = new NotaFiscalBuilderModificada();

            //NotaFiscal nf = new NotaFiscalBuilder().ParaEmpresa("ExemploEmpresa")
            //                          .ComCnpj("123.456.789/0000-00")
            //                          .ComItem(new ItemDaNota("Item 1", 100.00))
            //                          .ComItem(new ItemDaNota("Item 2", 200.00))
            //                          .ComItem(new ItemDaNota("item 3", 300.0))
            //                          .ComObservacoes("Exemplo de observação")
            //                          .Constroi();

            #endregion
        }
    }
}





