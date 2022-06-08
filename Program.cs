var array = new Stack<int>();

for (int i = 0; i < Convert.ToInt32(Console.ReadLine()); i++) array.Push(i + 1);
var arraySumSquared = array.Sum() * array.Sum();

var squareSum = 0;
while(array.Any()) squareSum += array.Peek() * array.Pop();

Console.WriteLine(arraySumSquared - squareSum);