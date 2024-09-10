using Cysharp.Threading.Tasks;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class ResMgr
{
    public static T LoadAsset<T>(object key)
    {
        AsyncOperationHandle<T> handle = Addressables.LoadAssetAsync<T>(key);
        handle.WaitForCompletion();
        return handle.Result;
    }


    public static UniTask<T> LoadAssetAsync<T>(object key)
    {
        AsyncOperationHandle<T> handle = Addressables.LoadAssetAsync<T>(key);
        return handle.ToUniTask();
    }
}