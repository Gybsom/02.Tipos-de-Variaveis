internal class Program
{
    enum Forma { Redonda, Quadrada, Triangular };

    private static void Main(string[] args)
    {
        Console.WriteLine("Exemplos de variáveis:");

        char meuCaractere = 'A';
        string minhaString = "minhaString é do tipo String";

        int meuInteiro = 1;
        float meuPontoFlutuante = 1f;
        // Double, Decimal
        
        bool meuBooleano = true;

        DateTime minhaDataHora = DateTime.Now;

        DateOnly minhaData = new DateOnly(2023,6,26);

        Console.WriteLine(meuCaractere);
        Console.WriteLine(minhaString);

        Console.WriteLine(meuInteiro);
        Console.WriteLine(meuPontoFlutuante);
        
        Console.WriteLine(meuBooleano);

        Console.WriteLine("Valores concatenados: " + meuCaractere + " e " + meuInteiro);

        Console.WriteLine("--------------");

        Console.WriteLine("Exemplos de constantes:");

        const string MINHA_CONSTANTE = "Esse valor não muda ao longo da execução";
        const float meuFloatConstante = 3.14f;

        Console.WriteLine(MINHA_CONSTANTE);
        Console.WriteLine(meuFloatConstante);

        Console.WriteLine("--------------");

        Forma novaForma = Forma.Triangular;
        Console.WriteLine(novaForma.ToString());

    }
}