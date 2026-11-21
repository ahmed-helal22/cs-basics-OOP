// using System;

// namespace backend 
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // ملاحظة: لا يمكن أخذ نسخة (Object) من كلاس Abstract مباشرة هكذا:
//             // Entity e = new Entity(); // خطأ برمجي!

//             // إنشاء طالب جديد (يرث من Human، و Human يرث من Entity)
//             Student person1 = new Student("Ahmed", 19, 3.83, 101);
            
//             // استدعاء الدوال للتأكد من عمل الوراثة والـ Override
//             person1.ShowInfo();
//             person1.Eat();

//             Console.WriteLine("Total Humans created: " + Human.nums);

//             Console.ReadKey();
//         }
//     }

//     // 1. كلاس مجرد (Abstract Class) يمثل القاعدة الأساسية للنظام
//     abstract class Entity
//     {
//         // دالة مجردة (Abstract Method) بدون جسم، تفرض على كل الأبناء تنفيذها
//         public abstract void ShowInfo();
//     }

//     // 2. كلاس Human يرث من الكلاس المجرد Entity
//     class Human : Entity
//     {
//         public static int nums;
//         public int age;
//         public string name;

//         public Human(string name, int age)
//         {
//             this.name = name;
//             this.age = age;
//             nums++;
//         }

//         public void Eat()
//         {
//             Console.WriteLine(name + " is eating.");
//         }

//         // تطبيق إجباري للدالة المجردة القادمة من الأب Entity
//         public override void ShowInfo()
//         {
//             Console.WriteLine($"Name: {name}, Age: {age}");
//         }
//     }

//     // 3. كلاس Student يرث من Human (وهو بدوره يرث من Entity)
//     class Student : Human
//     {
//         public int id;
//         public double gpa; // جعلناها double لتتناسب مع درجات الـ GPA الحقيقية

//         public Student(string name, int age, double gpa, int id) : base(name, age)
//         {
//             this.gpa = gpa;
//             this.id = id; 
//         }

//         // تخصيص الدالة لتناسب بيانات الطالب بشكل أدق
//         public override void ShowInfo()
//         {
//             Console.WriteLine($"Student -> Name: {name}, Age: {age}, ID: {id}, GPA: {gpa}");
//         }
//     }
// }

    // int temp=20;
            // System.Console.WriteLine((temp>=15)?"its warm outside":"its cold out side");
//                                       exception 
//      try
//            {
            //       Console.WriteLine("Hello Classic C#!");
            // Multply( 3.5,2.4 );
            // }
            // finally
            // {
            //     System.Console.WriteLine("thanks for visiting ");
                
            // }
          
// singHappyBirthday();
// singHappyBirthday();
// void singHappyBirthday()
// {
//     Console.WriteLine("Happy Birthday!");
// }

// string[] cars={"fait","bmw","marcedes","ferrari","GTR","lamborghini","audi","toyota","honda","nissan"};
// //يارب ارزقنا 
// cars[0]="GTR is the top";
// System.Console.WriteLine(cars[0]);
// for(int i=1;i<cars.Length;i++)
// {
//     System.Console.WriteLine(cars[i]);
// }


//                       game guessing number   

// Random random = new Random(); 
// int number ;
// int guess,gueeses;
// int min=1, max=100;
// string response;
// bool playagain=true;
// while(playagain)
// {
//     guess=0;gueeses=0;
//     response="n";
//     number=random.Next(min,max+1);
//     while(guess!=number)
//     {
//         Console.WriteLine("Guess a number between "+min +" and "+max+" : ");
//         guess=Convert.ToInt32(Console.ReadLine());
//         if(guess>number)
//         {
//             Console.WriteLine("Too high! Try again.");
//         }
//         else if(guess<number)
//         {
//             Console.WriteLine("Too low! Try again.");
//         }
//         gueeses++;
//     }
//     Console.WriteLine("Congratulations! You guessed the number "+number+" in "+gueeses+" guesses.");
//     Console.WriteLine("Do you want to play again? (y/n)");
//     response=Console.ReadLine();
//     response=response.ToLower();
//     if(response=="n")
//     {
//         playagain=false;
//     }
//     else
//     {
//     playagain=true;
//     }
// }
// Console.WriteLine("Thanks for playing! Goodbye.");
