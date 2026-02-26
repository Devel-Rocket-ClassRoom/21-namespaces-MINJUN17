using System;
using MyGame.Characters;
using MyGame.Item;

Player player = new Player();
Enemy enemy = new Enemy();
Weapon weapon = new Weapon();
Potion potion = new Potion();
Console.WriteLine("=== 캐릭터 시스템 ===");
player.Attack();
enemy.TakeDamage();
Console.WriteLine("\n");
Console.WriteLine("=== 아이템 시스템 ===");
weapon.GetDamage();
potion.Use();


namespace MyGame.Characters
{
    class Player
    {
        private string Name = "용사";
        public void Attack()
        {
            Console.WriteLine($"플레이어 {Name}(이)가 공격합니다!");
        }
    }
    class Enemy
    {
        private string Type = "고블린";
        public void TakeDamage()
        {
            Console.WriteLine($"적 {Type}(이)가 데미지를 받았습니다!");
        }
    }
}
namespace MyGame.Item
{
    class Weapon
    {
        private string Name = "불꽃검";
        public void GetDamage()
        {
            Console.WriteLine($"무기 {Name}의 공격력 : 50");
        }
    }
    class Potion
    {
        private string Name = "체력 포션";
        public void Use()
        {
            Console.WriteLine($"포션 {Name}을(를) 사용했습니다.");
        }
    }
}
