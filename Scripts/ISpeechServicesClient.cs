using System.Threading.Tasks;

namespace DracarysInteractive.AIStudio
{
    public interface ISpeechServicesClient
    {
        void StartSpeechRecognition();
        void SpeechRecognized(string text);
    }
}
