//Используя конструкции блокировки, создайте метод, который будет в цикле for (допустим, на 10 итераций) увеличивать счетчик на единицу и выводить на экран счетчик и текущий поток. 
//Метод запускается в трех потоках. Каждый поток должен выполниться поочередно, т.е. в результате на экран должны выводиться числа (значения счетчика) с 1 до 30 по порядку, а не в произвольном порядке.

int count = 0;

var th1 = new Thread(Counter);
var th2 = new Thread(Counter);
var th3 = new Thread(Counter);

th1.Start(); th1.Join();
th2.Start(); th2.Join();
th3.Start(); th3.Join();

void Counter()
{
    for (int i = 0; i < 10; i++)
        Console.WriteLine("count = " + ++count + " Thread - " + Thread.GetCurrentProcessorId());
}