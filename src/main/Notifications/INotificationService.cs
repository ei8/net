using System.Threading.Tasks;

namespace ei8.Net.Notifications
{
    public interface INotificationService<in T, in U> 
        where T: INotificationPayload 
        where U : INotificationReceiver
    {
        Task SendAsync(T payload, U subscription);
    }
}
