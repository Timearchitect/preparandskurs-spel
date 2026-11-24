class Datatyper
{

    public static void Main(string[] args)
    {
        short halfNumber = 32767;               // -32767      ->  32767
        int number = 2147483647;                // -2147483647 -> 2147483647
        long bigNumber = 9223372036854775807;   // -9223372036854775807 -> 9223372036854775807

        byte color = 255;                       // 0 ->  255
        ushort halfNumberPositive = 65535;      // 0 ->  65535
        uint positiveNumber = 4294967295;       // 0 -> 1.84467440737e+19
        ulong positiveBigNumber = 18446744073709551615;  // 0 -> 18446744073709551615

        float decimalNumber = 0.77767F;
        double decimalBigNumber = 0.1231d;
        decimal decimalVerybigNumber = 0.234m;


        System.Console.WriteLine(" aaaa " + number + " bbb ");
        //string interpolering (injekterar in i värden mellan string inuti {})
        System.Console.WriteLine($" aaaa {number} bbb ");

        //character (char)
        char c = '#';
        char c2 = '3';

        //string  
        string tom = "";  // tom text
        string text = "hello";
        
        string text2 = """Hon sa "hello"!  C:\Users\Alrik\Documents """;
        string text2b = "Hon sa \"hello\"!  C:\\Users\\Alrik\\Documents ";
        string text3 = @" text 
        med 
        radbrytningar !!! ";
        string text4 = "abc \n defg \t hijk"; // andra escape escape tecken


        Console.WriteLine(text);
        Console.WriteLine(text2);
        Console.WriteLine(text3);
        Console.WriteLine(text4);

        //Casting (converter datatyper)

        int x = 25;
        Console.WriteLine(x + "");   // konkatinerar
        Console.WriteLine(25.ToString()); // en metod som converterar


        int i;
        float flyt = 4.5f;
        i = (int)flyt;
        Console.WriteLine(i);



        string s = "hej";
        char a;
         a = s.ToCharArray()[0]; // första bokstaven


        // Boolean
        bool cool = true; 

    }
}
