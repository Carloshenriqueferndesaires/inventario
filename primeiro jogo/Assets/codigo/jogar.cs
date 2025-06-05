using UnityEngine;

public class jogar : MonoBehaviour
{
    public transicao jogar1;
    public musicatransicao musicatransicao;
    
    public void Jogar()
    {
        // Parar a música
        if (musicatransicao.instance != null)
        {
            musicatransicao.instance.PararMusica();
        }
          // Carregar a cena do jogo
        jogar1.LoadScene("menu");
    }     
    
}
