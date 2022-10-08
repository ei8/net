using System.Threading.Tasks;

namespace ei8.Net.PayloadHashing
{
    public interface IPayloadHashService
    {
        Task<string> GetPayloadHashAsync(string url);
    }
}
