//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Arc(N, M));
int Arc(int N, int M)
{
  if (N == 0)
  {
    return M + 1;}
  else{
    if ((N != 0) && (M == 0)){
      return Arc(N - 1, 1);}
    else{
      return Arc(N - 1, Arc(N, M - 1));}}
}