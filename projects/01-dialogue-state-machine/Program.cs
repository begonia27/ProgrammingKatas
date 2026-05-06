using System;

public class Program
{
    static int Main(string[] args)
    {
        Console.WriteLine(NodeConfig.GetEntryId(1).StoryText);
        // Console.WriteLine("场景1");
        // Console.WriteLine("放学后，你一个人走出校门。");
        // Console.WriteLine("走到路口时，你像平常一样要选回家的路。");
        // Console.WriteLine();
        // Console.WriteLine("你决定做什么？");
        // Console.WriteLine("1. 走河边小路");
        // Console.WriteLine("2. 走天桥大路");
        int buttonNumber = int.Parse(Console.ReadLine());

        if (buttonNumber == 1) // 1
        {
            Console.WriteLine(NodeConfig.GetEntryId(2).StoryText);
            // Console.WriteLine("你走进河边小路，这里人很少，很安静。");
            // Console.WriteLine("没走多久，你发现前面有两个情况:长椅上放着一个没人拿的书包，草丛里传来小动物的叫声");
            // Console.WriteLine();
            // Console.WriteLine("你决定做什么？");
            // Console.WriteLine("1. 去看长椅上的书包");
            // Console.WriteLine("2. 草丛里传来小动物的叫声");
            buttonNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("场景2");
            if (buttonNumber == 1) // 1-1
            {
                Console.WriteLine(NodeConfig.GetEntryId(4).StoryText);
                // Console.WriteLine("你走过去，发现书包看起来像是学生落下的。");
                // Console.WriteLine("拉链没有拉好，里面露出一本作业本。");
                // Console.WriteLine();
                // Console.WriteLine("你决定做什么？");
                // Console.WriteLine("1. 打开看看是谁的书包");
                // Console.WriteLine("2. 不乱动，直接送去门卫室");
                buttonNumber = int.Parse(Console.ReadLine());

                if (buttonNumber == 1) // 1-1-1
                {
                    Console.WriteLine(NodeConfig.GetEntryId(8).StoryText);
                    // Console.WriteLine("你打开书包，里面有学生证和作业本。");
                    // Console.WriteLine("原来是低一年级学生的书包，作业本第一页还写着班级和名字。");
                    // Console.WriteLine("你直接回学校，把书包交给了门卫。");
                    // Console.WriteLine("没过多久，一个小男生急匆匆跑过来，发现书包真的找回来了，激动得一直道谢。");
                    // Console.WriteLine("你回家虽然晚了点，但觉得今天做了件很不错的事。");
                    // Console.WriteLine();
                }
                else if(buttonNumber == 2) // 1-1-2
                {
                    Console.WriteLine(NodeConfig.GetEntryId(9).StoryText);
                    // Console.WriteLine("你觉得随便翻别人书包不太好，就直接把书包送去了门卫室。");
                    // Console.WriteLine("门卫老师看了一眼，说这个做法很好，他会负责联系老师和学生。");
                    // Console.WriteLine("你离开的时候，刚好看到一个家长急匆匆往学校里赶。");
                    // Console.WriteLine("你猜，他大概就是来找这个书包的。");
                    // Console.WriteLine("你没有多管太多，但事情还是被稳稳当当地解决了。");
                    // Console.WriteLine();
                }
            }
            else if(buttonNumber == 2) // 1-2
            {
                Console.WriteLine(NodeConfig.GetEntryId(5).StoryText);
                // Console.WriteLine("你走近一看，发现草丛里有一只小狗。");
                // Console.WriteLine("它脖子上的牵引绳缠在树枝上，动来动去却挣不开。");
                // Console.WriteLine("你蹲下来，想了想该怎么办。");
                // Console.WriteLine("");
                // Console.WriteLine("你决定做什么？");
                // Console.WriteLine("1. 试着帮它解开绳子");
                // Console.WriteLine("2. 去附近找大人帮忙");
                
                buttonNumber = int.Parse(Console.ReadLine());

                if (buttonNumber == 1) // 1-2-1
                {
                    Console.WriteLine(NodeConfig.GetEntryId(10).StoryText);
                    // Console.WriteLine(" 你小心地靠近，好不容易才把绳子解开。");
                    // Console.WriteLine(" 小狗一开始有点害怕，后来安静下来，还摇了摇尾巴。");
                    // Console.WriteLine(" 这时一个阿姨跑了过来，说这是她家丢的小狗，已经找了很久。");
                    // Console.WriteLine(" 她看到小狗没事，松了一大口气。");
                    // Console.WriteLine();
                }
                else if(buttonNumber == 2) // 1-2-2
                {
                    Console.WriteLine(NodeConfig.GetEntryId(11).StoryText);
                    // Console.WriteLine("你怕自己不会处理，反而让小狗更紧张，就去路边找保安帮忙。");
                    // Console.WriteLine("保安带着工具过来，很快把绳子弄开了。");
                    // Console.WriteLine("没多久，失主也找到了。");
                    // Console.WriteLine("保安夸你做事稳，不乱碰，也知道找人帮忙。");
                    // Console.WriteLine();
                }
            }

        }
        else if(buttonNumber == 2) // 2
        {
            
            Console.WriteLine(NodeConfig.GetEntryId(3).StoryText);
                // Console.WriteLine("天桥这边人多一点，路灯也亮得早。");
                // Console.WriteLine("你刚走上天桥，就看到前面有两个情况：");
                // Console.WriteLine();
                // Console.WriteLine("1. 一个同学蹲在地上找东西");
                // Console.WriteLine("2. 广场边有人在做社团活动");
            buttonNumber = int.Parse(Console.ReadLine());

            if (buttonNumber == 1) // 2-1
            {
                Console.WriteLine(NodeConfig.GetEntryId(6).StoryText);
                // Console.WriteLine("你走过去看了一眼，那个同学急得不行。");
                // Console.WriteLine("他说自己刚才还拿着公交卡，现在突然找不到了。");
                // Console.WriteLine();
                // Console.WriteLine("你决定先做什么？");
                // Console.WriteLine("1. 帮他一起找公交卡");
                // Console.WriteLine("2. 提醒他先翻书包和口袋");
                buttonNumber = int.Parse(Console.ReadLine());

                if (buttonNumber == 1) // 2-1-1
                {
                    Console.WriteLine(NodeConfig.GetEntryId(12).StoryText);
                    // Console.WriteLine("你陪着他在地上、栏杆边、台阶口找了好几遍。");
                    // Console.WriteLine("最后在天桥角落里找到了那张公交卡，应该是他刚才跑快了掉出来的。");
                    // Console.WriteLine("那个同学高兴坏了，一直跟你说谢谢。");
                    // Console.WriteLine("你们还顺路一起走了一段。");
                    // Console.WriteLine();
                }
                else if(buttonNumber == 2) // 2-1-2
                {
                    Console.WriteLine(NodeConfig.GetEntryId(13).StoryText);
                    // Console.WriteLine("你让他先别急，先把书包、校服口袋和作业本夹层都翻一遍。");
                    // Console.WriteLine("结果公交卡根本没丢，只是夹在作业本里了。");
                    // Console.WriteLine("他愣了一下，然后自己都笑了。");
                    // Console.WriteLine("你也松了口气，觉得果然越急越容易乱。");
                    // Console.WriteLine();
                }
            }
            else if(buttonNumber == 2) // 2-2
            {
                Console.WriteLine(NodeConfig.GetEntryId(7).StoryText);
                // Console.WriteLine("广场边围了几个人，原来是学校社团在做展示。");
                // Console.WriteLine("有人在拍照，有人在发传单，看起来挺热闹。");
                // Console.WriteLine("你站在旁边看了几秒。");
                // Console.WriteLine();
                // Console.WriteLine("你决定先做什么？");
                // Console.WriteLine("1. 过去看看他们在做什么");
                // Console.WriteLine("2. 直接绕过去继续回家");
                buttonNumber = int.Parse(Console.ReadLine());

                if (buttonNumber == 1) // 2-2-1
                {
                    Console.WriteLine(NodeConfig.GetEntryId(14).StoryText);
                    // Console.WriteLine("你走过去一问，原来是摄影社在招新。");
                    // Console.WriteLine("他们正好缺个人帮忙举反光板，学长看你站在旁边，就问你愿不愿意试试。");
                    // Console.WriteLine("你帮了十几分钟，气氛还挺轻松。");
                    // Console.WriteLine("临走前，学长递给你一张报名表，说你要是有兴趣，下周可以来看看。");
                    // Console.WriteLine();
                }
                else if(buttonNumber == 2) // 2-2-2
                {
                    Console.WriteLine(NodeConfig.GetEntryId(15).StoryText);
                    // Console.WriteLine("你看了一眼，觉得今天有点累，还是想早点回家。");
                    // Console.WriteLine("于是你背着书包，从人群边上慢慢绕了过去。");
                    // Console.WriteLine("路上风有点凉，街边小店亮起了灯。");
                    // Console.WriteLine("虽然今天什么特别的事都没发生，但你反而觉得这样也挺好。");
                    // Console.WriteLine();
                }
            }
        }

        return 0;
    }
}
