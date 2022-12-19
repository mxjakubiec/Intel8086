using Intel8086;

class Program
{
    static void Main(string[] args)
    {

        Memory memory = new Memory();
        while (true)
        {
            Console.WriteLine("Press RETURN");
            Console.In.ReadLine();
            Console.Clear();
            Console.Out.WriteLine("Command list:\n\tMOV [AX,BX,CX,DX] [AX,BX,CX,DX]\n\tADD [AX,BX,CX,DX] [value]\n\tAND\n\tQUIT");
            string input = Console.In.ReadLine();
            string[] commands = input.Split(' ');
            if (commands[0].ToLower().Equals("mov"))
            {
                if (memory.MOV(commands[1], commands[2]))
                    continue;
            }else if (commands[0].ToLower().Equals("add"))
            {
                if (memory.ADD(commands[1], commands[2]))
                    continue;
            }else if (commands[0].ToLower().Equals("and"))
            {
                Console.Out.WriteLine("Result: " + memory.AND());
                continue;
            }else if (commands[0].ToLower().Contains("quit"))
                break;
            Console.Out.WriteLine("Wrong input, press ENTER to continue");
        }

    }

}