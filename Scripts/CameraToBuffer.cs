using UnityEngine;

public class CameraToBuffer : MonoBehaviour {
    public RenderTexture[] textures;
    
    void Start ()
    {
        Camera camera = (GetComponent("Camera") as Camera);

        if (camera == null)
        {
            Debug.LogError("A script has been attached to the object \""  + gameObject.name  +  "\", but it has no Camera component.");
            Application.Quit();
            return;
        }

        if (textures.Length == 0)
        {
            Debug.LogAssertion("A script has been attached to the camera \"" + gameObject.name + "\", but it has no valid RenderTextures defined.");
            return;
        }

        for (int i = 1; i < textures.Length; i++)
        {
            if(textures[0].height != textures[i].height || 
                textures[0].width != textures[i].width || 
                textures[0].depth != textures[i].depth)
            {
                Debug.LogError("A script has been attached to the object \"" + gameObject.name + "\", but it does not support textures that do not have the same dimensions and depth.");
                Application.Quit();
            }
        }
        
        camera.targetTexture = textures[0];
        
    }

    private void OnPostRender()
    {
        for (int i = 1; i < textures.Length; i++)
        {
            Graphics.Blit(textures[0], textures[i]);
        }
    }

}
