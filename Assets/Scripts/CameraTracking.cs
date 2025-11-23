using UnityEngine;

public class CameraTracking : MonoBehaviour
{
   public Transform player;
   public Vector3 offset;
   public float smoothing;

   public float minZoom;
   public float maxZoom;
   public float zoomSpeed;

   public void ZoomIn()
    {   // Zooms the camera in while keeping the offest
        offset.z = Mathf.Clamp(offset.z + zoomSpeed * Time.deltaTime, -maxZoom, -minZoom);
    }

    public void ZoomOut()
    {   // zooms the camera out while keeping an offset
        offset.z = Mathf.Clamp(offset.z - zoomSpeed * Time.deltaTime, -maxZoom, -minZoom);
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
       // Move camera to follow the player
        transform.position = player.position + player.forward * offset.z + player.right * offset.x + Vector3.up * offset.y;


        // Make the camera look at the player
        transform.LookAt(player);

    }
}
