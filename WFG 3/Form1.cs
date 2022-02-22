﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
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
            HPPotion,
            MPPotion,
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

        public class HealSkill : Skill
        {
            public double HP_Heal;
            public double MP_Heal;

            public HealSkill()
            {
                HP_Heal = 0;
                MP_Heal = 0;
            }
            public HealSkill(string name0, string event_content0, int cooldown0, double cost0, string info0, double HP_Heal0, double MP_Heal0):base(name0, event_content0, cooldown0, cost0, info0)
            {
                HP_Heal = HP_Heal0;
                MP_Heal = MP_Heal0;
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
            public int LVL;

            public Item()
            {
                name = "";
                img_path = "";
                img = null;
                skill_count = 0;
                skills = null;
                Class = Class.None;
                LVL = 0;
            }
            public Item(string name0, string img_path0, Slot slot0, Class Class0, int LVL0)
            {
                name = name0;
                img_path = img_path0;
                img = Image.FromFile(img_path0);
                slot = slot0;
                Class = Class0;
                LVL = LVL0;
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

        public class Potion : Item
        {
            public double heal_HP;
            public double heal_MP;

            public Potion()
            {
                heal_HP = 0;
                heal_MP = 0;
            }

            public Potion(string name0, string img_path0, Slot slot0, Class Class0, int LVL0, double heal_HP0, double heal_MP0) : base(name0, img_path0, slot0, Class0, LVL0)
            {
                heal_HP = heal_HP0;
                heal_MP = heal_MP0;
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
            public int HealPotionCounter;
            public Item Heal_Potion;
            public int ManaPotionCounter;
            public Item Mana_Potion;


            public Hero()
            {
                Class = Class.None;
                icon = null;
                HealPotionCounter = 0;
                ManaPotionCounter = 0;
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

                HealPotionCounter = 3;
                Heal_Potion = HealPotion;
                ManaPotionCounter = 3;
                Mana_Potion = ManaPotion;
            }
        }

        public class Mob : Creature
        {
            public Class Class;
            public Image icon;
            public Item LeftHand;
            public Item Armor;
            public Item RightHand;

            public Mob()
            {
                Class = Class.None;
                icon = null;
                LeftHand = null;
                Armor = null;
                RightHand = null;

            }

            public Mob(int LVL0, string name0, Race race0, Class Class0, Item LeftHand0, Item Armor0, Item RightHand0) : base(LVL0, name0, race0)
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
                LeftHand = LeftHand0;
                Armor = Armor0;
                RightHand = RightHand0;
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
        Skill Shield_Attack = new DamageSkill("Shield_Attack", "", 2, 20, "Attack your enemy by shield", 20);
        Skill Poisoned_Arrow = new DamageSkill("Poisoned_Arrow", "", 5, 25, "Posion your enemy", 3);
        Skill FireBall_Attack = new DamageSkill("FireBall", "", 7, 55, "Damage your enemy", 40);
        Skill Heal1 = new HealSkill("Heal", "", 3, 0, "Heal your hero", 50, 0);
        Skill Mana1 = new HealSkill("Heal", "", 3, 0, "Restore Mana", 0, 50);






        //ДЕФОЛТНЫЕ ПРЕДМЕТЫ
        static Item Acorn = new Item("Acorn", "C:/Проект/WFG 3 — копия/WFG 3/Resources/A_AMR_LVL1_Acorn.png", Slot.Armor, Class.None, 1);
        static Item Sword = new Item("Sword", "C:/Проект/WFG 3 — копия/WFG 3/Resources/W_LH_LVL1_Sword.png", Slot.LeftHand, Class.Warrior, 1);
        static Item Shield = new Item("Shield", "C:/Проект/WFG 3 — копия/WFG 3/Resources/W_RH_LVL1_Shield.png", Slot.RightHand, Class.Warrior, 1);
        static Item Bow = new Item("Bow", "C:/Проект/WFG 3 — копия/WFG 3/Resources/R_LH_LVL1_Bow.png", Slot.LeftHand, Class.Ranger, 1);
        static Item PoisonedArrow = new Item("PoisonedArrow", "C:/Проект/WFG 3 — копия/WFG 3/Resources/R_RH_LVL1_PoisonedArrow.png", Slot.RightHand, Class.Ranger, 1);
        static Item Wand = new Item("Wand", "C:/Проект/WFG 3 — копия/WFG 3/Resources/M_LH_LVL1_Wand.png", Slot.LeftHand, Class.Mage, 1);
        static Item FireBall = new Item("FireBall", "C:/Проект/WFG 3 — копия/WFG 3/Resources/M_RH_LVL1_FireBall.png", Slot.RightHand, Class.Mage, 1);

        //ХИЛКИ
        static Item HealPotion = new Potion("Heal Potion", "C:/Проект/WFG 3 — копия/WFG 3/Resources/A_HPP_LVL1_HealPotion.png", Slot.HPPotion, Class.None, 1, 50, 0);
        static Item ManaPotion = new Potion("Heal Potion", "C:/Проект/WFG 3 — копия/WFG 3/Resources/A_MPP_LVL1_ManaPotion.png", Slot.MPPotion, Class.None, 1,  0, 50);


        //НЕДОМОБЫ
        Mob A = new Mob(1, "Urulgharl", Elf, Class.Warrior, Sword, Acorn, Shield);
        Mob B = new Mob(1, "PIZDA", Ogre, Class.Mage, Wand, Acorn, FireBall);

        public int turn = 0;

        Hero HERO0 = new Hero();

        Hero hero = new Hero();
        Mob enemy = new Mob();

        Page MAINMENU = new Page();
        Page CREATEHEROMENU = new Page();
        Page ENTERMENU = new Page();
        Page WARMENU = new Page();


        public int cur_floor;
        public int cur_room;

        public bool ISDEAD = false;

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
            FireBall.addSkill(FireBall_Attack);
            HealPotion.addSkill(Heal1);
            ManaPotion.addSkill(Mana1);


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
            WARMENU.addElement(herohp_label);
            WARMENU.addElement(heromp_label);
            WARMENU.addElement(enemyhp_label);
            WARMENU.addElement(enemymp_label);

            cur_floor = 1;
            cur_room = 1;



            MAINMENU.Display();
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(102, 102, 102);

            using (var soundPlayer = new SoundPlayer(@"C:/Проект/WFG 3 — копия/WFG 3/Resources/ЦЫК.wav"))
            {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
            }
        }
        private void button_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(187, 187, 187);
        }
        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            using (var soundPlayer = new SoundPlayer(@"C:/Проект/WFG 3 — копия/WFG 3/Resources/buttonclick.wav"))
            {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
            }
        }
        private void radiobutton_MouseEnter(object sender, EventArgs e)
        {
            ((RadioButton)sender).BackColor = Color.FromArgb(102, 102, 102);
            using (var soundPlayer = new SoundPlayer(@"C:/Проект/WFG 3 — копия/WFG 3/Resources/ЦЫК.wav"))
            {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
            }
        }
        private void radiobutton_MouseLeave(object sender, EventArgs e)
        {
            ((RadioButton)sender).BackColor = Color.FromArgb(187, 187, 187);
        }
        private void namebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            using (var soundPlayer = new SoundPlayer(@"C:/Проект/WFG 3 — копия/WFG 3/Resources/buttonclick.wav"))
            {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
            }
        }


        private void skillbutton_Pressed(object sender, EventArgs e)
        {
            if (turn%2 == 0)
            {
                if (((Button)sender).Name == "skill1_Button")
                {
                    label2.Text = hero.LeftHand.name;
                }
                else if (((Button)sender).Name == "skill2_Button")
                {
                    label2.Text = hero.Armor.name;
                }
                else if (((Button)sender).Name == "skill3_Button")
                {
                    label2.Text = hero.RightHand.name;
                }
                else if (((Button)sender).Name == "hppotion_Button")
                {
                    label2.Text = hero.Heal_Potion.name;
                }
                else if (((Button)sender).Name == "mppotion_Button")
                {
                    label2.Text = hero.Mana_Potion.name;
                }
                //turn++;
            }
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

                        HERO0 = new Hero(1, name0, race0, Class0);

                        CREATEHEROMENU.Hide();
                        ENTERMENU.Display();
                    }
                }
            }
        }

        private async void enter_Click(object sender, EventArgs e)
        {
            enter.Visible = false;

            using (var soundPlayer = new SoundPlayer(@"C:/Проект/WFG 3 — копия/WFG 3/Resources/backgroundIntro_var3.wav"))
            {
                soundPlayer.Play();
                soundPlayer.PlayLooping();
            }

            //while (label1.Location.Y < 600)
            //{
            //    label1.Location = new Point(label1.Location.X, label1.Location.Y + 1);
            //    await Task.Delay(15);
            //}

            ENTERMENU.Hide();

            enemy = A;
            hero = HERO0;

            battle();
        }

        public void battle()
        {
            roomfloor_label.Text = "FLOOR " + Convert.ToString(cur_floor) + "-" + Convert.ToString(cur_room) + " ROOM";

            enemyicon_pictureBox.Image = enemy.icon;
            enemyname_label.Text = enemy.name;
            enemylvl_label.Text = Convert.ToString(enemy.LVL);
            enemyhp_Bar.Value = 100;
            enemymp_Bar.Value = 100;
            enemyhp_label.Text = "Health: " + Convert.ToString(enemy.HP) + "/" + Convert.ToString(enemy.HP);
            enemymp_label.Text = "Mana: " + Convert.ToString(enemy.MP) + "/" + Convert.ToString(enemy.MP);


            heroicon_pictureBox.Image = hero.icon;
            heroname_label.Text = hero.name;
            herolvl_label.Text = Convert.ToString(hero.LVL);
            herohp_Bar.Value = 100;
            heromp_Bar.Value = 100;
            skill1_Button.Image = hero.LeftHand.img;
            skill2_Button.Image = hero.Armor.img;
            skill3_Button.Image = hero.RightHand.img;
            hppotion_Button.BackgroundImage = hero.Heal_Potion.img;
            mppotion_Button.BackgroundImage = hero.Mana_Potion.img;
            hppotion_counter.Text = Convert.ToString(hero.HealPotionCounter);
            mppotion_counter.Text = Convert.ToString(hero.ManaPotionCounter);
            herohp_label.Text = "Health: " + Convert.ToString(hero.HP) + "/" + Convert.ToString(HERO0.HP);
            heromp_label.Text = "Mana: " + Convert.ToString(hero.MP) + "/" + Convert.ToString(HERO0.MP);

            WARMENU.Display();
        }
    }
}
