using System;
using UnityEngine;

namespace DracarysInteractive.AIStudio
{
    [Serializable]
    public abstract class DialogueActionBase
    {
        [SerializeField] private string _type;
        [SerializeField] private float _creationTime;
        private Action _onCompletion;
        private float _startTime;
        private float _completionTime;

        protected DialogueActionBase(Action onCompletion = null)
        {
            _type = GetType().Name;
            this.onCompletion = onCompletion;
            creationTime = DialogueActionManager.Instance.currentTime;
            startTime = -1;
            completionTime = -1;
        }

        public Action onCompletion
        {
            get { return _onCompletion; }
            set { _onCompletion = value; }
        }

        public float creationTime
        {
            get { return _creationTime; }
            private set { _creationTime = value; }
        }

        public float startTime
        {
            get { return _startTime; }
            private set { _startTime = value; }
        }

        public float completionTime
        {
            get { return _completionTime; }
            protected set { _completionTime = value; }
        }

        public abstract void Invoke();
    }
}

