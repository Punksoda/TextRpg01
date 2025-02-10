﻿namespace SpartaDungeon
{
    public interface ItemData
    {
        string name { get; }
        int itemType { get; }   // 1: 무기 2: 갑옷, 3: 포션, 
        int classType { get; }   // 1: 전사 2: 마법사 3: 궁수 4: ALL
        float attack { get; }
        float defence { get; }
        float hp { get; }
        float mp { get; }
        string description { get; }
        int price { get; }
    }

    public abstract class Equipment : ItemData
    {
        public string name { get; set; }
        public int itemType { get; set; }
        public int classType { get; set; }
        public float attack { get; set; }
        public float defence { get; set; }
        public float hp { get; set; }
        public float mp { get; set; }
        public string description { get; set; }
        public int price { get; set; }
        public bool IsEquipable { get; set; }


    }
        public class Armor : Equipment
        {
            public Armor()
            {
                name = "존나 쌘 갑옷";
                itemType = 1;
                defence = 9999;
                description = "날 아무도 막을수 없으셈 ㅋㅋ";
                price = 9999;
            }
        }
    }

