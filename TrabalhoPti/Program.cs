namespace TrabalhoPti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(":::SEJA BEM-VINDO(A):::\n");
            Console.WriteLine("Quer ajuda para escolher entre álcool ou gasolina?\n");

            string opcao = "S";
            while(opcao.Equals("S") || opcao.Equals("s")) { 
            Console.Write("Informe o valor do álcool: ");
            double alcool = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor da gasolina: ");
            double gasolina = double.Parse(Console.ReadLine());
            double consumo = alcool / gasolina;

            if (consumo > 0.7)
            {
                Console.WriteLine("Escolha GASOLINA!");
            }
            else if (consumo < 0.7)
            {
                Console.WriteLine("Escolha ALCOOL");
            }
            else
            {
                Console.WriteLine("TANTO FAZ!");
            }
                Console.Write("Deseja realizar outro calculo? (S/N)");
                opcao = Console.ReadLine();
            }

            Console.WriteLine("Boa Viagem!");

        }
    }
}