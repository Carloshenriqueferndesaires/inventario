using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class transicao : MonoBehaviour
{

    public void LoadScene(string nome)
    {
        SceneManager.LoadScene(nome);
    }

    public void sairdojogo() {
        Application.Quit();
        Debug.Log("Saindo do jogo");
    }
}
