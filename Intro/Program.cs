using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Program p = new Program();
            p.TestVars();
            p.Numbers();
            int res =p.Sum(21,21);
            int min = p.MinOf(52,57);
            float max = p.MaxOf(23423.234f,25233.234f);
        }

        float MaxOf(float n1,float n2){
            float p = n1 > n2 ? n1:n2;
            System.Console.WriteLine(p);
            return n1 > n2 ? n1:n2;
        }
        int MinOf(int num1,int num2){
            // if(num1 < num2) return num1;
            // return num2;

            return num1 < num2 ? num1:num2;
        }


        int TestVars()
        {
            string name = "Andrew";
            int age = 35;
            float avg = 234.23432f;
            decimal price = 24.99m;
            bool found = false;

            Console.WriteLine(name);

            //if statements

            if(age > 100){
                Console.WriteLine("Old fart!");
            }else{
                Console.WriteLine("Not dead yet!");
            }

            //for loop
            // for(int i = 0; i<10;i++){
            //     Console.WriteLine("sup");
            // }

            return 1;
        }
        void Numbers(){
            for(int i = 0; i<3;i++){
                if(i!=7&&i!=9){
                Console.WriteLine(i);
        }
        }
    }
        int Sum(int one, int two){
            
            return one + two;
        }
}}
