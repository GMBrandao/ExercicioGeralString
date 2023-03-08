string frase, contrario;
int vogais = 0, consoantes = 0;
Console.WriteLine("Escreva sua string aqui: ");
frase = Console.ReadLine();

Console.WriteLine("\nA string tem " + frase.Length + " caracteres.");
QuantLetras(frase);
Console.WriteLine("A string tem " + vogais + " vogais.");
Console.WriteLine("A string tem " + consoantes + " consoantes.");
Console.WriteLine(Tamanhos(frase));


contrario = Espelhar(frase);
Console.WriteLine("A string ao contrário é:");
Console.WriteLine(contrario);


string Tamanhos(string frase)
{
    char[] aux = frase.ToCharArray();
    string maior = frase.ToUpper();
    string menor = frase.ToLower();
    for (int i  = 0; i < frase.Length; i++)
    {
        if(i % 2 == 0)
            aux[i] = maior[i];
        else
            aux[i] = menor[i];
    }
    string mudatamanho =  new string (aux);
    return mudatamanho;
}

string Espelhar(string normal)
{
    int len = normal.Length;
    char[] chars = new char[normal.Length];

    for (int i = len-1; i >= 0; i--)
    {
        chars[len-i-1] = normal[i];
    }

    string espelhada = new string (chars);
    return espelhada;
}

void QuantLetras(string contagem)
{
    for (int i = 0; i < contagem.Length; i++)
    {
        if (contagem[i] == 'a' || contagem[i] == 'e' || contagem[i] == 'i' || contagem[i] == 'o' || contagem[i] == 'u' ||
            contagem[i] == 'A' || contagem[i] == 'E' || contagem[i] == 'I' || contagem[i] == 'O' || contagem[i] == 'U')
        {
            vogais++;
        }
        else if ((contagem[i] >= 'a' && contagem[i] <= 'z') || (contagem[i] >= 'A' && contagem[i] <= 'Z'))
        {
            consoantes++;
        }
    }
}