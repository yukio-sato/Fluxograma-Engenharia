string resposta;
void frase(string txt, int x)
{
    Console.Clear();
    if (x == 1)
    {
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    }
    else if (x == 2)
    {
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    }
    else if (x == 3)
    {
    Console.ForegroundColor = ConsoleColor.Green;
    }
    txt += "\n";
    for (int i = 0; i < txt.Length; i++)
    {
        Console.Write(txt[i]);
        Thread.Sleep(30);
    }
}
void warn()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Erro, Utilize Somente [S] para Sim ou [N] para Não");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("Pressione qualquer tecla para finalizar.");
    Console.ReadKey();
    Console.Clear();
}
void ajustes()
{
Console.ForegroundColor = ConsoleColor.White;
resposta = Console.ReadLine()!.Trim().Substring(0,1).ToLower();
}
frase("Está se movendo? [S/N]",1);
ajustes();
if (resposta == "s")
{
    frase("Deveria? [S/N]",2);
    ajustes();
    if (resposta == "s")
    {
        frase("Ótimo.",3);
    }
    else if (resposta == "n")
    {
        frase("Use Silver Tape.",3);
    }
    else
    {
        warn();
    }
}
else if (resposta == "n")
{
    frase("Deveria? [S/N]",2);
    ajustes();
    if (resposta == "s")
    {
        frase("Use WD-40.",3);
    }
    else if (resposta == "n")
    {
        frase("Ótimo.",3);
    }
        else
    {
        warn();
    }
}
else
{
    warn();
}
Console.ResetColor();