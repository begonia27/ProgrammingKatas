using _01_dialogue_state_machine;

public class Program
{
    static int Main(string[] args)
    {
        Console.WriteLine(NodeConfig.GetEntryById(1).StoryText);
        Console.WriteLine($"{NodeConfig.GetOptionByIdAndKey(1, 1).OptionId} " + NodeConfig.GetOptionByIdAndKey(1, 1).OptionText);
        Console.WriteLine($"{NodeConfig.GetOptionByIdAndKey(1, 2).OptionId} " + NodeConfig.GetOptionByIdAndKey(1, 2).OptionText);

        int buttonNumber = int.Parse(Console.ReadLine());

        if (buttonNumber == 1) // 1
        {
            Console.WriteLine(NodeConfig.GetEntryById(2).StoryText);
            Console.WriteLine($"{NodeConfig.GetOptionByIdAndKey(2, 1).OptionId} " + NodeConfig.GetOptionByIdAndKey(2, 1).OptionText);
            Console.WriteLine($"{NodeConfig.GetOptionByIdAndKey(2, 2).OptionId} " + NodeConfig.GetOptionByIdAndKey(2, 2).OptionText);
            buttonNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("场景2");
            if (buttonNumber == 1) // 1-1
            {
                Console.WriteLine(NodeConfig.GetEntryById(4).StoryText);
                Console.WriteLine($"{NodeConfig.GetOptionByIdAndKey(4, 1).OptionId} " + NodeConfig.GetOptionByIdAndKey(4, 1).OptionText);
                Console.WriteLine($"{NodeConfig.GetOptionByIdAndKey(4, 2).OptionId} " + NodeConfig.GetOptionByIdAndKey(4, 2).OptionText);
                buttonNumber = int.Parse(Console.ReadLine());

                if (buttonNumber == 1) // 1-1-1
                {
                    Console.WriteLine(NodeConfig.GetEntryById(8).StoryText);
                }
                else if(buttonNumber == 2) // 1-1-2
                {
                    Console.WriteLine(NodeConfig.GetEntryById(9).StoryText);
                }
            }
            else if(buttonNumber == 2) // 1-2
            {
                Console.WriteLine(NodeConfig.GetEntryById(5).StoryText);
                Console.WriteLine($"{NodeConfig.GetOptionByIdAndKey(5, 1).OptionId} " + NodeConfig.GetOptionByIdAndKey(5, 1).OptionText);
                Console.WriteLine($"{NodeConfig.GetOptionByIdAndKey(5, 2).OptionId} " + NodeConfig.GetOptionByIdAndKey(5, 2).OptionText);
                buttonNumber = int.Parse(Console.ReadLine());

                if (buttonNumber == 1) // 1-2-1
                {
                    Console.WriteLine(NodeConfig.GetEntryById(10).StoryText);
                }
                else if(buttonNumber == 2) // 1-2-2
                {
                    Console.WriteLine(NodeConfig.GetEntryById(11).StoryText);
                }
            }

        }
        else if(buttonNumber == 2) // 2
        {

            Console.WriteLine(NodeConfig.GetEntryById(3).StoryText);
            Console.WriteLine($"{NodeConfig.GetOptionByIdAndKey(3, 1).OptionId} " + NodeConfig.GetOptionByIdAndKey(3, 1).OptionText);
            Console.WriteLine($"{NodeConfig.GetOptionByIdAndKey(3, 2).OptionId} " + NodeConfig.GetOptionByIdAndKey(3, 2).OptionText);
            buttonNumber = int.Parse(Console.ReadLine());

            if (buttonNumber == 1) // 2-1
            {
                Console.WriteLine(NodeConfig.GetEntryById(6).StoryText);
                Console.WriteLine($"{NodeConfig.GetOptionByIdAndKey(6, 1).OptionId} " + NodeConfig.GetOptionByIdAndKey(6, 1).OptionText);
                Console.WriteLine($"{NodeConfig.GetOptionByIdAndKey(6, 2).OptionId} " + NodeConfig.GetOptionByIdAndKey(6, 2).OptionText);
                buttonNumber = int.Parse(Console.ReadLine());

                if (buttonNumber == 1) // 2-1-1
                {
                    Console.WriteLine(NodeConfig.GetEntryById(12).StoryText);
                }
                else if(buttonNumber == 2) // 2-1-2
                {
                    Console.WriteLine(NodeConfig.GetEntryById(13).StoryText);
                }
            }
            else if(buttonNumber == 2) // 2-2
            {
                Console.WriteLine(NodeConfig.GetEntryById(7).StoryText);
                Console.WriteLine($"{NodeConfig.GetOptionByIdAndKey(7, 1).OptionId} " + NodeConfig.GetOptionByIdAndKey(7, 1).OptionText);
                Console.WriteLine($"{NodeConfig.GetOptionByIdAndKey(7, 2).OptionId} " + NodeConfig.GetOptionByIdAndKey(7, 2).OptionText);
                buttonNumber = int.Parse(Console.ReadLine());

                if (buttonNumber == 1) // 2-2-1
                {
                    Console.WriteLine(NodeConfig.GetEntryById(14).StoryText);
                }
                else if(buttonNumber == 2) // 2-2-2
                {
                    Console.WriteLine(NodeConfig.GetEntryById(15).StoryText);
                }
            }
        }

        return 0;
    }
}
