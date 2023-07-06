using System;
using System.Threading.Tasks;

namespace DracarysInteractive.AIStudio
{
    public interface ISpeechServices
    {
        void SetClient(ISpeechServicesClient client);
        void StartContinuousRecognizing();
        void StopContinuousRecognizing();
        void Recognize();
        void Speak(string text, string voice, Action<float[]> onDataReceived, Action onSynthesisCompleted);
        float SampleRate();
    }
}
