using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFG_3
{
    public partial class Form1 : Form
    {

        public enum Slot
        {
            LeftHand,
            Armor,
            RightHand,
            None,
        }
        public enum Class
        {
            Warrior,
            Ranger,
            Mage,
            None
        }
        public class Page
        {
            public Control[] content;
            public bool enabled;

            public Page()
            {
                content = null;
                enabled = false;
            }
            public Page(Control[] content0)
            {
                enabled = false;
                content = new Control[content0.Length];
                for (int i = 0; i < content0.Length; i++)
                {
                    content[i] = content0[i];
                }
            }

            public void Display()
            {
                if (content != null && enabled == false)
                {
                    enabled = true;
                    for (int i = 0; i < content.Length; i++)
                    {
                        content[i].Visible = true;
                    }
                }
            }

            public void Hide()
            {
                if (content != null && enabled == true)
                {
                    enabled = false;
                    for (int i = 0; i < content.Length; i++)
                    {
                        content[i].Visible = false;
                    }
                }
            }

            public void addElement(Control B)
            {
                B.Visible = false;
                if (content == null)
                {
                    content = new Control[1];
                    content[0] = B;
                }
                else
                {
                    int i;
                    Control[] tmp = new Control[content.Length + 1];
                    for (i = 0; i < content.Length; i++)
                    {
                        tmp[i] = content[i];
                    }
                    tmp[i] = B;
                    content = new Control[tmp.Length];
                    for (int j = 0; j < tmp.Length; j++)
                    {
                        content[j] = tmp[j];
                    }
                }
            }

            public void deleteElement(Control B)
            {
                if (content != null)
                {
                    Control[] tmp = new Control[content.Length - 1];
                    int t = 0;
                    for (int i = 0; i < content.Length; i++)
                    {
                        if (content[i] != B)
                        {
                            tmp[t] = content[i];
                            t++;
                        }
                    }
                }
            }

        }



        public class Skill
        {
            public string name;
            public string event_content;
            public int cooldown;
            public double cost;
            public string info;

            public Skill()
            {
                name = "";
                event_content = "";
                cooldown = 0;
                cost = 0;
                info = "";
            }

            public Skill(string name0, string event_content0, int cooldown0, double cost0, string info0)
            {
                name = name0;
                event_content = event_content0;
                cooldown = cooldown0;
                cost = cost0;
                info = info0;
            }
        }

        public class DamageSkill : Skill
        {
            public double damage;

            public DamageSkill()
            {
                damage = 0;
            }

            public DamageSkill(string name0, string event_content0, int cooldown0, double cost0, string info0, double damage0) : base(name0, event_content0, cooldown0, cost0, info0)
            {
                damage = damage0;
            }
        }

        public class BubbleSkill : Skill
        {
            public int duration;

            public BubbleSkill()
            {
                duration = 0;
            }

            public BubbleSkill(string name0, string event_content0, int cooldown0, double cost0, string info0, int duration0) : base(name0, event_content0, cooldown0, cost0, info0)
            {
                duration = duration0;
            }
        }

        public class DebuffSkill : Skill
        {
            public int duration;

            public DebuffSkill()
            {
                duration = 0;
            }

            public DebuffSkill(string name0, string event_content0, int cooldown0, double cost0, string info0, int duration0) : base(name0, event_content0, cooldown0, cost0, info0)
            {
                duration = duration0;
            }
        }

        public class DmgDebuffSkill : DebuffSkill
        {
            public double damage_per_turn;

            public DmgDebuffSkill()
            {
                damage_per_turn = 0;
            }

            public DmgDebuffSkill(string name0, string event_content0, int cooldown0, double cost0, string info0, int duration0, double damage_per_turn0) : base(name0, event_content0, cooldown0, cost0, info0, duration0)
            {
                damage_per_turn = damage_per_turn0;
            }
        }

        public class ManaBurnDebuffSkill : DebuffSkill
        {
            public double manaburn_per_turn;
            public ManaBurnDebuffSkill()
            {
                manaburn_per_turn = 0;
            }

            public ManaBurnDebuffSkill(string name0, string event_content0, int cooldown0, double cost0, string info0, int duration0, double manaburn_per_turn0) : base(name0, event_content0, cooldown0, cost0, info0, duration0)
            {
                manaburn_per_turn = manaburn_per_turn0;
            }
        }

        public class StunDebuffSkill : DebuffSkill
        {
            public StunDebuffSkill()
            {
            }

            public StunDebuffSkill(string name0, string event_content0, int cooldown0, double cost0, string info0, int duration0) : base(name0, event_content0, cooldown0, cost0, info0, duration0)
            {
            }

        }


        public class Item
        {
            public string name;
            public string img_path;
            public Image img;
            public int skill_count;
            public Skill[] skills;
            public Slot slot;
            public Class Class;

            public Item()
            {
                name = "";
                img_path = "";
                img = null;
                skill_count = 0;
                skills = null;
                Class = Class.None;
            }
            public Item(string name0, string img_path0, Slot slot0, Class Class0)
            {
                name = name0;
                img_path = img_path0;
                img = Image.FromFile(img_path0);
                slot = slot0;
                Class = Class0;
            }

            public void addSkill(Skill S)
            {
                if (skill_count == 0)
                {
                    skills = new Skill[1];
                    skills[0] = S;
                }
                else
                {
                    int i;
                    Skill[] tmp = new Skill[skill_count + 1];
                    for (i = 0; i < skills.Length; i++)
                    {
                        tmp[i] = skills[i];
                    }
                    tmp[i] = S;
                    skills = new Skill[tmp.Length];
                    for (int j = 0; j < tmp.Length; j++)
                    {
                        skills[j] = tmp[j];
                    }
                }
            }
        }




        public class Race
        {
            public string name;
            public double dHP;
            public double dMP;
            public double kHP;
            public double kMP;

            public Race()
            {
                name = "";
                dHP = 0;
                dMP = 0;
                kHP = 1;
                kMP = 1;
            }

            public Race(string name0)
            {
                name = name0;
                if (name0 == "Ogre")
                {
                    kHP = 1;
                    dHP = 50;
                    kMP = 1;
                    dMP = -50;

                }
                else if (name0 == "Human")
                {
                    kHP = 1;
                    dHP = 0;
                    kMP = 1;
                    dMP = 0;
                }
                else if (name0 == "Elf")
                {
                    kHP = 1;
                    dHP = -50;
                    kMP = 1;
                    dMP = 50;
                }
            }
        }

        public class Creature
        {
            public double HP;
            public double MP;
            public int LVL;
            public double DMG;
            public string name;
            public Race race;

            public Creature()
            {
                HP = 0;
                MP = 0;
                LVL = 0;
                DMG = 0;
                name = "";
                race = new Race();
            }

            public Creature(int LVL0, string name0, Race race0)
            {
                race = race0;
                LVL = LVL0;
                HP = 100 * LVL * race.kHP + race.dHP;
                MP = 100 * LVL * race.kMP + race.dMP;
                DMG = 5 * LVL;
                name = name0;

            }
        }

        public class Hero : Creature
        {
            public Class Class;
            public Image icon;
            public Item LeftHand;
            public Item RightHand;
            public Item Armor;

            public Hero()
            {
                Class = Class.None;
                icon = null;
            }

            public Hero(int LVL0, string name0, Race race0, Class Class0) : base(LVL0, name0, race0)
            {
                Class = Class0;
                if (race.name == "Ogre")
                {
                    if (Class == Class.Warrior)
                    {
                        icon = Image.FromFile("C:/Проект/WFG 3 — копия/WFG 3/Resources/OgreWarriorGood.png");
                        LeftHand = Sword;
                        RightHand = Shield;
                        Armor = Acorn;
                    }
                    else if (Class == Class.Ranger)
                    {
                        icon = Image.FromFile("C:/Проект/WFG 3 — копия/WFG 3/Resources/OgreRangerGood.png");
                        LeftHand = Bow;
                        RightHand = PoisonedArrow;
                        Armor = Acorn;
                    }
                    else if (Class == Class.Mage)
                    {
                        icon = Image.FromFile("C:/Проект/WFG 3 — копия/WFG 3/Resources/OgreMageGood.png");
                        LeftHand = Wand;
                        RightHand = FireBall;
                        Armor = Acorn;
                    }
                }
                else if (race.name == "Human")
                {
                    if (Class == Class.Warrior)
                    {
                        icon = Image.FromFile("C:/Проект/WFG 3 — копия/WFG 3/Resources/HumanWarriorGood.png");
                        LeftHand = Sword;
                        RightHand = Shield;
                        Armor = Acorn;
                    }
                    else if (Class == Class.Ranger)
                    {
                        icon = Image.FromFile("C:/Проект/WFG 3 — копия/WFG 3/Resources/HumanRangerGood.png");
                        LeftHand = Bow;
                        RightHand = PoisonedArrow;
                        Armor = Acorn;
                    }
                    else if (Class == Class.Mage)
                    {
                        icon = Image.FromFile("C:/Проект/WFG 3 — копия/WFG 3/Resources/HumanMageGood.png");
                        LeftHand = Wand;
                        RightHand = FireBall;
                        Armor = Acorn;
                    }
                }
                else if (race.name == "Elf")
                {
                    if (Class == Class.Warrior)
                    {
                        icon = Image.FromFile("C:/Проект/WFG 3 — копия/WFG 3/Resources/ElfWarriorGood.png");
                        LeftHand = Sword;
                        RightHand = Shield;
                        Armor = Acorn;
                    }
                    else if (Class == Class.Ranger)
                    {
                        icon = Image.FromFile("C:/Проект/WFG 3 — копия/WFG 3/Resources/ElfRangerGood.png");
                        LeftHand = Bow;
                        RightHand = PoisonedArrow;
                        Armor = Acorn;
                    }
                    else if (Class == Class.Mage)
                    {
                        icon = Image.FromFile("C:/Проект/WFG 3 — копия/WFG 3/Resources/ElfMageGood.png");
                        LeftHand = Wand;
                        RightHand = FireBall;
                        Armor = Acorn;
                    }
                }
            }
        }

        public class Mob : Creature
        {
            public Class Class;
            public Image icon;

            public Mob()
            {
                Class = Class.None;
                icon = null;
            }

            public Mob(int LVL0, string name0, Race race0, Class Class0) : base(LVL0, name0, race0)
            {
                Class = Class0;
                if (race.name == "Ogre")
                {
                    if (Class == Class.Warrior)
                    {
                        icon = Image.FromFile("C:/Проект/WFG 3 — копия/WFG 3/Resources/OgreWarriorBad.png");
                    }
                    else if (Class == Class.Ranger)
                    {
                        icon = Image.FromFile("C:/Проект/WFG 3 — копия/WFG 3/Resources/OgreRangerBad.png");
                    }
                    else if (Class == Class.Mage)
                    {
                        icon = Image.FromFile("C:/Проект/WFG 3 — копия/WFG 3/Resources/OgreMageBad.png");
                    }
                }
                else if (race.name == "Human")
                {
                    if (Class == Class.Warrior)
                    {
                        icon = Image.FromFile("C:/Проект/WFG 3 — копия/WFG 3/Resources/HumanWarriorBad.png");
                    }
                    else if (Class == Class.Ranger)
                    {
                        icon = Image.FromFile("C:/Проект/WFG 3 — копия/WFG 3/Resources/HumanRangerBad.png");
                    }
                    else if (Class == Class.Mage)
                    {
                        icon = Image.FromFile("C:/Проект/WFG 3 — копия/WFG 3/Resources/HumanMageBad.png");
                    }
                }
                else if (race.name == "Elf")
                {
                    if (Class == Class.Warrior)
                    {
                        icon = Image.FromFile("C:/Проект/WFG 3 — копия/WFG 3/Resources/ElfWarriorBad.png");
                    }
                    else if (Class == Class.Ranger)
                    {
                        icon = Image.FromFile("C:/Проект/WFG 3 — копия/WFG 3/Resources/ElfRangerBad.png");
                    }
                    else if (Class == Class.Mage)
                    {
                        icon = Image.FromFile("C:/Проект/WFG 3 — копия/WFG 3/Resources/ElfMageBad.png");
                    }
                }
            }
        }

        //РАССЫ
        static Race Ogre = new Race("Ogre");
        static Race Human = new Race("Human");
        static Race Elf = new Race("Elf");


        //ДЕФОЛТНЫЕ СКИЛЫ
        Skill Sword_Attack = new DamageSkill("Sword_Attack", "", 0, 0, "Weak Attack", 15);
        Skill Bow_Attack = new DamageSkill("Bow_Attack", "", 0, 0, "Weak Attack", 5);
        Skill Wand_Attack = new DamageSkill("Wand_Attack", "", 0, 0, "Weak Attack", 5);
        Skill Acorn_ROFL = new DamageSkill("Acorn_Attack", "", 0, 3, "The weakest attack in the Game", 1);
        Skill Shield_Attack = new StunDebuffSkill("Shield_Attack", "", 10, 20, "Stun your enemy", 2);
        Skill Poisoned_Arrow = new DmgDebuffSkill("Poisoned_Arrow", "", 5, 25, "Posion your enemy", 3, 10);
        Skill FireBallInst = new DamageSkill("FireBall", "", 7, 55, "Damage your enemy", 40);
        Skill FireBallPeriod = new DmgDebuffSkill("FireBall", "", 7, 55, "Fire your enemy", 4, 2);






        //ДЕФОЛТНЫЕ ПРЕДМЕТЫ
        static Item Acorn = new Item("Acorn", "C:/Проект/WFG 3 — копия/WFG 3/Resources/A_AMR_LVL1_Acorn.png", Slot.Armor, Class.None);
        static Item Sword = new Item("Sword", "C:/Проект/WFG 3 — копия/WFG 3/Resources/W_LH_LVL1_Sword.png", Slot.LeftHand, Class.Warrior);
        static Item Shield = new Item("Shield", "C:/Проект/WFG 3 — копия/WFG 3/Resources/W_RH_LVL1_Shield.png", Slot.RightHand, Class.Warrior);
        static Item Bow = new Item("Bow", "C:/Проект/WFG 3 — копия/WFG 3/Resources/R_LH_LVL1_Bow.png", Slot.LeftHand, Class.Ranger);
        static Item PoisonedArrow = new Item("PoisonedArrow", "C:/Проект/WFG 3 — копия/WFG 3/Resources/R_RH_LVL1_PoisonedArrow.png", Slot.RightHand, Class.Ranger);
        static Item Wand = new Item("Wand", "C:/Проект/WFG 3 — копия/WFG 3/Resources/M_LH_LVL1_Wand.png", Slot.LeftHand, Class.Mage);
        static Item FireBall = new Item("FireBall", "C:/Проект/WFG 3 — копия/WFG 3/Resources/M_RH_LVL1_FireBall.png", Slot.RightHand, Class.Mage);





        //НЕДОМОБЫ
        Mob A = new Mob(1, "Urulgharl", Elf, Class.Warrior);


        Hero HERO = new Hero();

        Page MAINMENU = new Page();
        Page CREATEHEROMENU = new Page();
        Page ENTERMENU = new Page();
        Page WARMENU = new Page();


        //СДЕЛАТЬ ИНИЦИАЛИЗАЦИЮ ПРЕДМЕТОВ СКИЛАМИ (СКИЛЫ И ПРЕДМЕТЫ СОЗДАЮТСЯ СВЕРХУ, НО ПРЕДМЕТЫ БЕЗ СКИЛОВ)
        public Form1()
        {
            InitializeComponent();

            Acorn.addSkill(Acorn_ROFL);
            Sword.addSkill(Sword_Attack);
            Shield.addSkill(Shield_Attack);
            Bow.addSkill(Bow_Attack);
            PoisonedArrow.addSkill(Poisoned_Arrow);
            Wand.addSkill(Wand_Attack);
            FireBall.addSkill(FireBallInst);
            FireBall.addSkill(FireBallPeriod);

            MAINMENU.addElement(label1);
            MAINMENU.addElement(panel1);

            CREATEHEROMENU.addElement(label1);
            CREATEHEROMENU.addElement(groupBox1);

            ENTERMENU.addElement(label1);
            ENTERMENU.addElement(enter);

            WARMENU.addElement(enemyinfo_groupBox);
            WARMENU.addElement(roomfloor_label);
            WARMENU.addElement(enemyhp_Bar);
            WARMENU.addElement(enemymp_Bar);
            WARMENU.addElement(hppotion_Panel);
            WARMENU.addElement(hppotion_counter);
            WARMENU.addElement(mppotion_Panel);
            WARMENU.addElement(mppotion_counter);
            WARMENU.addElement(skill1_Panel);
            WARMENU.addElement(skill1_CD);
            WARMENU.addElement(skill2_Panel);
            WARMENU.addElement(skill2_CD);
            WARMENU.addElement(skill3_Panel);
            WARMENU.addElement(skill3_CD);
            WARMENU.addElement(herohp_Bar);
            WARMENU.addElement(heromp_Bar);
            WARMENU.addElement(heroinfo_groupBox);
            WARMENU.addElement(event_label);


            MAINMENU.Display();
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(102, 102, 102);

            using (var soundPlayer = new SoundPlayer(@"C:\Проект\ЦЫК.wav"))
            {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()

            }
        }
        private void button_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(187, 187, 187);
        }
        private void radiobutton_MouseEnter(object sender, EventArgs e)
        {

            using (var soundPlayer = new SoundPlayer(@"C:\Проект\ЦЫК.wav"))
            {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()

            }
        }
        private void radiobutton_MouseLeave(object sender, EventArgs e)
        {
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void start_Click(object sender, EventArgs e)
        {
            MAINMENU.Hide();
            CREATEHEROMENU.Display();
        }

        private void createhero_Click(object sender, EventArgs e)
        {
            if (((warrior).Checked) || ((ranger).Checked) || ((mage).Checked))
            {
                if (((ogre).Checked) || ((human).Checked) || ((elf).Checked))
                {
                    if (namebox.Text != "")
                    {
                        Class Class0 = Class.None;
                        Race race0 = new Race("Ogre");
                        string name0;

                        if ((ogre).Checked)
                        {
                            race0 = new Race("Ogre");
                        }
                        else if ((human).Checked)
                        {
                            race0 = new Race("Human");
                        }
                        else if ((elf).Checked)
                        {
                            race0 = new Race("Elf");
                        }

                        if ((warrior).Checked)
                        {
                            Class0 = Class.Warrior;
                        }
                        else if ((ranger).Checked)
                        {
                            Class0 = Class.Ranger;
                        }
                        else if ((mage).Checked)
                        {
                            Class0 = Class.Mage;
                        }

                        name0 = namebox.Text;

                        HERO = new Hero(1, name0, race0, Class0);

                        CREATEHEROMENU.Hide();
                        ENTERMENU.Display();
                    }
                }
            }
        }

        private async void enter_Click(object sender, EventArgs e)
        {
            enter.Visible = false;

            using (var soundPlayer = new SoundPlayer(@"C:\Проект\backgroundIntro_var3.wav"))
            {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
                soundPlayer.PlayLooping();
            }

            while (label1.Location.Y < 600)
            {
                label1.Location = new Point(label1.Location.X, label1.Location.Y + 1);
                await Task.Delay(15);
            }

            ENTERMENU.Hide();
            MainLoop();
        }

        public void MainLoop()
        {
            //enemyicon_pictureBox.Image = A.icon;
            //enemyname_label.Text = A.name;
            //enemylvl_label.Text = Convert.ToString(A.LVL);
            //enemyhp_Bar.Minimum = 0;
            //enemyhp_Bar.Maximum = Convert.ToInt32(A.HP);
            //enemyhp_Bar.Value = Convert.ToInt32(A.HP);


            //heroicon_pictureBox.Image = HERO.icon;
            //herolvl_label.Text = Convert.ToString(HERO.LVL);
            //heroname_label.Text = HERO.name;
            //skill1_Button.Image = HERO.LeftHand.img;
            //skill2_Button.Image = HERO.Armor.img;
            //skill3_Button.Image = HERO.RightHand.img;
            //herohp_Bar.Minimum = 0;
            //herohp_Bar.Maximum = Convert.ToInt32(A.HP);
            //herohp_Bar.Value = Convert.ToInt32(A.HP);
            //WARMENU.Display();

            while (true)
            {



                WARMENU.Display();

            }


        }

        public void battle_process()
        {

        }

        public void afterbattle_process()
        {

        }
    }
}
