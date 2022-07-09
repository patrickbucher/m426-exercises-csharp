using System;

namespace Playground.Demo
{
    public class RuleOfThreeDemo
    {
        public static void Main(string[] args)
        {
            RuleOfThree potatoRule = new RuleOfThree(3.50, 12);
            var potatoPrice20 = potatoRule.CalculateFor(20);
            Console.WriteLine($"20 Potatoes for {potatoPrice20:0.00}");
            Console.WriteLine("correct? " + (potatoPrice20 == 3.50 / 12 * 20));

            RuleOfThree bananaRule = new RuleOfThree(2.90, 6);
            var bananaPrice10 = bananaRule.CalculateFor(10);
            Console.WriteLine($"10 Bananas for {bananaPrice10:0.00}");
            Console.WriteLine("correct? " + (bananaPrice10 == 2.90 / 6 * 10));
        }
    }
}
