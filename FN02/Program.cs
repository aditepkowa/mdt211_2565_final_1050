public class Program
{
    public static void Main(string[] args)
    {
        char vars;  
        string start = "stay01";
        int number = 2;    
        string bools = "false";
        CircularLinkedList<char> character = new CircularLinkedList<char>();
        character.Add('(');
        character.Add(')'); 
        CircularLinkedList<char> Inputchar = new CircularLinkedList<char>();
        do
        {
            vars = Inputcharacter();    
            if (vars == character.Get(0) || vars == character.Get(1) 
            || vars == character.Get(2) || vars == character.Get(3))
               {
                    bools = "true"; 
                    Inputchar.Add(vars);                                                     
                    if (Inputchar.Get(number) == '(' && start == "stay01")  
                    {
                       Console.WriteLine("*****************");
                       Console.WriteLine("Invalid.");
                       Inputchar.Set(0,Inputcharacter());                      
                    }  
                    else if (Inputchar.Get(number-2) == ')' && Inputchar.Get(number-2) == Inputchar.Get(number))  
                    {
                       Console.WriteLine("*****************");
                       Console.WriteLine("Valid.");
                       Inputchar.Remove(number);
                       number--;
                    }      
                    number++;   
                    start = "stay00";                                                                                              
               }             
            else 
            {
                 bools = "false"; 
            }          
                     
        }
        while(bools == "true");
        Console.WriteLine("*****************");
        for (int i = 0;i < Inputchar.GetLength();i++)
        { 
            Console.Write(Inputchar.Get(i));
        }
    }
    static char Inputcharacter()
    {
        Console.WriteLine("*****************");
        Console.Write("Input : ");
        return char.Parse(Console.ReadLine());
    }
    static void InputPostfix(Stack<char> postfix)
    {
        char inputChar;
        while(true)
        {
            inputChar = char.Parse(Console.ReadLine());
            if(inputChar == '?')
            {
                break;
            }
            else
            {
                postfix.Push(inputChar);
            }
        }
    }
}
