using System.Threading.Tasks;
using Firebase.Database;
using Secret.Santa.Settings;

namespace Secret.Santa.Services
{
    public class SecretSantaService
    {
        private FirebaseClient _firebaseClient;
        public SecretSantaService(FirebaseConfiguration config)
        {
            _firebaseClient = new FirebaseClient(config.AuthDomain, new FirebaseOptions
            {
                AuthTokenAsyncFactory = () => Task.FromResult(config.ApiKey)
            });
        }
    }
}
