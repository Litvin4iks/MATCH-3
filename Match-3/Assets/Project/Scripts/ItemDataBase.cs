using UnityEngine;

public static class ItemDataBase
{
    public static Item[] Items { get; private set; }

    /// <summary>
    /// Перед загрузкой сцены наши ресурсы будут помещены в массив Items
    /// </summary>
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Initialize()
    {
        Items = Resources.LoadAll<Item>("Items/");
    }
}
