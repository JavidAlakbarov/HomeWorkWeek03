using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace HomeTaskWeek03
//{
//    //1)https://www.exercisescsharp.com/oop/first-class-method-tostring
//    public class TaskWeek0301
//    {
//        public static void Main(string[] args)
//        {
//            int total = 3;
//            Human[] humans = new Human[total];
//            Console.WriteLine("What are your names: ");

//            for (int i = 0; i < total; i++)
//            {
//                humans[i] = new Human();
//                humans[i].Name = Console.ReadLine();
//            }
//            for (int i = 0; i < total; i++)
//            {
//                Console.WriteLine(humans[i].ToString());
//            }
//            Console.ReadLine();
//        }

//        public class Human
//        {
//            public string Name;
//            public override string ToString()
//            {
//                return "Hello.My name is " + Name;
//            }
//        }
//    }
//}
////2)https://www.exercisescsharp.com/oop/constructors-destructors
//namespace TaskWeek0302
//{
//    public class TaskWeek0302
//    {
//        public static void Main(string[] args)
//        {
//            int total = 3;
//            Human[] humans = new Human[total];
//            for (int i = 0; i < total; i++)
//            {
//                humans[i] = new Human();
//                humans[i].Name = Console.ReadLine();
//            }
//            for (int i = 0; i < total; i++)
//            {
//                Console.WriteLine(humans[i].ToString());
//            }
//        }

//        public class Human
//        {
//            public string name;
//            public string Name { get; set; }
//            public Human()
//            {
//                Name = name;
//            }
//            public override string ToString()
//            {
//                return "Hello.My name is " + Name;
//            }
//        }
//    }


//}

////3)https://www.exercisescsharp.com/oop/class-person-student-and-teacher
//namespace TaskWeek0303
//{
//    public class HomeTask0303
//    {
//        public static void Main(string[] args)
//        {
//            Person human = new Person();
//            human.Greet();

//            Student human01 = new Student();
//            human01.Age(18);
//            human01.Greet();
//            human01.showAge();
//            human01.Study();

//            Teacher human02 = new Teacher();
//            human02.Age(45);
//            human02.Greet();
//            human02.showAge();
//            human02.Explain();
//        }
//    }

//    public class Person
//    {
//        public int age;
//        public void Greet()
//        {
//            Console.WriteLine("Hello!");
//        }
//        public void Age(int a)
//        {
//            age = a;
//        }
//    }
//    public class Student : Person
//    {
//        public void Greet()
//        {
//            Console.WriteLine("Hello!");
//        }
//        public void Study()
//        {
//            Console.WriteLine("I am studying");
//        }
//        public void showAge()
//        {
//            Console.WriteLine($"My age is {18} years old");
//        }
//    }
//    public class Teacher : Person
//    {
//        public void Greet()
//        {
//            Console.WriteLine("Hello!");
//        }
//        public void showAge()
//        {
//            Console.WriteLine($"My age is {45} years old"); ;
//        }

//        public void Explain()
//        {
//            Console.WriteLine("I am explaining");
//        }
//    }
//}

////4)https://www.exercisescsharp.com/oop/photo-book-class
//namespace TaskWeek0304
//{
//    public class PhotoBook
//    {
//        public static void Main(string[] args)
//        {
//            Photobook gallery = new Photobook();
//            Console.WriteLine(gallery.GetPagesNum());

//            Photobook gallery1 = new Photobook();
//            Console.WriteLine(gallery.GetPagesNum());

//            BigPhotoBook bigGallery = new BigPhotoBook();
//            Console.WriteLine(bigGallery.GetPagesNum());
//        }

//        public class Photobook
//        {
//            public int PagesNum;

//            public Photobook()
//            {
//                PagesNum = 16;
//            }
//            public Photobook(int PagesNum)

//            {
//                this.PagesNum = PagesNum;
//            }
//            public int GetPagesNum()
//            {
//                return PagesNum;
//            }
//        }
//        public class BigPhotoBook : PhotoBook
//        {
//            public int PagesNum { get; }
//            public BigPhotoBook()
//            {
//                PagesNum = 64;
//            }
//            public int GetPagesNum()
//            {
//                return PagesNum;
//            }

//        }
//    }
//}

