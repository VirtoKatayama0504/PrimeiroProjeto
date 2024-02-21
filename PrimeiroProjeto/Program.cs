                                namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome ? ");
            Console.WriteLine("Quantos anos voce tem? ");
            Console.WriteLine("Que Cidade de voce mora? ");
            Console.WriteLine("(DIGITE AS RESPOSTAS EM ORDEM)");

            string nome = Console.ReadLine();
            int idade =  int.Parse(Console.ReadLine());
            string cidade = Console.ReadLine();

            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("idade: {0}", idade);
            Console.WriteLine("Cidade: {0}", cidade);
            Console.WriteLine("Nome: {0}, Idade: {1} anos, Cidade: {2}", nome, idade, cidade);
        }
    }
}
