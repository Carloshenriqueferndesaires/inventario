using UnityEngine;

public class inpputdoinventario : MonoBehaviour
{
   
    public GameObject arbriinventario;
    bool ativar = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            ativar = !ativar;
             arbriinventario.SetActive(ativar);
        }   
        if (ativar)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        
    }
}
