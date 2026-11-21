// //generics = <T>=<Thing>= ترجع اي داتا طيب 
// using System;
// namespace backend
// {
//     class Program
//     {
//         static void Main()
//         {
//             int[] intarray={1,2,3};
//             double[] doublearray={1,2,3};
//             string[] stringarray={"1","2","3"};
//             display(intarray);
//             display(doublearray);
//             display(stringarray);

//         }
// //        public static void display<Thing>() نفس الشئ 
//         public static void display<T>(T[] array)
//         {
//             foreach(T item in array)
//             {
//                 System.Console.Write(item+" ");
//             }
//             System.Console.WriteLine();
//         }

        //   public static void display(int[] array) 
        // كنا هنكتب ده لكل نوع قبل الثينج
        // {
        //     foreach(int item in array)
        //     {
        //         System.Console.Write(item+" ");
        //     }
            
        // }
//     }
// }

//       enums=اسامي لها رقم  

// using System;
// namespace MyProgram
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // طباعة اسم العنصر وقيمته العددية باستخدام التحويل (Casting)
//             Console.WriteLine(Planets.Mercury + " is planet #" + (int)Planets.Mercury);
//             Console.WriteLine(Planets.Pluto + " is planet #" + (int)Planets.Pluto);

//             // تحويل قيمة الـ Enum إلى نص باستخدام ToString أو التعامل مع Enum آخر
//             String name = Planets.Earth.ToString();
//             int radius = (int)Planets_Radius.Earth;
//             Console.WriteLine("Name " + name);
//             Console.WriteLine("Radius " + radius + " km");

//             Console.ReadKey();
//         }
//     }

//     // تعريف الـ Enum الأول للواكب وترتيبها
//     enum Planets
//     {
//         Mercury = 1,
//         Venus = 2,
//         Earth = 3,
//         Mars = 4,
//         Jupiter = 5,
//         Saturn = 6,
//         Uranus = 7,
//         Neptune = 8,
//         Pluto = 9
//     }

//     // تعريف الـ Enum الثاني لنصف قطر الكواكب
//     enum Planets_Radius
//     {
//         Mercury = 2440,
//         Venus = 6051,
//         Earth = 6371
//     }
// }

// list objects

// using System;
// using System.Collections.Generic;
// namespace backend
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             List<Player>players=new List<Player>();

//             Player player1 =new Player("chad");
//             Player player2 =new Player("nagy");

//             players.Add(player1);
//             players.Add(player2);
//             players.Add(new Player("maged"));
//             //another way to write list objects

//             foreach(Player player in players)
//             {
//                 System.Console.WriteLine(player);
//             //    System.Console.WriteLine(player.username);
//             //كده الاصح لو مفيش داله toString
//             }
//             Console.ReadKey();
//         }
//     }
//     class Player
//     {
//         public string username;
//         public Player(string name)
//         {
//             this.username=name;
//         }
//         public override string ToString()
//         {
//             return username;
//         }
//     }
// }
    
// // lists =dynamic array
// using System;
// namespace backend
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             List<string>food=new List<string>();
//             food.Add("koshari");
//             food.Add("meat");
//             food.Add("pizza");
//             food.Add("fries");
// //                                        اوامر
//             food.Remove("fries");
//             food.Insert(0,"hotdog");
//             System.Console.WriteLine(food.Count);            
//             System.Console.WriteLine(food.IndexOf("pizza"));            
//             System.Console.WriteLine(food.LastIndexOf("meat"));            
//             System.Console.WriteLine(food.Contains("hotdog"));//true or false
//             food.Sort();
//             food.Reverse();
//             food.Clear();

//             string[] foodarray=food.ToArray();          تحويل لمصفوفه  
//             foreach (string item in food)
//             {
//                 System.Console.WriteLine(item);
//             }
//             Console.ReadKey();
//         }
//     }
// }
//                         interface=داله كده بقدر اعملها كتير واورث اكتر من واحده منها لكلاس
//                          OVERride  لا يكتب بها كود ولكن يكتب بالكلاس بدون    
// using System;
// namespace BackendApp
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // إنشاء كائن من نوع بطاقة ائتمان وآخر من نوع فوري
//             IPaymentMethod creditCard = new CreditCard();
//             IPaymentMethod fawry = new FawryPayment();

//             // تنفيذ عملية الدفع لكل منهما بكل مرونة
//             ProcessCheckout(creditCard, 500);
//             ProcessCheckout(fawry, 200);

//             Console.ReadKey();
//         }

//         // دالة تعتمد على الواجهة (Interface) دون الاهتمام بطريقة الدفع التفصيلية
//         static void ProcessCheckout(IPaymentMethod paymentMethod, decimal amount)
//         {
//             paymentMethod.Pay(amount);
//         }
//     }

//     // 1. التعريف (العقد): الواجهة تحدد "ماذا" يجب أن يفعل الكلاس وليس "كيف"
//     interface IPaymentMethod
//     {
//         void Pay(decimal amount);
//     }

//     // 2. تطبيق الواجهة في كلاس الدفع بالبطاقة
//     class CreditCard : IPaymentMethod
//     {
//         public void Pay(decimal amount)
//         {
//             Console.WriteLine($"Paid {amount} EGP using Credit Card.");
//         }
//     }

//     // 3. تطبيق نفس الواجهة في كلاس الدفع عبر فوري
//     class FawryPayment : IPaymentMethod
//     {
//         public void Pay(decimal amount)
//         {
//             Console.WriteLine($"Paid {amount} EGP using Fawry.");
//         }
//     }
// }
//                          POLYMORPHISM= طريقه تفكير تعتمد ع الاوفر رايد من الداله الام والداله 
//              الام ممكن تشغلهم كما بالمثال  داله لها عمل مختلف  بكل كلاس
// using System;
// namespace backend
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Car car = new Car();
//             Bicycle bicycle =new Bicycle();
//             Boat boat =new Boat();

//             Vehicle[] vehicles={car,bicycle,boat};
            
//             foreach(Vehicle vehicle in vehicles)
//             {
//                 vehicle.go();    
//             } 

//             Console.ReadKey();
//         }
//     }
//     class Vehicle
//     {
//        public virtual void go()
//     {
//     }
//     }
//     class Car:Vehicle
//     {
//     public override void go()
//     {
//         Console.WriteLine("the car is moving");
//     }
//     }
//      class Bicycle:Vehicle
//     {
//     public override void go()
//     {
//         Console.WriteLine("the bicycle  is moving");
//     }   
//     } 
//     class Boat:Vehicle
//     {
//         public override void go()
//     {
//         Console.WriteLine("the boat is moving");
//     }
//     }
// }
//                               STRING CLASS

// using System;
// using System.Security.Cryptography.X509Certificates;
// namespace backend 
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Car[] garage =new Car[3];
//             Car car1=new Car("BMW");
//             Car car2=new Car("ferarri");
//             Car car3=new Car("lambo");

//             garage[0]=car1;
//             garage[1]=car2;
//             garage[2]=car3;

//             System.Console.WriteLine(garage[0].model);
//             System.Console.WriteLine(garage[1].model);
//             System.Console.WriteLine(garage[2].model);
//             changemodel(car2,"GTR");
//             //                          another wayyyy to print
//             foreach(Car car in garage)
//             {
//                 System.Console.WriteLine(car.model);
//             }
//             Console.ReadKey();
//         }
//         public static void changemodel(Car car,string model)
//             {
//                 car.model=model;
//             }

//     }
//     class Car
// {
//     public string model;
//     public Car(string model)
//     {
//         this.model=model;
//     }
// }
// } 