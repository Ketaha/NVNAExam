var array = new Stack<int>(Enumerable.Range(0, Convert.ToInt32(Console.ReadLine())).Select(i => i++).ToArray());

var arraySumSquared = array.Sum() * array.Sum();

var squareSum = 0;
while(array.Any()) squareSum += array.Peek() * array.Pop();

Console.WriteLine(arraySumSquared - squareSum);
