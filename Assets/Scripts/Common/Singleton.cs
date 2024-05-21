using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Common
{

    public abstract class Singleton<T> : Singleton where T : MonoBehaviour
    {
        private static T _instance;

        private static readonly object _lock = new object();

        private bool _persistent = true;
        public static T Instance
        {
            get
            {
                if (Quitting)
                {
                    return null;
                }
                lock (_lock)
                {
                    if (_instance != null)
                        return _instance;
                    var instances = FindObjectsOfType<T>();
                    var count = instances.Length;
                    if(count > 0)
                    {
                        if(count == 1)
                            return _instance = instances[0];

                        for(int i = 1; i < count; i++)
                            Destroy(instances[i]);
                        return _instance = instances[0];
                    }
                    return _instance = new GameObject($"({nameof(Singleton)}) {typeof(T)}").AddComponent<T>();
                }
            }
        }

        private void Awake()
        {
            if (_persistent)
                DontDestroyOnLoad(gameObject);
            OnAwake();
        }

        protected abstract void OnAwake();
    }

    public abstract class Singleton : MonoBehaviour
    {
        public static bool Quitting {  get; private set; }

        private void OnApplicationQuit()
        {
            Quitting = true;
        }
    }
}
