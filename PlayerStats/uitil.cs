using System.Collections.Generic;
using MEC;
using UnityEngine;

namespace YYYLike
{
    public class shop
    {
        private int id;
        private string name;
        private string nickname;
        private int point;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Nickname { get => nickname; set => nickname = value; }
        public int Point { get => point; set => point = value; }
    }
    public class uitil
    {
        private int id;
        private string name;
        private string nickname;
        private int point;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Nickname { get => nickname; set => nickname = value; }
        public int Point { get => point; set => point = value; }
    }
    public class jackpot
    {
        private int id;
        private string name;
        private string nickname;
        private float probability;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Nickname { get => nickname; set => nickname = value; }
        public float Probability { get => probability; set => probability = value; }
    }

    public class detail
    {
        private int id;
        private string userid;
        private string nickname;
        private int point;
        private string remarks;
        private string time;

        public int Id { get => id; set => id = value; }
        public string Userid { get => userid; set => userid = value; }
        public string Nickname { get => nickname; set => nickname = value; }
        public int Point { get => point; set => point = value; }
        public string Remarks { get => remarks; set => remarks = value; }
        public string Time { get => time; set => time = value; }
 
    }
    public class badge
    {
        private int id;
        private string userid;
        private string color;
        private string text;
        private int role;
     
        public int Id { get => id; set => id = value; }
        public string Userid { get => userid; set => userid = value; }
        public string Color { get => color; set => color = value; }
        public string Text { get => text; set => text = value; }
        public int Role { get => role; set => role = value; }
    }



}