using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Collectable : MonoBehaviour {
    public AudioClip snd;

    protected virtual void OnTriggerEnter2D (Collider2D collision) {
        if (collision.CompareTag ("Player")) {
            CollectableEffect ();
            
            if (snd != null)
                AudioControl.Singleton.PlaySound (snd);

            // Verifica se o item é um "LvlCheckCat" antes de pausar
            if (gameObject.CompareTag("LvlCheckCat")) {
                StartCoroutine(EsperaUmTico());
            } else {
                // Se não for "LvlCheckCat", apenas desativa o objeto imediatamente
                gameObject.SetActive(false);
            }

        }
    }

    protected abstract void CollectableEffect ();

    // Método corrigido
    protected IEnumerator EsperaUmTico() {
        yield return new WaitForSeconds(1.6f);
        this.gameObject.SetActive(false);
    }


}
