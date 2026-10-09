using UnityEngine;

public class Player_Sounds : MonoBehaviour
{
    public AudioSource sfxSource;
    public AudioClip sonidoPrueba;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("¡Tecla presionada correctamente!");
            sfxSource.PlayOneShot(sonidoPrueba);
        }
    }
}