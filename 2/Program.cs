//Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int S = 0;
Sum(M,N,S);
void Sum(int M, int N, int S){
    if (M>N){
        Console.Write(S);
        return;
    }
    else{
        S=S+M;
        M=M+1;
        Sum(M,N,S);

    }
}