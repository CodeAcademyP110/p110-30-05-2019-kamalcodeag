using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace P110_ConsoleDemo
{
    #region Subjects
    //enum - sadalamaq
    //struct
    //Generic type

    //interface
    //Collections & Collections.Generic namespace

    //delegate
    //event

    //Thread, Task
    //Reflection
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            #region Custom interface - ISortable
            //Student[] students = {
            //    new Student{ Name = "Ilkin", Age = 12 },
            //    new Student{ Name = "Tebriz", Age = 45 },
            //    new Student{ Name = "Aqil", Age = 39 },
            //    new Student{ Name = "Mixcan", Age = 25 },
            //    new Student{ Name = "Medis", Age = -5 }
            //};

            //Sort(students);

            //foreach (var item in students)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Collections
            //System.Collection
            //System.Collection.Generic
            //System.Collection.Concurrent

            //ArrayList arrayList = new ArrayList();
            //arrayList.Add("sdujfg");
            //arrayList.Add(25654);
            //arrayList.Add(new int[] { 15, 125 });

            //int[] n = { 10, 125, 12, 2 };

            //List<int> nums = new List<int>();
            //nums.Add(16);
            //nums.AddRange(n);

            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}

            //Queue<Person> people = new Queue<Person>();
            //people.Enqueue(new Person { Name = "Ilkin" });
            //people.Enqueue(new Person { Name = "Mixcan" });
            //people.Enqueue(new Person { Name = "Elmar" });

            //Console.WriteLine(people.Peek());
            //Console.WriteLine(people.Dequeue());

            //Stack<Person> people2 = new Stack<Person>();
            //people2.Push(new Person { Name = "Ramiz" });
            //people2.Push(new Person { Name = "Medis" });

            //Console.WriteLine(people2.Pop());

            //Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            //phoneBook.Add("Ilkin", "+994 55 555 55 55");
            //phoneBook.Add("Perviz", "+994 51 7893245");
            //phoneBook.Add("Medine", "+994 050");

            //Console.WriteLine(phoneBook["Perviz"]);


            #endregion






            #region Practice - Interface

            //ICodeable dev = new Developer();
            //dev.WriteCode("</>");


            //.NET IComparable interface
            //Person[] people = new Person[3];
            //people[0] = new Person { Name = "Rashford", Surname = "Marcus" };
            //people[1] = new Person { Name = "Lingard", Surname = "Jesse" };
            //people[2] = new Person { Name = "McTominay", Surname = "Scott" };

            //Array.Sort(people);

            //foreach (Person person in people)
            //{
            //    Console.WriteLine(person.Name);
            //}




            //string[] names = { "aaa", "bbb", "ccc" };

            //foreach (var n in names)
            //{
            //    Console.WriteLine(n);
            //}

            //.NET IEnumerable interface
            //Group group = new Group();
            //foreach(Person person in group)
            //{
            //    Console.WriteLine(person.Name);
            //}







            #endregion

            #region Practice - Non-generic Collections

            #region ArrayList

            //ArrayList numbers = new ArrayList();
            //numbers.Add(15);
            //numbers.Add(36);
            //numbers.Add(29);
            //numbers.Add("text");
            //Console.WriteLine(numbers.Capacity); //4
            //Console.WriteLine(numbers.Count); //3
            //numbers.Remove(15);
            //numbers.Reverse();
            //numbers.Sort();
            //foreach (var n in numbers)
            //{
            //    Console.WriteLine(n);
            //}
            //numbers.RemoveAt(1);
            //foreach (int n in numbers)
            //{
            //    Console.WriteLine(n);
            //}
            //numbers.Clear();
            //foreach (int n in numbers)
            //{
            //    Console.WriteLine(n);
            //}

            #endregion

            #region Hashtable

            //Hashtable hash = new Hashtable();
            //hash.Add("01", "A");
            //hash.Add("02", "B");
            //hash.Add("03", "C");
            //hash.Add("04", "D");
            //Console.WriteLine(hash.ContainsKey("03")); //true
            //Console.WriteLine(hash.ContainsValue("E")); //false
            ////hash.Clear();
            //ICollection k = hash.Keys;
            //foreach(var item in k)
            //{
            //    Console.WriteLine(hash[item]);
            //}
           
            #endregion

            #region SortedList

            //SortedList sort = new SortedList();
            //sort.Add("01", "Green");
            //sort.Add("02", "Red");
            //sort.Add("03", "Blue");
            //sort.Add("04", "White");
            //Console.WriteLine(sort.ContainsKey("05")); //false
            //Console.WriteLine(sort.ContainsValue("Green")); //true
            ////sort.Clear();
            //ICollection col = sort.Keys;
            //foreach(var k in col)
            //{
            //    Console.WriteLine(sort[k]);
            //}

            #endregion

            #region Stack

            Stack st = new Stack();
            //st.Push("A");
            //st.Push("B");
            //st.Push("C");
            //st.Push("D");
            //st.Push(25);
            //foreach (var item in st)
            //{
            //    Console.WriteLine(item); //25 D C B A
            //}
            //st.Pop(); //D
            //foreach (var item in st)
            //{
            //    Console.WriteLine(item);//C B A
            //}
            //Console.WriteLine(st.Peek()); //C

            #endregion

            #region Queue

            //Queue q = new Queue();
            //q.Enqueue("A");
            //q.Enqueue("B");
            //q.Enqueue("C");
            //q.Enqueue("D");
            //q.Enqueue(25);
            //foreach (var item in q)
            //{
            //    Console.WriteLine(item); //A B C D 25
            //}
            //q.Dequeue(); //A
            //foreach(var item in q)
            //{
            //    Console.WriteLine(item); //B C D 25
            //}
            //Console.WriteLine(q.Peek()); //B

            #endregion

            #endregion

            #region Practice - Generic Collections

            #region List<T>

            //List<string> names = new List<string>();
            //names.Add("A");
            //names.Add("B");
            //names.Add("C");
            //names.Add("D");
            //names.Add("E");
            //names.Insert(5, "F");
            //names.Remove("C");
            //names.RemoveAt(2);
            //Console.WriteLine(names.Count);
            //names.ForEach(n => Console.WriteLine(n));

            #endregion

            #region Dictionary<T>

            //Dictionary<string, string> words = new Dictionary<string, string>();
            //words.Add("remove", "delete");
            //words.Add("trust", "believe");
            //words.Add("to be part of", "to be into it");
            //words.Add("win", "achieve");
            //Console.WriteLine(words.ContainsKey("trust")); //true
            //Console.WriteLine(words.ContainsValue("lose")); //false
            //foreach(KeyValuePair<string,string> w in words)
            //{
            //    Console.WriteLine("Key: {0}, Value: {1}", w.Key, w.Value);
            //}

            #endregion

            #region Stack <T>

            //Stack<int> numbers = new Stack<int>();
            //numbers.Push(1);
            //numbers.Push(2);
            //numbers.Push(3);
            //numbers.Push(4);
            //numbers.Push(5);
            //Console.WriteLine(numbers.Peek());
            //foreach(int n in numbers)
            //{
            //    Console.WriteLine(n);
            //}
            //numbers.Pop();
            //foreach (int n in numbers)
            //{
            //    Console.WriteLine(n);
            //}

            #endregion

            #region Queue<T>

            //Queue<string> names = new Queue<string>();
            //names.Enqueue("A");
            //names.Enqueue("B");
            //names.Enqueue("C");
            //names.Enqueue("D");
            //names.Enqueue("E");
            //names.Dequeue();
            //foreach(string n in names)
            //{
            //    Console.WriteLine(n);
            //}
            //Console.WriteLine(names.Peek());

            #endregion

            #endregion




        }

        //static void Sort<T>(T[] array) 
        //{
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        int minIndex = i;
        //        for (int j = i + 1; j < array.Length; j++)
        //        {
        //            ISortable sortable = array[j] as ISortable;

        //            if (sortable == null)
        //                throw new InvalidCastException("At least one of the items should " +
        //                    "implement ISortable interface in order to be sortable.");

        //            if (sortable.Sort(array[minIndex]) < 0)
        //            {
        //                minIndex = j;
        //            }
        //        }

        //        Swap(array, minIndex, i);
        //    }
        //}

        //static void Swap<T>(T[] array, int i, int j)
        //{
        //    T temp = array[i];
        //    array[i] = array[j];
        //    array[j] = temp;
        //}
    }




    #region Practice - Interface

    //interface ICodeable
    //{
    //    void WriteCode(string code);
    //}

    //class Developer : ICodeable
    //{
    //    public void WriteCode(string code)
    //    {
    //        Console.WriteLine(code);
    //    }
    //}


    //public class Person : IComparable // .NET interface
    //{
    //    public string Name { get; set; }
    //    public string Surname { get; set; }

    //    public int CompareTo(object obj)
    //    {
    //        Person person = obj as Person;

    //        if(person != null)
    //        {
    //            return this.Name.CompareTo(person.Name);
    //        }
    //        else
    //        {
    //            throw new NullReferenceException("cannot be sorted");
    //        }
    //    }
    //}



    //public class Person
    //{
    //    public string Name { get; set; }
    //    public string Surname { get; set; }
    //}

    //public class Group : IEnumerable //.NET IEnumerable interface
    //{
    //    public Person[] people = new Person[3];

    //    public Group()
    //    {
    //        people[0] = new Person { Name = "Rashford", Surname = "Marcus" };
    //        people[1] = new Person { Name = "Lingard", Surname = "Jesse" };
    //        people[2] = new Person { Name = "McTominay", Surname = "Scott" };
    //    }

    //    public IEnumerator GetEnumerator()
    //    {
    //        return people.GetEnumerator();
    //    }
    //}










    #endregion

    #region Practice - Collections



    #endregion








    //class Student : IComparable, ISortable
    //{
    //    public int Age { get; set; }
    //    public string Name { get; set; }

    //    public int Sort(object obj)
    //    {
    //        Student student = (Student)obj;

    //        if (Age < student.Age) return -1;
    //        if (Age == student.Age) return 0;
    //        return 1;
    //    }

    //    public int CompareTo(object obj)
    //    {
    //        Student student = (Student)obj;

    //        //if (Age < student.Age) return -1;
    //        //if (Age == student.Age) return 0;
    //        //return 1;

    //        return Age.CompareTo(student.Age);

    //        //if (Name < student.Name) return -1;  
    //        //if (Name == student.Name) return 0;
    //        //return 1;

    //        //return Name.CompareTo(student.Name);
    //    }

    //    public override string ToString()
    //    {
    //        return $"{Name} {Age}";
    //    }
    //}

    //interface ISortable
    //{
    //    /// <summary>
    //    /// This interface should be used for sorting in sort arrays
    //    /// </summary>
    //    /// <param name="obj"></param>
    //    /// <returns>if int is less than 0, first precedes second. if 0, they are equal. Else first followss second.</returns>
    //    int Sort(object obj);
    //}

    #region Interface simple example
    //class Person : IRunnable
    //{
    //    public string Name { get; set; }

    //    public void Run()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public string TellName() => Name;

    //    public void Walk()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public override string ToString()
    //    {
    //        return Name;
    //    }
    //}

    //abstract class Animal
    //{
    //    public string Sort { get; set; }
    //    public string GetSort() => Sort;
    //}

    //class Zebra : Animal, IRunnable
    //{
    //    public void Run()
    //    {
    //    }

    //    public void Walk()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //class Snake : Animal { }

    //class Monkey : Animal, IRunnable
    //{
    //    public void Run()
    //    {
    //    }

    //    public void Walk()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //interface IRunnable : IWalkable
    //{
    //    void Run();
    //}

    //interface IWalkable
    //{
    //    void Walk();
    //}
    #endregion

}

