using System.Linq.Expressions;

class Demo2
{
    public static void Main(String[] args)
    {

        //datatyper
        byte b = 255;        // 0           -> 255
        short s = 32767;     // -32767      ->  32767  
        int i = 2147483647;  // -2147483647 -> 2147483647
        long l = 9223372036854775807;   // -9223372036854775807 -> 9223372036854775807

        float f = 0.04F;
        double d = 0.233;    //default   utan bokstav 
        decimal m = 0.32534662374263742m;

        char c = '/';  //character 
        string str = " hello ";

        System.Console.WriteLine(c);
        System.Console.WriteLine(str);
        int age = 50;
        System.Console.WriteLine("Alrik är: " + age + " år"); //konkatination

        System.Console.WriteLine($"Alrik är: {age} år"); //string interpolering

        string text1 = "  han sa \"hello\"! C:\\Users\\Alrik\\Desktop\\bingo.png  \n asda\tsd sa "; //altGr  +  +
        string text2 = """  han sa "hello"! C:\Users\Alrik\Desktop\bingo.png    asdasdasd """; //altGr  +  +
        string text3 =
@"
   __O__
     |
     |
    /\
   /  \ ";

        System.Console.WriteLine(text1);
        System.Console.WriteLine(text2);
        System.Console.WriteLine(text3);

        //konvertera datatyp 
        int nummer;
        double decimalTal = 2.5;
        nummer = (int)decimalTal;


        System.Console.WriteLine(nummer);
        decimalTal = 5;
        System.Console.WriteLine(decimalTal);

        int tal = 13;
        string namn = "Alrik";
        namn = "Felix";

        //int  ->  string
        namn = "" + tal;
        namn = tal.ToString(); // inbyggd metod som finns i allt nästan
        System.Console.WriteLine(namn);

        //boolean -> string

        bool cool = true; // false/true endast
        System.Console.WriteLine("Is Alrik cool ?  " + cool);

        String text5 = "hejsan";
        text5 = cool.ToString();
        System.Console.WriteLine(text5);


        //  string -> int
        string randomText = " 8   ";
        int on;
        on = int.Parse(randomText);  //* lite 
        System.Console.WriteLine(on);
        /* 

        Block kommentar

        cdfdsfsdfdsfa
        dsffsdfasfdfds
        asdfasfd
        asdfrfasdf

         */

    }
}