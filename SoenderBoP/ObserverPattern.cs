using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoenderBoP
{
    public class ObserverPattern
    {
        // private observers array/list/stack som skal kunne opdateres
        private static List<IObservable> observers = new List<IObservable>();

        //observe(observer) -Tilføj en observer til listen over observere
        //   observers.push(observer)
        public static void Observe(IObservable observer)
        {
            observers.Add(observer);
        }

        //unobserve -fjern medlemmer fra observer liste.
        //   observers.findAndDestroy(observer )
        public static void UnObserve(IObservable observer)
        {
            observers.Remove(observer);
        }

        //notify -Giv observere besked om eventuelle ændringer
        //   observers.foreach((observer) => observer.notify('Platanalle 47'))
        public static void Notify()
        {
            foreach (IObservable observer in observers)
            {
                observer.notify("Ny bolig tilgængelig");
            }
        }

    }
    //interface, 'IObservable', som indeholder en notify;
    public interface IObservable
    {
        void notify(string message);
    }

    public class Medlem : IObservable //kan hedde alt :)
    {
        public void notify(string message)
        {
            //Noget 
            MessageBox.Show(message);
        }
    }
}
