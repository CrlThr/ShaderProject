using UnityEngine;
using UnityEngine.LightTransport;

public class FogOfWar : MonoBehaviour
{
    [SerializeField] private Material fogOfWarMat;
    [SerializeField] private int texSize;
    [SerializeField] private Transform avatar; 
    [SerializeField] private int worldWidth;

    private Texture2D tex;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Texture2D texture = new Texture2D(texSize, texSize);
        texture.wrapMode = TextureWrapMode.Clamp;
        for (int y = 0; y < texture.height; y++)
        {
            for (int x = 0; x < texture.width; x++)
            {
                texture.SetPixel(x, y, new Color(1, 1, 1, 1));
            }
        }
        texture.Apply();

        fogOfWarMat.SetTexture("_Areas", tex);
    }

    // Update is called once per frame
    void Update()
    {
        int texWidth = tex.width;
        int texHeight = tex.height;

        float conversionFactor = texWidth / worldWidth;
    }
}