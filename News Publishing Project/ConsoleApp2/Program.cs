using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class NewArtical
    {
        public string Title = "";
        public string Content = "";

        public NewArtical(string Title, string Content)
        {
            this.Title = Title;
            this.Content = Content;
        }
    }
    public class Publisher
    {   
        public event EventHandler<NewArtical> NewArticalPublished;

        public void PublishNews(string Title, string Content)
        {
            var NewArtical = new NewArtical(Title, Content);
            if (NewArticalPublished != null)
            {
                NewArticalPublished(this, NewArtical);
            }
        }
    }
    public class Subscriber
    {
        string SubscriberName = "";

        public Subscriber(string SubscriberName)
        {
            this.SubscriberName = SubscriberName;
        }

        public void Subscripe(Publisher Publisher)
        {
            Publisher.NewArticalPublished += HandleTempretureChange;
        }
        public void UnSubscripe(Publisher Publisher)
        {
            Publisher.NewArticalPublished -= HandleTempretureChange;
        }
        public void HandleTempretureChange(object Sender, NewArtical e)
        {
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("New Artical Published :");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"Subscriber Name: {this.SubscriberName}");
            Console.WriteLine($"Artical Title : {e.Title}");
            Console.WriteLine($"Artical Content : {e.Content}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        }
    }

    internal class Program
    {      
        static void Main(string[] args)
        {
            Publisher Publisher1 = new Publisher();
             Publisher Publisher2 = new Publisher();
            Subscriber Subscriber1 = new Subscriber("Aloor");
            Subscriber Subscriber2 = new Subscriber("Ali");
            Subscriber Subscriber3 = new Subscriber("Adam");
 
            Subscriber1.Subscripe(Publisher1);
            Subscriber2.Subscripe(Publisher1);
 
            Subscriber1.Subscripe(Publisher2);
            Subscriber2.Subscripe(Publisher2);
            Subscriber3.Subscripe(Publisher2);
            Subscriber3.UnSubscripe(Publisher2);


            Publisher2.PublishNews("N", "j");
            Publisher2.PublishNews("N2", "j2");
            Publisher1.PublishNews("N2N", "j2j");


            Console.ReadKey();
        }  
    }
}
