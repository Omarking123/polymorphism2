using PolyMorphism.casting_operators_overloading;
using PolyMorphism.Operators_Overloading;
using PolyMorphism.Ploymorphism_overriding;

namespace PolyMorphism
{
    #region Employee binding
    class FullTimeEmployee : Employee
    {
        public decimal salary { get; set; }

        public new void Myfun01()
        {
            Console.WriteLine("I am Fulltime emplyoee");
        }

        public override void MyFun02()


        {
            Console.WriteLine($"full time emplyee : id {id} name {Name}, age : {age} salary{salary}");
        }

    }

    class partTimeEmployee : Employee
    {
        public decimal HourRate { get; set; }

        public new void Myfun01()
        {
            Console.WriteLine("i'm part time employee");
        }
        public override void MyFun02()
        {
            Console.WriteLine($"part time emplyee : id {id} name {Name}, age : {age} salary{HourRate}");
        }
    }
    class Employee
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int age { get; set; }

        public void Myfun01()
        {
            Console.WriteLine("I am emplyoee");
        }
        public virtual void MyFun02()
        {
            Console.WriteLine($"emplyee : id {id} name {Name}, age : {age}");
        }
    }
    internal class Program
    {


        #region Overloading
        static int sum(int X, int Y)
        {
            return X + Y;
        }
        static double sum(double X, double Y)
        {
            return X + Y;
        }
        static double sum(int X, double Y)
        {
            return X + Y;
        }
        static int sum(int X, int Y, int Z)
        {
            return X + Y + Z;
        }

        #endregion

        public static void processemployeee(Employee employee)
        {
            if (employee is not null)
            {
                employee.Myfun01();
                employee.MyFun02();

            }
        }


        #endregion

        static void Main1(string[] args)
        {


            #region Polymorpism 1- overloading
            //dynamic result = sum(2.2, 3.4);
            //result = sum(1, 3, 4);
            //Console.WriteLine(result);

            #endregion


            #region Operators


            //Complex c3 = default; // null 
            //c3 = c1 + c2;

            //c2 += c1;
            //c3 = c1 + c1 + c3;
            //c3 = c1 + c2;
            ////int reulst = 3 + 2;
            //Console.WriteLine($"c1  = {c1}");
            //Console.WriteLine($"c2  = {c2}");
            //Console.WriteLine("----------");
            //Console.WriteLine($"c3  = {c3}"); 
            #endregion

            #region unary operators

            //Complex c3 = ++c1;
            //Console.WriteLine($"c1  {c1}");
            //Console.WriteLine($"c3 =  {c3}"); 
            #endregion
            #region relational 

            //if (c1 > c2)
            //    Console.WriteLine("C1 is greater than c2");
            //else if (c1 < c2)
            //    Console.WriteLine("c1 is less than c2 ");
            //else
            //    Console.WriteLine("c1 equals c2 "); 
            #endregion

            #region casting oprators overloading
            #region exmaple 01 
            //Complex c1 = new Complex() { real = 4, imag = 3 };
            //int y = (int)c1;
            //Console.WriteLine(y);

            //object o1 = 5;
            //int x = (int) o1; 
            #endregion

            #region exmpale 2 
            //Complex C1 = new Complex() { real = 4, imag = 5 };

            //string y = (string) C1;
            //Console.WriteLine(y);
            //object O1 = "ahmed";
            //string x = (string)O1;
            //Console.WriteLine(x);
            #endregion

            #endregion

            #region overloading need 
            //user user = new user()
            //{
            //    Id = 1,
            //    FullName = "Ahmed Nasr",
            //    Email="test@yahoo.com",
            //    Password = "password",
            //    SecurityStemp = Guid.NewGuid()
            //};
            //userviewmodel userviewmodel = (userviewmodel) user;

            //Console.WriteLine(userviewmodel.Id);
            //Console.WriteLine(userviewmodel.Fname);
            //Console.WriteLine(userviewmodel.LName);
            //Console.WriteLine(userviewmodel.Email);
            //Console.WriteLine(userviewmodel.Passw 
            #endregion);

            #region 2.overriding 

            typeA typeA = new TypeB(1, 2);
            typeA.A = 11;
            //typeA.B = 22;
            typeA.Myfunc01();
            typeA.MyFun02();




            //TypeB typeB = new TypeB(1,2);
            //typeB.A = 11;

            //typeB.B = 22;
            //typeB.Myfunc01();

            //typeB.MyFun02(); 
            #endregion


            FullTimeEmployee employee = new FullTimeEmployee()
            {
                id = 10,
                Name = "Test",
                age = 30,
                salary = 50,
            };

        }
    }
}
