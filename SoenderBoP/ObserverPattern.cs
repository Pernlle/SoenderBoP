using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoenderBoP
{
    public class ObserverPattern
    {
        // private observers array
        private static List<IObservable> observers = new List<IObservable>();

        //observe(observer: IObservable)
        // observers.push(observer)
        public static void Observe(IObservable observer)
        {
            observers.Add(observer);
        }

        //unobserve
        // observers.findAndDestroy(observer )
        public static void UnObserve(IObservable observer)
        {
            observers.Remove(observer);
        }

        //notify 
        // observers.foreach((observer) => observer.notify('Platanalle 47'))
        public static void Notify()
        {
            foreach (IObservable observer in observers)
            {
                observer.notify("Ny bolig tilgængelig");
            }
        }

    }
    //interface, 'IObservable', som indeholder en;
    public interface IObservable
    {
        void notify(string addresse);
    }

    public class Medlem : IObservable //kan hedde alt :)
    {
        public void notify(string adresse)
        {

            throw new NotImplementedException();
        }
    }
}
