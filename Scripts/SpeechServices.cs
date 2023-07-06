using System;
using System.Threading.Tasks;
using UnityEngine;

namespace DracarysInteractive.AIStudio
{
    [RequireComponent(typeof(ISpeechServices))]
    public class SpeechServices : Pluggable<SpeechServices, ISpeechServices>
    {
        public bool recognizeContinuously = true;
        public GameObject warningText;

        public void StartContinuousRecognizing()
        {
            Implementation.StartContinuousRecognizing();
        }

        public void StopContinuousRecognizing()
        {
            Implementation.StopContinuousRecognizing();
        }

        public void Recognize()
        {
            Implementation.Recognize();
        }

        public void Speak(string text, string voice, Action<float[]> onDataReceived, Action onSynthesisCompleted)
        {
            Implementation.Speak(text, voice, onDataReceived, onSynthesisCompleted);
        }
        public float SampleRate()
        {
            return Implementation.SampleRate();
        }

        public void SetClient(ISpeechServicesClient client)
        {
            Implementation.SetClient(client);
        }

        void Update()
        {
            if (warningText)
            {
                warningText.SetActive(!recognizeContinuously);
            }

            if (!recognizeContinuously && Input.GetKeyDown(KeyCode.Backspace))
            {
                Implementation.Recognize();
            }
        }
    }
}
