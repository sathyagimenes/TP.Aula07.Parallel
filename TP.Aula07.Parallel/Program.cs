using System.Linq;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        //// Questão 1
        ////Criar um aplicativo que simule uma chamada à uma API. Utilize
        ////Sleep para definir o tempo de 2 segundos para uma chamada. Utilizando
        ////paralelismo (for ou foreach), execute essa chamada 100 vezes utilizando no
        ////máximo 7 threads. Exiba uma mensagem de finalização ao terminar cada chamada.
        ////Exiba o tempo gasto para toda a operação em segundos.


        //static void ChamarAPI()
        //{
        //    Console.WriteLine($"Chamando API... (Thread: {Thread.CurrentThread.ManagedThreadId})");
        //    Thread.Sleep(2000);
        //    Console.WriteLine("Chamada concluida");
        //}

        //ParallelOptions option = new ParallelOptions();
        //option.MaxDegreeOfParallelism = 7;

        //Stopwatch stopwatch = new();
        //stopwatch.Start();

        //Parallel.For(0, 100, i =>
        //{
        //    ChamarAPI();
        //});

        //stopwatch.Stop();
        //Console.WriteLine($"Tempo total: {stopwatch.ElapsedMilliseconds} msegundos"); 

        //-------------------------------------------------------------------------
        // Questão 2
        //Criar um aplicativo que possua 3 métodos:
        // AcertarBaseDeDados
        // EnviarEmail
        // LimparArquivosTemporarios
        //Cada método terá seu tempo de execução definido por Sleep(no máximo 4 segundos).
        //Faça com que os 3 métodos sejam executados em paralelo.Utilize um quarto método
        //que fará a execução dos demais e faça com que ele espere um parâmetro onde será
        //informada a quantidade de threads a serem utilizadas na execução. Exiba do tempo
        //gasto em milissegundos.

        void AcertarBaseDeDados()
        {
            Console.WriteLine("Acertando base de dados...");
            Thread.Sleep(1000);
        }
        void EnviarEmail()
        {
            Console.WriteLine("Enviando e-mail...");
            Thread.Sleep(1500);
        }
        void LimparArquivosTemporarios()
        {
            Console.WriteLine("Limpando arquivos temporários...");
            Thread.Sleep(1500);
        }

        Stopwatch stopwatch = new();
        stopwatch.Start();

        ParallelOptions option = new ParallelOptions();

        void ExecutarFuncao(int maxThread)
        {
            option.MaxDegreeOfParallelism = maxThread;
            Parallel.Invoke(option, () => AcertarBaseDeDados(),
                                    () => EnviarEmail(),
                                    () => LimparArquivosTemporarios());
        }

        Console.WriteLine("Qual a quantidade de Threads a serem utilizadas?");
        int maxThread = Convert.ToInt32(Console.ReadLine());
        ExecutarFuncao(maxThread);

        stopwatch.Stop();
        Console.WriteLine($"Tempo total: {stopwatch.ElapsedMilliseconds} msegundos"); 
    }
}
