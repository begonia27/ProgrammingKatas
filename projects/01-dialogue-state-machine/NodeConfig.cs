using System;

public static class NodeConfig
{
    public static int CurrentNodeId;
    public static string ContentText;
    private static List<OptionEntry> Steps = new List<OptionEntry>()
    {
        new OptionEntry {EntryId = 1, StoryText = "场景1\n放学后，你一个人走出校门。\n走到路口时，你像平常一样要选回家的路。\n\n你决定做什么？\n1. 走河边小路\n2. 走天桥大路"},
        new OptionEntry {EntryId = 2, StoryText = "你走进河边小路，这里人很少，很安静。\n没走多久，你发现前面有两个情况:长椅上放着一个没人拿的书包，草丛里传来小动物的叫声\n\n你决定做什么？\n\n1. 去看长椅上的书包\n2. 草丛里传来小动物的叫声"},
        new OptionEntry {EntryId = 3, StoryText = "天桥这边人多一点，路灯也亮得早。\n你刚走上天桥，就看到前面有两个情况：\n\n1. 一个同学蹲在地上找东西\n2. 广场边有人在做社团活动"},
        new OptionEntry {EntryId = 4, StoryText = "你走过去，发现书包看起来像是学生落下的。\n拉链没有拉好，里面露出一本作业本。\n\n你决定做什么？\n1. 打开看看是谁的书包\n2. 不乱动，直接送去门卫室"},
        new OptionEntry {EntryId = 5, StoryText = "你走近一看，发现草丛里有一只小狗。\n它脖子上的牵引绳缠在树枝上，动来动去却挣不开。\n你蹲下来，想了想该怎么办。\n\n你决定做什么？\n1. 试着帮它解开绳子\n2. 去附近找大人帮忙"},
        new OptionEntry {EntryId = 6, StoryText = "你走过去看了一眼，那个同学急得不行。\n他说自己刚才还拿着公交卡，现在突然找不到了。\n\n你决定先做什么？\n1. 帮他一起找公交卡\n2. 提醒他先翻书包和口袋"},
        new OptionEntry {EntryId = 7, StoryText = "广场边围了几个人，原来是学校社团在做展示。\n有人在拍照，有人在发传单，看起来挺热闹。\n你站在旁边看了几秒。\n\n你决定先做什么？\n1. 过去看看他们在做什么\n2. 直接绕过去继续回家"},
        new OptionEntry {EntryId = 8, StoryText = "你打开书包，里面有学生证和作业本。\n原来是低一年级学生的书包，作业本第一页还写着班级和名字。\n你直接回学校，把书包交给了门卫。\n没过多久，一个小男生急匆匆跑过来，发现书包真的找回来了，激动得一直道谢。\n你回家虽然晚了点，但觉得今天做了件很不错的事。\n\n"},
        new OptionEntry {EntryId = 9, StoryText = "你觉得随便翻别人书包不太好，就直接把书包送去了门卫室。\n门卫老师看了一眼，说这个做法很好，他会负责联系老师和学生。\n你离开的时候，刚好看到一个家长急匆匆往学校里赶。\n你猜，他大概就是来找这个书包的。\n你没有多管太多，但事情还是被稳稳当当地解决了。\n\n"},
        new OptionEntry {EntryId = 10, StoryText = "你小心地靠近，好不容易才把绳子解开。\n小狗一开始有点害怕，后来安静下来，还摇了摇尾巴。\n这时一个阿姨跑了过来，说这是她家丢的小狗，已经找了很久。\n她看到小狗没事，松了一大口气。\n\n"},
        new OptionEntry {EntryId = 11, StoryText = "你怕自己不会处理，反而让小狗更紧张，就去路边找保安帮忙。\n保安带着工具过来，很快把绳子弄开了。\n没多久，失主也找到了。\n保安夸你做事稳，不乱碰，也知道找人帮忙。\n\n"},
        new OptionEntry {EntryId = 12, StoryText = "你陪着他在地上、栏杆边、台阶口找了好几遍。\n最后在天桥角落里找到了那张公交卡，应该是他刚才跑快了掉出来的。\n那个同学高兴坏了，一直跟你说谢谢。\n你们还顺路一起走了一段。\n\n"},
        new OptionEntry {EntryId = 13, StoryText = "你让他先别急，先把书包、校服口袋和作业本夹层都翻一遍。\n结果公交卡根本没丢，只是夹在作业本里了。\n他愣了一下，然后自己都笑了。\n你也松了口气，觉得果然越急越容易乱。\n\n"},
        new OptionEntry {EntryId = 14, StoryText = "你走过去一问，原来是摄影社在招新。\n他们正好缺个人帮忙举反光板，学长看你站在旁边，就问你愿不愿意试试。\n你帮了十几分钟，气氛还挺轻松。\n临走前，学长递给你一张报名表，说你要是有兴趣，下周可以来看看。\n\n"},
        new OptionEntry {EntryId = 15, StoryText = "你看了一眼，觉得今天有点累，还是想早点回家。\n于是你背着书包，从人群边上慢慢绕了过去。\n路上风有点凉，街边小店亮起了灯。\n虽然今天什么特别的事都没发生，但你反而觉得这样也挺好。\n\n"},
    };

    public static OptionEntry GetEntryId(int id)
    {
        for (int i = 0; i < Steps.Count-1; i++)
        {
            if (id == Steps[i].EntryId)
            {
                return Steps[i];
            }

        }

        return null;
    }
}
