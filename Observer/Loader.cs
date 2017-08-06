using UnityEngine;
using Wizard;

namespace ShadowWatcher
{
    public class Loader
    {
        private static GameObject rootObj = GameMgr.GetIns().m_GameManagerObj;

        public static void Load()
        {
            Unload();

            rootObj.AddComponent<Observer>();
        }

        public static void Unload()
        {
            var observer = rootObj.GetComponent<Observer>();
            if (observer != null)
            {
                Object.DestroyObject(observer);
            }
        }
    }
}
