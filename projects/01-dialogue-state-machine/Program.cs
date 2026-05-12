using _01_dialogue_state_machine;

public class Program
{
    static int Main(string[] args)
    {
        Console.WriteLine(NodeConfig.GetEntryId(1).StoryText);
        int buttonNumber = int.Parse(Console.ReadLine());

        if (buttonNumber == 1) // 1
        {
            Console.WriteLine(NodeConfig.GetEntryId(2).StoryText);
            buttonNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("场景2");
            if (buttonNumber == 1) // 1-1
            {
                Console.WriteLine(NodeConfig.GetEntryId(4).StoryText);
                buttonNumber = int.Parse(Console.ReadLine());

                if (buttonNumber == 1) // 1-1-1
                {
                    Console.WriteLine(NodeConfig.GetEntryId(8).StoryText);
                }
                else if(buttonNumber == 2) // 1-1-2
                {
                    Console.WriteLine(NodeConfig.GetEntryId(9).StoryText);
                }
            }
            else if(buttonNumber == 2) // 1-2
            {
                Console.WriteLine(NodeConfig.GetEntryId(5).StoryText);
                buttonNumber = int.Parse(Console.ReadLine());

                if (buttonNumber == 1) // 1-2-1
                {
                    Console.WriteLine(NodeConfig.GetEntryId(10).StoryText);
                }
                else if(buttonNumber == 2) // 1-2-2
                {
                    Console.WriteLine(NodeConfig.GetEntryId(11).StoryText);
                }
            }

        }
        else if(buttonNumber == 2) // 2
        {

            Console.WriteLine(NodeConfig.GetEntryId(3).StoryText);
            buttonNumber = int.Parse(Console.ReadLine());

            if (buttonNumber == 1) // 2-1
            {
                Console.WriteLine(NodeConfig.GetEntryId(6).StoryText);
                buttonNumber = int.Parse(Console.ReadLine());

                if (buttonNumber == 1) // 2-1-1
                {
                    Console.WriteLine(NodeConfig.GetEntryId(12).StoryText);
                }
                else if(buttonNumber == 2) // 2-1-2
                {
                    Console.WriteLine(NodeConfig.GetEntryId(13).StoryText);
                }
            }
            else if(buttonNumber == 2) // 2-2
            {
                Console.WriteLine(NodeConfig.GetEntryId(7).StoryText);
                buttonNumber = int.Parse(Console.ReadLine());

                if (buttonNumber == 1) // 2-2-1
                {
                    Console.WriteLine(NodeConfig.GetEntryId(14).StoryText);
                }
                else if(buttonNumber == 2) // 2-2-2
                {
                    Console.WriteLine(NodeConfig.GetEntryId(15).StoryText);
                }
            }
        }

        return 0;
    }
}
