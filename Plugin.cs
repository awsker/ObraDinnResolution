using BepInEx;
using HarmonyLib;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ResolutionFix
{
    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"   Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");

            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly());

            SceneManager.sceneLoaded += sceneManager_sceneLoaded;
            //SceneManager.activeSceneChanged += sceneManager_activeSceneChanged;
        }

        private void sceneManager_sceneLoaded(Scene scene, LoadSceneMode mode)
        {
            Logger.LogInfo($"   SCENE LOADED: " + scene.name);
            fixScene();
        }

        private void fixScene()
        {
            var scene = SceneManager.GetActiveScene();
            
            foreach (var root in scene.GetRootGameObjects())
            {
                /*
                var monitor = root.GetComponentInChildren<Monitor>();
                if (monitor != null)
                {
                    monitor.blurAtEdges = false;
                    monitor.borderTexture = null;
                }
                var onebit = root.GetComponentInChildren<OneBit>();
                if (onebit != null)
                {
                    onebit.linedSettings.distortFringe = false;
                }*/
                var meshRenderers = root.GetComponentsInChildren<MeshRenderer>();
                foreach (var mesh in meshRenderers)
                {
                    if (mesh.gameObject.name.Contains("blur") || mesh.gameObject.name.Contains("Blur"))
                    {
                        mesh.gameObject.SetActive(false);
                    }
                }
            }
            Settings.outputMode = Settings.OutputMode.Digital0;
        }
    }
}