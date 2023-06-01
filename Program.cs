namespace lista
{

    class Program
    {
        static void Main(string[] args)
        {
            //exercício 1
            Lista lista = new();
            lista.inserirInicio(30);
            lista.inserirInicio(19);
            lista.inserirInicio(8);
            lista.inserirFim(12);
            
            lista.percurso();

            lista.removerInicio();
            lista.removerFim();
            
            lista.percurso();
            // fim do exercício 1
            System.Console.WriteLine("---");
            System.Console.WriteLine("---");
            System.Console.WriteLine("---");
            //  exercício 2

            Funcionario lista2 = new Funcionario();
            lista2.inserirInicio("João Pedro", 15, "3927382783", 1300.0);
            lista2.inserirInicio("Yan Andrade", 15, "263726377272", 1500.00);
            lista2.inserirInicio("Kayk", 15, "263726377272", 1500.00);
            lista2.inserirFim("Adryan", 15, "36262762672", 1500.0);
            lista2.inserirFim("Diogo", 15, "4382738728738", 1300.0);

            lista2.percurso();
            lista2.consultaNome("Yan Andrade", lista2);

            lista2.removerFim();
            lista2.removerInicio();
            lista2.percurso();

            lista2.impressao();
            // fim do exercício 2
            System.Console.WriteLine("---");
            System.Console.WriteLine("---");
            System.Console.WriteLine("---");
            //  exercício 3

            ListaAssunto lista3 = new ListaAssunto();

            lista3.inserirInicio("Engenheiro", 6, 200, "Gabiroba");
            lista3.inserirInicio("Pedreiro", 6, 200, "Gabiroba");
            lista3.inserirInicio("Professor", 6, 200, "Gabiroba");
            lista3.inserirInicio("Garipeiro", 6, 200, "Gabiroba");
            lista3.inserirInicio("Babá", 6, 200, "Gabiroba");
            lista3.impressao();
            lista3.consultaNome("Engenheiro", lista3);

            // fim do exercício 3
            


        }
    }
}