//EXERCICIO 1
int indice = 13, soma = 0, k=0;
while (k < indice)
{
    k++;
    soma = soma+k;
}
Console.WriteLine(soma);
//resultado:91

//------------------------------------------------------------------------------------------------------------------

//EXERCICIO 2
int valor;
Console.WriteLine("Digite um valor:");
valor = Convert.ToInt32(Console.ReadLine());
CalcularValor(valor);
void CalcularValor(int val)
{
    int anterior1 = 0,anterior2=1,atual,i=0;
    while( i == 0)
    {
        atual = anterior1+anterior2;
        if(atual!= val)
        {
            anterior1 = anterior2;
            anterior2 = atual;
            Console.WriteLine($"{anterior1}+{anterior2} = {anterior1+anterior2}");
        }
        if(atual > val){
            Console.WriteLine("O numero NÃO pertence a sequência de Fibonacci");
            i = 1;
        }
        else if(atual == val)
        {
            Console.WriteLine("O numero pertence a sequência de Fibonacci");
            i=1;
        }
            
    }
    
    
}

//---------------------------------------------------------

//EXERCICIO 3
/*Descubra a lógica e complete o próximo elemento:



a) 1, 3, 5, 7, 9

b) 2, 4, 8, 16, 32, 64, 129

c) 0, 1, 4, 9, 16, 25, 36, 49

d) 4, 16, 36, 64, 100

e) 1, 1, 2, 3, 5, 8, 13

f) 2,10, 12, 16, 17, 18, 19, 20
*/

//EXERCICIO 4
/* Eu ligaria o interruptor 1 e deixaria ligado por um tempo
    em seguida eu desligaria e ligaria o interruptor 2
    entraria na sala A-assim gastando minha primeira volta naquela sala
    caso a lampada esteja quente significa que o interruptor 1 a controla, se ela estiver fria o interruptor 3, e se estiver acessa é o 2
    agora eu repetiria esse processo para a outra lampada.*/

//--------------------------------------------------------------------------------------

//EXERCICIO 5
string palavra;
Console.WriteLine("Digite a palavra");
palavra = Console.ReadLine();

char[] chars = palavra.ToCharArray();
for (int i=0, j=chars.Length - 1; i < j; i++, j--)
    {
        char charTemp = chars[i];
        chars[i] = chars[j];
        chars[j] = charTemp;
    }
Console.WriteLine(chars);