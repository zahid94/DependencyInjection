using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class PropertyInjection : INotification
    {
        public void ActOnNotification(string message)
        {
            Console.WriteLine(message);
        }
    }
    public interface INotification
    {
        void ActOnNotification(string message);
    }

    public class Sam
    {
        INotification _notification = null;
        public void Notify(INotification notification, string message)
        {
            _notification = notification;
            _notification.ActOnNotification(message);
        }
    }
}
