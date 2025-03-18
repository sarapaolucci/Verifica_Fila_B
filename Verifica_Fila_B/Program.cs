
//ESERCIZIO A
Random random = new Random();
void popolaTemperature(int [,] m)
{
    for(int i = 0; i < m.GetLength(0); i++)
    {
        for(int j = 0; j < m.GetLength(1); j++)
        {
            if( i == 0)
            {
                m[i, j] = random.Next(-10, 36);
            }
            else if( i == 1)
            {
                m[i, j] = 0;
            }
        }
    }
}
void stampamatrice(int [,] m)
{
    for(int i = 0; i < m.GetLength(0); i++)
    {
        for(int j = 0; j < m.GetLength(1); j++)
        {
            Console.Write("[" + m[i, j] + "]\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


//ESERCIZIO B
void mediaprogressiva(int [,] m)
{
    int somma = 0;
    int n = 0;
    for(int i = 0; i < m.GetLength(0); i++)
    {
        for(int j = 0; j < m.GetLength (1); j++)
        {
            if (i == 1)
            {
               for(int k = 0; k <= j; k++)
               {
                  somma = somma + m[0, k];
                    n++;
               }
                m[i, j] = somma / n;
            }
            somma = 0;
            n = 0;
        }
    }
}

int temperaturamassima(int [,] m)
{
    int nmax = -100;
    for(int i = 0; i < m.GetLength(0); i++)
    {
        for ( int j = 0; j < m.GetLength (1); j++)
        {
            if (m[i, j] > nmax)
            {
                nmax = m[i, j];
            }
        }
    }
    return nmax;
}

//ESERCIZIO C

string completaa(string parola)
{
    string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    for (int i = 0; i < alfabeto.Length; i++)
    {
       if(parola.Contains(alfabeto[i]) != true)
       {
            parola = parola + alfabeto[i];
       }
    }
    return parola;
}

//ESERCIZIO D
bool verifica(string stringa)
{
    string cifre = "1234567890";
    for(int i = 0; i < cifre.Length; i++)
    {
        int n = 0;
        for ( int j = 0; j < stringa.Length; j++)
        {
            if(stringa[j] == cifre[i])
            {
                n++;
            }
        }
        if( n > 1)
        {
            return false;
        }
    }
    return true;
}

//ESERCIZIO A
int[,] temp = new int[2, 12];
popolaTemperature(temp);
stampamatrice(temp);

//ESERCIZIO B
mediaprogressiva(temp);
stampamatrice(temp);
Console.WriteLine("La temperatura massima dell'anno è " + temperaturamassima(temp));

//ESERCIZIO C
string parola = "ILMATNOHRBC";
Console.WriteLine(completaa(parola));

//ESERCIZIO D
string stringa = "124678923";
Console.WriteLine(verifica(stringa));
