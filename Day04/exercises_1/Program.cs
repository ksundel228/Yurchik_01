using System;

class Program
{
    static void Main()
    {
        byte x = 200;
        byte y = 200;

        try
        {
            byte result = (byte)(x + y); 
            Console.WriteLine("1: {0}", result); 

            result = checked((byte)(x + y)); 
            Console.WriteLine("2: {0}", result); 
        }
        catch (OverflowException)
        {
            Console.WriteLine("возникло переполнение");
        }
    }
}

//Ответ на вопрос:
//С блоком unchecked переполнение игнорировалось, и результат усекался до значения, которое помещается в диапазон. 
//Убрав unchecked, программа начинает строго контролировать такие ситуации, поэтому работа останавливается при ошибке.