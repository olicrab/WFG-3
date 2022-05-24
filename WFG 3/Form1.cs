using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
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


        public class Item
        {
            public string name;
            public string img_path;
            public Image img;
            public Slot slot;
            public Class Class;
            public int LVL;
            public double mpcost;
            public int CD;
            public string caption = "";
            public Item()
            {
                name = "";
                img_path = "";
                img = null;
                Class = Class.None;
                LVL = 0;
                mpcost = 0;
                CD = 0;
            }
            public Item(string name0, string img_path0, Slot slot0, Class Class0, int LVL0, double mpcost0, int CD0)
            {
                name = name0;
                img_path = img_path0;
                img = Image.FromFile(img_path0);
                slot = slot0;
                Class = Class0;
                LVL = LVL0;
                mpcost = mpcost0;
                CD = CD0;

                caption = "Name: \"" + name + "\"\nSlot: " + slot.ToString() + "\nClass: " + Class.ToString() + "\nLevel: " + LVL.ToString() + "\nMana cost: " + mpcost.ToString() + "\nCooldown: " + CD.ToString();
            }

            public string convToStr()
            {
                string res = "";
                res += "\"" + name + "\" SLOT:" + slot.ToString() + " CLASS:" + Class.ToString() + " LVL:" + LVL.ToString() + " MPCOST:" + mpcost.ToString() + " CD:" + CD.ToString();
                return res;
            }

            public static string createCaptionByItem(Item Itm, Creature C)
            {
                if (Itm is HealPotionItem)
                {
                    return Itm.caption + "\nHeals by '" + ((HealPotionItem)Itm).heal.ToString() + "' points.";
                }
                else if (Itm is HealItem)
                {
                    return Itm.caption + "\nHeals by '" + ((HealItem)Itm).heal.ToString() + "*" + C.PWR.ToString() + "' = '" + (((HealItem)Itm).heal * C.PWR) + "' points.";
                }
                else if (Itm is DamageItem)
                {
                    return Itm.caption + "\nDeals '" + ((DamageItem)Itm).dmg.ToString() + "*" + C.PWR.ToString() + "' = '" + (((DamageItem)Itm).dmg * C.PWR) + "' damage.";
                }
                
                //вставлять сюда описание для классов наследников класса Item

                else
                {
                    return "";
                }
            }



            //переделать
            public static string createEventByItem(Item Itm, Creature Object, Creature Victim)
            {
                if (Itm is HealPotionItem)
                {
                    return "\""+Object.name + "\" use \"" + Itm.name + "\", and healed yourself by '" + ((HealPotionItem)Itm).heal.ToString() + "' points.";
                }
                else if (Itm is HealItem)
                {
                    return "\""+Object.name + "\" use \"" + Itm.name + "\", and healed yourself by '" + (((HealItem)Itm).heal * Object.PWR).ToString() + "' points.";
                }
                else if (Itm is DamageItem)
                {
                    return "\""+Object.name + "\" use \"" + Itm.name + "\", and dealt '" + (((DamageItem)Itm).dmg * Object.PWR).ToString() + "' damage to \"" + Victim.name + "\".";
                }
                else
                {
                    return "";
                }
            }
        }

        public class HealItem : Item
        {
            public double heal;

            public HealItem()
            {
                heal = 0;
            }
            public HealItem(string name0, string img_path0, Slot slot0, Class Class0, int LVL0, double mpcost0, int CD0, double heal0) : base(name0, img_path0, slot0, Class0, LVL0, mpcost0, CD0)
            {
                heal = heal0;
            }

        }
        public class DamageItem : Item
        {
            public double dmg;

            public DamageItem()
            {
                dmg = 0;
            }
            public DamageItem(string name0, string img_path0, Slot slot0, Class Class0, int LVL0, double mpcost0, int CD0, double dmg0) : base(name0, img_path0, slot0, Class0, LVL0, mpcost0, CD0)
            {
                dmg = dmg0;
            }
        }
        public class HealPotionItem : HealItem
        {
            public HealPotionItem(string name0, string img_path0, Slot slot0, Class Class0, int LVL0, double mpcost0, int CD0, double heal0) : base(name0, img_path0, slot0, Class0, LVL0, mpcost0, CD0, heal0)
            {

            }
        }

        public class ItemList
        {
            public List<Item> L;
            public int Length;

            public ItemList()
            {
                L = new List<Item>();
                Length = 0;
            }
            public ItemList(int len)
            {
                L = new List<Item>(len);
                Length = len;
            }

            public void Add(Item item)
            {
                L.Add(item);
                Length++;
            }
            public void Del(Item item)
            {
                if (L.Contains(item))
                {
                    L.Remove(item);
                    Length--;
                }
            }

            public ItemList ExtractBySlot(Slot s)
            {
                ItemList res = new ItemList();
                foreach (Item a in L)
                {
                    if (a.slot == s)
                    {
                        res.Add(a);
                    }
                }
                return res;
            }

            public ItemList ExtractByLvl(int lvl)
            {
                ItemList res = new ItemList();
                foreach (Item a in L)
                {
                    if (a.LVL == lvl)
                    {
                        res.Add(a);
                    }
                }
                return res;
            }

            public ItemList ExtractByLessLvl(int lvl)
            {
                ItemList res = new ItemList();
                foreach (Item a in L)
                {
                    if (a.LVL <= lvl)
                    {
                        res.Add(a);
                    }
                }
                return res;
            }

            public ItemList ExtractByClass(Class C)
            {
                ItemList res = new ItemList();
                foreach (Item a in L)
                {
                    if (a.Class == C || a.Class == Class.None)
                    {
                        res.Add(a);
                    }
                }
                return res;
            }

            public ItemList ExtractByTypeName(string TypeName)
            {
                ItemList res = new ItemList();
                foreach (Item a in L)
                {
                    if (a.ToString() == TypeName)
                    {
                        res.Add(a);
                    }
                }
                return res;
            }

            public Item GetRndItem()
            {
                Random R = new Random();
                return L[R.Next(0, Length)];
            }

            public string convToStr()
            {
                string res = "";
                foreach (Item a in L)
                {
                    res += a.convToStr();
                    res += '\n';
                }
                return res;
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
                    kHP = 1.5;
                    dHP = 50;
                    kMP = 1.2;
                    dMP = -20;

                }
                else if (name0 == "Human")
                {
                    kHP = 1.75;
                    dHP = 0;
                    kMP = 1.75;
                    dMP = 0;
                }
                else if (name0 == "Elf")
                {
                    kHP = 1.2;
                    dHP = -20;
                    kMP = 1.5;
                    dMP = 50;
                }
            }

            public static Race GetRandom()
            {
                int seed = Root.Next(0, 3);
                switch (seed)
                {
                    case 0:
                        return new Race("Ogre");
                    case 1:
                        return new Race("Human");
                    case 2:
                        return new Race("Elf");
                    default:
                        return new Race();
                }
            }

            public override string ToString()
            {
                return name;
            }
        }

        public class Creature
        {
            public double HP;
            public double MP;
            public double max_HP;
            public double max_MP;
            public int MP_Reg;
            public int LVL;
            public int EXP;
            public double PWR;
            public string name;
            public Race race;

            public Creature()
            {
                HP = 0;
                MP = 0;
                max_HP = 0;
                max_MP = 0;
                LVL = 0;
                PWR = 0;
                name = "";
                race = new Race();
            }

            public Creature(int LVL0, string name0, Race race0)
            {
                race = race0;
                LVL = LVL0;
                max_HP = 100 * LVL * race.kHP + race.dHP;
                max_MP = 100 * LVL * race.kMP + race.dMP;
                HP = max_HP;
                MP = max_MP;

                MP_Reg = LVL * 5;

                EXP = 0;
                PWR = 5 * (LVL + (EXP / (Math.Pow(2, LVL - 1) * 100)));
                name = name0;

            }

            public void updateStats()
            {
                max_HP = 100 * LVL * race.kHP + race.dHP;
                max_MP = 100 * LVL * race.kMP + race.dMP;
                HP = max_HP;
                MP = max_MP;

                MP_Reg = LVL * 5;

                PWR = 5 * (LVL+(EXP / (Math.Pow(2, LVL - 1) * 100)));
            }

            public void RegenerateMana()
            {
                if (MP + MP_Reg < max_MP)
                {
                    MP += MP_Reg;
                }
                else
                {
                    MP = max_MP;
                }
            }

            public void AddEXP(int dEXP)
            {
                if (EXP + dEXP < Math.Pow(2, LVL - 1) * 100)
                {
                    EXP += dEXP;
                }
                else if (EXP + dEXP > Math.Pow(2, LVL - 1) * 100)
                {
                    LVL++;
                    dEXP += EXP;
                    EXP = 0;
                    AddEXP(Convert.ToInt32(dEXP - Math.Pow(2, LVL - 2) * 100));
                }
                else
                {
                    LVL++;
                    EXP = 0;
                }
                updateStats();
            }

            public double GetPercentForNextLvl()
            {
                return (EXP / (Math.Pow(2, LVL-1) * 100)) * 100;
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

            public Hero()
            {
                Class = Class.None;
                icon = null;
                HealPotionCounter = 0;
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
            }

            public void Equip(Item itm)
            {
                if ((itm.Class == Class || itm.Class == Class.None) && itm.LVL <= LVL)
                {
                    switch (itm.slot)
                    {
                        case Slot.LeftHand:
                            LeftHand = itm;
                            break;
                        case Slot.Armor:
                            Armor = itm;
                            break;
                        case Slot.RightHand:
                            RightHand = itm;
                            break;
                    }
                }
            }

            public Item GetItemBySlot(Slot S)
            {
                switch (S)
                {
                    case Slot.LeftHand:
                        return LeftHand;
                    case Slot.Armor:
                        return Armor;
                    case Slot.RightHand:
                        return RightHand;
                    case Slot.HPPotion:
                        return Heal_Potion;
                    default:
                        return null;
                }
            }

            public string convToStr()
            {
                return "Name: \"" + name + "\"\nHealth: " + max_HP + "\nMana: " + max_MP +
                    "\nLevel: " + LVL + "\nXP: " + EXP + "\\" + Math.Pow(2, LVL-1)*100 + "\nPower: " + PWR + "\nRace: " + race.ToString() + "\nClass: " + Class;
            }
        }

        public class Mob : Creature
        {
            public Class Class;
            public Image icon;
            public Item LeftHand;
            public Item Armor;
            public Item RightHand;
            public int HealPotionCounter;
            public Item Heal_Potion;

            public Mob()
            {
                Class = Class.None;
                icon = null;
                LeftHand = null;
                Armor = null;
                RightHand = null;
                HealPotionCounter = 1;
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
                HealPotionCounter = Root.Next(0,3);
                Heal_Potion = HealPotion;
            }

            public static Mob randGen(int LVL0)
            {
                Class C;
                Race R = Race.GetRandom();

                //вставить реализацию рандомной генерации моба через списки с вещами
                //рандомно задавать EXP

                int seed = Root.Next(0, 3);

                switch(seed)
                {
                    case 0:
                        C = Class.Warrior;
                        break;
                    case 1:
                        C = Class.Ranger;
                        break;
                    case 2:
                        C = Class.Mage;
                        break;
                    default:
                        C = Class.None;
                        break;
                }

                Item LeftHand0 = all_items.ExtractByClass(C).ExtractByLessLvl(LVL0).ExtractBySlot(Slot.LeftHand).GetRndItem();
                Item Armor0 = all_items.ExtractByClass(C).ExtractByLessLvl(LVL0).ExtractBySlot(Slot.Armor).GetRndItem();
                Item RightHand0 = all_items.ExtractByClass(C).ExtractByLessLvl(LVL0).ExtractBySlot(Slot.RightHand).GetRndItem();
                Mob Res = new Mob(LVL0, "asd", R, C, LeftHand0, Armor0, RightHand0);
                Res.EXP = Root.Next(0, Convert.ToInt32(Math.Pow(2, LVL0-1) * 100));
           //случайная генерация имен \/
                return Res;
            }

            public string convToStr()
            {
                return "Name: \"" + name + "\"\nHealth: " + max_HP + "\nMana: " + max_MP +
                    "\nLevel: " + LVL + "\nXP: " + EXP + "\\" + Math.Pow(2, LVL - 1) * 100 + "\nPower: " + PWR + "\nRace: " + race.ToString() + "\nClass: " + Class;
            }
        }


        //РАССЫ
        static Race Ogre = new Race("Ogre");
        static Race Human = new Race("Human");
        static Race Elf = new Race("Elf");

        public static ItemList all_items = new ItemList();






        //ВСЕ ПРЕДМЕТЫ ЗАСОВЫВАТЬ В СПИСОК
        //ДЕФОЛТНЫЕ ПРЕДМЕТЫ
        //добавить нагрудники 1-го уровня
        //сделать желудь пасхалкой
        static DamageItem Acorn = new DamageItem("Acorn", "C:/Проект/WFG 3 — копия/WFG 3/Resources/A_AMR_LVL1_Acorn.png", Slot.Armor, Class.None, 1, 0, 0, 1000);
        static DamageItem trash = new DamageItem("trash", "C:/Проект/WFG 3 — копия/WFG 3/Resources/A_AMR_LVL1_Acorn.png", Slot.Armor, Class.None, 1, 0, 0, 0);





        #region WEAPONS



        #region WAR

        #region LVL1
        static DamageItem Sword = new DamageItem("Sword", "C:/Проект/WFG 3 — копия/WFG 3/Resources/W_LH_LVL1_Sword.png", Slot.LeftHand, Class.Warrior, 1, 5, 1, 2);
        static DamageItem BroadSword = new DamageItem("Broad sword", "C:/Проект/WFG 3 — копия/WFG 3/Resources/W_LH_LVL1_BroadSword.png", Slot.LeftHand, Class.Warrior, 1, 10, 2, 2.5);
        static DamageItem Shield = new DamageItem("Shield", "C:/Проект/WFG 3 — копия/WFG 3/Resources/W_RH_LVL1_Shield.png", Slot.RightHand, Class.Warrior, 1, 20, 4, 4);
        static HealItem Bracer = new HealItem("Bracer", "C:/Проект/WFG 3 — копия/WFG 3/Resources/W_RH_LVL1_Bracer.png", Slot.RightHand, Class.Warrior, 1, 30, 4, 3);
        #endregion
        
        #region LVL2
        #endregion

        #endregion

        #region RANGER

        #region LVL1
        static DamageItem Bow = new DamageItem("Bow", "C:/Проект/WFG 3 — копия/WFG 3/Resources/R_LH_LVL1_Bow.png", Slot.LeftHand, Class.Ranger, 1, 15, 1, 3);
        static DamageItem PoisonedArrow = new DamageItem("Poisoned Arrow", "C:/Проект/WFG 3 — копия/WFG 3/Resources/R_RH_LVL1_PoisonedArrow.png", Slot.RightHand, Class.Ranger, 1, 20, 3, 6);
        #endregion

        #region LVL2
        #endregion

        #endregion

        #region MAGE

        #region LVL1
        static DamageItem Wand = new DamageItem("Wand", "C:/Проект/WFG 3 — копия/WFG 3/Resources/M_LH_LVL1_Wand.png", Slot.LeftHand, Class.Mage, 1, 15, 2, 2.5);
        static DamageItem FireBall = new DamageItem("Fire Ball", "C:/Проект/WFG 3 — копия/WFG 3/Resources/M_RH_LVL1_FireBall.png", Slot.RightHand, Class.Mage, 1, 40, 6, 8);
        #endregion

        #region LVL2
        #endregion

        #endregion



        #endregion




        //ХИЛКИ
        static HealPotionItem HealPotion = new HealPotionItem("Heal Potion", "C:/Проект/WFG 3 — копия/WFG 3/Resources/A_HPP_LVL1_HealPotion.png", Slot.HPPotion, Class.None, 1, 0, 0, 50);




        public Item REWARD = new Item();

        Hero HERO = new Hero();
        Mob ENEMY = new Mob();

        Page MAINMENU = new Page();
        Page CREATEHEROMENU = new Page();
        Page ENTERMENU = new Page();
        Page WARMENU = new Page();
        Page REWARDPAGE = new Page();

        public ToolTip TTtemplate = new ToolTip();

        public int enemyTurnTimeCounter = 0;
        public int enemyTurnCouldown = 8;

        public int herowinTimeCounter = 0;
        public int herowinCouldown = 20;

        public int afterbattleTimeCounter = 0;
        public int afterbattleCouldown = 25;

        public bool is_turn = true;
        public bool is_win = false;
        public bool is_lose = false;

        public bool is_choose_reward = false;

        public int cur_floor;
        public int cur_room;

        public static Random Root = new Random();
        public Form1()
        {
            InitializeComponent();

            all_items.Add(Acorn);
            all_items.Add(Sword);
            all_items.Add(Shield);
            all_items.Add(Bow);
            all_items.Add(PoisonedArrow);
            all_items.Add(Wand);
            all_items.Add(FireBall);
            all_items.Add(HealPotion);
            all_items.Add(Bracer);
            all_items.Add(BroadSword);
            all_items.Add(trash);




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
            WARMENU.addElement(skip_button);
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
            WARMENU.addElement(scnd_event_label);
            WARMENU.addElement(thrd_event_label);
            WARMENU.addElement(turn_indicator);
            WARMENU.addElement(herohp_label);
            WARMENU.addElement(heromp_label);
            WARMENU.addElement(enemyhp_label);
            WARMENU.addElement(enemymp_label);
            WARMENU.addElement(enemy_skill1_CD);
            WARMENU.addElement(enemy_skill1_panel);
            WARMENU.addElement(enemy_skill2_CD);
            WARMENU.addElement(enemy_skill2_panel);
            WARMENU.addElement(enemy_skill3_CD);
            WARMENU.addElement(enemy_skill3_panel);
            WARMENU.addElement(enemy_hppotion_panel);
            WARMENU.addElement(enemy_hppotion_counter);

            REWARDPAGE.addElement(reward_panel);

            cur_floor = 1;
            cur_room = 1;


            MAINMENU.Display();
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            using (var soundPlayer = new SoundPlayer(@"C:/Проект/WFG 3 — копия/WFG 3/Resources/ЦЫК.wav"))
            {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
            }
        }
        private void button_MouseLeave(object sender, EventArgs e)
        {
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

        }
        private void radiobutton_MouseLeave(object sender, EventArgs e)
        {

        }
        private void namebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            using (var soundPlayer = new SoundPlayer(@"C:/Проект/WFG 3 — копия/WFG 3/Resources/buttonclick.wav"))
            {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
            }
        }
        private void addEvent(string newev)
        {
            thrd_event_label.Text = scnd_event_label.Text;
            scnd_event_label.Text = event_label.Text;
            event_label.Text = newev;
        }

        public bool increaseRoom()
        {
            bool res = false;
            if (cur_room == 3)
            {
                cur_room = 1;
                res = increaseFloor();
            }
            else
            {
                cur_room++;
            }
            return res;
        }
        public bool increaseFloor()
        {
            bool res = false;
            if (cur_floor == 10)
            {
                cur_floor++;
                res = true;
                FINAL();
            }
            else
            {
                cur_floor++;
            }
            return res;
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

            //using (var soundPlayer = new SoundPlayer(@"C:/Проект/WFG 3 — копия/WFG 3/Resources/backgroundIntro_var3.wav"))
            //{
            //    soundPlayer.Play();
            //    soundPlayer.PlayLooping();
            //}

            //while (label1.Location.Y < 600)
            //{
            //    label1.Location = new Point(label1.Location.X, label1.Location.Y + 1);
            //    await Task.Delay(15);
            //}

            ENTERMENU.Hide();
            MainLoop();
        }



        public void MainLoop()
        {
            //Рандомная генерация моба
            ENEMY = Mob.randGen(cur_floor);
            is_win = false;
            is_lose = false;
            is_turn = true;
            BattleDisplay();
        }
        public void BattleDisplay()
        {
            HERO.updateStats();
            ENEMY.updateStats();

            WARMENU.Display();

            roomfloor_label.Text = "FLOOR " + Convert.ToString(cur_floor) + "-" + Convert.ToString(cur_room) + " ROOM";

            enemyicon_pictureBox.Image = ENEMY.icon;
            enemyname_label.Text = ENEMY.name;
            enemylvl_label.Text = Convert.ToString(ENEMY.LVL);
            enemyhp_Bar.Value = 100;
            enemymp_Bar.Value = 100;
            enemy_skill1.Image = new Bitmap(ENEMY.LeftHand.img, new Size(32,32));
            enemy_skill2.Image = new Bitmap(ENEMY.Armor.img, new Size(32, 32));
            enemy_skill3.Image = new Bitmap(ENEMY.RightHand.img, new Size(32, 32));
            enemy_hppotion.Image = new Bitmap(ENEMY.Heal_Potion.img, new Size(32, 32));
            enemy_hppotion_counter.Text = ENEMY.HealPotionCounter.ToString();
            enemyhp_label.Text = "Health: " + Convert.ToString(ENEMY.HP) + "/" + Convert.ToString(ENEMY.HP);
            enemymp_label.Text = "Mana: " + Convert.ToString(ENEMY.MP) + "/" + Convert.ToString(ENEMY.MP);
            enemy_skill1_CD.Text = "0";
            enemy_skill2_CD.Text = "0";
            enemy_skill3_CD.Text = "0";
            enemy_xp_bar.Value = Convert.ToInt32(ENEMY.GetPercentForNextLvl());

            heroicon_pictureBox.Image = HERO.icon;
            heroname_label.Text = HERO.name;
            herolvl_label.Text = Convert.ToString(HERO.LVL);
            herohp_Bar.Value = 100;
            heromp_Bar.Value = 100;
            skill1_Button.Image = HERO.LeftHand.img;
            skill2_Button.Image = HERO.Armor.img;
            skill3_Button.Image = HERO.RightHand.img;
            hppotion_Button.Image = HERO.Heal_Potion.img;
            hppotion_counter.Text = Convert.ToString(HERO.HealPotionCounter);
            herohp_label.Text = "Health: " + Convert.ToString(HERO.HP) + "/" + Convert.ToString(HERO.HP);
            heromp_label.Text = "Mana: " + Convert.ToString(HERO.MP) + "/" + Convert.ToString(HERO.MP);
            skill1_CD.Text = "0";
            skill2_CD.Text = "0";
            skill3_CD.Text = "0";
            hero_xp_bar.Value = Convert.ToInt32(HERO.GetPercentForNextLvl());

            event_label.Text = "";
            scnd_event_label.Text = "";
            thrd_event_label.Text = "";
            turn_indicator.Text = "Your turn!";


            TTtemplate.AutoPopDelay = 0;
            TTtemplate.ShowAlways = true;


            ToolTip TThero = TTtemplate;
            ToolTip TTskill1 = TTtemplate;
            ToolTip TTskill2 = TTtemplate;
            ToolTip TTskill3 = TTtemplate;
            ToolTip TTpotion = TTtemplate;
            ToolTip TTxpbar = TTtemplate;
            TThero.SetToolTip(heroicon_pictureBox, HERO.convToStr());
            TTskill1.SetToolTip(skill1_Button, Item.createCaptionByItem(HERO.LeftHand, HERO));
            TTskill2.SetToolTip(skill2_Button, Item.createCaptionByItem(HERO.Armor, HERO));
            TTskill3.SetToolTip(skill3_Button, Item.createCaptionByItem(HERO.RightHand, HERO));
            TTpotion.SetToolTip(hppotion_Button, Item.createCaptionByItem(HERO.Heal_Potion, HERO));
            TTxpbar.SetToolTip(hero_xp_bar, HERO.GetPercentForNextLvl() + "%");


            ToolTip TTenemy = TTtemplate;
            ToolTip TTenskill1 = TTtemplate;
            ToolTip TTenskill2 = TTtemplate;
            ToolTip TTenskill3 = TTtemplate;
            ToolTip TTenpotion = TTtemplate;
            ToolTip TTenxpbar = TTtemplate;
            TTenemy.SetToolTip(enemyicon_pictureBox, ENEMY.convToStr());
            TTenskill1.SetToolTip(enemy_skill1, Item.createCaptionByItem(ENEMY.LeftHand, ENEMY));
            TTenskill2.SetToolTip(enemy_skill2, Item.createCaptionByItem(ENEMY.Armor, ENEMY));
            TTenskill3.SetToolTip(enemy_skill3, Item.createCaptionByItem(ENEMY.RightHand, ENEMY));
            TTenpotion.SetToolTip(enemy_hppotion, Item.createCaptionByItem(ENEMY.Heal_Potion, ENEMY));
            TTenxpbar.SetToolTip(enemy_xp_bar, ENEMY.GetPercentForNextLvl() + "%");


            buttonAnalysis();
            enemyButtonAnalysis();
        }



        private void skip_button_Click(object sender, EventArgs e)
        {
            if (is_turn)
            {
                endHeroTurn();
            }
        }
        private void skill1_Button_Click(object sender, EventArgs e)
        {
            if (is_turn)
            {
                useSkill(HERO.LeftHand, skill1_CD, skill1_Button);
                endHeroTurn();
            }
        }
        private void skill2_Button_Click(object sender, EventArgs e)
        {
            if (is_turn)
            {
                useSkill(HERO.Armor, skill2_CD, skill2_Button);
                endHeroTurn();
            }
        }
        private void skill3_Button_Click(object sender, EventArgs e)
        {
            if (is_turn)
            {
                useSkill(HERO.RightHand, skill3_CD, skill3_Button);
                endHeroTurn();
            }
        }
        private void hppotion_Button_Click(object sender, EventArgs e)
        {
            if (is_turn)
            {
                useSkill(HERO.Heal_Potion, hppotion_counter, hppotion_Button);
                endHeroTurn();
            }
        }

        private void useSkill(Item item, Label skill_CD, Button skill_Button)
        {
            if (item is HealPotionItem)
            {
                if (HERO.HealPotionCounter > 0)
                {
                    HealItem I = (HealItem)HERO.Heal_Potion;
                    if (HERO.HP + I.heal <= HERO.max_HP)
                    {
                        HERO.HP += I.heal;
                    }
                    else
                    {
                        HERO.HP = HERO.max_HP;
                    }

                    HERO.HealPotionCounter--;
                    hppotion_counter.Text = HERO.HealPotionCounter.ToString();

                    herohp_Bar.Value = Convert.ToInt32(100 * HERO.HP / HERO.max_HP);
                    herohp_label.Text = "Health: " + HERO.HP.ToString() + "/" + HERO.max_HP.ToString();
                    hppotion_Button.Enabled = false;
                }
            }
            else if (item is DamageItem)
            {
                if (Convert.ToInt32(skill_CD.Text) == 0 && HERO.MP - item.mpcost >= 0)
                {
                    DamageItem I = (DamageItem)item;
                    if (ENEMY.HP - I.dmg*HERO.PWR <= 0)
                    {
                        ENEMY.HP = 0;

                        enemyhp_Bar.Value = Convert.ToInt32(100 * ENEMY.HP / ENEMY.max_HP);
                        enemyhp_label.Text = "Health: " + ENEMY.HP.ToString() + "/" + ENEMY.max_HP.ToString();

                        is_win = true;
                    }
                    else
                    {
                        ENEMY.HP -= I.dmg* HERO.PWR;

                        enemyhp_Bar.Value = Convert.ToInt32(100 * ENEMY.HP / ENEMY.max_HP);
                        enemyhp_label.Text = "Health: " + ENEMY.HP.ToString() + "/" + ENEMY.max_HP.ToString();
                    }
                    skill_CD.Text = item.CD.ToString();
                    HERO.MP -= item.mpcost;
                    heromp_Bar.Value = Convert.ToInt32(100 * HERO.MP / HERO.max_MP);
                    heromp_label.Text = "Mana: " + HERO.MP.ToString() + "/" + HERO.max_MP.ToString();
                    skill_CD.Text = item.CD.ToString();

                    skill_Button.Enabled = false;
                }
            }
            else if (item is HealItem)
            {
                if (Convert.ToInt32(skill_CD.Text) == 0 && HERO.MP - item.mpcost >= 0)
                {
                    {
                        HealItem I = (HealItem)item;
                        if (HERO.HP + I.heal*HERO.PWR <= HERO.max_HP)
                        {
                            HERO.HP += I.heal * HERO.PWR;
                        }
                        else
                        {
                            HERO.HP = HERO.max_HP;
                        }
                        herohp_Bar.Value = Convert.ToInt32(100 * HERO.HP / HERO.max_HP);
                        herohp_label.Text = "Health: " + HERO.HP.ToString() + "/" + HERO.max_HP.ToString();
                    }
                    skill_CD.Text = item.CD.ToString();
                    HERO.MP -= item.mpcost;
                    heromp_Bar.Value = Convert.ToInt32(100 * HERO.MP / HERO.max_MP);
                    heromp_label.Text = "Mana: " + HERO.MP.ToString() + "/" + HERO.max_MP.ToString();
                    skill_CD.Text = item.CD.ToString();

                    skill_Button.Enabled = false;
                }
            }
            addEvent(Item.createEventByItem(item, HERO, ENEMY));
        }

        private void endHeroTurn()
        {
            is_turn = false;
            enemyTurnTimeCounter = 0;
            enemy_turn_timer.Enabled = true;//таймер вызывает ход врага
            if (is_win)
            {
                turn_indicator.Text = "You win!";
            }
            else
            {
                turn_indicator.Text = "Enemy turn...";
            }

        }
        private void startHeroTurn()
        {
            is_turn = true;
            cutCD();
            HERO.RegenerateMana();
            heromp_Bar.Value = Convert.ToInt32(100 * HERO.MP / HERO.max_MP);
            heromp_label.Text = "Mana: " + HERO.MP.ToString() + "/" + HERO.max_MP.ToString();

            turn_indicator.Text = "Your turn!";
            buttonAnalysis();
        }
        private void cutCD()
        {
            if (Convert.ToInt32(skill1_CD.Text) > 0)
            {
                skill1_CD.Text = (Convert.ToInt32(skill1_CD.Text) - 1).ToString();
            }

            if (Convert.ToInt32(skill2_CD.Text) > 0)
            {
                skill2_CD.Text = (Convert.ToInt32(skill2_CD.Text) - 1).ToString();
            }

            if (Convert.ToInt32(skill3_CD.Text) > 0)
            {
                skill3_CD.Text = (Convert.ToInt32(skill3_CD.Text) - 1).ToString();
            }
            buttonAnalysis();
        }
        private void buttonAnalysis()
        {
            if (Convert.ToInt32(skill1_CD.Text) == 0 && HERO.LeftHand.mpcost <= HERO.MP)
            {
                skill1_Button.Enabled = true;
            }
            else
            {
                skill1_Button.Enabled = false;
            }

            if (Convert.ToInt32(skill2_CD.Text) == 0 && HERO.Armor.mpcost <= HERO.MP)
            {
                skill2_Button.Enabled = true;
            }
            else
            {
                skill2_Button.Enabled = false;
            }

            if (Convert.ToInt32(skill3_CD.Text) == 0 && HERO.RightHand.mpcost <= HERO.MP)
            {
                skill3_Button.Enabled = true;
            }
            else
            {
                skill3_Button.Enabled = false;
            }

            if (Convert.ToInt32(hppotion_counter.Text) == 0)
            {
                hppotion_Button.Enabled = false;
            }
            else
            {
                hppotion_Button.Enabled = true;
            }
        }
        private void enemy_turn_timer_tick(object sender, EventArgs e)
        {
            if (enemyTurnTimeCounter < enemyTurnCouldown)
            {
                enemyTurnTimeCounter++;
            }
            else
            {
                enemy_turn_timer.Enabled = false;
                if (is_win)
                {
                    heroWinEvent();
                }
                else
                {
                    EnemyTurn();
                }
            }
        }


        private void EnemyTurn()
        {
            EnemyCutCD();
            ENEMY.RegenerateMana();
            enemymp_Bar.Value = Convert.ToInt32(100 * ENEMY.MP / ENEMY.max_MP);
            enemymp_label.Text = "Mana: " + ENEMY.MP.ToString() + "/" + ENEMY.max_MP.ToString();
            enemyButtonAnalysis();

            //ход врага

            addEvent("AAAAAAAAAAA");
            startHeroTurn();
        }


        private void EnemyCutCD()
        {
            if (Convert.ToInt32(enemy_skill1_CD.Text) > 0)
            {
                enemy_skill1_CD.Text = (Convert.ToInt32(enemy_skill1_CD.Text) - 1).ToString();
            }

            if (Convert.ToInt32(enemy_skill2_CD.Text) > 0)
            {
                enemy_skill2_CD.Text = (Convert.ToInt32(enemy_skill2_CD.Text) - 1).ToString();
            }

            if (Convert.ToInt32(enemy_skill3_CD.Text) > 0)
            {
                enemy_skill3_CD.Text = (Convert.ToInt32(enemy_skill3_CD.Text) - 1).ToString();
            }
            enemyButtonAnalysis();
        }
        private void enemyButtonAnalysis()
        {
            if (Convert.ToInt32(enemy_skill1_CD.Text) == 0 && ENEMY.LeftHand.mpcost <= ENEMY.MP)
            {
                enemy_skill1.Image = new Bitmap(ENEMY.LeftHand.img, new Size(32, 32));
                enemy_skill1.Tag = "1";
            }
            else
            {
                enemy_skill1.Image = MakeGrayscale(new Bitmap(ENEMY.LeftHand.img, new Size(32, 32)));
                enemy_skill1.Tag = "0";
            }

            if (Convert.ToInt32(enemy_skill2_CD.Text) == 0 && ENEMY.Armor.mpcost <= ENEMY.MP)
            {
                enemy_skill2.Image = new Bitmap(ENEMY.Armor.img, new Size(32, 32));
                enemy_skill2.Tag = "1";
            }
            else
            {
                enemy_skill2.Image = MakeGrayscale(new Bitmap(ENEMY.Armor.img, new Size(32, 32)));
                enemy_skill2.Tag = "0";
            }

            if (Convert.ToInt32(enemy_skill3_CD.Text) == 0 && ENEMY.RightHand.mpcost <= ENEMY.MP)
            {
                enemy_skill3.Image = new Bitmap(ENEMY.RightHand.img, new Size(32, 32));
                enemy_skill3.Tag = "1";
            }
            else
            {
                enemy_skill3.Image = MakeGrayscale(new Bitmap(ENEMY.RightHand.img, new Size(32, 32)));
                enemy_skill3.Tag = "0";
            }

            if (Convert.ToInt32(enemy_hppotion_counter.Text) != 0)
            {
                enemy_hppotion.Image = new Bitmap(ENEMY.Heal_Potion.img, new Size(32, 32));
            }
            else
            {
                enemy_hppotion.Image = MakeGrayscale(new Bitmap(ENEMY.Heal_Potion.img, new Size(32, 32)));
            }
        }


        private void heroWinEvent()
        {
            addEvent("\""+HERO.name+"\" deafeted \"" + ENEMY.name + "\"");
            hero_win_timer.Enabled = true;
        }

        private void hero_win_timer_Tick(object sender, EventArgs e)
        {
            if (herowinTimeCounter < herowinCouldown)
            {
                herowinTimeCounter++;
            }
            else
            {
                herowinTimeCounter = 0;
                hero_win_timer.Enabled = false;
                herowin();
            }
        }

        private void herowin()
        {
            WARMENU.Hide();
            reward_panel.Location = new Point(107, 32);
            REWARDPAGE.Display();
            is_choose_reward = true;

            TTtemplate.AutoPopDelay = 0;
            TTtemplate.ShowAlways = true;

            int LVL0 = HERO.LVL;
            int EXP0 = HERO.EXP;
            //возможная замена формулы опыта
            //текущая: 2^(ур.вр. -1)*50 +- 20%
            int rewEXP = Convert.ToInt32(Math.Pow(2, ENEMY.LVL - 1) * 50 + (Root.Next(-20, 21) / 100.0) * Math.Pow(2, ENEMY.LVL - 1) * 50);
            HERO.AddEXP(rewEXP);
            earned_exp.Text = "+" + rewEXP.ToString() + " XP.";
            if (LVL0 != HERO.LVL)
            {
                hero_changed_xp_bar.Value = 0;
                exp_changes.Text = "LVL " + LVL0.ToString() + "   →   LVL " + HERO.LVL.ToString() + "\n\nEXP: "+HERO.EXP.ToString() + "XP";
                hero_changed_xp_bar.Value = Convert.ToInt32(HERO.GetPercentForNextLvl());
            }
            else
            {
                exp_changes.Text = EXP0.ToString() + "XP  →  " + HERO.EXP.ToString()+"XP";
                hero_changed_xp_bar.Value = Convert.ToInt32(HERO.GetPercentForNextLvl());
            }

            //рандомная генерация предмета
            ItemList REWARDS = all_items.ExtractByClass(HERO.Class).ExtractByLessLvl(HERO.LVL);
            REWARDS.Del(HERO.LeftHand);
            REWARDS.Del(HERO.Armor);
            REWARDS.Del(HERO.RightHand);
            REWARDS.Del(HERO.Heal_Potion);
            REWARD = REWARDS.GetRndItem();

            reward_image.Image = new Bitmap(REWARD.img, reward_image.Width, reward_image.Height);

            cur_item_image.Image = new Bitmap(HERO.GetItemBySlot(REWARD.slot).img, cur_item_image.Width, cur_item_image.Height);

            ToolTip TTreward = TTtemplate;
            TTreward.SetToolTip(reward_image, Item.createCaptionByItem(REWARD, HERO));

            ToolTip TTrewhppotion = TTtemplate;
            TTrewhppotion.SetToolTip(reward_potion_image, Item.createCaptionByItem(HealPotion, HERO));

            ToolTip TTcuritem = TTtemplate;
            TTcuritem.SetToolTip(cur_item_image, Item.createCaptionByItem(HERO.GetItemBySlot(REWARD.slot), HERO));

            ToolTip TTxpbar = TTtemplate;
            TTxpbar.SetToolTip(hero_changed_xp_bar, HERO.GetPercentForNextLvl() + "%");

            HERO.HealPotionCounter++;
        }

        private void equip_button_Click(object sender, EventArgs e)
        {
            if (is_choose_reward)
            {
                is_choose_reward = false;
                HERO.Equip(REWARD);
                next_floor();
            }
        }

        private void cancel_equip_button_Click(object sender, EventArgs e)
        {
            if (is_choose_reward)
            {
                is_choose_reward = false;
                next_floor();
            }
        }

        private void next_floor()
        {
            REWARDPAGE.Hide();

            increaseRoom();
            afterbattle_label.Text = "FLOOR " + Convert.ToString(cur_floor) + "-" + Convert.ToString(cur_room) + " ROOM";
            afterbattle_label.Visible = true;
            afterbattle_interval_timer.Enabled = true;
        }


        private void afterbattle_interval_timer_Tick(object sender, EventArgs e)
        {
            if (afterbattleTimeCounter < afterbattleCouldown)
            {
                afterbattleTimeCounter++;
                afterbattle_label.Location = new Point(afterbattle_label.Location.X, afterbattle_label.Location.Y + 1);
            }
            else
            {
                afterbattle_interval_timer.Enabled = false;
                afterbattle_label.Visible = false;
                afterbattle_label.Location = new Point(207, 252);
                afterbattleTimeCounter = 0;
                MainLoop();
            }
        }










        public void FINAL()
        {
            this.Close();
        }


        public static Bitmap MakeGrayscale(Bitmap original)
        {
            //make an empty bitmap the same size as original
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);

            for (int i = 0; i < original.Width; i++)
            {
                for (int j = 0; j < original.Height; j++)
                {
                    //get the pixel from the original image
                    Color originalColor = original.GetPixel(i, j);

                    //create the grayscale version of the pixel
                    int grayScale = (int)((originalColor.R * .3) + (originalColor.G * .59)
                        + (originalColor.B * .11));

                    //create the color object
                    Color newColor = Color.FromArgb(grayScale, grayScale, grayScale);

                    //set the new image's pixel to the grayscale version
                    newBitmap.SetPixel(i, j, newColor);
                }
            }

            return newBitmap;
        }

    }
}